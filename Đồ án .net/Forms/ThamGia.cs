using MetroFramework.Forms;
using System;
using System.Data;
using System.Windows.Forms;
using Đồ_án.net.Functions;
using Đồ_án.net.Properties;

namespace Đồ_án.net.Forms
{
    public partial class ThamGia : MetroForm
    {
        Ketnoi kn = new Ketnoi();
        int index_pos = 0;
        public ThamGia()
        {
            InitializeComponent();
            this.StyleManager = metroStyleManager1;
            this.StyleManager.Theme = Settings.Default.Theme;
            this.StyleManager.Style = Settings.Default.Style;
            metroStyleExtender1.StyleManager.Theme = StyleManager.Theme;
        }
        public void getthamgia()
        {
            string query = string.Format(
                "select * from [dbo].[attendence_detail]"
                );
            DataSet ds = kn.GetData(query);
            metroGrid1.DataSource = ds.Tables[0];
        }
        private void metroLink1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home obj = new Home();
            obj.Show();
        }

        private void ThamGia_Load(object sender, EventArgs e)
        {
            metroTile2.Text = DateTime.Now.ToLongDateString();
            date_box.Text = DateTime.Now.Year.ToString() + " , " + DateTime.Now.ToString("MMMM");
            load_data(index_pos);
            getthamgia();
        }
        public void load_data(int index)
        {
            DataTable dt = kn.SQLtable("select std_id,s_name,class_id from [dbo].[enrollment_details]");
            DataRow dr = dt.Rows[index];
            try
            {
                std_id.Text = dr["std_id"].ToString();
                std_name.Text = dr["s_name"].ToString();
                std_class.Text = dr["class_id"].ToString();
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi " + e);
            }
        }

        private void next_btn_Click(object sender, EventArgs e)
        {
            DataSet ds = kn.GetData("select std_id,s_name,class_id from [dbo].[enrollment_details]");
            std_id.Text = " ";
            std_name.Text = " ";
            std_class.Text = " ";
            index_pos++;
            if ( index_pos < ds.Tables[0].Rows.Count)
            {
                load_data(index_pos);
                no_data_lb.Visible = false;
                std_id.Visible = true;
                std_name.Visible = true;
                std_class.Visible = true;
            }
            else
            {
                no_data_lb.Visible = true;
                std_id.Visible = false;
                std_name.Visible = false;
                std_class.Visible = false;
                index_pos = ds.Tables[0].Rows.Count - 1;
            }
        }

        private void prev_btn_Click(object sender, EventArgs e)
        {
            DataSet ds = kn.GetData("select std_id,s_name,class_id from [dbo].[enrollment_details]");
            std_id.Text = "";
            std_name.Text = "";
            std_class.Text = "";

            index_pos--;
            if (index_pos == -1)
            {
                index_pos = 0;
                no_data_lb.Visible = true;
            }
            else
            {
                if (index_pos >= 0)
                {
                    load_data(index_pos);
                    no_data_lb.Visible = false;
                    std_id.Visible = true;
                    std_name.Visible = true;
                    std_class.Visible = true;
                }
                else
                {
                    no_data_lb.Visible = true;
                    std_id.Visible = false;
                    std_name.Visible = false;
                    std_class.Visible = false;
                }
            }
        }

        private void Done_btn_Click(object sender, EventArgs e)
        {
            string remarks = " ";
            if (prst_radio_btn.Checked)
            {
                remarks = "Có mặt";
            }
            if (abs_radio_btn.Checked)
            {
                remarks = "Vắng mặt";
            }
            if (leave_radio_btn.Checked)
            {
                remarks = "Nghỉ phép";
            }
            if (late_radio_btn.Checked)
            {
                remarks = "Đi muộn";
            }

            string id = std_id.Text;
            string name = std_name.Text;
            string s_class = std_class.Text;
            string date = DateTime.Now.ToString("dddd, dd MMMM yyyy");

            DataSet ds = kn.GetData("select count(*) from [dbo].[attendence_detail] where date = '" + date + "' and std_id = '" + id + "'");
            int cont = ds.Tables[0].Rows.Count;
            if (cont > 1)
            {
                string q = "update [dbo].[attendence_detail] set remarks='" + remarks + "' where date='" + date + "'and std_id='" + id + "'";
                try
                {
                    kn.Thucthi(q);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);
                }
            }
            else
            {
                string q = "insert into [dbo].[attendence_detail](std_id,name,class_id,date,remarks) values ('" + id + "','" + name + "','" + s_class + "','" + date + "','" + remarks + "')";
                try
                {
                    kn.Thucthi(q);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);
                }
            }

            metroGrid1.DataSource = kn.SQLtable("select * from  [dbo].[attendence_detail]");
            metroGrid1.Refresh();
        }

        private void refresh_link_Click(object sender, EventArgs e)
        {
            metroGrid1.DataSource = kn.SQLtable("select * from  [dbo].[attendence_detail]");
            metroGrid1.Refresh();
        }

        private void metroLink1_MouseLeave(object sender, EventArgs e)
        {
            this.metroLink1.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.home_icon_grey));
            this.metroLink1.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void metroLink1_MouseMove(object sender, MouseEventArgs e)
        {
            this.metroLink1.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.home_icon_black));
            this.metroLink1.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void refresh_link_MouseLeave(object sender, EventArgs e)
        {
            this.refresh_link.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.refresh_grey));
            this.refresh_link.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void refresh_link_MouseMove(object sender, MouseEventArgs e)
        {
            this.refresh_link.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.refresh2));
            this.refresh_link.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void no_data_lb_VisibleChanged(object sender, EventArgs e)
        {
   
        }
    }
}
