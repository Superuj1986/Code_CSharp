using MetroFramework.Forms;
using System;
using System.Data;
using System.Windows.Forms;
using Đồ_án.net.Functions;
using Đồ_án.net.Properties;

namespace Đồ_án.net.Forms
{
    public partial class Hocvien : MetroForm
    {
        Ketnoi kn = new Ketnoi();
        public string s_id;
        public string name;
        public Hocvien()
        {
            InitializeComponent();
            this.StyleManager = metroStyleManager1;
            this.StyleManager.Theme = Settings.Default.Theme;
            this.StyleManager.Style = Settings.Default.Style;
        }
        public void getdata()
        {
            string query = string.Format(
                "select * from enrollment_details"
                );
            DataSet ds = kn.GetData(query);
            metroGrid1.DataSource = ds.Tables[0];
        }
        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Nhaphoc obj = new Nhaphoc();
            obj.Show();
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home obj = new Home();
            obj.Show();
        }

        private void Hocvien_Load(object sender, EventArgs e)
        {
            metroTile3.Text = DateTime.Now.ToLongDateString();
            getdata();
        }

        private void del_btn_Click(object sender, EventArgs e)
        {
            if (s_id == "")
            {
                MessageBox.Show("Hãy chọn dòng dữ liệu ");
            }
            else
            {
                if (MetroFramework.MetroMessageBox.Show(this, "Bạn có muốn xóa dữ liệu của "+ name + " không ?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    string query = string.Format(
                        "delete from enrollment_details where std_id = '{0}'",
                        s_id
                        );
                    if (kn.Thucthi(query) == true)
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Xóa thành công", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        metroButton1.PerformClick();
                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Xóa thất bại", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void metroGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = e.RowIndex;
            if ( r >= 0)
            {
                DataGridViewRow row = this.metroGrid1.Rows[r];
                s_id = row.Cells[0].Value.ToString();
                name = row.Cells[1].Value.ToString();
            }
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            string query = string.Format(
                "select * from enrollment_details where std_id like '%{0}%'",
                search_box.Text
                );
            DataSet ds = kn.GetData(query);
            metroGrid1.DataSource = ds.Tables[0];
        }

        private void metroLink1_MouseMove(object sender, MouseEventArgs e)
        {
            this.metroLink1.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.home_icon_black));
            this.metroLink1.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void metroLink1_MouseLeave(object sender, EventArgs e)
        {
            this.metroLink1.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.home_icon_grey));
            this.metroLink1.BackgroundImageLayout = ImageLayout.Zoom;
        }
    }
}
