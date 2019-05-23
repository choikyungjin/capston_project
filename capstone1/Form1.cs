using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;


using Microsoft.Scripting;
using Microsoft.Scripting.Hosting;


using IronPython.Hosting;
using System.Diagnostics;
using System.Threading;
using System.IO;
using WIA;
using Excel = Microsoft.Office.Interop.Excel;

using MaterialSkin;
using MaterialSkin.Controls;

namespace capstone1
{
    

    public partial class Form_Ctrl : MaterialForm
    {
        
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect
                                                      , int nTopRect
                                                      , int nRightRect
                                                      , int nBottomRect
                                                      , int nWidthEllipse
                                                      , int nHeightEllipse);

        [System.Runtime.InteropServices.DllImport("gdi32.dll", EntryPoint = "DeleteObject")]
        private static extern bool DeleteObject(System.IntPtr hObject);


        public string file_pwd = string.Empty;
        string only_fileName = string.Empty;
        string abs_dir = string.Empty;
        string folder_pwd = string.Empty;
        string m_curPath = string.Empty;

        string save_result_name = string.Empty;
        string save_result_num = string.Empty;

        // WIA
        DeviceManager deviceManager;
        DeviceInfo firstScannerAvailable = null;
        ImageFile image_file = new ImageFile();
        string imageExtension = string.Empty;

        

        // WIA Setting
        public Form_Ctrl()
        {
            InitializeComponent();

            
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Red700, Primary.Red700, Primary.Red500, Accent.Red100, TextShade.WHITE);


