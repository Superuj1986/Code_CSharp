using System;
using System.Drawing;
using System.Windows.Forms;
using MetroFramework.Forms;
using Transitions;
using MetroFramework.Controls;
using MetroFramework;
using Đồ_án.net.Properties;
using Đồ_án.net.Functions;

namespace Đồ_án.net.Slide_Panel
{
    public partial class panel : MetroUserControl
    {
        public event EventHandler SettingClosed;

        public panel()
        {
            InitializeComponent();
            for (int i = 3; i < 13; i++)
            {
                MetroTile tile = new MetroTile();
                tile.Size = new Size(30, 30);
                tile.Tag = i;
                tile.Style = (MetroColorStyle)i;
                flowLayoutPanel1.Controls.Add(tile);
            }
            this.StyleManager = metroStyleManager1;
            this.StyleManager.Theme = Settings.Default.Theme;
            this.StyleManager.Style = Settings.Default.Style;

            servername_box.Text = Settings.Default.Server;
            dbname_box.Text = Settings.Default.Database;
            user_box.Text = Settings.Default.Username;
            pass_box.Text = Settings.Default.Password;
        }


        Form _owner = null;
        bool _loaded = false;

        #region Event
        public event EventHandler Closed;
        public event EventHandler Shown;

        protected virtual void closed(EventArgs e)
        {
            EventHandler handler = Closed;
            if (handler != null) handler(this, e);
        }
        protected virtual void shown(EventArgs e)
        {
            EventHandler handler = Shown;
            if (handler != null) handler(this, e);

            servername_box.Focus();
        }
        #endregion

        public panel(Form owner)
            :this()
        {
            this.Visible = false;
            _owner = owner;
            owner.Controls.Add(this);
            owner.Resize += owner_Resize;
            this.Click += pnlSlider_Click;

            ResizeForm();
        }
        void pnlSlider_Click(object sender, EventArgs e)
        {
            swipe(false);
        }
        void tile_Click(object sender, EventArgs e)
        {
            ((MetroForm)this.Parent).StyleManager.Style = (MetroColorStyle)((MetroTile)sender).Tag;
            SaveSettings();
        }
        void owner_Resize(object sender, EventArgs e)
        {
            ResizeForm();
        }
        private void ResizeForm()
        {
            this.Width = _owner.Width;
            this.Height = _owner.Height - 77;
            this.Location = new Point(_loaded ? 0 : _owner.Width, 50);
        }

        public void swipe(bool show = true)
        {

            this.Visible = true;
            Transition _transasition = new Transitions.Transition(new TransitionType_EaseInEaseOut(500));
            _transasition.add(this, "Left", show ? 0 : this.Width);
            _transasition.run();

            while (this.Left != (show ? 0 : this.Width))
            {
                Application.DoEvents();
            }

            if (!show)
            {
                closed(new EventArgs());
                _owner.Resize -= owner_Resize;
                _owner.Controls.Remove(this);
                this.Dispose();
            }
            else
            {
                _loaded = true;
                ResizeForm();
                shown(new EventArgs());
            }
        }


        void SaveSettings()
        {
            Settings.Default.Theme = ((MetroForm)this.Parent).StyleManager.Theme;
            Settings.Default.Style = ((MetroForm)this.Parent).StyleManager.Style;
            Settings.Default.Server = servername_box.Text;
            Settings.Default.Database = dbname_box.Text;
            Settings.Default.Username = user_box.Text;
            Settings.Default.Password = pass_box.Text;

            Settings.Default.Save();
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            metroPanel1.Visible = false;
            EventHandler handler = SettingClosed;
            if (handler != null) handler(this, e);
        }

        private void metroRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (metroRadioButton1.Checked)
            {
                ((MetroForm)this.Parent).StyleManager.Theme = MetroThemeStyle.Dark;
            }
            SaveSettings();
        }

        private void metroRadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (metroRadioButton2.Checked)
            {
                ((MetroForm)this.Parent).StyleManager.Theme = MetroThemeStyle.Light;
            }
            SaveSettings();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            SaveSettings();
            if (Ketnoi.TestConnection())
            {
                MetroFramework.MetroMessageBox.Show(_owner, "Connection Succefully Established", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}
