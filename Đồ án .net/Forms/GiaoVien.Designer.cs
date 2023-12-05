
namespace Đồ_án.net.Forms
{
    partial class GiaoVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GiaoVien));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroLink1 = new MetroFramework.Controls.MetroLink();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.del_btn = new MetroFramework.Controls.MetroButton();
            this.fix_btn = new MetroFramework.Controls.MetroButton();
            this.add_btn = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.te_classunder = new MetroFramework.Controls.MetroComboBox();
            this.te_sdt = new MetroFramework.Controls.MetroTextBox();
            this.te_sa = new MetroFramework.Controls.MetroTextBox();
            this.te_sub = new MetroFramework.Controls.MetroTextBox();
            this.te_qua = new MetroFramework.Controls.MetroTextBox();
            this.te_age = new MetroFramework.Controls.MetroTextBox();
            this.te_name = new MetroFramework.Controls.MetroTextBox();
            this.te_id = new MetroFramework.Controls.MetroTextBox();
            this.te_dob = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.search_box = new MetroFramework.Controls.MetroTextBox();
            this.metroTile3 = new MetroFramework.Controls.MetroTile();
            this.search_btn = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLink1
            // 
            this.metroLink1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("metroLink1.BackgroundImage")));
            this.metroLink1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.metroLink1.Location = new System.Drawing.Point(11, 20);
            this.metroLink1.Name = "metroLink1";
            this.metroLink1.Size = new System.Drawing.Size(56, 51);
            this.metroLink1.TabIndex = 0;
            this.metroLink1.UseSelectable = true;
            this.metroLink1.Click += new System.EventHandler(this.metroLink1_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(83, 35);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(72, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Giáo viên";
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = null;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.del_btn);
            this.metroPanel1.Controls.Add(this.fix_btn);
            this.metroPanel1.Controls.Add(this.add_btn);
            this.metroPanel1.Controls.Add(this.metroButton1);
            this.metroPanel1.Controls.Add(this.te_classunder);
            this.metroPanel1.Controls.Add(this.te_sdt);
            this.metroPanel1.Controls.Add(this.te_sa);
            this.metroPanel1.Controls.Add(this.te_sub);
            this.metroPanel1.Controls.Add(this.te_qua);
            this.metroPanel1.Controls.Add(this.te_age);
            this.metroPanel1.Controls.Add(this.te_name);
            this.metroPanel1.Controls.Add(this.te_id);
            this.metroPanel1.Controls.Add(this.te_dob);
            this.metroPanel1.Controls.Add(this.metroLabel10);
            this.metroPanel1.Controls.Add(this.metroLabel9);
            this.metroPanel1.Controls.Add(this.metroLabel8);
            this.metroPanel1.Controls.Add(this.metroLabel7);
            this.metroPanel1.Controls.Add(this.metroLabel6);
            this.metroPanel1.Controls.Add(this.metroLabel5);
            this.metroPanel1.Controls.Add(this.metroLabel4);
            this.metroPanel1.Controls.Add(this.metroLabel3);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.metroTile1);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(23, 77);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(509, 528);
            this.metroPanel1.TabIndex = 2;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
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
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(28, 477);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(95, 36);
            this.metroButton1.TabIndex = 22;
            this.metroButton1.Text = "Làm mới";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // te_classunder
            // 
            this.te_classunder.FormattingEnabled = true;
            this.te_classunder.ItemHeight = 23;
            this.te_classunder.Items.AddRange(new object[] {
            "Playground classes",
            "Primary classes",
            "Secondary classes",
            "Matric classes",
            "Practical classes"});
            this.te_classunder.Location = new System.Drawing.Point(199, 417);
            this.te_classunder.Name = "te_classunder";
            this.te_classunder.Size = new System.Drawing.Size(282, 29);
            this.te_classunder.TabIndex = 21;
            this.te_classunder.UseSelectable = true;
            // 
            // te_sdt
            // 
            // 
            // 
            // 
            this.te_sdt.CustomButton.Image = null;
            this.te_sdt.CustomButton.Location = new System.Drawing.Point(260, 1);
            this.te_sdt.CustomButton.Name = "";
            this.te_sdt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.te_sdt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.te_sdt.CustomButton.TabIndex = 1;
            this.te_sdt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.te_sdt.CustomButton.UseSelectable = true;
            this.te_sdt.CustomButton.Visible = false;
            this.te_sdt.Lines = new string[0];
            this.te_sdt.Location = new System.Drawing.Point(199, 376);
            this.te_sdt.MaxLength = 32767;
            this.te_sdt.Name = "te_sdt";
            this.te_sdt.PasswordChar = '\0';
            this.te_sdt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.te_sdt.SelectedText = "";
            this.te_sdt.SelectionLength = 0;
            this.te_sdt.SelectionStart = 0;
            this.te_sdt.ShortcutsEnabled = true;
            this.te_sdt.Size = new System.Drawing.Size(282, 23);
            this.te_sdt.TabIndex = 20;
            this.te_sdt.UseSelectable = true;
            this.te_sdt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.te_sdt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.te_sdt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.te_sdt_KeyPress);
            // 
            // te_sa
            // 
            // 
            // 
            // 
            this.te_sa.CustomButton.Image = null;
            this.te_sa.CustomButton.Location = new System.Drawing.Point(260, 1);
            this.te_sa.CustomButton.Name = "";
            this.te_sa.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.te_sa.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.te_sa.CustomButton.TabIndex = 1;
            this.te_sa.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.te_sa.CustomButton.UseSelectable = true;
            this.te_sa.CustomButton.Visible = false;
            this.te_sa.Lines = new string[0];
            this.te_sa.Location = new System.Drawing.Point(199, 339);
            this.te_sa.MaxLength = 32767;
            this.te_sa.Name = "te_sa";
            this.te_sa.PasswordChar = '\0';
            this.te_sa.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.te_sa.SelectedText = "";
            this.te_sa.SelectionLength = 0;
            this.te_sa.SelectionStart = 0;
            this.te_sa.ShortcutsEnabled = true;
            this.te_sa.Size = new System.Drawing.Size(282, 23);
            this.te_sa.TabIndex = 19;
            this.te_sa.UseSelectable = true;
            this.te_sa.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.te_sa.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // te_sub
            // 
            // 
            // 
            // 
            this.te_sub.CustomButton.Image = null;
            this.te_sub.CustomButton.Location = new System.Drawing.Point(260, 1);
            this.te_sub.CustomButton.Name = "";
            this.te_sub.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.te_sub.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.te_sub.CustomButton.TabIndex = 1;
            this.te_sub.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.te_sub.CustomButton.UseSelectable = true;
            this.te_sub.CustomButton.Visible = false;
            this.te_sub.Lines = new string[0];
            this.te_sub.Location = new System.Drawing.Point(199, 296);
            this.te_sub.MaxLength = 32767;
            this.te_sub.Name = "te_sub";
            this.te_sub.PasswordChar = '\0';
            this.te_sub.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.te_sub.SelectedText = "";
            this.te_sub.SelectionLength = 0;
            this.te_sub.SelectionStart = 0;
            this.te_sub.ShortcutsEnabled = true;
            this.te_sub.Size = new System.Drawing.Size(282, 23);
            this.te_sub.TabIndex = 18;
            this.te_sub.UseSelectable = true;
            this.te_sub.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.te_sub.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // te_qua
            // 
            // 
            // 
            // 
            this.te_qua.CustomButton.Image = null;
            this.te_qua.CustomButton.Location = new System.Drawing.Point(260, 1);
            this.te_qua.CustomButton.Name = "";
            this.te_qua.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.te_qua.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.te_qua.CustomButton.TabIndex = 1;
            this.te_qua.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.te_qua.CustomButton.UseSelectable = true;
            this.te_qua.CustomButton.Visible = false;
            this.te_qua.Lines = new string[0];
            this.te_qua.Location = new System.Drawing.Point(199, 256);
            this.te_qua.MaxLength = 32767;
            this.te_qua.Name = "te_qua";
            this.te_qua.PasswordChar = '\0';
            this.te_qua.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.te_qua.SelectedText = "";
            this.te_qua.SelectionLength = 0;
            this.te_qua.SelectionStart = 0;
            this.te_qua.ShortcutsEnabled = true;
            this.te_qua.Size = new System.Drawing.Size(282, 23);
            this.te_qua.TabIndex = 17;
            this.te_qua.UseSelectable = true;
            this.te_qua.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.te_qua.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // te_age
            // 
            // 
            // 
            // 
            this.te_age.CustomButton.Image = null;
            this.te_age.CustomButton.Location = new System.Drawing.Point(260, 1);
            this.te_age.CustomButton.Name = "";
            this.te_age.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.te_age.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.te_age.CustomButton.TabIndex = 1;
            this.te_age.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.te_age.CustomButton.UseSelectable = true;
            this.te_age.CustomButton.Visible = false;
            this.te_age.Lines = new string[0];
            this.te_age.Location = new System.Drawing.Point(199, 213);
            this.te_age.MaxLength = 32767;
            this.te_age.Name = "te_age";
            this.te_age.PasswordChar = '\0';
            this.te_age.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.te_age.SelectedText = "";
            this.te_age.SelectionLength = 0;
            this.te_age.SelectionStart = 0;
            this.te_age.ShortcutsEnabled = true;
            this.te_age.Size = new System.Drawing.Size(282, 23);
            this.te_age.TabIndex = 16;
            this.te_age.UseSelectable = true;
            this.te_age.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.te_age.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.te_age.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.te_age_KeyPress);
            // 
            // te_name
            // 
            // 
            // 
            // 
            this.te_name.CustomButton.Image = null;
            this.te_name.CustomButton.Location = new System.Drawing.Point(260, 1);
            this.te_name.CustomButton.Name = "";
            this.te_name.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.te_name.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.te_name.CustomButton.TabIndex = 1;
            this.te_name.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.te_name.CustomButton.UseSelectable = true;
            this.te_name.CustomButton.Visible = false;
            this.te_name.Lines = new string[0];
            this.te_name.Location = new System.Drawing.Point(199, 124);
            this.te_name.MaxLength = 32767;
            this.te_name.Name = "te_name";
            this.te_name.PasswordChar = '\0';
            this.te_name.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.te_name.SelectedText = "";
            this.te_name.SelectionLength = 0;
            this.te_name.SelectionStart = 0;
            this.te_name.ShortcutsEnabled = true;
            this.te_name.Size = new System.Drawing.Size(282, 23);
            this.te_name.TabIndex = 15;
            this.te_name.UseSelectable = true;
            this.te_name.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.te_name.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // te_id
            // 
            // 
            // 
            // 
            this.te_id.CustomButton.Image = null;
            this.te_id.CustomButton.Location = new System.Drawing.Point(260, 1);
            this.te_id.CustomButton.Name = "";
            this.te_id.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.te_id.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.te_id.CustomButton.TabIndex = 1;
            this.te_id.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.te_id.CustomButton.UseSelectable = true;
            this.te_id.CustomButton.Visible = false;
            this.te_id.Lines = new string[0];
            this.te_id.Location = new System.Drawing.Point(199, 79);
            this.te_id.MaxLength = 32767;
            this.te_id.Name = "te_id";
            this.te_id.PasswordChar = '\0';
            this.te_id.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.te_id.SelectedText = "";
            this.te_id.SelectionLength = 0;
            this.te_id.SelectionStart = 0;
            this.te_id.ShortcutsEnabled = true;
            this.te_id.Size = new System.Drawing.Size(282, 23);
            this.te_id.TabIndex = 0;
            this.te_id.UseSelectable = true;
            this.te_id.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.te_id.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // te_dob
            // 
            this.te_dob.Location = new System.Drawing.Point(199, 171);
            this.te_dob.MinimumSize = new System.Drawing.Size(0, 29);
            this.te_dob.Name = "te_dob";
            this.te_dob.Size = new System.Drawing.Size(282, 29);
            this.te_dob.TabIndex = 13;
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(28, 417);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(95, 19);
            this.metroLabel10.TabIndex = 12;
            this.metroLabel10.Text = "Chủ nhiệm lớp";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(28, 376);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(31, 19);
            this.metroLabel9.TabIndex = 11;
            this.metroLabel9.Text = "SDT";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(28, 339);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(46, 19);
            this.metroLabel8.TabIndex = 10;
            this.metroLabel8.Text = "Lương";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(28, 296);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(61, 19);
            this.metroLabel7.TabIndex = 9;
            this.metroLabel7.Text = "Môn học";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(28, 256);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(64, 19);
            this.metroLabel6.TabIndex = 8;
            this.metroLabel6.Text = "Bằng cấp";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(28, 213);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(32, 19);
            this.metroLabel5.TabIndex = 7;
            this.metroLabel5.Text = "Tuổi";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(28, 171);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(66, 19);
            this.metroLabel4.TabIndex = 5;
            this.metroLabel4.Text = "Ngày sinh";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(28, 124);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(85, 19);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "Tên giáo viên";
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
            this.metroGrid1.Location = new System.Drawing.Point(538, 143);
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
            this.metroGrid1.Size = new System.Drawing.Size(680, 462);
            this.metroGrid1.TabIndex = 3;
            this.metroGrid1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGrid1_CellClick);
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.Location = new System.Drawing.Point(538, 78);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(864, 62);
            this.metroTile2.TabIndex = 4;
            this.metroTile2.Text = "Dữ liệu";
            this.metroTile2.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.metroTile2.UseSelectable = true;
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
            this.search_box.Location = new System.Drawing.Point(592, 35);
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
            this.search_box.TabIndex = 5;
            this.search_box.UseSelectable = true;
            this.search_box.WaterMark = "Tìm theo ID";
            this.search_box.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.search_box.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTile3
            // 
            this.metroTile3.ActiveControl = null;
            this.metroTile3.Location = new System.Drawing.Point(-2, 641);
            this.metroTile3.Name = "metroTile3";
            this.metroTile3.Size = new System.Drawing.Size(1459, 26);
            this.metroTile3.TabIndex = 6;
            this.metroTile3.UseSelectable = true;
            // 
            // search_btn
            // 
            this.search_btn.Location = new System.Drawing.Point(875, 20);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(115, 38);
            this.search_btn.TabIndex = 7;
            this.search_btn.Text = "Tìm kiếm";
            this.search_btn.UseSelectable = true;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // GiaoVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1456, 669);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.metroTile3);
            this.Controls.Add(this.search_box);
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.metroGrid1);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroLink1);
            this.Name = "GiaoVien";
            this.Load += new System.EventHandler(this.GiaoVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLink metroLink1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroTextBox search_box;
        private MetroFramework.Controls.MetroTile metroTile3;
        private MetroFramework.Controls.MetroComboBox te_classunder;
        private MetroFramework.Controls.MetroTextBox te_sdt;
        private MetroFramework.Controls.MetroTextBox te_sa;
        private MetroFramework.Controls.MetroTextBox te_sub;
        private MetroFramework.Controls.MetroTextBox te_qua;
        private MetroFramework.Controls.MetroTextBox te_age;
        private MetroFramework.Controls.MetroTextBox te_name;
        private MetroFramework.Controls.MetroTextBox te_id;
        private MetroFramework.Controls.MetroDateTime te_dob;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton del_btn;
        private MetroFramework.Controls.MetroButton fix_btn;
        private MetroFramework.Controls.MetroButton add_btn;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton search_btn;
    }
}