using System;
using System.Data;
using System.Windows.Forms;
using MetroFramework.Forms;
using Đồ_án.net.Functions;
using Đồ_án.net.Forms;
using Đồ_án.net.Properties;
using Đồ_án.net.Slide_Panel;

namespace Đồ_án.net.Forms
{
    public partial class Login : MetroForm
    {
        Ketnoi kn = new Ketnoi();
        public Login()
        {
            InitializeComponent();
            this.StyleManager = metroStyleManager1;
            this.StyleManager.Theme = Settings.Default.Theme;
            this.StyleManager.Style = Settings.Default.Style;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = string.Format(
                "select * from dbo.user_details where user_name = '{0}' and password = '{1}'",
                usertxt.Text,
                passtxt.Text
                );
            DataSet ds = kn.GetData(query);
            if (ds.Tables[0].Rows.Count == 1)
            {
                MetroFramework.MetroMessageBox.Show(this, "Đăng nhập thành công",Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                Settings.Default.displayname = usertxt.Text;
                this.Hide();
                Home obj1 = new Home();
                obj1.Show();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại");
            }
        }

        void _pnlone_Closed(object sender, EventArgs e)
        {
            metroLink1.Enabled = true;
            metroLink1.Visible = true;
            metroLink2.Visible = true;
            usertxt.Enabled = true;
            passtxt.Enabled = true;
            login_btn.Enabled = true;
            usertxt.Focus();
        }
        void _pnlone_Shown(object sender, EventArgs e)
        {
            metroLink1.Visible = false;
            metroLink2.Visible = false;
        }

        private void usertxt_TextChanged(object sender, EventArgs e)
        {
            if (usertxt.Text == "" || passtxt.Text == "" || usertxt.Text == "")
            {
                login_btn.Enabled = false;
            }
            else
            {
                login_btn.Enabled = true;
            }

            if (usertxt.Text == "")
            {
                user_empty.Visible = true;
            }
            else
            {
                user_empty.Visible = false;
            }
        }

        private void passtxt_TextChanged(object sender, EventArgs e)
        {
            if (passtxt.Text == "" || usertxt.Text == "")
            {
                login_btn.Enabled = false;
            }
            else
            {
                login_btn.Enabled = true;
            }
            if (passtxt.Text == "")
            {
                pass_empty.Visible = true;
            }
            else
            {
                pass_empty.Visible = false;
            }
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            panel _pnlone = new panel(this);
            _pnlone.Closed += _pnlone_Closed;
            _pnlone.Shown += _pnlone_Shown;
            _pnlone.swipe(true);
            usertxt.Enabled = false;
            passtxt.Enabled = false;
            login_btn.Enabled = false;
        }

        private void metroLink2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            usertxt.Focus();
            login_btn.Enabled = false;
        }

        private void metroLink2_MouseLeave(object sender, EventArgs e)
        {
            this.metroLink2.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.exit_white));
            this.metroLink2.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void metroLink2_MouseMove(object sender, MouseEventArgs e)
        {
            this.metroLink2.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.exit_black));
            this.metroLink2.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void metroLink1_MouseLeave(object sender, EventArgs e)
        {
            this.metroLink1.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.cogwheel_outline));
            this.metroLink1.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void metroLink1_MouseMove(object sender, MouseEventArgs e)
        {
            this.metroLink1.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.cogwheel_outline_black));
            this.metroLink1.BackgroundImageLayout = ImageLayout.Zoom;
        }
    }
}
