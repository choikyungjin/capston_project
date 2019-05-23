

namespace capstone1
{
    partial class Form_Ctrl
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Ctrl));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tp_one = new System.Windows.Forms.TabPage();
            this.pnl_loading = new System.Windows.Forms.Panel();
            this.pb_loading = new System.Windows.Forms.PictureBox();
            this.lb_loading = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.cbox_format = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_fileName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_scan = new System.Windows.Forms.Button();
            this.listbox = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lb_open_fileName = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_open = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pb_stamp = new System.Windows.Forms.PictureBox();
            this.pb_person = new System.Windows.Forms.PictureBox();
            this.lb_adr2 = new System.Windows.Forms.Label();
            this.lb_loc = new System.Windows.Forms.Label();
            this.lb_date = new System.Windows.Forms.Label();
            this.lb_adr1 = new System.Windows.Forms.Label();
            this.lb_num = new System.Windows.Forms.Label();
            this.lb_name = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_extract = new System.Windows.Forms.Button();
            this.tp_two = new System.Windows.Forms.TabPage();
            this.pnl_loading2 = new System.Windows.Forms.Panel();
            this.pb_loading2 = new System.Windows.Forms.PictureBox();
            this.lb_loading2 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btn2_save = new System.Windows.Forms.Button();
            this.btn2_reset = new System.Windows.Forms.Button();
            this.btn2_extract = new System.Windows.Forms.Button();
            this.lv_result = new System.Windows.Forms.ListView();
            this.col_fileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_num = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn2_open = new System.Windows.Forms.Button();
            this.lvwFiles = new System.Windows.Forms.ListView();
            this.colFileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFileSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFileDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imgList = new System.Windows.Forms.ImageList(this.components);
            this.trvDir = new System.Windows.Forms.TreeView();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tabControl1.SuspendLayout();
            this.tp_one.SuspendLayout();
            this.pnl_loading.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_loading)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_stamp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_person)).BeginInit();
            this.tp_two.SuspendLayout();
            this.pnl_loading2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_loading2)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tp_one);
            this.tabControl1.Controls.Add(this.tp_two);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(870, 840);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControl1_Selecting);
            // 
            // tp_one
            // 
            this.tp_one.BackColor = System.Drawing.Color.White;
            this.tp_one.Controls.Add(this.pnl_loading);
            this.tp_one.Controls.Add(this.panel3);
            this.tp_one.Controls.Add(this.groupBox3);
            this.tp_one.Controls.Add(this.groupBox1);
            this.tp_one.Controls.Add(this.groupBox2);
            this.tp_one.Location = new System.Drawing.Point(4, 22);
            this.tp_one.Name = "tp_one";
            this.tp_one.Padding = new System.Windows.Forms.Padding(3);
            this.tp_one.Size = new System.Drawing.Size(862, 814);
            this.tp_one.TabIndex = 0;
            this.tp_one.Text = "파일";
            // 
            // pnl_loading
            // 
            this.pnl_loading.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.pnl_loading.Controls.Add(this.pb_loading);
            this.pnl_loading.Controls.Add(this.lb_loading);
            this.pnl_loading.Location = new System.Drawing.Point(268, 228);
            this.pnl_loading.Name = "pnl_loading";
            this.pnl_loading.Size = new System.Drawing.Size(300, 300);
            this.pnl_loading.TabIndex = 26;
            this.pnl_loading.Visible = false;
            // 
            // pb_loading
            // 
            this.pb_loading.Image = global::capstone1.Properties.Resources.loading;
            this.pb_loading.InitialImage = global::capstone1.Properties.Resources.loading;
            this.pb_loading.Location = new System.Drawing.Point(60, 30);
            this.pb_loading.Name = "pb_loading";
            this.pb_loading.Size = new System.Drawing.Size(180, 180);
            this.pb_loading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pb_loading.TabIndex = 1;
            this.pb_loading.TabStop = false;
            // 
            // lb_loading
            // 
            this.lb_loading.AutoSize = true;
            this.lb_loading.Font = new System.Drawing.Font("나눔스퀘어 Bold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_loading.Location = new System.Drawing.Point(82, 239);
            this.lb_loading.Name = "lb_loading";
            this.lb_loading.Size = new System.Drawing.Size(145, 30);
            this.lb_loading.TabIndex = 0;
            this.lb_loading.Text = "Loading ...";
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(604, 655);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(242, 149);
            this.panel3.TabIndex = 35;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.groupBox6);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.btn_scan);
            this.groupBox3.Controls.Add(this.listbox);
            this.groupBox3.Font = new System.Drawing.Font("나눔스퀘어 ExtraBold", 13F, System.Drawing.FontStyle.Bold);
            this.groupBox3.ForeColor = System.Drawing.Color.Black;
            this.groupBox3.Location = new System.Drawing.Point(14, 642);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(584, 164);
            this.groupBox3.TabIndex = 28;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = " SCANNER ";
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox6.Controls.Add(this.cbox_format);
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Controls.Add(this.tb_fileName);
            this.groupBox6.Controls.Add(this.label5);
            this.groupBox6.Font = new System.Drawing.Font("문체부 돋음체", 10F);
            this.groupBox6.Location = new System.Drawing.Point(270, 26);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(209, 124);
            this.groupBox6.TabIndex = 36;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = " OPTION ";
            // 
            // cbox_format
            // 
            this.cbox_format.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_format.Font = new System.Drawing.Font("굴림", 10F);
            this.cbox_format.FormattingEnabled = true;
            this.cbox_format.Items.AddRange(new object[] {
            "JPEG",
            "PNG",
            "TIFF"});
            this.cbox_format.Location = new System.Drawing.Point(13, 42);
            this.cbox_format.Name = "cbox_format";
            this.cbox_format.Size = new System.Drawing.Size(183, 21);
            this.cbox_format.TabIndex = 32;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("문체부 돋음체", 11F);
            this.label8.Location = new System.Drawing.Point(13, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 15);
            this.label8.TabIndex = 34;
            this.label8.Text = "File Name";
            // 
            // tb_fileName
            // 
            this.tb_fileName.Font = new System.Drawing.Font("굴림", 10F);
            this.tb_fileName.Location = new System.Drawing.Point(13, 93);
            this.tb_fileName.Name = "tb_fileName";
            this.tb_fileName.Size = new System.Drawing.Size(183, 23);
            this.tb_fileName.TabIndex = 31;
            this.tb_fileName.Text = "test";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("문체부 돋음체", 11F);
            this.label5.Location = new System.Drawing.Point(13, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 15);
            this.label5.TabIndex = 33;
            this.label5.Text = "Image Format";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("문체부 돋음체", 11F);
            this.label1.Location = new System.Drawing.Point(18, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 15);
            this.label1.TabIndex = 30;
            this.label1.Text = "Select a Scanner";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("문체부 돋음체", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(103, -22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 24);
            this.label7.TabIndex = 29;
            this.label7.Text = "SCANNER";
            // 
            // btn_scan
            // 
            this.btn_scan.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_scan.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_scan.FlatAppearance.BorderSize = 0;
            this.btn_scan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_scan.Font = new System.Drawing.Font("돋움", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_scan.ForeColor = System.Drawing.Color.Black;
            this.btn_scan.Location = new System.Drawing.Point(488, 26);
            this.btn_scan.Name = "btn_scan";
            this.btn_scan.Size = new System.Drawing.Size(76, 123);
            this.btn_scan.TabIndex = 25;
            this.btn_scan.Text = "SCAN";
            this.btn_scan.UseVisualStyleBackColor = false;
            this.btn_scan.Click += new System.EventHandler(this.btn_scan_Click);
            // 
            // listbox
            // 
            this.listbox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.listbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listbox.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.listbox.FormattingEnabled = true;
            this.listbox.ItemHeight = 12;
            this.listbox.Location = new System.Drawing.Point(20, 50);
            this.listbox.Name = "listbox";
            this.listbox.Size = new System.Drawing.Size(237, 96);
            this.listbox.TabIndex = 27;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.lb_open_fileName);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.btn_open);
            this.groupBox1.Font = new System.Drawing.Font("나눔스퀘어 ExtraBold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(13, 8);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(394, 628);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " IMAGE ";
            // 
            // lb_open_fileName
            // 
            this.lb_open_fileName.AutoSize = true;
            this.lb_open_fileName.Font = new System.Drawing.Font("돋움", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_open_fileName.Location = new System.Drawing.Point(72, 96);
            this.lb_open_fileName.Name = "lb_open_fileName";
            this.lb_open_fileName.Size = new System.Drawing.Size(0, 12);
            this.lb_open_fileName.TabIndex = 28;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("돋움", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(21, 97);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 11);
            this.label9.TabIndex = 27;
            this.label9.Text = "파일명 : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("바탕", 9F);
            this.label2.Location = new System.Drawing.Point(21, 605);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(237, 12);
            this.label2.TabIndex = 10;
            this.label2.Text = "※ 이미지를 더블클릭하면 확대 가능합니다";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(21, 117);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(353, 481);
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.DoubleClick += new System.EventHandler(this.pictureBox1_DoubleClick);
            // 
            // btn_open
            // 
            this.btn_open.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_open.FlatAppearance.BorderSize = 0;
            this.btn_open.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_open.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_open.ForeColor = System.Drawing.Color.Black;
            this.btn_open.Location = new System.Drawing.Point(21, 46);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(353, 34);
            this.btn_open.TabIndex = 13;
            this.btn_open.Text = "파일 열기";
            this.btn_open.UseVisualStyleBackColor = false;
            this.btn_open.Click += new System.EventHandler(this.btn_open_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.btn_save);
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Controls.Add(this.btn_reset);
            this.groupBox2.Controls.Add(this.btn_extract);
            this.groupBox2.Font = new System.Drawing.Font("나눔스퀘어 ExtraBold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(414, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(432, 628);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = " IDENTIFICATION ";
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.MistyRose;
            this.btn_save.FlatAppearance.BorderSize = 0;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("맑은 고딕", 11.25F);
            this.btn_save.ForeColor = System.Drawing.Color.Black;
            this.btn_save.Location = new System.Drawing.Point(20, 506);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(390, 37);
            this.btn_save.TabIndex = 24;
            this.btn_save.Text = "저장";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Ivory;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.pb_stamp);
            this.panel1.Controls.Add(this.pb_person);
            this.panel1.Controls.Add(this.lb_adr2);
            this.panel1.Controls.Add(this.lb_loc);
            this.panel1.Controls.Add(this.lb_date);
            this.panel1.Controls.Add(this.lb_adr1);
            this.panel1.Controls.Add(this.lb_num);
            this.panel1.Controls.Add(this.lb_name);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(20, 97);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(390, 250);
            this.panel1.TabIndex = 16;
            // 
            // pb_stamp
            // 
            this.pb_stamp.BackColor = System.Drawing.Color.Transparent;
            this.pb_stamp.Image = global::capstone1.Properties.Resources.도장;
            this.pb_stamp.InitialImage = null;
            this.pb_stamp.Location = new System.Drawing.Point(268, 177);
            this.pb_stamp.Name = "pb_stamp";
            this.pb_stamp.Size = new System.Drawing.Size(50, 50);
            this.pb_stamp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_stamp.TabIndex = 33;
            this.pb_stamp.TabStop = false;
            this.pb_stamp.Visible = false;
            // 
            // pb_person
            // 
            this.pb_person.BackColor = System.Drawing.Color.White;
            this.pb_person.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_person.Location = new System.Drawing.Point(235, 19);
            this.pb_person.Name = "pb_person";
            this.pb_person.Size = new System.Drawing.Size(127, 151);
            this.pb_person.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_person.TabIndex = 26;
            this.pb_person.TabStop = false;
            // 
            // lb_adr2
            // 
            this.lb_adr2.AutoSize = true;
            this.lb_adr2.Font = new System.Drawing.Font("바탕", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_adr2.Location = new System.Drawing.Point(36, 156);
            this.lb_adr2.Name = "lb_adr2";
            this.lb_adr2.Size = new System.Drawing.Size(106, 14);
            this.lb_adr2.TabIndex = 32;
            this.lb_adr2.Text = "(OO동 000-00)";
            this.lb_adr2.Visible = false;
            // 
            // lb_loc
            // 
            this.lb_loc.AutoSize = true;
            this.lb_loc.Font = new System.Drawing.Font("함초롬돋움", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_loc.Location = new System.Drawing.Point(146, 206);
            this.lb_loc.Name = "lb_loc";
            this.lb_loc.Size = new System.Drawing.Size(91, 21);
            this.lb_loc.TabIndex = 31;
            this.lb_loc.Text = "OO시 OO구";
            this.lb_loc.Visible = false;
            // 
            // lb_date
            // 
            this.lb_date.AutoSize = true;
            this.lb_date.Font = new System.Drawing.Font("함초롬돋움", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_date.Location = new System.Drawing.Point(151, 187);
            this.lb_date.Name = "lb_date";
            this.lb_date.Size = new System.Drawing.Size(84, 18);
            this.lb_date.TabIndex = 30;
            this.lb_date.Text = "2019. 5. 16.";
            this.lb_date.Visible = false;
            // 
            // lb_adr1
            // 
            this.lb_adr1.AutoSize = true;
            this.lb_adr1.Font = new System.Drawing.Font("바탕", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_adr1.Location = new System.Drawing.Point(36, 139);
            this.lb_adr1.Name = "lb_adr1";
            this.lb_adr1.Size = new System.Drawing.Size(148, 14);
            this.lb_adr1.TabIndex = 29;
            this.lb_adr1.Text = "OO시 OO구 OO로 000\r\n";
            this.lb_adr1.Visible = false;
            // 
            // lb_num
            // 
            this.lb_num.AutoSize = true;
            this.lb_num.Font = new System.Drawing.Font("바탕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_num.ForeColor = System.Drawing.Color.Black;
            this.lb_num.Location = new System.Drawing.Point(46, 103);
            this.lb_num.Name = "lb_num";
            this.lb_num.Size = new System.Drawing.Size(144, 16);
            this.lb_num.TabIndex = 9;
            this.lb_num.Text = "000000 - 0000000";
            this.lb_num.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Font = new System.Drawing.Font("바탕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_name.ForeColor = System.Drawing.Color.Black;
            this.lb_name.Location = new System.Drawing.Point(84, 66);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(50, 16);
            this.lb_name.TabIndex = 6;
            this.lb_name.Text = "(이름)";
            this.lb_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("문체부 제목 돋음체", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(44, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 27);
            this.label3.TabIndex = 5;
            this.label3.Text = "주민등록증";
            // 
            // btn_reset
            // 
            this.btn_reset.BackColor = System.Drawing.Color.MistyRose;
            this.btn_reset.FlatAppearance.BorderSize = 0;
            this.btn_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reset.Font = new System.Drawing.Font("맑은 고딕", 11.25F);
            this.btn_reset.ForeColor = System.Drawing.Color.Black;
            this.btn_reset.Location = new System.Drawing.Point(20, 561);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(390, 37);
            this.btn_reset.TabIndex = 25;
            this.btn_reset.Text = "RESET";
            this.btn_reset.UseVisualStyleBackColor = false;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_extract
            // 
            this.btn_extract.BackColor = System.Drawing.Color.Tomato;
            this.btn_extract.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_extract.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_extract.FlatAppearance.BorderSize = 0;
            this.btn_extract.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_extract.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_extract.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_extract.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_extract.ForeColor = System.Drawing.Color.White;
            this.btn_extract.Location = new System.Drawing.Point(20, 452);
            this.btn_extract.Name = "btn_extract";
            this.btn_extract.Size = new System.Drawing.Size(390, 37);
            this.btn_extract.TabIndex = 23;
            this.btn_extract.Text = "추출";
            this.btn_extract.UseVisualStyleBackColor = false;
            this.btn_extract.Click += new System.EventHandler(this.btn_extract_Click);
            // 
            // tp_two
            // 
            this.tp_two.BackColor = System.Drawing.Color.White;
            this.tp_two.Controls.Add(this.pnl_loading2);
            this.tp_two.Controls.Add(this.groupBox5);
            this.tp_two.Controls.Add(this.groupBox4);
            this.tp_two.Location = new System.Drawing.Point(4, 22);
            this.tp_two.Name = "tp_two";
            this.tp_two.Padding = new System.Windows.Forms.Padding(3);
            this.tp_two.Size = new System.Drawing.Size(862, 814);
            this.tp_two.TabIndex = 1;
            this.tp_two.Text = "폴더";
            // 
            // pnl_loading2
            // 
            this.pnl_loading2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.pnl_loading2.Controls.Add(this.pb_loading2);
            this.pnl_loading2.Controls.Add(this.lb_loading2);
            this.pnl_loading2.Location = new System.Drawing.Point(186, 169);
            this.pnl_loading2.Name = "pnl_loading2";
            this.pnl_loading2.Size = new System.Drawing.Size(300, 300);
            this.pnl_loading2.TabIndex = 27;
            this.pnl_loading2.Visible = false;
            // 
            // pb_loading2
            // 
            this.pb_loading2.Image = global::capstone1.Properties.Resources.loading;
            this.pb_loading2.InitialImage = global::capstone1.Properties.Resources.loading;
            this.pb_loading2.Location = new System.Drawing.Point(60, 30);
            this.pb_loading2.Name = "pb_loading2";
            this.pb_loading2.Size = new System.Drawing.Size(180, 180);
            this.pb_loading2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pb_loading2.TabIndex = 1;
            this.pb_loading2.TabStop = false;
            // 
            // lb_loading2
            // 
            this.lb_loading2.AutoSize = true;
            this.lb_loading2.Font = new System.Drawing.Font("나눔스퀘어 Bold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_loading2.Location = new System.Drawing.Point(82, 239);
            this.lb_loading2.Name = "lb_loading2";
            this.lb_loading2.Size = new System.Drawing.Size(145, 30);
            this.lb_loading2.TabIndex = 0;
            this.lb_loading2.Text = "Loading ...";
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Transparent;
            this.groupBox5.Controls.Add(this.btn2_save);
            this.groupBox5.Controls.Add(this.btn2_reset);
            this.groupBox5.Controls.Add(this.btn2_extract);
            this.groupBox5.Controls.Add(this.lv_result);
            this.groupBox5.Font = new System.Drawing.Font("나눔스퀘어 ExtraBold", 15F, System.Drawing.FontStyle.Bold);
            this.groupBox5.Location = new System.Drawing.Point(10, 394);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(660, 295);
            this.groupBox5.TabIndex = 26;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = " OUTPUT ";
            // 
            // btn2_save
            // 
            this.btn2_save.BackColor = System.Drawing.Color.MistyRose;
            this.btn2_save.FlatAppearance.BorderSize = 0;
            this.btn2_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2_save.Font = new System.Drawing.Font("맑은 고딕", 11.25F);
            this.btn2_save.ForeColor = System.Drawing.Color.Black;
            this.btn2_save.Location = new System.Drawing.Point(14, 133);
            this.btn2_save.Name = "btn2_save";
            this.btn2_save.Size = new System.Drawing.Size(239, 37);
            this.btn2_save.TabIndex = 26;
            this.btn2_save.Text = "저장";
            this.btn2_save.UseVisualStyleBackColor = false;
            this.btn2_save.Click += new System.EventHandler(this.btn2_save_Click);
            // 
            // btn2_reset
            // 
            this.btn2_reset.BackColor = System.Drawing.Color.MistyRose;
            this.btn2_reset.FlatAppearance.BorderSize = 0;
            this.btn2_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2_reset.Font = new System.Drawing.Font("맑은 고딕", 11.25F);
            this.btn2_reset.ForeColor = System.Drawing.Color.Black;
            this.btn2_reset.Location = new System.Drawing.Point(14, 188);
            this.btn2_reset.Name = "btn2_reset";
            this.btn2_reset.Size = new System.Drawing.Size(239, 37);
            this.btn2_reset.TabIndex = 27;
            this.btn2_reset.Text = "RESET";
            this.btn2_reset.UseVisualStyleBackColor = false;
            this.btn2_reset.Click += new System.EventHandler(this.btn2_reset_Click);
            // 
            // btn2_extract
            // 
            this.btn2_extract.BackColor = System.Drawing.Color.Tomato;
            this.btn2_extract.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn2_extract.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn2_extract.FlatAppearance.BorderSize = 0;
            this.btn2_extract.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn2_extract.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn2_extract.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2_extract.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn2_extract.ForeColor = System.Drawing.Color.White;
            this.btn2_extract.Location = new System.Drawing.Point(14, 78);
            this.btn2_extract.Name = "btn2_extract";
            this.btn2_extract.Size = new System.Drawing.Size(239, 37);
            this.btn2_extract.TabIndex = 24;
            this.btn2_extract.Text = "추출";
            this.btn2_extract.UseVisualStyleBackColor = false;
            this.btn2_extract.Click += new System.EventHandler(this.btn2_extract_Click);
            // 
            // lv_result
            // 
            this.lv_result.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_fileName,
            this.col_name,
            this.col_num});
            this.lv_result.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lv_result.GridLines = true;
            this.lv_result.Location = new System.Drawing.Point(268, 35);
            this.lv_result.Name = "lv_result";
            this.lv_result.Size = new System.Drawing.Size(376, 243);
            this.lv_result.TabIndex = 19;
            this.lv_result.UseCompatibleStateImageBehavior = false;
            this.lv_result.View = System.Windows.Forms.View.Details;
            // 
            // col_fileName
            // 
            this.col_fileName.Text = "파일명";
            this.col_fileName.Width = 150;
            // 
            // col_name
            // 
            this.col_name.Text = "이름";
            this.col_name.Width = 80;
            // 
            // col_num
            // 
            this.col_num.Text = "주민등록번호";
            this.col_num.Width = 100;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.btn2_open);
            this.groupBox4.Controls.Add(this.lvwFiles);
            this.groupBox4.Controls.Add(this.trvDir);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.txtPath);
            this.groupBox4.Font = new System.Drawing.Font("나눔스퀘어 ExtraBold", 15F, System.Drawing.FontStyle.Bold);
            this.groupBox4.Location = new System.Drawing.Point(10, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(660, 380);
            this.groupBox4.TabIndex = 25;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = " INPUT ";
            // 
            // btn2_open
            // 
            this.btn2_open.BackColor = System.Drawing.Color.Gainsboro;
            this.btn2_open.FlatAppearance.BorderSize = 0;
            this.btn2_open.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2_open.Font = new System.Drawing.Font("맑은 고딕", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn2_open.ForeColor = System.Drawing.Color.Black;
            this.btn2_open.Location = new System.Drawing.Point(557, 37);
            this.btn2_open.Name = "btn2_open";
            this.btn2_open.Size = new System.Drawing.Size(87, 21);
            this.btn2_open.TabIndex = 27;
            this.btn2_open.Text = "폴더 열기";
            this.btn2_open.UseVisualStyleBackColor = false;
            this.btn2_open.Click += new System.EventHandler(this.btn2_open_Click);
            // 
            // lvwFiles
            // 
            this.lvwFiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colFileName,
            this.colFileSize,
            this.colFileDate});
            this.lvwFiles.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lvwFiles.LargeImageList = this.imgList;
            this.lvwFiles.Location = new System.Drawing.Point(189, 100);
            this.lvwFiles.Name = "lvwFiles";
            this.lvwFiles.Size = new System.Drawing.Size(455, 262);
            this.lvwFiles.SmallImageList = this.imgList;
            this.lvwFiles.TabIndex = 25;
            this.lvwFiles.UseCompatibleStateImageBehavior = false;
            this.lvwFiles.DoubleClick += new System.EventHandler(this.lvwFiles_DoubleClick);
            // 
            // imgList
            // 
            this.imgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgList.ImageStream")));
            this.imgList.TransparentColor = System.Drawing.Color.Transparent;
            this.imgList.Images.SetKeyName(0, "directory.png");
            this.imgList.Images.SetKeyName(1, "file.png");
            this.imgList.Images.SetKeyName(2, "drive.png");
            // 
            // trvDir
            // 
            this.trvDir.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.trvDir.ImageIndex = 0;
            this.trvDir.ImageList = this.imgList;
            this.trvDir.Location = new System.Drawing.Point(14, 100);
            this.trvDir.Name = "trvDir";
            this.trvDir.SelectedImageIndex = 0;
            this.trvDir.Size = new System.Drawing.Size(169, 262);
            this.trvDir.TabIndex = 20;
            this.trvDir.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.trvDir_BeforeExpand);
            this.trvDir.BeforeSelect += new System.Windows.Forms.TreeViewCancelEventHandler(this.trvDir_BeforeSelect);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("바탕", 9F);
            this.label6.Location = new System.Drawing.Point(12, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(229, 12);
            this.label6.TabIndex = 24;
            this.label6.Text = "※ 파일을 더블클릭하면 실행 가능합니다.";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(11, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "현재 경로";
            // 
            // txtPath
            // 
            this.txtPath.Enabled = false;
            this.txtPath.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtPath.Location = new System.Drawing.Point(80, 37);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(471, 21);
            this.txtPath.TabIndex = 22;
            // 
            // Form_Ctrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 840);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form_Ctrl";
            this.Text = "CONTROLER";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tp_one.ResumeLayout(false);
            this.pnl_loading.ResumeLayout(false);
            this.pnl_loading.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_loading)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_stamp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_person)).EndInit();
            this.tp_two.ResumeLayout(false);
            this.pnl_loading2.ResumeLayout(false);
            this.pnl_loading2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_loading2)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tp_one;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_num;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_open;
        private System.Windows.Forms.TabPage tp_two;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btn_scan;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listbox;
        private System.Windows.Forms.ListView lv_result;
        private System.Windows.Forms.ImageList imgList;
        private System.Windows.Forms.TreeView trvDir;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView lvwFiles;
        private System.Windows.Forms.ColumnHeader colFileName;
        private System.Windows.Forms.ColumnHeader colFileSize;
        private System.Windows.Forms.ColumnHeader colFileDate;
        private System.Windows.Forms.ColumnHeader col_name;
        private System.Windows.Forms.ColumnHeader col_num;
        private System.Windows.Forms.ColumnHeader col_fileName;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_extract;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn2_extract;
        private System.Windows.Forms.Button btn2_save;
        private System.Windows.Forms.Button btn2_reset;
        private System.Windows.Forms.Button btn2_open;
        private System.Windows.Forms.Panel pnl_loading;
        public System.Windows.Forms.PictureBox pb_loading;
        public System.Windows.Forms.Label lb_loading;
        private System.Windows.Forms.Panel pnl_loading2;
        public System.Windows.Forms.PictureBox pb_loading2;
        public System.Windows.Forms.Label lb_loading2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cbox_format;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_fileName;
        private System.Windows.Forms.Label lb_open_fileName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pb_stamp;
        private System.Windows.Forms.PictureBox pb_person;
        private System.Windows.Forms.Label lb_adr2;
        private System.Windows.Forms.Label lb_loc;
        private System.Windows.Forms.Label lb_date;
        private System.Windows.Forms.Label lb_adr1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

