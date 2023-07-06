using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL.Connections
{
    public class CommanMaster
    {
        string ConnectionString = "Data Source=DESKTOP-8GAARUG;Initial Catalog=Sample;Integrated Security=True";
        SqlConnection con;

        public void OpenConection()
        {
            con = new SqlConnection(ConnectionString);
            con.Open();
        }


        public void CloseConnection()
        {
            con.Close();
        }


        public void ExecuteQueries(string Query_)
        {
            OpenConection();
            SqlCommand cmd = new SqlCommand(Query_, con);
            cmd.ExecuteNonQuery();
            CloseConnection();
        }


        public SqlDataReader DataReader(string Query_)
        {
            OpenConection();
            SqlCommand cmd = new SqlCommand(Query_, con);
            SqlDataReader dr = cmd.ExecuteReader();
            CloseConnection();
            return dr;

        }


        public DataTable GetRecordSet(string Query_)
        {
            OpenConection();
            SqlDataAdapter dr = new SqlDataAdapter(Query_, ConnectionString);
            DataSet ds = new DataSet();
            dr.Fill(ds);
            DataTable dataum = ds.Tables[0];
            CloseConnection();
            return dataum;

        }
    }
}
