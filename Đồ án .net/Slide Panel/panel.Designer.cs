
namespace Đồ_án.net.Slide_Panel
{
    partial class panel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.testkn_btn = new MetroFramework.Controls.MetroTabPage();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.pass_box = new MetroFramework.Controls.MetroTextBox();
            this.user_box = new MetroFramework.Controls.MetroTextBox();
            this.dbname_box = new MetroFramework.Controls.MetroTextBox();
            this.servername_box = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.metroRadioButton2 = new MetroFramework.Controls.MetroRadioButton();
            this.metroRadioButton1 = new MetroFramework.Controls.MetroRadioButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLink1 = new MetroFramework.Controls.MetroLink();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.metroPanel1.SuspendLayout();
            this.metroTabControl1.SuspendLayout();
            this.testkn_btn.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.metroTabControl1);
            this.metroPanel1.Controls.Add(this.metroLink1);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(675, 3);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(461, 528);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.testkn_btn);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Location = new System.Drawing.Point(4, 100);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(454, 425);
            this.metroTabControl1.TabIndex = 3;
            this.metroTabControl1.UseSelectable = true;
            // 
            // testkn_btn
            // 
            this.testkn_btn.Controls.Add(this.metroButton1);
            this.testkn_btn.Controls.Add(this.pass_box);
            this.testkn_btn.Controls.Add(this.user_box);
            this.testkn_btn.Controls.Add(this.dbname_box);
            this.testkn_btn.Controls.Add(this.servername_box);
            this.testkn_btn.Controls.Add(this.metroLabel6);
            this.testkn_btn.Controls.Add(this.metroLabel5);
            this.testkn_btn.Controls.Add(this.metroLabel4);
            this.testkn_btn.Controls.Add(this.metroLabel3);
            this.testkn_btn.HorizontalScrollbarBarColor = true;
            this.testkn_btn.HorizontalScrollbarHighlightOnWheel = false;
            this.testkn_btn.HorizontalScrollbarSize = 10;
            this.testkn_btn.Location = new System.Drawing.Point(4, 38);
            this.testkn_btn.Name = "testkn_btn";
            this.testkn_btn.Size = new System.Drawing.Size(446, 383);
            this.testkn_btn.TabIndex = 0;
            this.testkn_btn.Text = "Kết nối";
            this.testkn_btn.VerticalScrollbarBarColor = true;
            this.testkn_btn.VerticalScrollbarHighlightOnWheel = false;
            this.testkn_btn.VerticalScrollbarSize = 10;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(148, 326);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(175, 41);
            this.metroButton1.TabIndex = 10;
            this.metroButton1.Text = "Kiểm tra kết nối";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // pass_box
            // 
            // 
            // 
            // 
            this.pass_box.CustomButton.Image = null;
            this.pass_box.CustomButton.Location = new System.Drawing.Point(345, 1);
            this.pass_box.CustomButton.Name = "";
            this.pass_box.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.pass_box.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.pass_box.CustomButton.TabIndex = 1;
            this.pass_box.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.pass_box.CustomButton.UseSelectable = true;
            this.pass_box.CustomButton.Visible = false;
            this.pass_box.Lines = new string[0];
            this.pass_box.Location = new System.Drawing.Point(15, 279);
            this.pass_box.MaxLength = 32767;
            this.pass_box.Name = "pass_box";
            this.pass_box.PasswordChar = '\0';
            this.pass_box.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.pass_box.SelectedText = "";
            this.pass_box.SelectionLength = 0;
            this.pass_box.SelectionStart = 0;
            this.pass_box.ShortcutsEnabled = true;
            this.pass_box.Size = new System.Drawing.Size(367, 23);
            this.pass_box.TabIndex = 9;
            this.pass_box.UseSelectable = true;
            this.pass_box.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.pass_box.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // user_box
            // 
            // 
            // 
            // 
            this.user_box.CustomButton.Image = null;
            this.user_box.CustomButton.Location = new System.Drawing.Point(345, 1);
            this.user_box.CustomButton.Name = "";
            this.user_box.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.user_box.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.user_box.CustomButton.TabIndex = 1;
            this.user_box.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.user_box.CustomButton.UseSelectable = true;
            this.user_box.CustomButton.Visible = false;
            this.user_box.Lines = new string[0];
            this.user_box.Location = new System.Drawing.Point(15, 207);
            this.user_box.MaxLength = 32767;
            this.user_box.Name = "user_box";
            this.user_box.PasswordChar = '\0';
            this.user_box.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.user_box.SelectedText = "";
            this.user_box.SelectionLength = 0;
            this.user_box.SelectionStart = 0;
            this.user_box.ShortcutsEnabled = true;
            this.user_box.Size = new System.Drawing.Size(367, 23);
            this.user_box.TabIndex = 8;
            this.user_box.UseSelectable = true;
            this.user_box.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.user_box.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // dbname_box
            // 
            // 
            // 
            // 
            this.dbname_box.CustomButton.Image = null;
            this.dbname_box.CustomButton.Location = new System.Drawing.Point(345, 1);
            this.dbname_box.CustomButton.Name = "";
            this.dbname_box.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.dbname_box.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.dbname_box.CustomButton.TabIndex = 1;
            this.dbname_box.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.dbname_box.CustomButton.UseSelectable = true;
            this.dbname_box.CustomButton.Visible = false;
            this.dbname_box.Lines = new string[0];
            this.dbname_box.Location = new System.Drawing.Point(15, 129);
            this.dbname_box.MaxLength = 32767;
            this.dbname_box.Name = "dbname_box";
            this.dbname_box.PasswordChar = '\0';
            this.dbname_box.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dbname_box.SelectedText = "";
            this.dbname_box.SelectionLength = 0;
            this.dbname_box.SelectionStart = 0;
            this.dbname_box.ShortcutsEnabled = true;
            this.dbname_box.Size = new System.Drawing.Size(367, 23);
            this.dbname_box.TabIndex = 7;
            this.dbname_box.UseSelectable = true;
            this.dbname_box.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.dbname_box.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // servername_box
            // 
            // 
            // 
            // 
            this.servername_box.CustomButton.Image = null;
            this.servername_box.CustomButton.Location = new System.Drawing.Point(345, 1);
            this.servername_box.CustomButton.Name = "";
            this.servername_box.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.servername_box.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.servername_box.CustomButton.TabIndex = 1;
            this.servername_box.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.servername_box.CustomButton.UseSelectable = true;
            this.servername_box.CustomButton.Visible = false;
            this.servername_box.Lines = new string[0];
            this.servername_box.Location = new System.Drawing.Point(15, 53);
            this.servername_box.MaxLength = 32767;
            this.servername_box.Name = "servername_box";
            this.servername_box.PasswordChar = '\0';
            this.servername_box.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.servername_box.SelectedText = "";
            this.servername_box.SelectionLength = 0;
            this.servername_box.SelectionStart = 0;
            this.servername_box.ShortcutsEnabled = true;
            this.servername_box.Size = new System.Drawing.Size(367, 23);
            this.servername_box.TabIndex = 6;
            this.servername_box.UseSelectable = true;
            this.servername_box.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.servername_box.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(15, 247);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(63, 19);
            this.metroLabel6.TabIndex = 5;
            this.metroLabel6.Text = "Mật khẩu";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(15, 169);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(100, 19);
            this.metroLabel5.TabIndex = 4;
            this.metroLabel5.Text = "Tên người dùng";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(15, 91);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(48, 19);
            this.metroLabel4.TabIndex = 3;
            this.metroLabel4.Text = "Tên db";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(15, 21);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(68, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Tên server";
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.metroRadioButton2);
            this.metroTabPage2.Controls.Add(this.metroRadioButton1);
            this.metroTabPage2.Controls.Add(this.flowLayoutPanel1);
            this.metroTabPage2.Controls.Add(this.metroLabel2);
            this.metroTabPage2.Controls.Add(this.metroLabel1);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(446, 383);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Chủ đề";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // metroRadioButton2
            // 
            this.metroRadioButton2.AutoSize = true;
            this.metroRadioButton2.Location = new System.Drawing.Point(215, 54);
            this.metroRadioButton2.Name = "metroRadioButton2";
            this.metroRadioButton2.Size = new System.Drawing.Size(50, 15);
            this.metroRadioButton2.TabIndex = 6;
            this.metroRadioButton2.Text = "Light";
            this.metroRadioButton2.UseSelectable = true;
            this.metroRadioButton2.CheckedChanged += new System.EventHandler(this.metroRadioButton2_CheckedChanged);
            // 
            // metroRadioButton1
            // 
            this.metroRadioButton1.AutoSize = true;
            this.metroRadioButton1.Location = new System.Drawing.Point(19, 54);
            this.metroRadioButton1.Name = "metroRadioButton1";
            this.metroRadioButton1.Size = new System.Drawing.Size(47, 15);
            this.metroRadioButton1.TabIndex = 5;
            this.metroRadioButton1.Text = "Dark";
            this.metroRadioButton1.UseSelectable = true;
            this.metroRadioButton1.CheckedChanged += new System.EventHandler(this.metroRadioButton1_CheckedChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(4, 115);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(439, 265);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(19, 92);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(36, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Style";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(19, 19);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(49, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Theme";
            // 
            // metroLink1
            // 
            this.metroLink1.Location = new System.Drawing.Point(49, 49);
            this.metroLink1.Name = "metroLink1";
            this.metroLink1.Size = new System.Drawing.Size(75, 23);
            this.metroLink1.TabIndex = 2;
            this.metroLink1.Text = "Cài đặt";
            this.metroLink1.UseSelectable = true;
            this.metroLink1.Click += new System.EventHandler(this.metroLink1_Click);
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = null;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroPanel1);
            this.Name = "panel";
            this.Size = new System.Drawing.Size(1136, 624);
            this.metroPanel1.ResumeLayout(false);
            this.metroTabControl1.ResumeLayout(false);
            this.testkn_btn.ResumeLayout(false);
            this.testkn_btn.PerformLayout();
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage testkn_btn;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroLink metroLink1;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroTextBox pass_box;
        private MetroFramework.Controls.MetroTextBox user_box;
        private MetroFramework.Controls.MetroTextBox dbname_box;
        private MetroFramework.Controls.MetroTextBox servername_box;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroRadioButton metroRadioButton2;
        private MetroFramework.Controls.MetroRadioButton metroRadioButton1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}
