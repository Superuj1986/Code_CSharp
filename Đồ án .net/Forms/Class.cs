using MetroFramework.Forms;
using System;
using System.Data;
using System.Windows.Forms;
using Đồ_án.net.Functions;
using Đồ_án.net.Properties;

namespace Đồ_án.net.Forms
{
    public partial class Class : MetroForm
    {
        Ketnoi kn = new Ketnoi();
        public Class()
        {
            InitializeComponent();
            this.StyleManager = metroStyleManager1;
            this.StyleManager.Theme = Settings.Default.Theme;
            this.StyleManager.Style = Settings.Default.Style;
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home obj = new Home();
            obj.Show();
        }
        public void getclass()
        {
            string query = string.Format(
                "select * from [dbo].[classes_details]"
                );
            DataSet ds = kn.GetData(query);
            metroGrid1.DataSource = ds.Tables[0];
        }

        private void Class_Load(object sender, EventArgs e)
        {
            metroTile3.Text = DateTime.Now.ToLongDateString();
            getclass();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            class_id.Text = " ";
            class_name.Text = " ";
            getclass();
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string query = string.Format(
                    "insert into [dbo].[classes_details] values ( '{0}', N'{1}' )",
                    class_id.Text,
                    class_name.Text
                    );
                if (kn.Thucthi(query) == true)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Thêm mới thành công", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    metroButton1.PerformClick();
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Thêm mới thất bại", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }catch(Exception E)
            {
                MetroFramework.MetroMessageBox.Show(this, "Lỗi" + E, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void fix_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string query = string.Format(
                    "update [dbo].[classes_details] set class_name = '{1}' where class_id = '{0}'",
                    class_id.Text,
                    class_name.Text
                    );
                if (kn.Thucthi(query) == true)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Sửa thành công", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    metroButton1.PerformClick();
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
            
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string query = string.Format(
                    "select * from [dbo].[classes_details] where class_id = '{0}'",
                    search_box.Text
                    );
                DataSet ds = kn.GetData(query);
                metroGrid1.DataSource = ds.Tables[0];
            }catch(Exception E)
            {
                MetroFramework.MetroMessageBox.Show(this, "Lỗi" + E, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void metroGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = e.RowIndex;
            if ( r >= 0)
            {
                class_id.Text = metroGrid1.Rows[r].Cells["class_id"].Value.ToString();
                class_name.Text = metroGrid1.Rows[r].Cells["class_name"].Value.ToString();
            }
        }

        private void del_btn_Click_1(object sender, EventArgs e)
        {
            if (class_id.Text == " ")
            {
                MessageBox.Show("Hãy chọn dòng dữ liệu ");
            }
            else 
            {
                if (MetroFramework.MetroMessageBox.Show(this, "Bạn có muốn xóa dữ liệu của " + class_id.Text + " không ?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    try
                    {
                        string query = string.Format(
                            "delete from classes_details where class_id = '{0}'",
                            class_id.Text
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
                    catch (Exception E)
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Lỗi" + E, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
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
