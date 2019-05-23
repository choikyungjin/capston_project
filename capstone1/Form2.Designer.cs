namespace capstone1
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ctrl_Scrollpb = new ScrollPictureBox.Ctrl_ScrollPictureBox();
            this.SuspendLayout();
            // 
            // ctrl_Scrollpb
            // 
            this.ctrl_Scrollpb.BackColor = System.Drawing.Color.White;
            this.ctrl_Scrollpb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ctrl_Scrollpb.Location = new System.Drawing.Point(0, 25);
            this.ctrl_Scrollpb.Name = "ctrl_Scrollpb";
            this.ctrl_Scrollpb.Size = new System.Drawing.Size(684, 636);
            this.ctrl_Scrollpb.TabIndex = 24;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 661);
            this.Controls.Add(this.ctrl_Scrollpb);
            this.Name = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ScrollPictureBox.Ctrl_ScrollPictureBox ctrl_Scrollpb;
    }
}