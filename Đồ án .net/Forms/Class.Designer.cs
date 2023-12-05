
namespace Đồ_án.net.Forms
{
    partial class Class
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Class));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLink1 = new MetroFramework.Controls.MetroLink();
            this.fix_btn = new MetroFramework.Controls.MetroButton();
            this.add_btn = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.del_btn = new MetroFramework.Controls.MetroButton();
            this.class_name = new MetroFramework.Controls.MetroTextBox();
            this.class_id = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroTile3 = new MetroFramework.Controls.MetroTile();
            this.search_box = new MetroFramework.Controls.MetroTextBox();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.search_btn = new MetroFramework.Controls.MetroButton();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(84, 34);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(62, 19);
            this.metroLabel1.TabIndex = 17;
            this.metroLabel1.Text = "Lớp học";
            // 
            // metroLink1
            // 
            this.metroLink1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("metroLink1.BackgroundImage")));
            this.metroLink1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.metroLink1.Location = new System.Drawing.Point(12, 19);
            this.metroLink1.Name = "metroLink1";
            this.metroLink1.Size = new System.Drawing.Size(56, 51);
            this.metroLink1.TabIndex = 16;
            this.metroLink1.UseSelectable = true;
            this.metroLink1.Click += new System.EventHandler(this.metroLink1_Click);
            this.metroLink1.MouseLeave += new System.EventHandler(this.metroLink1_MouseLeave);
            this.metroLink1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.metroLink1_MouseMove);
            // 
            // fix_btn
            // 
            this.fix_btn.Location = new System.Drawing.Point(277, 477);
            this.fix_btn.Name = "fix_btn";
            this.fix_btn.Size = new System.Drawing.Size(95, 36);
            this.fix_btn.TabIndex = 24;
            this.fix_btn.Text = "Sửa";
            this.fix_btn.UseSelectable = true;
            this.fix_btn.Click += new System.EventHandler(this.fix_btn_Click);
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(156, 477);
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
            this.metroPanel1.Controls.Add(this.class_name);
            this.metroPanel1.Controls.Add(this.class_id);
            this.metroPanel1.Controls.Add(this.metroLabel3);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.metroTile1);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(24, 76);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(509, 528);
            this.metroPanel1.TabIndex = 18;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // del_btn
            // 
            this.del_btn.Location = new System.Drawing.Point(393, 477);
            this.del_btn.Name = "del_btn";
            this.del_btn.Size = new System.Drawing.Size(88, 36);
            this.del_btn.TabIndex = 25;
            this.del_btn.Text = "Xóa";
            this.del_btn.UseSelectable = true;
            this.del_btn.Click += new System.EventHandler(this.del_btn_Click_1);
            // 
            // class_name
            // 
            // 
            // 
            // 
            this.class_name.CustomButton.Image = null;
            this.class_name.CustomButton.Location = new System.Drawing.Point(260, 1);
            this.class_name.CustomButton.Name = "";
            this.class_name.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.class_name.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.class_name.CustomButton.TabIndex = 1;
            this.class_name.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.class_name.CustomButton.UseSelectable = true;
            this.class_name.CustomButton.Visible = false;
            this.class_name.Lines = new string[0];
            this.class_name.Location = new System.Drawing.Point(199, 124);
            this.class_name.MaxLength = 32767;
            this.class_name.Name = "class_name";
            this.class_name.PasswordChar = '\0';
            this.class_name.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.class_name.SelectedText = "";
            this.class_name.SelectionLength = 0;
            this.class_name.SelectionStart = 0;
            this.class_name.ShortcutsEnabled = true;
            this.class_name.Size = new System.Drawing.Size(282, 23);
            this.class_name.TabIndex = 15;
            this.class_name.UseSelectable = true;
            this.class_name.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.class_name.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // class_id
            // 
            // 
            // 
            // 
            this.class_id.CustomButton.Image = null;
            this.class_id.CustomButton.Location = new System.Drawing.Point(260, 1);
            this.class_id.CustomButton.Name = "";
            this.class_id.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.class_id.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.class_id.CustomButton.TabIndex = 1;
            this.class_id.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.class_id.CustomButton.UseSelectable = true;
            this.class_id.CustomButton.Visible = false;
            this.class_id.Lines = new string[0];
            this.class_id.Location = new System.Drawing.Point(199, 79);
            this.class_id.MaxLength = 32767;
            this.class_id.Name = "class_id";
            this.class_id.PasswordChar = '\0';
            this.class_id.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.class_id.SelectedText = "";
            this.class_id.SelectionLength = 0;
            this.class_id.SelectionStart = 0;
            this.class_id.ShortcutsEnabled = true;
            this.class_id.Size = new System.Drawing.Size(282, 23);
            this.class_id.TabIndex = 0;
            this.class_id.UseSelectable = true;
            this.class_id.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.class_id.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(28, 124);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(76, 19);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "Tên lớp học";
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
            // metroTile3
            // 
            this.metroTile3.ActiveControl = null;
            this.metroTile3.Location = new System.Drawing.Point(-1, 640);
            this.metroTile3.Name = "metroTile3";
            this.metroTile3.Size = new System.Drawing.Size(1459, 26);
            this.metroTile3.TabIndex = 22;
            this.metroTile3.UseSelectable = true;
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
            this.search_box.Location = new System.Drawing.Point(593, 34);
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
            this.search_box.TabIndex = 21;
            this.search_box.UseSelectable = true;
            this.search_box.WaterMark = "Tìm theo ID";
            this.search_box.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.search_box.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.Location = new System.Drawing.Point(539, 77);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(864, 62);
            this.metroTile2.TabIndex = 20;
            this.metroTile2.Text = "Dữ liệu";
            this.metroTile2.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.metroTile2.UseSelectable = true;
            // 
            // search_btn
            // 
            this.search_btn.Location = new System.Drawing.Point(876, 19);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(115, 38);
            this.search_btn.TabIndex = 23;
            this.search_btn.Text = "Tìm kiếm";
            this.search_btn.UseSelectable = true;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(539, 142);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGrid1.RowHeadersWidth = 62;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.RowTemplate.Height = 28;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(680, 462);
            this.metroGrid1.TabIndex = 19;
            this.metroGrid1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGrid1_CellClick);
            // 
            // Class
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1426, 751);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroLink1);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.metroTile3);
            this.Controls.Add(this.search_box);
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.metroGrid1);
            this.Name = "Class";
            this.Load += new System.EventHandler(this.Class_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLink metroLink1;
        private MetroFramework.Controls.MetroButton fix_btn;
        private MetroFramework.Controls.MetroButton add_btn;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTextBox class_name;
        private MetroFramework.Controls.MetroTextBox class_id;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTile metroTile3;
        private MetroFramework.Controls.MetroTextBox search_box;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroButton search_btn;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private MetroFramework.Controls.MetroButton del_btn;
    }
}