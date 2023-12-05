using MetroFramework.Forms;
using System;
using System.Windows.Forms;
using Đồ_án.net.Properties;
using Đồ_án.net.Slide_Panel;
using System.Data;
using Đồ_án.net.Functions;
using Đồ_án.net.Forms;

namespace Đồ_án.net.Forms
{
    public partial class Home : MetroForm
    {
        public Home()
        {
            InitializeComponent();
            this.StyleManager = metroStyleManager1;
            this.StyleManager.Theme = Settings.Default.Theme;
            this.StyleManager.Style = Settings.Default.Style;
        }

        private void enroll_tile_Click(object sender, EventArgs e)
        {
            metroPanel1.Visible = false;
            this.Hide();
            Nhaphoc obj1 = new Nhaphoc();
            obj1.Show();
        }

        private void teacher_tile_Click(object sender, EventArgs e)
        {
            metroPanel1.Visible = false;
            this.Hide();
            GiaoVien obj1 = new GiaoVien();
            obj1.Show();
        }

        private void attendance_tile_Click(object sender, EventArgs e)
        {
            metroPanel1.Visible = false;
            this.Hide();
            ThamGia obj1 = new ThamGia();
            obj1.Show();
        }

        private void student_tile_Click(object sender, EventArgs e)
        {
            metroPanel1.Visible = false;
            this.Hide();
            Hocvien obj1 = new Hocvien();
            obj1.Show();
        }

        private void billing_tile_Click(object sender, EventArgs e)
        {
            metroPanel1.Visible = false;
            this.Hide();
            Hoadon obj1 = new Hoadon();
            obj1.Show();
        }

        private void manage_tile_Click(object sender, EventArgs e)
        {
            metroPanel1.Visible = false;
            this.Hide();
            Nguoidung obj1 = new Nguoidung();
            obj1.Show();
        }
        void _pnlone_Closed(object sender, EventArgs e)
        {
            metroPanel1.Visible = true;
        }
        void _pnlone_Shown(object sender, EventArgs e)
        {
            metroTile2.SendToBack();
            metroPanel1.Visible = false;
        }

        private void setting_tile_Click(object sender, EventArgs e)
        {
            metroPanel1.Visible = false;

            panel _pnlone = new panel(this);
            _pnlone.Closed += _pnlone_Closed;
            _pnlone.Shown += _pnlone_Shown;
            _pnlone.swipe(true);
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            metroPanel1.Visible = false;
            this.Hide();
            Login obj = new Login();
            obj.Show();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void class_tile_Click(object sender, EventArgs e)
        {
            metroPanel1.Visible = false;
            this.Hide();
            Class obj1 = new Class();
            obj1.Show();
        }

        private void schedule_tile_Click(object sender, EventArgs e)
        {
            metroPanel1.Visible = false;
            this.Hide();
            Schedule obj1 = new Schedule();
            obj1.Show();
        }

        private void thongke_fm_Click(object sender, EventArgs e)
        {
            metroPanel1.Visible = false;
            this.Hide();
            ThongKe obj1 = new ThongKe();
            obj1.Show();
        }
    }
}
