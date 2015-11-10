using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WcfService.DAL
{
    public class DbConnection
    {
        private static DbConnection instance = null;
        string ConnString = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;
        private static SqlConnection conn;
        //public static SqlCommand comm;

        private DbConnection()
        {
            conn = new SqlConnection(ConnString);
        }

        public static DbConnection GetInstance()
        {

            if (instance == null)
            {
                instance = new DbConnection();

            }
            return instance;

        }

        public SqlConnection GetConnection()
        {
            return conn;
        }
    }
}