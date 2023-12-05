using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Đồ_án.net.Properties;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Đồ_án.net.Functions
{
    class Ketnoi
    {
        
        public static SqlConnection con = new SqlConnection();
        public static string cons
        {
            get
            {
                return "Data Source=" + Settings.Default.Server + ";Initial Catalog=" + Settings.Default.Database + ";User ID=" + Settings.Default.Username + ";Password=" + Settings.Default.Password +";";
            }
        }
        public Ketnoi()
        {
            con = new SqlConnection(cons);
        }
        public static bool TestConnection()
        {
            bool b = true;
            using (SqlConnection con = new SqlConnection(cons))
            {
                try
                {
                    con.Open();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    b = false;
                }
            }
            return b;
        }
        public DataSet GetData(string query)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.Fill(ds);
            return ds;
        }
        public DataTable SQLtable(string query)
        {
            SqlConnection con = null;
            SqlCommand cmd = null;
            SqlDataReader reader = null;

            DataTable dt = new DataTable();

            try
            {
                con = new SqlConnection(cons);
                if (con.State == ConnectionState.Closed)
                    con.Open();
                try
                {
                    cmd = new SqlCommand(query, con);
                    reader = cmd.ExecuteReader();

                    dt.Load(reader);
                    con.Close();
                    con = null;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message, "Data set Error!!!",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dt = null;
                    reader = null;
                    con.Close();
                    con = null;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Connection Error!!!",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dt = null;
                reader = null;
                con.Close();
                con = null;
            }

            return dt;
        }
        public bool Thucthi(string query)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                int r = cmd.ExecuteNonQuery();
                con.Close();
                return r > 0;
            }
            catch (Exception e)
            {
                Console.WriteLine("Lỗi" + e);
                return false;
            }
        }

    }
}
