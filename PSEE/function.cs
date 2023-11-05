using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSEE
{ 
    internal class function
    {
        protected SqlConnection GetSqlConnection() 
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = VIVEK\\SQLEXPRESS01; database = psee; integrated security =True";
            return con;
        }
        public DataSet getData(string query)
        {
            SqlConnection con = GetSqlConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = query;
            SqlDataAdapter da= new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        public void setData (string query)
        {
            SqlConnection con = GetSqlConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            con.Close();


            MessageBox.Show("Data Processed Successfully.", "Success", MessageBoxButtons.OK,MessageBoxIcon.Information);



        }
    }
}
