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

            comm.CommandText = "SELECT * FROM Person WHERE userName=(@User) AND password=(@Password)";
            comm.Parameters.AddWithValue("User", p.UserName);
            comm.Parameters.AddWithValue("Password", p.Password);

            DbConnection.GetInstance().GetConnection().Open();

            comm.CommandType = CommandType.Text;

            if (comm.ExecuteReader().HasRows)
            {
                return true;
            }
            else
            {
                return false;
            }
            

        }
    }
}