using MetroFramework.Forms;
using System;
using System.Data;
using System.Windows.Forms;
using Đồ_án.net.Functions;
using Đồ_án.net.Properties;

namespace Đồ_án.net.Forms
{
    public partial class Hoadon : MetroForm
    {
        Ketnoi kn = new Ketnoi();
        int index_pos = 0;
        public Hoadon()
        {
            InitializeComponent();
            this.StyleManager = metroStyleManager1;
            this.StyleManager.Theme = Settings.Default.Theme;
            this.StyleManager.Style = Settings.Default.Style;
            metroStyleExtender1.StyleManager.Theme = StyleManager.Theme;
        }
        public void gethoadon()
        {
            string query = string.Format(
                "select * from [dbo].[billing_details]"
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

        private void refresh_link_Click(object sender, EventArgs e)
        {
            metroGrid1.DataSource = kn.SQLtable("select * from  [dbo].[billing_details]");
            metroGrid1.Refresh();
        }

        private void Hoadon_Load(object sender, EventArgs e)
        {
            metroTile2.Text = DateTime.Now.ToLongDateString();
            date_box.Text = DateTime.Now.Year.ToString() + " , " + DateTime.Now.ToString("MMMM");
            load_data(index_pos);
            gethoadon();
            metroGrid1.ScrollBars = ScrollBars.Both;
            metroGrid1.AutoSize = false;
        }
        public void load_data(int index)
        {
            DataTable dt = kn.SQLtable("select std_id,s_name,class_id,tution_fees,other_charges,total_amount from [dbo].[enrollment_details]");
            DataRow dr = dt.Rows[index];
            try
            {
                s_id.Text = dr["std_id"].ToString();
                s_name.Text = dr["s_name"].ToString();
                s_class.Text = dr["class_id"].ToString();
                s_fees.Text = dr["tution_fees"].ToString();
                s_other.Text = dr["other_charges"].ToString();
                s_total.Text = dr["total_amount"].ToString();
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi " + e);
            }
        }


        private void prev_btn_Click(object sender, EventArgs e)
        {
            DataSet ds = kn.GetData("select std_id,s_name,class_id,tution_fees,other_charges,total_amount from [dbo].[enrollment_details]");
            s_id.Text = "";
            s_name.Text = "";
            s_class.Text = "";
            s_fees.Text = "";
            s_other.Text = "";
            s_total.Text = "";

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
                    s_id.Visible = true;
                    s_name.Visible = true;
                    s_class.Visible = true;
                }
                else
                {
                    no_data_lb.Visible = true;
                    s_id.Visible = false;
                    s_name.Visible = false;
                    s_class.Visible = false;
                }
            }
        }

        private void done_btn_Click(object sender, EventArgs e)
        {
            string status = " ";
            if (paid_radio.Checked)
            {
                status = "Đã trả";
            }
            if (unpaid_radio.Checked)
            {
                status = "Chưa trả";
            }
            if (latepaid_radio.Checked)
            {
                status = "Trả muộn";
            }

            string std_id = s_id.Text;
            string name = s_name.Text;
            string std_class = s_class.Text;
            string tution = s_fees.Text;
            string other = s_other.Text;
            string total = s_total.Text;
            string date = DateTime.Now.ToString("dd/MMMM/yyyy");

            DataSet ds = kn.GetData("select count(*) from [dbo].[billing_details] where date = '" + date + "' and std_id='" + std_id + "'");
            int cont = ds.Tables[0].Rows.Count;
            if (cont > 1)
            {
                string q = "update [dbo].[billing_details] set status = '" + status + "' where date ='" + date + "' and std_id ='" + std_id + "'";
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
                string q = "insert into [dbo].[billing_details] (std_id,name,class_id,date,tution_fees,other_charges,total_amount,status) values ('" + std_id + "','" + name + "','" + std_class + "','" + date + "','" + tution + "','" + other + "','" + total + "','" + status + "')";
                try
                {
                    kn.Thucthi(q);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);
                }
            }

            metroGrid1.DataSource = kn.SQLtable("select * from [dbo].[billing_details]");
            metroGrid1.Refresh();
        }

        private void next_btn_Click(object sender, EventArgs e)
        {
            DataSet ds = kn.GetData("select std_id,s_name,class_id,tution_fees,other_charges,total_amount from [dbo].[enrollment_details]");
            s_id.Text = "";
            s_name.Text = "";
            s_class.Text = "";
            s_fees.Text = "";
            s_other.Text = "";
            s_total.Text = "";
            index_pos++;
            if (index_pos < ds.Tables[0].Rows.Count)
            {
                load_data(index_pos);
                no_data_lb.Visible = false;
                s_id.Visible = true;
                s_name.Visible = true;
                s_class.Visible = true;
            }
            else
            {
                no_data_lb.Visible = true;
                s_id.Visible = false;
                s_name.Visible = false;
                s_class.Visible = false;
                index_pos = ds.Tables[0].Rows.Count - 1;
            }
        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

        private void del_btn_Click(object sender, EventArgs e)
        {
        }
    }
}
