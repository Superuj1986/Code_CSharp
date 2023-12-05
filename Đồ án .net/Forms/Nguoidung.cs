using MetroFramework.Forms;
using System;
using System.Data;
using System.Windows.Forms;
using Đồ_án.net.Functions;
using Đồ_án.net.Properties;
namespace Đồ_án.net.Forms
{
    public partial class Nguoidung : MetroForm
    {
        Ketnoi kn = new Ketnoi();
        public Nguoidung()
        {
            InitializeComponent();
            this.StyleManager = metroStyleManager1;
            this.StyleManager.Theme = Settings.Default.Theme;
            this.StyleManager.Style = Settings.Default.Style;
        }
        public void getdata()
        {
            string query = string.Format(
                " select * from [dbo].[user_details]"
                );
            DataSet ds = kn.GetData(query);
            metroGrid1.DataSource = ds.Tables[0];
        }
        private void metroLink1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home obj1 = new Home();
            obj1.Show();
        }
        public void refresh()
        {
            user_id.Text = " ";
            user_name.Text = " ";
            user_acc.Text = " ";
            user_pass.Text = " ";
            user_type.SelectedValue = " ";
        }
        private void Nguoidung_Load(object sender, EventArgs e)
        {
            getdata();
        }

        private void re_btn_Click(object sender, EventArgs e)
        {
            refresh();
            getdata();
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            string query = string.Format(
                "insert into [dbo].[user_details] values ('{0}','{1}','{2}','{3}','{4}')",
                user_id.Text ,
                user_name.Text,
                user_acc.Text,
                user_pass.Text,
                (string)user_type.Text
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

        private void fix_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string query = string.Format(
                    "update [dbo].[user_details] set name = N'{1}',user_name ='{2}',password = '{3}',type = '{4}' where user_id = '{0}'",
                    user_id.Text,
                    user_name.Text,
                    user_acc.Text,
                    user_pass.Text,
                    (string)user_type.Text
                    );
                if (kn.Thucthi(query) == true)
                {
                    MetroFramework.MetroMessageBox.Show(this,"Sửa thành công",Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    re_btn.PerformClick();
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Sửa thất bại", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception E)
            {
                MessageBox.Show("Lỗi" + E, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void del_btn_Click(object sender, EventArgs e)
        {
            if (user_id.Text == " ")
            {
                MessageBox.Show("Hãy chọn dòng dữ liệu ");
            }
            else
            {
                if (MetroFramework.MetroMessageBox.Show(this, "Bạn có muốn xóa dữ liệu của " + user_id.Text + " không ?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    try
                    {
                        string query = string.Format(
                            "delete from [dbo].[user_details] where user_id = '{0}'",
                            user_id.Text
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

        private void search_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string query = string.Format(
                    "select * from [dbo].[user_details] where user_id like '%{0}%'",
                    search_box.Text
                    );
                DataSet ds = kn.GetData(query);
                metroGrid1.DataSource = ds.Tables[0];
            }
            catch (Exception E)
            {
                MetroFramework.MetroMessageBox.Show(this, "Lỗi" + E, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void metroGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = e.RowIndex;
            if ( r >= 0)
            {
                user_id.Text = metroGrid1.Rows[r].Cells["user_id"].Value.ToString();
                user_name.Text = metroGrid1.Rows[r].Cells["name"].Value.ToString();
                user_acc.Text = metroGrid1.Rows[r].Cells["user_name"].Value.ToString();
                user_pass.Text = metroGrid1.Rows[r].Cells["password"].Value.ToString();
                user_type.SelectedItem = metroGrid1.Rows[r].Cells["type"].Value.ToString();
            }
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
