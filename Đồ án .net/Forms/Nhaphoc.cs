using MetroFramework.Forms;
using System;
using System.Data;
using System.Windows.Forms;
using Đồ_án.net.Functions;
using Đồ_án.net.Properties;
using System.Globalization;

namespace Đồ_án.net.Forms
{
    public partial class Nhaphoc : MetroForm
    {
        Ketnoi kn = new Ketnoi();
        public int x;
        public int y;
        public Nhaphoc()
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
            class_cbbox.DataSource = ds.Tables[0];
            class_cbbox.ValueMember = "class_id";
        }
        private void Nhaphoc_Load(object sender, EventArgs e)
        {
            getclass();
            metroTile2.Text = DateTime.Now.ToLongDateString();
            sname_box.Focus();
            done_btn.Enabled = false;
        }

        private void sname_box_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(sname_box.Text)) 
            { 
                sname_empty_lb.Visible = true; empty_lb.Visible = true; 
            } else { 
                sname_empty_lb.Visible = false; empty_lb.Visible = false; 
            }
            if (sname_box.Text == "" || age_box.Text == "" || city_box.Text == "" || pname_box.Text == "" || occu_box.Text == "" || address_box.Text == "" || cellphone_box.Text == "" || receipt_box.Text == "" || id_box.Text == "")
            { 
                done_btn.Enabled = false; 
            } else { 
                done_btn.Enabled = true; 
            }
        }

        private void age_box_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(age_box.Text))
            {
                sage_empty_lb.Visible = true; empty_lb.Visible = true;
            }
            else
            {
                sage_empty_lb.Visible = false; empty_lb.Visible = false;
            }
            if (sname_box.Text == "" || age_box.Text == "" || city_box.Text == "" || pname_box.Text == "" || occu_box.Text == "" || address_box.Text == "" || cellphone_box.Text == "" || receipt_box.Text == "" || id_box.Text == "")
            {
                done_btn.Enabled = false;
            }
            else
            {
                done_btn.Enabled = true;
            }
        }

        private void city_box_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(city_box.Text))
            {
                scity_empty_lb.Visible = true; empty_lb.Visible = true;
            }
            else
            {
                scity_empty_lb.Visible = false; empty_lb.Visible = false;
            }
            if (sname_box.Text == "" || age_box.Text == "" || city_box.Text == "" || pname_box.Text == "" || occu_box.Text == "" || address_box.Text == "" || cellphone_box.Text == "" || receipt_box.Text == "" || id_box.Text == "")
            {
                done_btn.Enabled = false;
            }
            else
            {
                done_btn.Enabled = true;
            }
        }

        private void pname_box_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(pname_box.Text))
            {
                pname_empty.Visible = true; empty_lb.Visible = true;
            }
            else
            {
                pname_empty.Visible = false; empty_lb.Visible = false;
            }
            if (sname_box.Text == "" || age_box.Text == "" || city_box.Text == "" || pname_box.Text == "" || occu_box.Text == "" || address_box.Text == "" || cellphone_box.Text == "" || receipt_box.Text == "" || id_box.Text == "")
            {
                done_btn.Enabled = false;
            }
            else
            {
                done_btn.Enabled = true;
            }
        }

        private void occu_box_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(occu_box.Text))
            {
                pocc_empty.Visible = true; empty_lb.Visible = true;
            }
            else
            {
                pocc_empty.Visible = false; empty_lb.Visible = false;
            }
            if (sname_box.Text == "" || age_box.Text == "" || city_box.Text == "" || pname_box.Text == "" || occu_box.Text == "" || address_box.Text == "" || cellphone_box.Text == "" || receipt_box.Text == "" || id_box.Text == "")
            {
                done_btn.Enabled = false;
            }
            else
            {
                done_btn.Enabled = true;
            }
        }

        private void address_box_TextChanged(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(address_box.Text)) 
            { 
                paddress_empty.Visible = true; empty_lb.Visible = true; 
            } else 
            {
                paddress_empty.Visible = false; empty_lb.Visible = false; 
            }
            if (sname_box.Text == "" || age_box.Text == "" || city_box.Text == "" || pname_box.Text == "" || occu_box.Text == "" || address_box.Text == "" || cellphone_box.Text == "" || receipt_box.Text == "" || id_box.Text == "")
            {
                done_btn.Enabled = false;
            }
            else
            {
                done_btn.Enabled = true;
            }
        }

        private void cellphone_box_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cellphone_box.Text))
            {
                SDT_empty.Visible = true; empty_lb.Visible = true;
            }
            else
            {
                SDT_empty.Visible = false; empty_lb.Visible = false;
            }
            if (sname_box.Text == "" || age_box.Text == "" || city_box.Text == "" || pname_box.Text == "" || occu_box.Text == "" || address_box.Text == "" || cellphone_box.Text == "" || receipt_box.Text == "" || id_box.Text == "")
            {
                done_btn.Enabled = false;
            }
            else
            {
                done_btn.Enabled = true;
            }
        }

        private void id_box_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(id_box.Text))
            {
                id_empty.Visible = true; empty_lb.Visible = true;
            }
            else
            {
                id_empty.Visible = false; empty_lb.Visible = false;
            }
            if (sname_box.Text == "" || age_box.Text == "" || city_box.Text == "" || pname_box.Text == "" || occu_box.Text == "" || address_box.Text == "" || cellphone_box.Text == "" || receipt_box.Text == "" || id_box.Text == "")
            {
                done_btn.Enabled = false;
            }
            else
            {
                done_btn.Enabled = true;
            }
        }

        private void class_cbbox_TextChanged(object sender, EventArgs e)
        {
            switch (class_cbbox.SelectedValue.ToString())
            {
                case "PTTK":
                    tuition_box.Text = "1500";
                    other_box.Text = "400";
                    break;
                case "LTHT":
                    tuition_box.Text = "1500";
                    other_box.Text = "700";
                    break;
                case "WNC":
                    tuition_box.Text = "2000";
                    other_box.Text = "700";
                    break;
                case "CNPM":
                    tuition_box.Text = "2500";
                    other_box.Text = "700";
                    break;
                case "AI":
                    tuition_box.Text = "2500";
                    other_box.Text = "800";
                    break;
                case "RN":
                    tuition_box.Text = "3000";
                    other_box.Text = "800";
                    break;
                default:
                    tuition_box.Text = "0";
                    other_box.Text = "0";
                    break;
            }
            x = Int32.Parse(tuition_box.Text, NumberStyles.AllowThousands);
            y = Int32.Parse(other_box.Text, NumberStyles.AllowThousands);
            total_box.Text = string.Format("{0:n0}", x + y);
        }

        private void receipt_box_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(receipt_box.Text))
            {
                receipt_empty.Visible = true;
                empty_lb.Visible = true;
            }
            else
            {
                receipt_empty.Visible = false;
                empty_lb.Visible = false;
            }
            if (sname_box.Text == "" || age_box.Text == "" || city_box.Text == "" || pname_box.Text == "" || occu_box.Text == "" || address_box.Text == "" || cellphone_box.Text == "" || receipt_box.Text == "" || id_box.Text == "")
            {
                done_btn.Enabled = false;
            }
            else
            {
                done_btn.Enabled = true;
            }
        }

        private void done_btn_Click(object sender, EventArgs e)
        {

            string q = string.Format(
                "insert into enrollment_details (s_name, birthdate , age , gender , birth_city ,birth_province , birth_region , p_name ,occupation , address ,cell_phone , std_id , class_id , tution_fees , other_charges , discount , total_amount , receipt_number) " +
                "values ( N'{0}', '{1}','{2}',N'{3}',N'{4}',N'{5}',N'{6}',N'{7}',N'{8}',N'{9}','{10}','{11}',N'{12}','{13}','{14}','{15}','{16}','{17}')", 
                sname_box.Text,
                birthdate_box.Value,
                age_box.Text,
                (string)gender_cbbox.Text,
                city_box.Text,
                province_box.Text,
                region_box.Text,
                pname_box.Text,
                occu_box.Text,
                address_box.Text,
                cellphone_box.Text,
                id_box.Text,
                (string)class_cbbox.Text,
                tuition_box.Text,
                other_box.Text,
                discount_box.Text,
                total_box.Text,
                receipt_box.Text
                );
            if (kn.Thucthi(q) == true)
            {
                MetroFramework.MetroMessageBox.Show(this, "Đã lưu dữ liệu!!!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);

                sname_box.Text = "";
                birthdate_box.Text = "";
                age_box.Text = "";
                gender_cbbox.Text = "";
                city_box.Text = "";
                province_box.Text = "";
                region_box.Text = "";
                pname_box.Text = "";
                occu_box.Text = "";
                address_box.Text = "";
                cellphone_box.Text = "";
                id_box.Text = "";
                class_cbbox.Text = "";
                tuition_box.Text = "";
                other_box.Text = "";
                discount_box.Text = "";
                total_box.Text = "";
                receipt_box.Text = "";

                this.Hide();
                Hocvien obj1 = new Hocvien();
                obj1.Show();
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Dữ liệu chưa chính xác!!!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void discount_box_TextChanged(object sender, EventArgs e)
        {
            if (discount_box.Text == "")
            {
                total_box.Text = string.Format("{0:n0}", x + y);
            }
            else
            {
                try
                {
                    float d = Int32.Parse(discount_box.Text);
                    float a = d / 100 * (x + y);
                    float q = (x + y - (a));
                    total_box.Text = string.Format("{0:n0}", q);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);
                }
            }
        }

        private void clr_btn_Click(object sender, EventArgs e)
        {
            sname_box.Text = "";
            birthdate_box.Text = "";
            age_box.Text = "";
            gender_cbbox.Text = "";
            city_box.Text = "";
            province_box.Text = "";
            region_box.Text = "";
            pname_box.Text = "";
            occu_box.Text = "";
            address_box.Text = "";
            cellphone_box.Text = "";
            id_box.Text = "";
            class_cbbox.Text = "";
            tuition_box.Text = "";
            other_box.Text = "";
            discount_box.Text = "";
            total_box.Text = "";
            receipt_box.Text = "";
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home obj = new Home();
            obj.Show();
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

        private void age_box_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;

            }
        }

        private void cellphone_box_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;

            }
        }

        private void discount_box_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;

            }
        }

    }
}
