using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Đồ_án.net.Functions;
using MetroFramework.Forms;

namespace Đồ_án.net.Forms
{
    public partial class ThongKe : MetroForm
    {
        Ketnoi kn = new Ketnoi();
        public ThongKe()
        {
            InitializeComponent();
        }
        void get_year()
        {
            try
            {
                string query = "SELECT DISTINCT YEAR(DATE) AS NAMXUAT FROM billing_details";
                DataSet ds = kn.GetData(query);
                cbbox_year.DataSource = ds.Tables[0];
                cbbox_year.DisplayMember = "Nam";
                cbbox_year.ValueMember = "NAMXUAT";
                cbbox_year.Text = "2023";
            }
            catch (Exception e)
            {

            }
        }

        private void ThongKe_Load(object sender, EventArgs e)
        {
            get_year();
        }

        private void cbbox_year_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                chart1.Series.Clear();
                string query = "select MONTH(date) as Thang, SUM(total_amount) as Tong from billing_details \r\n" +
                    $"where YEAR(date) = {cbbox_year.Text} and status like '%Đã trả%'" +
                    "group by MONTH(date)";
                DataSet ds = kn.GetData(query);

                Series column = new Series("Tong_Column");
                column.ChartType = SeriesChartType.Column;
                chart1.Series.Add(column);
                column["PointWidth"] = "0.5";

                Series line = new Series("Tong_Line");
                line.ChartType = SeriesChartType.Line;
                chart1.Series.Add(line);
                line.BorderWidth = 2;

                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    DataPoint pointcol = new DataPoint();
                    pointcol.SetValueXY(row["Thang"], row["Tong"]);
                    pointcol.LabelForeColor = Color.Red;
                    pointcol.Color = Color.FromArgb(73, 134, 255);
                    column.Points.Add(pointcol);

                    DataPoint pointline = new DataPoint();
                    pointline.SetValueXY(row["Thang"], row["Tong"]);
                    pointline.Label = row["Tong"].ToString();
                    pointline.LabelForeColor = Color.Red;
                    pointline.Color = Color.FromArgb(255, 0, 0);
                    line.Points.Add(pointline);
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home obj = new Home();
            obj.Show();
        }
    }
}
