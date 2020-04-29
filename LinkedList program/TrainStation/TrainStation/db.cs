using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainStation
{
    class db
    {
        SqlConnection con;
        SqlCommand com;
        SqlDataAdapter sda;

        public db()
        {
            con = new SqlConnection("Data Source = DESKTOP-4L5BBSM\\SQLEXPRESS; Initial Catalog = TrainStation; Integrated Security = True");
        }
        public int sdu(string sql)
        {
            con.Open();
            com = new SqlCommand(sql, con);
            int ex = com.ExecuteNonQuery();
            con.Close();
            return ex;
        }
        public DataTable search(string sqlq)
        {
            con.Open();
            sda = new SqlDataAdapter(sqlq, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            return dt;
        }
        public SqlDataReader sear(string mysql)
        {
            DataTable dt = new DataTable();
            con.Open();
            SqlDataReader sdr = null;
            SqlCommand myCommand = new SqlCommand(mysql, con);

            sdr = myCommand.ExecuteReader();
            con.Close();
            //
            return sdr;

        }
        public void onclose()
        { con.Close(); }
    }
}
