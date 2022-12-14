using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebCrudOperations
{
    public class DALC
    {
        SqlConnection con = new SqlConnection(Connection.GetConnect);
        public SqlDataAdapter GetData()
        {
            if (con.State != ConnectionState.Open)
                con.Open();

            SqlCommand cmd = new SqlCommand("select * from Grid", con);
            cmd.ExecuteNonQuery();
            SqlDataAdapter dr = new SqlDataAdapter(cmd);
            con.Close();

            return dr;
        }

        public void Update(string id, string CompanyName, string ContactName, string ContactTitle, string Adress, string City)
        {
            if (con.State != ConnectionState.Open) con.Open();

            var Id = int.Parse(id);
            SqlCommand cmd = new SqlCommand("update Grid set CompanyName='" + CompanyName + "',ContactName='" + ContactName + "',ContactTitle='" + ContactTitle + "',Adress='"+ Adress + "', City='" + City + "' where id='" + Id + "'", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void Delete(int id)
        {
            if (con.State != ConnectionState.Open) con.Open();

            SqlCommand cmd = new SqlCommand("Delete from Grid where id='" + id + "'", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}