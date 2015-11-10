using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WcfService.Model;

namespace WcfService.DAL
{
    public class LoginDb
    {
        private SqlCommand comm;

        public bool Login(Person p)
        {
            comm = new SqlCommand();
            comm.CommandText = "SELECT * FROM Person WHERE userName=(@userName) AND password=(@password)";
            comm.Parameters.AddWithValue("userName", p.UserName);
            comm.Parameters.AddWithValue("password", p.Password);

            comm.Connection = DbConnection.GetInstance().GetConnection();
            comm.Connection.Open();

            comm.CommandType = CommandType.Text;

            if (comm.ExecuteReader().HasRows)
            {
                comm.Connection.Close();
                return true;
                
            }
            else
            {
                comm.Connection.Close();
                return false;
            }
            


        }
    }
}