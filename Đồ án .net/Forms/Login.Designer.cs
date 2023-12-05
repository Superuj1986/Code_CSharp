
namespace Đồ_án.net.Forms
{
    partial class Login
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLink1 = new MetroFramework.Controls.MetroLink();
            this.usertxt = new MetroFramework.Controls.MetroTextBox();
            this.passtxt = new MetroFramework.Controls.MetroTextBox();
            this.login_btn = new System.Windows.Forms.Button();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.user_empty = new MetroFramework.Controls.MetroLabel();
            this.pass_empty = new MetroFramework.Controls.MetroLabel();
            this.metroLink2 = new MetroFramework.Controls.MetroLink();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(372, 83);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(41, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Login";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(286, 136);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(198, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Hãy đăng nhập để vào hệ thống";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(140, 202);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(63, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Tài khoản";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(140, 295);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(63, 19);
            this.metroLabel4.TabIndex = 3;
            this.metroLabel4.Text = "Mật khẩu";
            // 
            // metroLink1
            // 
            this.metroLink1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("metroLink1.BackgroundImage")));
            this.metroLink1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.metroLink1.Location = new System.Drawing.Point(899, 38);
            this.metroLink1.Name = "metroLink1";
            this.metroLink1.Size = new System.Drawing.Size(70, 54);
            this.metroLink1.TabIndex = 4;
            this.metroLink1.UseSelectable = true;
            this.metroLink1.Click += new System.EventHandler(this.metroLink1_Click);
            this.metroLink1.MouseLeave += new System.EventHandler(this.metroLink1_MouseLeave);
            this.metroLink1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.metroLink1_MouseMove);
            // 
            // usertxt
            // 
            // 
            // 
            // 
            this.usertxt.CustomButton.Image = null;
            this.usertxt.CustomButton.Location = new System.Drawing.Point(223, 1);
            this.usertxt.CustomButton.Name = "";
            this.usertxt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.usertxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.usertxt.CustomButton.TabIndex = 1;
            this.usertxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.usertxt.CustomButton.UseSelectable = true;
            this.usertxt.CustomButton.Visible = false;
            this.usertxt.Lines = new string[0];
            this.usertxt.Location = new System.Drawing.Point(286, 202);
            this.usertxt.MaxLength = 32767;
            this.usertxt.Name = "usertxt";
            this.usertxt.PasswordChar = '\0';
            this.usertxt.PromptText = "Nhập tên tài khoản";
            this.usertxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.usertxt.SelectedText = "";
            this.usertxt.SelectionLength = 0;
            this.usertxt.SelectionStart = 0;
            this.usertxt.ShortcutsEnabled = true;
            this.usertxt.Size = new System.Drawing.Size(245, 23);
            this.usertxt.TabIndex = 0;
            this.usertxt.UseSelectable = true;
            this.usertxt.WaterMark = "Nhập tên tài khoản";
            this.usertxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.usertxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.usertxt.TextChanged += new System.EventHandler(this.usertxt_TextChanged);
            // 
            // passtxt
            // 
            // 
            // 
            // 
            this.passtxt.CustomButton.Image = null;
            this.passtxt.CustomButton.Location = new System.Drawing.Point(223, 1);
            this.passtxt.CustomButton.Name = "";
            this.passtxt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.passtxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.passtxt.CustomButton.TabIndex = 1;
            this.passtxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.passtxt.CustomButton.UseSelectable = true;
            this.passtxt.CustomButton.Visible = false;
            this.passtxt.Lines = new string[0];
            this.passtxt.Location = new System.Drawing.Point(286, 295);
            this.passtxt.MaxLength = 32767;
            this.passtxt.Name = "passtxt";
            this.passtxt.PasswordChar = '*';
            this.passtxt.PromptText = "Nhập mật khẩu";
            this.passtxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.passtxt.SelectedText = "";
            this.passtxt.SelectionLength = 0;
            this.passtxt.SelectionStart = 0;
            this.passtxt.ShortcutsEnabled = true;
            this.passtxt.Size = new System.Drawing.Size(245, 23);
            this.passtxt.TabIndex = 1;
            this.passtxt.UseSelectable = true;
            this.passtxt.WaterMark = "Nhập mật khẩu";
            this.passtxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.passtxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.passtxt.TextChanged += new System.EventHandler(this.passtxt_TextChanged);
            // 
            // login_btn
            // 
            this.login_btn.Location = new System.Drawing.Point(322, 377);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(162, 43);
            this.login_btn.TabIndex = 2;
            this.login_btn.Text = "Đăng nhập";
            this.login_btn.UseVisualStyleBackColor = true;
            this.login_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = null;
            // 
            // user_empty
            // 
            this.user_empty.AutoSize = true;
            this.user_empty.ForeColor = System.Drawing.Color.Red;
            this.user_empty.Location = new System.Drawing.Point(516, 180);
            this.user_empty.Name = "user_empty";
            this.user_empty.Size = new System.Drawing.Size(15, 19);
            this.user_empty.TabIndex = 9;
            this.user_empty.Text = "*";
            this.user_empty.UseCustomBackColor = true;
            this.user_empty.UseCustomForeColor = true;
            this.user_empty.UseStyleColors = true;
            // 
            // pass_empty
            // 
            this.pass_empty.AutoSize = true;
            this.pass_empty.ForeColor = System.Drawing.Color.Red;
            this.pass_empty.Location = new System.Drawing.Point(516, 273);
            this.pass_empty.Name = "pass_empty";
            this.pass_empty.Size = new System.Drawing.Size(15, 19);
            this.pass_empty.TabIndex = 10;
            this.pass_empty.Text = "*";
            this.pass_empty.UseCustomBackColor = true;
            this.pass_empty.UseCustomForeColor = true;
            this.pass_empty.UseStyleColors = true;
            // 
            // metroLink2
            // 
            this.metroLink2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("metroLink2.BackgroundImage")));
            this.metroLink2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.metroLink2.Location = new System.Drawing.Point(1019, 38);
            this.metroLink2.Name = "metroLink2";
            this.metroLink2.Size = new System.Drawing.Size(53, 54);
            this.metroLink2.TabIndex = 5;
            this.metroLink2.UseSelectable = true;
            this.metroLink2.Click += new System.EventHandler(this.metroLink2_Click);
            this.metroLink2.MouseLeave += new System.EventHandler(this.metroLink2_MouseLeave);
            this.metroLink2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.metroLink2_MouseMove);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 693);
            this.Controls.Add(this.pass_empty);
            this.Controls.Add(this.user_empty);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.passtxt);
            this.Controls.Add(this.usertxt);
            this.Controls.Add(this.metroLink2);
            this.Controls.Add(this.metroLink1);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLink metroLink1;
        private MetroFramework.Controls.MetroTextBox usertxt;
        private MetroFramework.Controls.MetroTextBox passtxt;
        private System.Windows.Forms.Button login_btn;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Controls.MetroLabel user_empty;
        private MetroFramework.Controls.MetroLabel pass_empty;
        private MetroFramework.Controls.MetroLink metroLink2;
    }
}