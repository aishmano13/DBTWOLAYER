using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace DBTWOLAYER
{
    public class ConClass
    {
        SqlConnection Con;
        SqlCommand cmd;

        public ConClass()
        {
        Con = new SqlConnection(@"server=HP\SQLEXPRESS01;database=DBTWOLAYER;Integrated security=true");
        }

        public int fn_Nonquery(string sqlquery)//insert,delete,update
        {
            if (Con.State == ConnectionState.Open)
            {
                Con.Close();
            }
            cmd = new SqlCommand(sqlquery, Con);
            Con.Open();
            int i = cmd.ExecuteNonQuery();
            Con.Close();
            return i;
        }
        public string fn_Scaler(string sqlquery)
        {
            if (Con.State == ConnectionState.Open)
            {
                Con.Close();
            }
            cmd = new SqlCommand(sqlquery, Con);
            Con.Open();
            string s = cmd.ExecuteScalar().ToString();
            Con.Close();
            return s;
        }
        public SqlDataReader fn_Datareader(string sqlquery)
        {
            if(Con.State==ConnectionState.Open)
            {
                Con.Close();
            }
            cmd = new SqlCommand(sqlquery, Con);
            Con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }
        public DataSet fn_Dataset(string sqlquery)
        {
            if (Con.State == ConnectionState.Open)
            {
                Con.Close();
            }
            SqlDataAdapter da = new SqlDataAdapter(sqlquery, Con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
    }
}
