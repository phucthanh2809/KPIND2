using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanMemQuanLyKPI
{
    public class myFunctions
    {
        public static string _macty;
        public static string _madvi;
        public static string _src;
        public static string _us;
        public static string _pw;
        public static string _db;
        static SqlConnection con = new SqlConnection();



        public static void taoketnoi()
        {
            string connectionString = "data source=192.168.50.108,1433;initial catalog=QuanLyKPI;user id=sa;password=123;";

            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder(connectionString);

            // Lưu các thông tin vào các biến tương ứng
            _src = builder.DataSource;
            _db = builder.InitialCatalog;
            _us = builder.UserID;
            _pw = builder.Password;

            try
            {
                if (con.State != ConnectionState.Open)
                {
                    con.ConnectionString = connectionString;
                    con.Open();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                throw;
            }
        }


        public static void dongketnoi()
        {
            con.Close();
        }

        public static DataTable laydulieu(string qr)
        {
            taoketnoi();
            DataTable tb = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(qr, con);
            da.Fill(tb);
            dongketnoi();
            return tb;
        }

        // Hàm lấy dữ liệu bằng Dataset
        public static DataSet getDataSet(string query)
        {
            taoketnoi();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder();
            DataSet ds = new DataSet();
            da.Fill(ds);
            // moi them
            dongketnoi();
            return ds;
        }

        //Ham insert, update du lieu
        public static void execQuery(string query)
        {
            taoketnoi();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            dongketnoi();
        }

        public static string laydulieuString(string qr)
        {
            taoketnoi();
            string myname = "";
            DataTable tb = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(qr, con);
            da.Fill(tb);
            for (int i = 0; i < tb.Rows.Count - 1; i++)
            {
                myname = tb.Rows[i][0].ToString();
            }
            dongketnoi();
            return myname;
        }
    }
}
