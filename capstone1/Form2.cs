using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MaterialSkin;
using MaterialSkin.Controls;

namespace capstone1
{
    public partial class Form2 : MaterialForm
    {
        public String file_pwd = "";
        public Form2()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Red700, Primary.Red700, Primary.Red500, Accent.Red100, TextShade.WHITE);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Form_Ctrl parent = new Form_Ctrl();

            if (file_pwd != "")
                ctrl_Scrollpb.LoadImage(file_pwd);
            
        }
    }
}
