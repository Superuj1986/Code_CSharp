using MetroFramework.Forms;
using System;
using System.Data;
using System.Windows.Forms;
using Đồ_án.net.Functions;
using Đồ_án.net.Properties;

namespace Đồ_án.net.Forms
{
    public partial class Schedule : MetroForm
    {
        Ketnoi kn = new Ketnoi();
        public Schedule()
        {
            InitializeComponent();
            this.StyleManager = metroStyleManager1;
            this.StyleManager.Theme = Settings.Default.Theme;
            this.StyleManager.Style = Settings.Default.Style;
        }
        public void getidgv()
        {
            string query = string.Format(
                "select * from teachers_details"
                );
            DataSet ds = kn.GetData(query);
            te_id.DataSource = ds.Tables[0];
            te_id.ValueMember = "teacher_id";
        }
        public void getidclass()
        {
            string query = string.Format(
                "select * from classes_details"
                );
            DataSet ds = kn.GetData(query);
            class_id.DataSource = ds.Tables[0];
            class_id.ValueMember = "class_id";
        }
        public void getdata()
        {
            string query = string.Format(
                "select * from schedule_details"
                );
            DataSet ds = kn.GetData(query);
            metroGrid1.DataSource = ds.Tables[0];
        }
        private void re_btn_Click(object sender, EventArgs e)
        {
            schedule_id.Text = " ";
            te_id.Text = " ";
            class_id.Text = " ";
            getdata();
        }

        private void Schedule_Load(object sender, EventArgs e)
        {
            metroTile3.Text = DateTime.Now.ToLongDateString();
            getidclass();
            getidgv();
            getdata();
        }

        private void metroGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = e.RowIndex;
            if ( r >= 0)
            {
                schedule_id.Text = metroGrid1.Rows[r].Cells["id"].Value.ToString();
                date.Value = DateTime.Parse(metroGrid1.Rows[r].Cells["date"].Value.ToString());
                te_id.Text = metroGrid1.Rows[r].Cells["teacher_id"].Value.ToString();
                class_id.Text = metroGrid1.Rows[r].Cells["class_id"].Value.ToString();
            }
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string query = string.Format(
                    "insert into schedule_details values ( '{0}','{1}','{2}','{3}' ) ",
                    schedule_id.Text,
                    (string)date.Text,
                    (string)te_id.Text,
                    (string)class_id.Text
                    );
                if (kn.Thucthi(query) == true)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Thêm mới thành công", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    re_btn.PerformClick();
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Thêm mới thất bại", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception E)
            {
                MetroFramework.MetroMessageBox.Show(this, "Lỗi" + E, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void fix_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string query = string.Format(
                    "update schedule_details set date = '{1}', teacher_id = '{2}', class_id = '{3}' where id = '{0}'",
                    schedule_id.Text,
                    (string)date.Text,
                    te_id.Text,
                    class_id.Text
                    );
                if (kn.Thucthi(query) == true)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Sửa thành công", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    re_btn.PerformClick();
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Sửa thất bại", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception E)
            {
                MetroFramework.MetroMessageBox.Show(this, "Lỗi" + E, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void del_btn_Click(object sender, EventArgs e)
        {
            if (schedule_id.Text == " ")
            {
                MessageBox.Show("Hãy chọn dòng dữ liệu ");
            }
            else
            {
                if (MetroFramework.MetroMessageBox.Show(this, "Bạn có muốn xóa dữ liệu của " + schedule_id.Text + " không ?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    try
                    {
                        string query = string.Format(
                            "delete from schedule_details where id = '{0}'",
                            schedule_id.Text
                            );
                        if (kn.Thucthi(query) == true)
                        {
                            MetroFramework.MetroMessageBox.Show(this, "Xóa thành công", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            re_btn.PerformClick();
                        }
                        else
                        {
                            MetroFramework.MetroMessageBox.Show(this, "Xóa thất bại", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception E)
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Lỗi" + E, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home obj = new Home();
            obj.Show();
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

        private void search_btn_Click(object sender, EventArgs e)
        {
            string query = string.Format(
                "select * from schedule_details where id like '%{0}'",
                search_box.Text
                );
            DataSet ds = kn.GetData(query);
            metroGrid1.DataSource = ds.Tables[0];
        }
    }
}