            panel1.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panel1.Width, panel1.Height, 30, 30));
            btn_scan.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_scan.Width, btn_scan.Height, 5, 5));
            btn_open.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_open.Width, btn_open.Height, 10, 10));
            btn2_open.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, btn2_open.Width, btn2_open.Height, 5, 5));

            btn_extract.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_extract.Width, btn_extract.Height, 10, 10));
            btn_save.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_save.Width, btn_save.Height, 10, 10));
            btn_reset.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_reset.Width, btn_reset.Height, 10, 10));

            btn2_extract.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, btn2_extract.Width, btn2_extract.Height, 10, 10));
            btn2_save.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, btn2_save.Width, btn2_save.Height, 10, 10));
            btn2_reset.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, btn2_reset.Width, btn2_reset.Height, 10, 10));

            pnl_loading.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, pnl_loading.Width, pnl_loading.Height, 50, 50));
            pnl_loading2.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, pnl_loading2.Width, pnl_loading2.Height, 50, 50));

            this.AllowDrop = true;
            cbox_format.SelectedIndex = 0;
        }


        // Tab 1: file
        private void btn_open_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                Image image = Bitmap.FromFile(openFileDialog1.FileName);
                file_pwd = openFileDialog1.FileName;
                only_fileName = Path.GetFileName(openFileDialog1.FileName);
                pictureBox1.Image = image;
                //MessageBox.Show(only_fileName);

                if (image.Height > image.Width)
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                else
                    pictureBox1.SizeMode = PictureBoxSizeMode.Normal;

                Invoke(new MethodInvoker(delegate ()
                {
                    lb_open_fileName.Text = only_fileName;
                    lb_open_fileName.ForeColor = Color.Tomato;
                    lb_open_fileName.Font = new Font(lb_open_fileName.Font, FontStyle.Underline);
                }));
                
            }
            
        }


        private void excute_file_extract()
        {
            

            string output = string.Empty;
            abs_dir = string.Empty;
            abs_dir = Directory.GetCurrentDirectory();

            try
            {


                ProcessStartInfo start = new ProcessStartInfo();
                start.FileName = @"temp"; /* pc별 python 설치 경로  */
                string file_path = abs_dir + @"\operate_file.py " + file_pwd;

                string args_path = file_path.Replace(@"\", "//");
                start.Arguments = args_path;

                start.UseShellExecute = false;
                start.RedirectStandardOutput = true;
                start.CreateNoWindow = true;

                using (Process process = Process.Start(start))
                {

                    using (StreamReader reader = process.StandardOutput)
                    {
                        output = reader.ReadToEnd();
                    }

                }

                String fileName = @"./result.txt";
                String result = File.ReadAllText(fileName);

                String[] labels = result.Split('^');
                Invoke(new MethodInvoker(delegate ()
                {
                    lb_name.Text = labels[0];   
                    lb_num.Text = labels[1];
                    lb_name.ForeColor = Color.Tomato;
                    lb_num.ForeColor = Color.Tomato;
                    lb_name.Font = new Font(lb_name.Font, FontStyle.Bold);
                    lb_num.Font = new Font(lb_num.Font, FontStyle.Bold);


                    lb_adr1.Visible = true;
                    lb_adr2.Visible = true;
                    lb_date.Visible = true;
                    lb_loc.Visible = true;
                    pb_stamp.Visible = true;

                    pb_person.Image = Properties.Resources.unknown;
                    pb_person.SizeMode = PictureBoxSizeMode.StretchImage;
                }));

                pnl_loading.Visible = false;
                save_result_name = labels[0];
                save_result_num = labels[1];

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private void btn_extract_Click(object sender, EventArgs e)
        {
            if (file_pwd == "" || file_pwd == string.Empty)
            {
                MessageBox.Show("이미지가 없습니다.");
                return;
            }

            pnl_loading.Visible = true;

            Thread th_file = new Thread(new ThreadStart(excute_file_extract));
            th_file.Start();
            
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            Form2 child = new Form2();
            child.Owner = this;
            child.file_pwd = file_pwd;

            if (file_pwd != "")
                child.Show();
            else
                MessageBox.Show("이미지가 없습니다.");
        }

        // scanner
        private void Form1_Load(object sender, EventArgs e)
        {
            // Tab1: Clear the ListBox.
            listbox.Items.Clear();
            
            
            // Tab2: setting
            lv_result.Columns[0].Width = 100;
            lv_result.Columns[1].Width = 80;
            lv_result.AutoResizeColumn(2, ColumnHeaderAutoResizeStyle.HeaderSize);

            // Create a DeviceManager instance
            var deviceManager = new DeviceManager();

            // Loop through the list of devices and add the name to the listbox
            for (int i = 1; i <= deviceManager.DeviceInfos.Count; i++)
            {
                // Add the device only if it's a scanner
                if (deviceManager.DeviceInfos[i].Type != WiaDeviceType.ScannerDeviceType)
                {
                    continue;
                }

                // Add the Scanner device to the listbox (the entire DeviceInfos object)
                // Important: we store an object of type scanner (which ToString method returns the name of the scanner)
                listbox.Items.Add(new Scanner(deviceManager.DeviceInfos[i])
                );
            }


            // tab 2
            string[] Drv_list;
            TreeNode root;

            Drv_list = Environment.GetLogicalDrives();

            foreach (string Drv in Drv_list)
            {
                root = trvDir.Nodes.Add(Drv);
                root.ImageIndex = 2;

                if (trvDir.SelectedNode == null)
                    trvDir.SelectedNode = root;

                root.SelectedImageIndex = root.ImageIndex;
                root.Nodes.Add("");
            }

        }

        private void btn_scan_Click(object sender, EventArgs e)
        {
            if (StartScanning())
                TriggerScan();
            //Task.Factory.StartNew(StartScanning).ContinueWith(result => TriggerScan());
        }
        private void TriggerScan()
        {
            try
            {
                // Save the image
                pictureBox1.Image = null;
                string path = "./scanned_" + tb_fileName.Text + imageExtension;

                if (File.Exists(path))
                {
                    File.Delete(path);
                }

                image_file.SaveFile(path);
                pictureBox1.Image = Bitmap.FromFile(path);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                file_pwd = Directory.GetCurrentDirectory() + path;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        public bool StartScanning()
        {
            Scanner device = null;

            this.Invoke(new MethodInvoker(delegate ()
            {
                device = listbox.SelectedItem as Scanner;
            }));

            if (device == null)
            {
                MessageBox.Show("선택된 스캐너가 없습니다", "스캔 실패", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (String.IsNullOrEmpty(tb_fileName.Text))
            {
                MessageBox.Show("스캔할 문서의 파일명을 입력해 주세요", "파일명 오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            try
            {
                Invoke(new MethodInvoker(delegate ()
                {
                    switch (cbox_format.SelectedIndex)
                    {
                        case 0:
                            image_file = device.ScanJPEG();
                            imageExtension = ".jpeg";
                            break;
                        case 1:
                            image_file = device.ScanPNG();
                            imageExtension = ".png";
                            break;
                        case 2:
                            image_file = device.ScanTIFF();
                            imageExtension = ".tiff";
                            break;
                    }

                }));
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            return true;
        }


        private void btn_save_Click(object sender, EventArgs e)
        {
            if (file_pwd == "" || file_pwd == string.Empty)
            {
                MessageBox.Show("이미지가 없습니다.");
                return;
            }

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "텍스트 문서(*.txt)|*.txt|모든 파일|*.*";
            sfd.DefaultExt = "txt";
            sfd.AddExtension = true;


            if(sfd.ShowDialog() == DialogResult.OK)
            {
                try {
                    FileStream fs = new FileStream(sfd.FileName, FileMode.Create, FileAccess.Write);
                    StreamWriter st = new StreamWriter(fs);                
                    st.WriteLine("이름: " + save_result_name);
                    st.WriteLine("주민번호: " + save_result_num);
                    st.Close();
                    MessageBox.Show("저장 완료");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            this.Invoke(new MethodInvoker(delegate ()
            {
                lb_name.Text = "(이름)";
                lb_num.Text = "000000 - 0000000";
                lb_name.ForeColor = Color.Black;
                lb_num.ForeColor = Color.Black;
                lb_name.Font = new Font(lb_name.Font, FontStyle.Regular);
                lb_num.Font = new Font(lb_num.Font, FontStyle.Regular);

                pictureBox1.Image = null;
                lb_open_fileName.Text = "";
                lb_adr1.Visible = false;
                lb_adr2.Visible = false;
                lb_date.Visible = false;
                lb_loc.Visible = false;
                pb_stamp.Visible = false;

                pb_person.Image = null;
            }));

            file_pwd = "";
        }



        ////////////////////////////////////////////////////////// Tab 2: folder
        public void setPlus(TreeNode node)
        {
            string path;
            DirectoryInfo dir;
            DirectoryInfo[] di;

            try
            {
                path = node.FullPath;
                dir = new DirectoryInfo(path);
                di = dir.GetDirectories();
                if (di.Length > 0)
                    node.Nodes.Add("");
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        public void OpenFiles()
        {
            ListView.SelectedListViewItemCollection siList;
            siList = lvwFiles.SelectedItems;

            foreach (ListViewItem item in siList)
            {
                OpenItem(item);
            }
        }

        public void OpenItem(ListViewItem item)
        {
            TreeNode node;
            TreeNode child;

            if (item.Tag.ToString() == "D")
            {
                node = trvDir.SelectedNode;
                node.Expand();

                child = node.FirstNode;

                while (child != null)
                {
                    if (child.Text == item.Text)
                    {
                        trvDir.SelectedNode = child;
                        trvDir.Focus();
                        break;
                    }
                    child = child.NextNode;
                }
            }
            else
            {
                Process.Start(txtPath.Text + "\\" + item.Text);
            }
        }

        private void trvDir_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            string path;
            DirectoryInfo dir;
            DirectoryInfo[] di;
            TreeNode node;

            try
            {
                e.Node.Nodes.Clear();
                path = e.Node.FullPath;
                dir = new DirectoryInfo(path);
                di = dir.GetDirectories();

                foreach (DirectoryInfo dirs in di)
                {
                    node = e.Node.Nodes.Add(dirs.Name);
                    setPlus(node);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void trvDir_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            DirectoryInfo di;
            DirectoryInfo[] diarray;
            ListViewItem item;
            FileInfo[] fiArray;

            try
            {
                di = new DirectoryInfo(e.Node.FullPath);
                txtPath.Text = e.Node.FullPath.Substring(0, 2) + e.Node.FullPath.Substring(3);
                lvwFiles.Items.Clear();

                diarray = di.GetDirectories();
                foreach (DirectoryInfo tdis in diarray)
                {
                    item = lvwFiles.Items.Add(tdis.Name);
                    item.SubItems.Add("");
                    item.SubItems.Add(tdis.LastWriteTime.ToString());
                    item.ImageIndex = 0;
                    item.Tag = "D";
                }

                fiArray = di.GetFiles();
                foreach (FileInfo fis in fiArray)
                {
                    item = lvwFiles.Items.Add(fis.Name);
                    item.SubItems.Add(fis.Length.ToString());
                    item.SubItems.Add(fis.LastWriteTime.ToString());
                    item.ImageIndex = 1;
                    item.Tag = "F";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lvwFiles_DoubleClick(object sender, EventArgs e)
        {
            OpenFiles();
        }

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPageIndex == 0)
                this.Size = new Size(870, 840);

                
            else if (e.TabPageIndex == 1)
                this.Size = new Size(688, 720);
 
        }

        private void btn2_open_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {

                txtPath.Text = folderBrowserDialog1.SelectedPath;

                m_curPath = txtPath.Text;
                txtPath.Text = m_curPath;

                if (txtPath.Text[2] != '/')
                {
                    Invoke(new MethodInvoker(delegate ()
                    {
                        txtPath.Text = txtPath.Text.Insert(2, @"\");
                    }));
                    
                }
                   

                TreeNode root = trvDir.Nodes.Add(m_curPath);

                string[] drives = Directory.GetLogicalDrives();    // 모든 논리적으로 구분되어 있는 드라이브들을 읽어들임

                foreach (string drive in drives)
                {
                    //root = TreeView.Nodes.Add(drive);
                    root.ImageIndex = 2;
                    if (trvDir.SelectedNode == null)
                        trvDir.SelectedNode = root;
                    root.SelectedImageIndex = root.ImageIndex;
                    root.Nodes.Add("");

                }
                ////
                DirectoryInfo di;
                DirectoryInfo[] diarray;
                ListViewItem item;
                FileInfo[] fiArray;
            
                try
                {
                    di = new DirectoryInfo(m_curPath);
                    txtPath.Text = m_curPath.Substring(0, 2) + m_curPath.Substring(3);
                    lvwFiles.Items.Clear();

                    diarray = di.GetDirectories();
                    foreach (DirectoryInfo tdis in diarray)
                    {
                        item = lvwFiles.Items.Add(tdis.Name);
                        item.SubItems.Add("");
                        item.SubItems.Add(tdis.LastWriteTime.ToString());
                        item.ImageIndex = 0;
                        item.Tag = "D";
                    }

                    fiArray = di.GetFiles();
                    foreach (FileInfo fis in fiArray)
                    {
                        item = lvwFiles.Items.Add(fis.Name);
                        item.SubItems.Add(fis.Length.ToString());
                        item.SubItems.Add(fis.LastWriteTime.ToString());
                        item.ImageIndex = 1;
                        item.Tag = "F";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void excute_folder_extract()
        {
            string output = string.Empty;
            abs_dir = Directory.GetCurrentDirectory();
            folder_pwd = txtPath.Text;

            if (folder_pwd[2] != '/')
                folder_pwd = folder_pwd.Insert(2, @"/");

            try
            {
                ProcessStartInfo start = new ProcessStartInfo();
                start.FileName = @"temp"; /* pc별 python 설치 경로  */
                string folder_path = abs_dir + @"\operate_folder.py " + folder_pwd;

                string args_path = folder_path.Replace(@"\", "/");
                start.Arguments = args_path;

                start.UseShellExecute = false;
                start.RedirectStandardOutput = true;
                start.CreateNoWindow = true;

                using (Process process = Process.Start(start))
                {

                    using (StreamReader reader = process.StandardOutput)
                    {
                        output = reader.ReadToEnd();
                    }

                }

                String tmpText = "";
                abs_dir = Directory.GetCurrentDirectory() + "\\result2.txt";

                if (File.Exists(abs_dir))
                    tmpText = File.ReadAllText(abs_dir);
                else
                {
                    MessageBox.Show("파일 X");
                }

                String[] info = tmpText.Split('\n');
                for (int i = 0; i < info.Length && info[i].Length > 0; i++)
                {
                    String[] info_sub = info[i].Split('^');
                    //list view에 추가
                    Invoke(new MethodInvoker(delegate ()
                    {
                        string[] subitem = { info_sub[0], info_sub[1], info_sub[2] };
                        ListViewItem new_items = new ListViewItem(subitem);
                        lv_result.Items.Add(new_items);
                    }));
                }
                pnl_loading2.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btn2_extract_Click(object sender, EventArgs e)
        {
            reset_list();
            pnl_loading2.Visible = true;
            Thread th_folder = new Thread(new ThreadStart(excute_folder_extract));
            th_folder.Start();
        }

        private void btn2_save_Click(object sender, EventArgs e)
        {
            if(lvwFiles.Items.Count == 0)
            {
                MessageBox.Show("저장 항목이 없습니다.");
                return;
            }

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "엑셀 문서(*.xlsx)|*.xlsx|모든 파일|*.*";
            sfd.DefaultExt = "xlxs";
            sfd.AddExtension = true;


            if (sfd.ShowDialog() == DialogResult.OK)
            {
               
                Excel.Application ExcelApp = null;
                Excel.Workbook ExcelBook = null;
                Excel.Worksheet ExcelSheet = null;

                ExcelApp = new Excel.Application();
                ExcelApp.Visible = false;
                ExcelApp.DisplayAlerts = false;
                ExcelApp.Interactive = false;

                if (ExcelApp == null)
                {
                    MessageBox.Show("Excel이 정상적으로 설치되지 않았습니다.", "Message", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                try
                {
                    ExcelBook = ExcelApp.Workbooks.Add(Type.Missing);
                    ExcelSheet = ExcelBook.ActiveSheet;

                    ExcelSheet.Name = "result";
                    ExcelSheet.Cells[2, 2] = "파일명";
                    ExcelSheet.Cells[2, 3] = "이름";
                    ExcelSheet.Cells[2, 4] = "주민등록번호";
                    int row = 3; int col = 2;


                    for (int num = 0; num < lv_result.Items.Count; num++)
                    {
                        ListViewItem.ListViewSubItemCollection lvItem = lv_result.Items[num].SubItems;
                        string[] elements = { lvItem[0].Text, lvItem[1].Text, lvItem[2].Text };

                        ExcelSheet.Cells[row, col++] = elements[0];
                        ExcelSheet.Cells[row, col++] = elements[1];
                        ExcelSheet.Cells[row, col] = elements[2];

                        row++; col = 2;
                    }

                    ExcelBook.SaveAs(Filename: sfd.FileName);
                    ExcelBook.Close();
                    ExcelApp.Quit();

                    ReleaseExcelObject(ExcelSheet);
                    ReleaseExcelObject(ExcelBook);
                    ReleaseExcelObject(ExcelApp);
                    MessageBox.Show("저장 완료");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private static void ReleaseExcelObject(object obj)
        {
            try
            {
                if(obj != null)
                {
                    Marshal.ReleaseComObject(obj);
                    obj = null;
                }
            }
            catch(Exception ex)
            {
                obj = null;
                throw ex;
            }
            finally
            {
                GC.Collect();
            }
        }

        private void btn2_reset_Click(object sender, EventArgs e)
        {
            reset_list();
        }

        private void reset_list()
        {
            // renewal
            int n = lv_result.Items.Count;
            if (n > 0)
            {
                while (n > 0)
                {
                    lv_result.Items.RemoveAt(n - 1);
                    n--;
                }
            }
        }

    }
}
