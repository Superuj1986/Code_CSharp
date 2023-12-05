
namespace Đồ_án.net.Forms
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.enroll_tile = new MetroFramework.Controls.MetroTile();
            this.teacher_tile = new MetroFramework.Controls.MetroTile();
            this.student_tile = new MetroFramework.Controls.MetroTile();
            this.setting_tile = new MetroFramework.Controls.MetroTile();
            this.manage_tile = new MetroFramework.Controls.MetroTile();
            this.attendance_tile = new MetroFramework.Controls.MetroTile();
            this.billing_tile = new MetroFramework.Controls.MetroTile();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLink1 = new MetroFramework.Controls.MetroLink();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.class_tile = new MetroFramework.Controls.MetroTile();
            this.schedule_tile = new MetroFramework.Controls.MetroTile();
            this.thongke_fm = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = null;
            // 
            // enroll_tile
            // 
            this.enroll_tile.ActiveControl = null;
            this.enroll_tile.Location = new System.Drawing.Point(172, 98);
            this.enroll_tile.Name = "enroll_tile";
            this.enroll_tile.Size = new System.Drawing.Size(214, 208);
            this.enroll_tile.TabIndex = 0;
            this.enroll_tile.Text = "Nhập học";
            this.enroll_tile.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.enroll_tile.TileImage = ((System.Drawing.Image)(resources.GetObject("enroll_tile.TileImage")));
            this.enroll_tile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.enroll_tile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.enroll_tile.UseSelectable = true;
            this.enroll_tile.UseStyleColors = true;
            this.enroll_tile.UseTileImage = true;
            this.enroll_tile.Click += new System.EventHandler(this.enroll_tile_Click);
            // 
            // teacher_tile
            // 
            this.teacher_tile.ActiveControl = null;
            this.teacher_tile.Location = new System.Drawing.Point(509, 202);
            this.teacher_tile.Name = "teacher_tile";
            this.teacher_tile.Size = new System.Drawing.Size(111, 104);
            this.teacher_tile.TabIndex = 1;
            this.teacher_tile.Text = "Giáo viên";
            this.teacher_tile.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.teacher_tile.TileImage = ((System.Drawing.Image)(resources.GetObject("teacher_tile.TileImage")));
            this.teacher_tile.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.teacher_tile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.teacher_tile.UseSelectable = true;
            this.teacher_tile.UseStyleColors = true;
            this.teacher_tile.UseTileImage = true;
            this.teacher_tile.Click += new System.EventHandler(this.teacher_tile_Click);
            // 
            // student_tile
            // 
            this.student_tile.ActiveControl = null;
            this.student_tile.Location = new System.Drawing.Point(392, 202);
            this.student_tile.Name = "student_tile";
            this.student_tile.Size = new System.Drawing.Size(111, 104);
            this.student_tile.TabIndex = 0;
            this.student_tile.Text = "Học viên";
            this.student_tile.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.student_tile.TileImage = ((System.Drawing.Image)(resources.GetObject("student_tile.TileImage")));
            this.student_tile.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.student_tile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.student_tile.UseSelectable = true;
            this.student_tile.UseStyleColors = true;
            this.student_tile.UseTileImage = true;
            this.student_tile.Click += new System.EventHandler(this.student_tile_Click);
            // 
            // setting_tile
            // 
            this.setting_tile.ActiveControl = null;
            this.setting_tile.Location = new System.Drawing.Point(509, 98);
            this.setting_tile.Name = "setting_tile";
            this.setting_tile.Size = new System.Drawing.Size(111, 98);
            this.setting_tile.TabIndex = 0;
            this.setting_tile.Text = "Cài đặt";
            this.setting_tile.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.setting_tile.TileImage = ((System.Drawing.Image)(resources.GetObject("setting_tile.TileImage")));
            this.setting_tile.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.setting_tile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.setting_tile.UseSelectable = true;
            this.setting_tile.UseStyleColors = true;
            this.setting_tile.UseTileImage = true;
            this.setting_tile.Click += new System.EventHandler(this.setting_tile_Click);
            // 
            // manage_tile
            // 
            this.manage_tile.ActiveControl = null;
            this.manage_tile.Location = new System.Drawing.Point(392, 312);
            this.manage_tile.Name = "manage_tile";
            this.manage_tile.Size = new System.Drawing.Size(228, 105);
            this.manage_tile.TabIndex = 0;
            this.manage_tile.Text = "Quản lý người dùng";
            this.manage_tile.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.manage_tile.TileImage = ((System.Drawing.Image)(resources.GetObject("manage_tile.TileImage")));
            this.manage_tile.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.manage_tile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.manage_tile.UseSelectable = true;
            this.manage_tile.UseStyleColors = true;
            this.manage_tile.UseTileImage = true;
            this.manage_tile.Click += new System.EventHandler(this.manage_tile_Click);
            // 
            // attendance_tile
            // 
            this.attendance_tile.ActiveControl = null;
            this.attendance_tile.Location = new System.Drawing.Point(392, 98);
            this.attendance_tile.Name = "attendance_tile";
            this.attendance_tile.Size = new System.Drawing.Size(111, 98);
            this.attendance_tile.TabIndex = 0;
            this.attendance_tile.Text = "Tham gia";
            this.attendance_tile.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.attendance_tile.TileImage = ((System.Drawing.Image)(resources.GetObject("attendance_tile.TileImage")));
            this.attendance_tile.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.attendance_tile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.attendance_tile.UseSelectable = true;
            this.attendance_tile.UseStyleColors = true;
            this.attendance_tile.UseTileImage = true;
            this.attendance_tile.Click += new System.EventHandler(this.attendance_tile_Click);
            // 
            // billing_tile
            // 
            this.billing_tile.ActiveControl = null;
            this.billing_tile.Location = new System.Drawing.Point(172, 312);
            this.billing_tile.Name = "billing_tile";
            this.billing_tile.Size = new System.Drawing.Size(214, 105);
            this.billing_tile.TabIndex = 0;
            this.billing_tile.Text = "Hóa đơn";
            this.billing_tile.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.billing_tile.TileImage = ((System.Drawing.Image)(resources.GetObject("billing_tile.TileImage")));
            this.billing_tile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.billing_tile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.billing_tile.UseSelectable = true;
            this.billing_tile.UseStyleColors = true;
            this.billing_tile.UseTileImage = true;
            this.billing_tile.Click += new System.EventHandler(this.billing_tile_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(118, 41);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(109, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Hệ thống quản lý";
            // 
            // metroLink1
            // 
            this.metroLink1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("metroLink1.BackgroundImage")));
            this.metroLink1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.metroLink1.Location = new System.Drawing.Point(662, 15);
            this.metroLink1.Name = "metroLink1";
            this.metroLink1.Size = new System.Drawing.Size(63, 45);
            this.metroLink1.TabIndex = 3;
            this.metroLink1.UseSelectable = true;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.metroButton2);
            this.metroPanel1.Controls.Add(this.metroButton1);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(662, 98);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(200, 100);
            this.metroPanel1.TabIndex = 4;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(13, 53);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(169, 35);
            this.metroButton2.TabIndex = 3;
            this.metroButton2.Text = "Thoát";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(13, 14);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(169, 33);
            this.metroButton1.TabIndex = 2;
            this.metroButton1.Text = "Đăng xuất";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(2, 681);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(1315, 22);
            this.metroTile1.TabIndex = 5;
            this.metroTile1.Text = "metroTile1";
            this.metroTile1.UseSelectable = true;
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.Location = new System.Drawing.Point(118, 63);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(533, 11);
            this.metroTile2.TabIndex = 6;
            this.metroTile2.Text = "metroTile2";
            this.metroTile2.UseSelectable = true;
            // 
            // class_tile
            // 
            this.class_tile.ActiveControl = null;
            this.class_tile.Location = new System.Drawing.Point(172, 424);
            this.class_tile.Name = "class_tile";
            this.class_tile.Size = new System.Drawing.Size(214, 99);
            this.class_tile.TabIndex = 7;
            this.class_tile.Text = "Lớp học";
            this.class_tile.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.class_tile.TileImage = ((System.Drawing.Image)(resources.GetObject("class_tile.TileImage")));
            this.class_tile.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.class_tile.UseSelectable = true;
            this.class_tile.UseTileImage = true;
            this.class_tile.Click += new System.EventHandler(this.class_tile_Click);
            // 
            // schedule_tile
            // 
            this.schedule_tile.ActiveControl = null;
            this.schedule_tile.Cursor = System.Windows.Forms.Cursors.Default;
            this.schedule_tile.Location = new System.Drawing.Point(393, 424);
            this.schedule_tile.Name = "schedule_tile";
            this.schedule_tile.Size = new System.Drawing.Size(227, 99);
            this.schedule_tile.TabIndex = 8;
            this.schedule_tile.Text = "Lịch làm việc";
            this.schedule_tile.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.schedule_tile.TileImage = ((System.Drawing.Image)(resources.GetObject("schedule_tile.TileImage")));
            this.schedule_tile.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.schedule_tile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.schedule_tile.UseSelectable = true;
            this.schedule_tile.UseStyleColors = true;
            this.schedule_tile.UseTileImage = true;
            this.schedule_tile.Click += new System.EventHandler(this.schedule_tile_Click);
            // 
            // thongke_fm
            // 
            this.thongke_fm.ActiveControl = null;
            this.thongke_fm.Location = new System.Drawing.Point(172, 529);
            this.thongke_fm.Name = "thongke_fm";
            this.thongke_fm.Size = new System.Drawing.Size(214, 104);
            this.thongke_fm.TabIndex = 9;
            this.thongke_fm.Text = "Thống kế";
            this.thongke_fm.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.thongke_fm.TileImage = ((System.Drawing.Image)(resources.GetObject("thongke_fm.TileImage")));
            this.thongke_fm.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.thongke_fm.UseSelectable = true;
            this.thongke_fm.UseTileImage = true;
            this.thongke_fm.Click += new System.EventHandler(this.thongke_fm_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1317, 700);
            this.Controls.Add(this.thongke_fm);
            this.Controls.Add(this.schedule_tile);
            this.Controls.Add(this.class_tile);
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.metroLink1);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.student_tile);
            this.Controls.Add(this.setting_tile);
            this.Controls.Add(this.manage_tile);
            this.Controls.Add(this.attendance_tile);
            this.Controls.Add(this.billing_tile);
            this.Controls.Add(this.teacher_tile);
            this.Controls.Add(this.enroll_tile);
            this.Name = "Home";
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Controls.MetroTile enroll_tile;
        private MetroFramework.Controls.MetroTile teacher_tile;
        private MetroFramework.Controls.MetroTile student_tile;
        private MetroFramework.Controls.MetroTile setting_tile;
        private MetroFramework.Controls.MetroTile manage_tile;
        private MetroFramework.Controls.MetroTile attendance_tile;
        private MetroFramework.Controls.MetroTile billing_tile;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLink metroLink1;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroTile class_tile;
        private MetroFramework.Controls.MetroTile schedule_tile;
        private MetroFramework.Controls.MetroTile thongke_fm;
    }
}