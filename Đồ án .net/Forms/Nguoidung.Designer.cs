
namespace Đồ_án.net.Forms
{
    partial class Nguoidung
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Nguoidung));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.search_btn = new MetroFramework.Controls.MetroButton();
            this.search_box = new MetroFramework.Controls.MetroTextBox();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.del_btn = new MetroFramework.Controls.MetroButton();
            this.fix_btn = new MetroFramework.Controls.MetroButton();
            this.add_btn = new MetroFramework.Controls.MetroButton();
            this.re_btn = new MetroFramework.Controls.MetroButton();
            this.user_type = new MetroFramework.Controls.MetroComboBox();
            this.user_pass = new MetroFramework.Controls.MetroTextBox();
            this.user_acc = new MetroFramework.Controls.MetroTextBox();
            this.user_name = new MetroFramework.Controls.MetroTextBox();
            this.user_id = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroTile3 = new MetroFramework.Controls.MetroTile();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLink1 = new MetroFramework.Controls.MetroLink();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // search_btn
            // 
            this.search_btn.Location = new System.Drawing.Point(877, 17);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(115, 38);
            this.search_btn.TabIndex = 15;
            this.search_btn.Text = "Tìm kiếm";
            this.search_btn.UseSelectable = true;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // search_box
            // 
            // 
            // 
            // 
            this.search_box.CustomButton.Image = null;
            this.search_box.CustomButton.Location = new System.Drawing.Point(254, 1);
            this.search_box.CustomButton.Name = "";
            this.search_box.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.search_box.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.search_box.CustomButton.TabIndex = 1;
            this.search_box.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.search_box.CustomButton.UseSelectable = true;
            this.search_box.CustomButton.Visible = false;
            this.search_box.DisplayIcon = true;
            this.search_box.Icon = ((System.Drawing.Image)(resources.GetObject("search_box.Icon")));
            this.search_box.IconRight = true;
            this.search_box.Lines = new string[0];
            this.search_box.Location = new System.Drawing.Point(594, 32);
            this.search_box.MaxLength = 32767;
            this.search_box.Name = "search_box";
            this.search_box.PasswordChar = '\0';
            this.search_box.PromptText = "Tìm theo ID";
            this.search_box.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.search_box.SelectedText = "";
            this.search_box.SelectionLength = 0;
            this.search_box.SelectionStart = 0;
            this.search_box.ShortcutsEnabled = true;
            this.search_box.Size = new System.Drawing.Size(276, 23);
            this.search_box.TabIndex = 13;
            this.search_box.UseSelectable = true;
            this.search_box.WaterMark = "Tìm theo ID";
            this.search_box.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.search_box.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.Location = new System.Drawing.Point(540, 75);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(864, 62);
            this.metroTile2.TabIndex = 12;
            this.metroTile2.Text = "Dữ liệu";
            this.metroTile2.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.metroTile2.UseSelectable = true;
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle5;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(540, 140);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.metroGrid1.RowHeadersWidth = 62;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.RowTemplate.Height = 28;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(861, 462);
            this.metroGrid1.TabIndex = 11;
            this.metroGrid1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGrid1_CellClick);
            // 
            // del_btn
            // 
            this.del_btn.Location = new System.Drawing.Point(385, 478);
            this.del_btn.Name = "del_btn";
            this.del_btn.Size = new System.Drawing.Size(96, 36);
            this.del_btn.TabIndex = 25;
            this.del_btn.Text = "Xóa";
            this.del_btn.UseSelectable = true;
            this.del_btn.Click += new System.EventHandler(this.del_btn_Click);
            // 
            // fix_btn
            // 
            this.fix_btn.Location = new System.Drawing.Point(266, 477);
            this.fix_btn.Name = "fix_btn";
            this.fix_btn.Size = new System.Drawing.Size(95, 36);
            this.fix_btn.TabIndex = 24;
            this.fix_btn.Text = "Sửa";
            this.fix_btn.UseSelectable = true;
            this.fix_btn.Click += new System.EventHandler(this.fix_btn_Click);
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(151, 477);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(92, 36);
            this.add_btn.TabIndex = 23;
            this.add_btn.Text = "Thêm";
            this.add_btn.UseSelectable = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // re_btn
            // 
            this.re_btn.Location = new System.Drawing.Point(28, 477);
            this.re_btn.Name = "re_btn";
            this.re_btn.Size = new System.Drawing.Size(95, 36);
            this.re_btn.TabIndex = 22;
            this.re_btn.Text = "Làm mới";
            this.re_btn.UseSelectable = true;
            this.re_btn.Click += new System.EventHandler(this.re_btn_Click);
            // 
            // user_type
            // 
            this.user_type.FormattingEnabled = true;
            this.user_type.ItemHeight = 23;
            this.user_type.Items.AddRange(new object[] {
            "Admin",
            "Staff",
            "Teacher"});
            this.user_type.Location = new System.Drawing.Point(199, 417);
            this.user_type.Name = "user_type";
            this.user_type.Size = new System.Drawing.Size(282, 29);
            this.user_type.TabIndex = 21;
            this.user_type.UseSelectable = true;
            // 
            // user_pass
            // 
            // 
            // 
            // 
            this.user_pass.CustomButton.Image = null;
            this.user_pass.CustomButton.Location = new System.Drawing.Point(260, 1);
            this.user_pass.CustomButton.Name = "";
            this.user_pass.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.user_pass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.user_pass.CustomButton.TabIndex = 1;
            this.user_pass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.user_pass.CustomButton.UseSelectable = true;
            this.user_pass.CustomButton.Visible = false;
            this.user_pass.Lines = new string[0];
            this.user_pass.Location = new System.Drawing.Point(199, 341);
            this.user_pass.MaxLength = 32767;
            this.user_pass.Name = "user_pass";
            this.user_pass.PasswordChar = '\0';
            this.user_pass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.user_pass.SelectedText = "";
            this.user_pass.SelectionLength = 0;
            this.user_pass.SelectionStart = 0;
            this.user_pass.ShortcutsEnabled = true;
            this.user_pass.Size = new System.Drawing.Size(282, 23);
            this.user_pass.TabIndex = 17;
            this.user_pass.UseSelectable = true;
            this.user_pass.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.user_pass.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // user_acc
            // 
            // 
            // 
            // 
            this.user_acc.CustomButton.Image = null;
            this.user_acc.CustomButton.Location = new System.Drawing.Point(260, 1);
            this.user_acc.CustomButton.Name = "";
            this.user_acc.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.user_acc.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.user_acc.CustomButton.TabIndex = 1;
            this.user_acc.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.user_acc.CustomButton.UseSelectable = true;
            this.user_acc.CustomButton.Visible = false;
            this.user_acc.Lines = new string[0];
            this.user_acc.Location = new System.Drawing.Point(199, 250);
            this.user_acc.MaxLength = 32767;
            this.user_acc.Name = "user_acc";
            this.user_acc.PasswordChar = '\0';
            this.user_acc.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.user_acc.SelectedText = "";
            this.user_acc.SelectionLength = 0;
            this.user_acc.SelectionStart = 0;
            this.user_acc.ShortcutsEnabled = true;
            this.user_acc.Size = new System.Drawing.Size(282, 23);
            this.user_acc.TabIndex = 16;
            this.user_acc.UseSelectable = true;
            this.user_acc.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.user_acc.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // user_name
            // 
            // 
            // 
            // 
            this.user_name.CustomButton.Image = null;
            this.user_name.CustomButton.Location = new System.Drawing.Point(260, 1);
            this.user_name.CustomButton.Name = "";
            this.user_name.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.user_name.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.user_name.CustomButton.TabIndex = 1;
            this.user_name.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.user_name.CustomButton.UseSelectable = true;
            this.user_name.CustomButton.Visible = false;
            this.user_name.Lines = new string[0];
            this.user_name.Location = new System.Drawing.Point(199, 167);
            this.user_name.MaxLength = 32767;
            this.user_name.Name = "user_name";
            this.user_name.PasswordChar = '\0';
            this.user_name.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.user_name.SelectedText = "";
            this.user_name.SelectionLength = 0;
            this.user_name.SelectionStart = 0;
            this.user_name.ShortcutsEnabled = true;
            this.user_name.Size = new System.Drawing.Size(282, 23);
            this.user_name.TabIndex = 15;
            this.user_name.UseSelectable = true;
            this.user_name.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.user_name.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // user_id
            // 
            // 
            // 
            // 
            this.user_id.CustomButton.Image = null;
            this.user_id.CustomButton.Location = new System.Drawing.Point(260, 1);
            this.user_id.CustomButton.Name = "";
            this.user_id.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.user_id.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.user_id.CustomButton.TabIndex = 1;
            this.user_id.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.user_id.CustomButton.UseSelectable = true;
            this.user_id.CustomButton.Visible = false;
            this.user_id.Lines = new string[0];
            this.user_id.Location = new System.Drawing.Point(199, 79);
            this.user_id.MaxLength = 32767;
            this.user_id.Name = "user_id";
            this.user_id.PasswordChar = '\0';
            this.user_id.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.user_id.SelectedText = "";
            this.user_id.SelectionLength = 0;
            this.user_id.SelectionStart = 0;
            this.user_id.ShortcutsEnabled = true;
            this.user_id.Size = new System.Drawing.Size(282, 23);
            this.user_id.TabIndex = 0;
            this.user_id.UseSelectable = true;
            this.user_id.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.user_id.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(28, 417);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(72, 19);
            this.metroLabel10.TabIndex = 12;
            this.metroLabel10.Text = "Chức năng";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(28, 341);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(63, 19);
            this.metroLabel5.TabIndex = 7;
            this.metroLabel5.Text = "Mật khẩu";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(28, 250);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(85, 19);
            this.metroLabel4.TabIndex = 5;
            this.metroLabel4.Text = "Tên tài khoản";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(28, 167);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(48, 19);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "Họ tên";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(28, 79);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(21, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "ID";
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(0, 1);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(509, 62);
            this.metroTile1.TabIndex = 2;
            this.metroTile1.Text = "Chức năng";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.metroTile1.UseSelectable = true;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.del_btn);
            this.metroPanel1.Controls.Add(this.fix_btn);
            this.metroPanel1.Controls.Add(this.add_btn);
            this.metroPanel1.Controls.Add(this.re_btn);
            this.metroPanel1.Controls.Add(this.user_type);
            this.metroPanel1.Controls.Add(this.user_pass);
            this.metroPanel1.Controls.Add(this.user_acc);
            this.metroPanel1.Controls.Add(this.user_name);
            this.metroPanel1.Controls.Add(this.user_id);
            this.metroPanel1.Controls.Add(this.metroLabel10);
            this.metroPanel1.Controls.Add(this.metroLabel5);
            this.metroPanel1.Controls.Add(this.metroLabel4);
            this.metroPanel1.Controls.Add(this.metroLabel3);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.metroTile1);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(25, 74);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(509, 528);
            this.metroPanel1.TabIndex = 10;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = null;
            // 
            // metroTile3
            // 
            this.metroTile3.ActiveControl = null;
            this.metroTile3.Location = new System.Drawing.Point(0, 638);
            this.metroTile3.Name = "metroTile3";
            this.metroTile3.Size = new System.Drawing.Size(1459, 26);
            this.metroTile3.TabIndex = 14;
            this.metroTile3.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(85, 32);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(89, 19);
            this.metroLabel1.TabIndex = 9;
            this.metroLabel1.Text = "Người dùng";
            // 
            // metroLink1
            // 
            this.metroLink1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("metroLink1.BackgroundImage")));
            this.metroLink1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.metroLink1.Location = new System.Drawing.Point(13, 17);
            this.metroLink1.Name = "metroLink1";
            this.metroLink1.Size = new System.Drawing.Size(56, 51);
            this.metroLink1.TabIndex = 8;
            this.metroLink1.UseSelectable = true;
            this.metroLink1.Click += new System.EventHandler(this.metroLink1_Click);
            this.metroLink1.MouseLeave += new System.EventHandler(this.metroLink1_MouseLeave);
            this.metroLink1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.metroLink1_MouseMove);
            // 
            // Nguoidung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1458, 665);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.search_box);
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.metroGrid1);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.metroTile3);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroLink1);
            this.Name = "Nguoidung";
            this.Load += new System.EventHandler(this.Nguoidung_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton search_btn;
        private MetroFramework.Controls.MetroTextBox search_box;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private MetroFramework.Controls.MetroButton del_btn;
        private MetroFramework.Controls.MetroButton fix_btn;
        private MetroFramework.Controls.MetroButton add_btn;
        private MetroFramework.Controls.MetroButton re_btn;
        private MetroFramework.Controls.MetroComboBox user_type;
        private MetroFramework.Controls.MetroTextBox user_pass;
        private MetroFramework.Controls.MetroTextBox user_acc;
        private MetroFramework.Controls.MetroTextBox user_name;
        private MetroFramework.Controls.MetroTextBox user_id;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Controls.MetroTile metroTile3;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLink metroLink1;
    }
}