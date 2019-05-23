# -*- coding: utf-8 -*-

import numpy as np
import cv2
from PIL import Image
import pytesseract
import os
import sys


def make_boundary(rectangles):
    sortx = sorted(rectangles, key=lambda rectangle: rectangle[0])
    sorty = sorted(rectangles, key=lambda rectangle: rectangle[1])
    bound_x = sortx[0][0] - 10
    bound_y = sorty[0][1] - 1

    lastx = sortx[len(sortx) - 1]
    lasty = sorty[len(sorty) - 1]

    bound_w = lastx[0] + lastx[2] - sortx[0][0] + 15
    bound_h = lasty[1] + lasty[3] - sorty[0][1] + 5
    return bound_x, bound_y, bound_w, bound_h


# valid text area
def find_text(contours, warped):
    borders = []
    for i, cct in enumerate(contours):
        x, y, w, h = cv2.boundingRect(cct)
        rect_area = w * h
        ratio = float(w) / h
        if (ratio >= 0.2) and (rect_area <= 1000) and (rect_area >= 100):
            if 20 < x < 200 and 5 < y < 150:
                borders.append(cv2.boundingRect(cct))

    borders.sort(key=lambda border: border[1])  # sort by 'y' axis
    borders.append((warped.shape[0], warped.shape[1], 0, 0))

    rect_set = []
    rect_set_sub = []
    for k in range(len(borders) - 1):
        rect_set_sub.append(borders[k])
        if borders[k + 1][1] - borders[k][1] > 10:
            boundary = make_boundary(rect_set_sub)
            rect_set.append(boundary)
            rect_set_sub = []

    return rect_set


