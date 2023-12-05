
namespace Đồ_án.net.Forms
{
    partial class Hoadon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hoadon));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.paid_radio = new MetroFramework.Controls.MetroRadioButton();
            this.latepaid_radio = new MetroFramework.Controls.MetroRadioButton();
            this.unpaid_radio = new MetroFramework.Controls.MetroRadioButton();
            this.done_btn = new MetroFramework.Controls.MetroButton();
            this.prev_btn = new MetroFramework.Controls.MetroButton();
            this.next_btn = new MetroFramework.Controls.MetroButton();
            this.no_data_lb = new MetroFramework.Controls.MetroLabel();
            this.date_box = new MetroFramework.Controls.MetroTextBox();
            this.refresh_link = new MetroFramework.Controls.MetroLink();
            this.search_box = new MetroFramework.Controls.MetroTextBox();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLink1 = new MetroFramework.Controls.MetroLink();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroStyleExtender1 = new MetroFramework.Components.MetroStyleExtender(this.components);
            this.s_id = new MetroFramework.Controls.MetroLabel();
            this.s_name = new MetroFramework.Controls.MetroLabel();
            this.s_class = new MetroFramework.Controls.MetroLabel();
            this.s_fees = new MetroFramework.Controls.MetroLabel();
            this.s_other = new MetroFramework.Controls.MetroLabel();
            this.s_total = new MetroFramework.Controls.MetroLabel();
            this.del_btn = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // paid_radio
            // 
            this.paid_radio.AutoSize = true;
            this.paid_radio.Location = new System.Drawing.Point(450, 503);
            this.paid_radio.Name = "paid_radio";
            this.paid_radio.Size = new System.Drawing.Size(54, 15);
            this.paid_radio.TabIndex = 28;
            this.paid_radio.Text = "Đã trả";
            this.paid_radio.UseSelectable = true;
            // 
            // latepaid_radio
            // 
            this.latepaid_radio.AutoSize = true;
            this.latepaid_radio.Location = new System.Drawing.Point(543, 503);
            this.latepaid_radio.Name = "latepaid_radio";
            this.latepaid_radio.Size = new System.Drawing.Size(73, 15);
            this.latepaid_radio.TabIndex = 27;
            this.latepaid_radio.Text = "Trả muộn";
            this.latepaid_radio.UseSelectable = true;
            // 
            // unpaid_radio
            // 
            this.unpaid_radio.AutoSize = true;
            this.unpaid_radio.Location = new System.Drawing.Point(663, 503);
            this.unpaid_radio.Name = "unpaid_radio";
            this.unpaid_radio.Size = new System.Drawing.Size(68, 15);
            this.unpaid_radio.TabIndex = 26;
            this.unpaid_radio.Text = "Chưa trả";
            this.unpaid_radio.UseSelectable = true;
            // 
            // done_btn
            // 
            this.done_btn.Location = new System.Drawing.Point(514, 566);
            this.done_btn.Name = "done_btn";
            this.done_btn.Size = new System.Drawing.Size(134, 42);
            this.done_btn.TabIndex = 25;
            this.done_btn.Text = "Done";
            this.done_btn.UseSelectable = true;
            this.done_btn.Click += new System.EventHandler(this.done_btn_Click);
            // 
            // prev_btn
            // 
            this.prev_btn.Location = new System.Drawing.Point(450, 566);
            this.prev_btn.Name = "prev_btn";
            this.prev_btn.Size = new System.Drawing.Size(47, 42);
            this.prev_btn.TabIndex = 24;
            this.prev_btn.Text = "<<";
            this.prev_btn.UseSelectable = true;
            this.prev_btn.Click += new System.EventHandler(this.prev_btn_Click);
            // 
            // next_btn
            // 
            this.next_btn.Location = new System.Drawing.Point(663, 566);
            this.next_btn.Name = "next_btn";
            this.next_btn.Size = new System.Drawing.Size(48, 42);
            this.next_btn.TabIndex = 23;
            this.next_btn.Text = ">>";
            this.next_btn.UseSelectable = true;
            this.next_btn.Click += new System.EventHandler(this.next_btn_Click);
            // 
            // no_data_lb
            // 
            this.no_data_lb.AutoSize = true;
            this.no_data_lb.Location = new System.Drawing.Point(500, 427);
            this.no_data_lb.Name = "no_data_lb";
            this.no_data_lb.Size = new System.Drawing.Size(180, 19);
            this.no_data_lb.TabIndex = 22;
            this.no_data_lb.Text = "Không có học sinh để hiển thị";
            // 
            // date_box
            // 
            // 
            // 
            // 
            this.date_box.CustomButton.Image = null;
            this.date_box.CustomButton.Location = new System.Drawing.Point(271, 1);
            this.date_box.CustomButton.Name = "";
            this.date_box.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.date_box.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.date_box.CustomButton.TabIndex = 1;
            this.date_box.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.date_box.CustomButton.UseSelectable = true;
            this.date_box.CustomButton.Visible = false;
            this.date_box.Lines = new string[0];
            this.date_box.Location = new System.Drawing.Point(61, 424);
            this.date_box.MaxLength = 32767;
            this.date_box.Name = "date_box";
            this.date_box.PasswordChar = '\0';
            this.date_box.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.date_box.SelectedText = "";
            this.date_box.SelectionLength = 0;
            this.date_box.SelectionStart = 0;
            this.date_box.ShortcutsEnabled = true;
            this.date_box.Size = new System.Drawing.Size(293, 23);
            this.date_box.TabIndex = 21;
            this.date_box.UseSelectable = true;
            this.date_box.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.date_box.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // refresh_link
            // 
            this.refresh_link.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("refresh_link.BackgroundImage")));
            this.refresh_link.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.refresh_link.Location = new System.Drawing.Point(917, 56);
            this.refresh_link.Name = "refresh_link";
            this.refresh_link.Size = new System.Drawing.Size(40, 32);
            this.refresh_link.TabIndex = 20;
            this.refresh_link.UseSelectable = true;
            this.refresh_link.Click += new System.EventHandler(this.refresh_link_Click);
            // 
            // search_box
            // 
            // 
            // 
            // 
            this.search_box.CustomButton.Image = null;
            this.search_box.CustomButton.Location = new System.Drawing.Point(207, 1);
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
            this.search_box.Location = new System.Drawing.Point(672, 62);
            this.search_box.MaxLength = 32767;
            this.search_box.Name = "search_box";
            this.search_box.PasswordChar = '\0';
            this.search_box.PromptText = "Tìm theo ID";
            this.search_box.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.search_box.SelectedText = "";
            this.search_box.SelectionLength = 0;
            this.search_box.SelectionStart = 0;
            this.search_box.ShortcutsEnabled = true;
            this.search_box.Size = new System.Drawing.Size(229, 23);
            this.search_box.TabIndex = 19;
            this.search_box.UseCustomBackColor = true;
            this.search_box.UseSelectable = true;
            this.search_box.WaterMark = "Tìm theo ID";
            this.search_box.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.search_box.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.Location = new System.Drawing.Point(4, 395);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(1062, 10);
            this.metroTile2.TabIndex = 14;
            this.metroTile2.Text = "metroTile2";
            this.metroTile2.UseSelectable = true;
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(4, 629);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(1062, 21);
            this.metroTile1.TabIndex = 18;
            this.metroTile1.UseSelectable = true;
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
            this.metroGrid1.Location = new System.Drawing.Point(266, 94);
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
            this.metroGrid1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(780, 275);
            this.metroGrid1.TabIndex = 17;
            this.metroGrid1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGrid1_CellContentClick);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(106, 56);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(60, 19);
            this.metroLabel1.TabIndex = 16;
            this.metroLabel1.Text = "Hóa đơn";
            // 
            // metroLink1
            // 
            this.metroLink1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("metroLink1.BackgroundImage")));
            this.metroLink1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.metroLink1.Location = new System.Drawing.Point(47, 39);
            this.metroLink1.Name = "metroLink1";
            this.metroLink1.Size = new System.Drawing.Size(53, 47);
            this.metroLink1.TabIndex = 15;
            this.metroLink1.UseSelectable = true;
            this.metroLink1.Click += new System.EventHandler(this.metroLink1_Click);
            this.metroLink1.MouseLeave += new System.EventHandler(this.metroLink1_MouseLeave);
            this.metroLink1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.metroLink1_MouseMove);
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = null;
            // 
            // s_id
            // 
            this.s_id.AutoSize = true;
            this.s_id.Location = new System.Drawing.Point(47, 119);
            this.s_id.Name = "s_id";
            this.s_id.Size = new System.Drawing.Size(21, 19);
            this.s_id.TabIndex = 29;
            this.s_id.Text = "ID";
            // 
            // s_name
            // 
            this.s_name.AutoSize = true;
            this.s_name.Location = new System.Drawing.Point(47, 158);
            this.s_name.Name = "s_name";
            this.s_name.Size = new System.Drawing.Size(48, 19);
            this.s_name.TabIndex = 30;
            this.s_name.Text = "Họ tên";
            // 
            // s_class
            // 
            this.s_class.AutoSize = true;
            this.s_class.Location = new System.Drawing.Point(47, 201);
            this.s_class.Name = "s_class";
            this.s_class.Size = new System.Drawing.Size(56, 19);
            this.s_class.TabIndex = 31;
            this.s_class.Text = "Lớp học";
            // 
            // s_fees
            // 
            this.s_fees.AutoSize = true;
            this.s_fees.Location = new System.Drawing.Point(47, 242);
            this.s_fees.Name = "s_fees";
            this.s_fees.Size = new System.Drawing.Size(54, 19);
            this.s_fees.TabIndex = 32;
            this.s_fees.Text = "Học phí";
            // 
            // s_other
            // 
            this.s_other.AutoSize = true;
            this.s_other.Location = new System.Drawing.Point(47, 285);
            this.s_other.Name = "s_other";
            this.s_other.Size = new System.Drawing.Size(83, 19);
            this.s_other.TabIndex = 33;
            this.s_other.Text = "Các phí khác";
            // 
            // s_total
            // 
            this.s_total.AutoSize = true;
            this.s_total.Location = new System.Drawing.Point(47, 335);
            this.s_total.Name = "s_total";
            this.s_total.Size = new System.Drawing.Size(43, 19);
            this.s_total.TabIndex = 34;
            this.s_total.Text = "Tổng ";
            // 
            // del_btn
            // 
            this.del_btn.Location = new System.Drawing.Point(1094, 524);
            this.del_btn.Name = "del_btn";
            this.del_btn.Size = new System.Drawing.Size(134, 42);
            this.del_btn.TabIndex = 35;
            this.del_btn.Text = "Xóa";
            this.del_btn.UseSelectable = true;
            this.del_btn.Click += new System.EventHandler(this.del_btn_Click);
            // 
            // Hoadon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 651);
            this.Controls.Add(this.del_btn);
            this.Controls.Add(this.s_total);
            this.Controls.Add(this.s_other);
            this.Controls.Add(this.s_fees);
            this.Controls.Add(this.s_class);
            this.Controls.Add(this.s_name);
            this.Controls.Add(this.s_id);
            this.Controls.Add(this.paid_radio);
            this.Controls.Add(this.latepaid_radio);
            this.Controls.Add(this.unpaid_radio);
            this.Controls.Add(this.done_btn);
            this.Controls.Add(this.prev_btn);
            this.Controls.Add(this.next_btn);
            this.Controls.Add(this.no_data_lb);
            this.Controls.Add(this.date_box);
            this.Controls.Add(this.refresh_link);
            this.Controls.Add(this.search_box);
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.metroGrid1);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroLink1);
            this.Name = "Hoadon";
            this.Load += new System.EventHandler(this.Hoadon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroRadioButton paid_radio;
        private MetroFramework.Controls.MetroRadioButton latepaid_radio;
        private MetroFramework.Controls.MetroRadioButton unpaid_radio;
        private MetroFramework.Controls.MetroButton done_btn;
        private MetroFramework.Controls.MetroButton prev_btn;
        private MetroFramework.Controls.MetroButton next_btn;
        private MetroFramework.Controls.MetroLabel no_data_lb;
        private MetroFramework.Controls.MetroTextBox date_box;
        private MetroFramework.Controls.MetroLink refresh_link;
        private MetroFramework.Controls.MetroTextBox search_box;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLink metroLink1;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Components.MetroStyleExtender metroStyleExtender1;
        private MetroFramework.Controls.MetroLabel s_id;
        private MetroFramework.Controls.MetroLabel s_name;
        private MetroFramework.Controls.MetroLabel s_class;
        private MetroFramework.Controls.MetroLabel s_fees;
        private MetroFramework.Controls.MetroLabel s_other;
        private MetroFramework.Controls.MetroLabel s_total;
        private MetroFramework.Controls.MetroButton del_btn;
    }
}