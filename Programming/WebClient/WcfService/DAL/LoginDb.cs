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

        public Person Login(Person p)
        {
            comm = new SqlCommand();
            comm.CommandText = "SELECT * FROM Person WHERE userName=(@userName) AND password=(@password)";
            comm.Parameters.AddWithValue("userName", p.UserName);
            comm.Parameters.AddWithValue("password", p.Password);

            comm.Connection = DbConnection.GetInstance().GetConnection();
            comm.Connection.Open();

            comm.CommandType = CommandType.Text;
            SqlDataReader dr = comm.ExecuteReader();
       

            if (dr.Read()&&dr.HasRows)
            {
                Person pers = new Person();
                pers.Name = dr["name"].ToString();
                pers.Email = dr["email"].ToString();
                pers.Phone = dr["phone"].ToString();
                pers.UserType = Convert.ToInt32(dr["userType"]);
                pers.UserName = dr["userName"].ToString();
                comm.Connection.Close();
                return pers;
                
            }
            else
            {
                comm.Connection.Close();
                return null;
            }
            


        }
    }
}