using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WcfService.Model;
using System.Data.SqlClient;
using System.Data;

namespace WcfService.DAL
{
    public class PersonDb
    {
        private SqlCommand comm;
        private DbConnection dbCon;


        public Teacher GetTeacher(Person p)
        {
            comm = new SqlCommand();
            comm.CommandText = "SELECT * FROM Teacher WHERE pid=(@pid)";
            comm.Parameters.AddWithValue("pid", p.Id);
            dbCon = new DbConnection();
            comm.Connection = dbCon.GetConnection();
            comm.Connection.Open();

            comm.CommandType = CommandType.Text;
            SqlDataReader dr = comm.ExecuteReader();


            if (dr.Read() && dr.HasRows)
            {
                Teacher teacher = new Teacher();
                teacher.Id = p.Id;
                teacher.Name = p.Name;
                teacher.Password = p.Password;
                teacher.Phone = p.Phone;
                teacher.UserName = p.UserName;
                teacher.UserType = p.UserType;
                teacher.Subject = Convert.ToString(dr["subject"]);
                return teacher;
            }
            else
            {
                comm.Connection.Close();
                return null;
            }
        }
        public Child GetChild(Person p)
        {
            comm = new SqlCommand();
            comm.CommandText = "SELECT * FROM Child WHERE pid=(@pid)";
            comm.Parameters.AddWithValue("pid", p.Id);
            dbCon = new DbConnection();
            comm.Connection = dbCon.GetConnection();
            comm.Connection.Open();

            comm.CommandType = CommandType.Text;
            SqlDataReader dr = comm.ExecuteReader();


            if (dr.Read() && dr.HasRows)
            {
                Child child = new Child();
                child.Email = p.Email;
                child.Id = p.Id;
                child.Name = p.Name;
                child.Password = p.Password;
                child.Phone = p.Phone;
                child.UserName = p.UserName;
                child.UserType = p.UserType;
                child.Grade = dr["grade"].ToString();
                return child;
            }
            else
            {
                comm.Connection.Close();
                return null;
            }
        }
    }
}