def main(*arguments):
    tpp = []
    for k in arguments:
        tpp.append(k)


    image = None
    file_name = tpp[0][1]
    print(file_name)

    try:
        image = cv2.imread(file_name)
        image = image.astype(np.uint8)
    except Exception:
        raise print('파일이 존재하지 않습니다.')


    _copy = None

    if image.shape[0] > image.shape[1]:
        ratio = 1200.0 / image.shape[0]
        dim = (int(image.shape[1] * ratio), 1200)
    else:
        ratio = 1200.0 / image.shape[1]
        dim = (1200, int(image.shape[0] * ratio))

    image = cv2.resize(image, dim, interpolation=cv2.INTER_AREA)
    _copy = image.copy()
    init_area = image.shape[0] * image.shape[1] - 4000
    # print("init area: {}".format(init_area))


    # convert gray and find outline
    gray = cv2.cvtColor(image, cv2.COLOR_BGR2GRAY)
    ret, gray = cv2.threshold(gray, 235, 255, cv2.THRESH_BINARY)
    # canny_output = cv2.Canny(gray, 200, 250)

    # find contours
    _contours, hierarchy = cv2.findContours(gray, cv2.RETR_TREE, cv2.CHAIN_APPROX_SIMPLE)

    largest_index = 0
    largest_area = 0
    for i, cct in enumerate(_contours):
        area = cv2.contourArea(cct, False)
        if largest_area < area < (init_area / 2):
            largest_area = area
            largest_index = i

    largest = _contours[largest_index]
    screen = cv2.approxPolyDP(largest, 0.1 * cv2.arcLength(largest, True), True)

    cv2.drawContours(_copy, [screen], -1, (0, 0, 255), 2)

    # ------------------ ERROR Handling -------------------------------
    try:
        points = np.reshape(screen, (4, 2))
    except Exception:
        raise SystemExit('Cannot Find Image')

    rect = np.zeros((4, 2), dtype="float32")

    _sum = np.sum(points, axis=1)
    rect[0] = points[np.argmin(_sum)]
    rect[2] = points[np.argmax(_sum)]

    _sub = np.diff(points, axis=1)
    rect[1] = points[np.argmin(_sub)]
    rect[3] = points[np.argmax(_sub)]

    topLeft, topRight, bottomRight, bottomLeft = rect

    maxWidth = max(abs(bottomRight[0] - bottomLeft[0]), abs(topRight[0] - topLeft[0]))
    maxHeight = max(abs(topRight[1] - bottomRight[1]), abs(topLeft[1] - bottomLeft[1]))

    dst = np.float32([[0, 0], [maxWidth - 1, 0], [maxWidth - 1, maxHeight - 1], [0, maxHeight - 1]])
    # projection (warp)  |  zoom: height 250
    # 예외처리1
    # horizontal case
    if maxWidth > maxHeight:
        tmp_mat = cv2.getPerspectiveTransform(rect, dst)
        warped = cv2.warpPerspective(image, tmp_mat, (maxWidth, maxHeight), flags=cv2.INTER_LANCZOS4)

        ratio = 250.0 / maxHeight
        dim = (int(maxWidth * ratio), 250)

    # vertical case
    else:
        rect[0] = points[np.argmin(_sub)]
        rect[1] = points[np.argmax(_sum)]
        rect[2] = points[np.argmax(_sub)]
        rect[3] = points[np.argmin(_sum)]

        tmp_mat = cv2.getPerspectiveTransform(rect, dst)
        warped = cv2.warpPerspective(image, tmp_mat, (maxWidth, maxHeight), flags=cv2.INTER_LANCZOS4)

        ratio = 250.0 / maxWidth
        dim = (int(maxHeight * ratio), 250)

    # mask operation
    warped = cv2.resize(warped, dim, interpolation=cv2.INTER_LANCZOS4)
    kernel = np.float32([[0, -1.0, 0],
                         [-1.0, 5.0, -1.0],
                         [0, -1.0, 0]])
    warped = cv2.filter2D(warped, -1, kernel)

    warped_gray = cv2.cvtColor(warped, cv2.COLOR_BGR2GRAY)
    warped_gray = cv2.adaptiveThreshold(warped_gray, 255, cv2.ADAPTIVE_THRESH_MEAN_C, cv2.THRESH_BINARY, 27, 25)
    _copy2 = warped.copy()


    # 주민등록번호 or 도장 # cv2.rectangle(_copy2, (50, 10), (90, 60), (0, 255, 0), 2)
    # 이름름  # cv2.rectangle(_copy2, (40, 50), (120, 90), (0, 255, 0), 2)

    # 예외처리 2, 회전
    first_trim = _copy2[10:60, 50:90]

    hsv = cv2.cvtColor(first_trim, cv2.COLOR_BGR2HSV)

    lower_red = np.array([-10, 100, 50])
    upper_red = np.array([10, 255, 255])

    mask_red = cv2.inRange(hsv, lower_red, upper_red)
    red_res = cv2.bitwise_and(first_trim, first_trim, mask=mask_red)

    red_res = cv2.cvtColor(red_res, cv2.COLOR_BGR2GRAY)
    ret2, red_res = cv2.threshold(red_res, 127, 255, cv2.THRESH_BINARY_INV)

    tmp_contours, hierarchy2 = cv2.findContours(red_res, cv2.RETR_TREE, cv2.CHAIN_APPROX_SIMPLE)
    area_len = 0
    for cct in tmp_contours:
        area_len += cv2.arcLength(cct, False)

    if area_len > 200:
        h, w = _copy2.shape[:2]
        matrix = cv2.getRotationMatrix2D((w / 2, h / 2), 180, 1)
        _copy2 = cv2.warpAffine(_copy2, matrix, (w, h))
        warped_gray = cv2.cvtColor(_copy2, cv2.COLOR_BGR2GRAY)

    canny_contours, hierarchy2 = cv2.findContours(warped_gray.copy(), cv2.RETR_TREE, cv2.CHAIN_APPROX_SIMPLE)
    rect_set = find_text(canny_contours, _copy2)

    warped_gray = cv2.cvtColor(_copy2, cv2.COLOR_BGR2GRAY)
    _copy3 = warped_gray.copy()

    name = rect_set[1]
    num = rect_set[2]

    img_name_path = "./name.png"
    img_num_path = "./num.png"

    name_trim = _copy3[name[1]:name[1] + name[3], name[0]:name[0] + name[2]]

    num_trim = _copy3[num[1]:num[1] + num[3], num[0]:num[0] + num[2]]
    cv2.imwrite(img_name_path, name_trim)
    cv2.imwrite(img_num_path, num_trim)

    lang_hangul = ('kor')
    config_hangul = ('--psm 6 --oem 1 -c preserve_interword_spaces=1')

    lang_num = ('eng')
    config_num = ('--psm 10 --oem 1')

    result_name = pytesseract.image_to_string(Image.open(img_name_path), lang=lang_hangul, config=config_hangul)
    result_num = pytesseract.image_to_string(Image.open(img_num_path), lang=lang_num, config=config_num)

    # select, split name
    except_pattern = ['（', '０', '(']
    for pattern in except_pattern:
        if result_name.find(pattern) != -1:
            result_name = result_name.split(pattern)[0]

    # select, split num
    revise = []
    for c in result_num:
        if '0' <= c <= '9' or c == '-':
            revise.append(c)
    result_num = ''.join(revise)

    result = result_name + '^' + result_num

    try:
        abs_dir = "result.txt"
        if os.path.exists(abs_dir):
            os.remove(abs_dir)
        fs = open(abs_dir, mode='wt', encoding='utf-8')
        fs.write(result)
        fs.close()
        print(result)
    except Exception:
        print(Exception.__str__())

    os.remove(img_name_path)
    os.remove(img_num_path)


if __name__ == '__main__':
    main(sys.argv)

