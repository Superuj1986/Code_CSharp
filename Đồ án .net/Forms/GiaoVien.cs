using MetroFramework.Forms;
using System;
using System.Data;
using System.Windows.Forms;
using Đồ_án.net.Functions;
using Đồ_án.net.Properties;

namespace Đồ_án.net.Forms
{
    public partial class GiaoVien : MetroForm
    {
        Ketnoi kn = new Ketnoi();
        public GiaoVien()
        {
            InitializeComponent();
            this.StyleManager = metroStyleManager1;
            this.StyleManager.Theme = Settings.Default.Theme;
            this.StyleManager.Style = Settings.Default.Style;
        }
        
        public void getclass()
        {
           string query = string.Format(
                "select * from [dbo].[classes_details]"
                );
            DataSet ds = kn.GetData(query);
            te_classunder.DataSource = ds.Tables[0];
            te_classunder.ValueMember = "class_id";
        }
        public void getdata()
        {
            string query = string.Format(
                "select * from teachers_details"
                );
            DataSet ds = kn.GetData(query);
            metroGrid1.DataSource = ds.Tables[0];
        }
        public void refresh()
        {
            te_id.Text = " ";
            te_name.Text = " ";
            te_age.Text = " ";
            te_qua.Text = " ";
            te_sub.Text = " ";
            te_sa.Text = " ";
            te_sdt.Text = " ";
            te_classunder.SelectedValue = " ";
        }
        private void GiaoVien_Load(object sender, EventArgs e)
        {
            metroTile3.Text = DateTime.Now.ToLongDateString();
            getdata();
            getclass();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            refresh();
            getdata();
        }

        private void metroGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = e.RowIndex;
            if ( r >= 0 )
            {
                te_id.Text = metroGrid1.Rows[r].Cells["teacher_id"].Value.ToString();
                te_name.Text = metroGrid1.Rows[r].Cells["teacher_name"].Value.ToString();
                te_dob.Value = DateTime.Parse(metroGrid1.Rows[r].Cells["date_of_birth"].Value.ToString());
                te_age.Text = metroGrid1.Rows[r].Cells["age"].Value.ToString();
                te_qua.Text = metroGrid1.Rows[r].Cells["qualification"].Value.ToString();
                te_sub.Text = metroGrid1.Rows[r].Cells["subjects"].Value.ToString();
                te_sa.Text = metroGrid1.Rows[r].Cells["salary"].Value.ToString();
                te_sdt.Text = metroGrid1.Rows[r].Cells["phone_no"].Value.ToString();
                te_classunder.SelectedValue = metroGrid1.Rows[r].Cells["class_id"].Value.ToString();
            } 
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string query = string.Format(
                    "insert into [dbo].[teachers_details] values ( '{0}',N'{1}','{2}','{3}',N'{4}',N'{5}','{6}','{7}','{8}' )",
                    te_id.Text,
                    te_name.Text,
                    te_dob.Value,
                    te_age.Text,
                    te_qua.Text,
                    te_sub.Text,
                    te_sa.Text,
                    te_sdt.Text,
                    (string)te_classunder.Text
                    );
                if ( kn.Thucthi(query) == true)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Thêm mới thành công", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    metroButton1.PerformClick();
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

        private void search_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string query = string.Format(
                    "select * from [dbo].[teachers_details] where teacher_id like '%{0}%'",
                    search_box.Text
                    );
                DataSet ds = kn.GetData(query);
                metroGrid1.DataSource = ds.Tables[0];
            }
            catch ( Exception E)
            {
                MetroFramework.MetroMessageBox.Show(this, "Lỗi" + E, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void fix_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string query = string.Format(
                    "update [dbo].[teachers_details] set teacher_name = N'{1}',date_of_birth = '{2}',age = '{3}',qualification = '{4}',subjects = '{5}',salary = '{6}',phone_no = '{7}',class_id = '{8}' where teacher_id = '{0}'",
                    te_id.Text,
                    te_name.Text,
                    te_dob.Value,
                    te_age.Text,
                    te_qua.Text,
                    te_sub.Text,
                    te_sa.Text,
                    te_sdt.Text,
                    (string)te_classunder.Text
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
            catch ( Exception E)
            {
                MetroFramework.MetroMessageBox.Show(this, "Lỗi" + E, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void del_btn_Click(object sender, EventArgs e)
        {
            if (te_id.Text == " ")
            {
                MessageBox.Show("Hãy chọn dòng dữ liệu ");
            }
            else
            {
                if (MetroFramework.MetroMessageBox.Show(this, "Bạn có muốn xóa dữ liệu của " + te_id.Text + " không ?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    try
                    {
                        string query = string.Format(
                            "delete from [dbo].[teachers_details] where teacher_id = '{0}'",
                            te_id.Text
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

        private void metroLink1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home obj = new Home();
            obj.Show();
        }

        private void te_age_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;

            }
        }

        private void te_sdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;

            }
        }

    }
}
