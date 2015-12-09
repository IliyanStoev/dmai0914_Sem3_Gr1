using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WcfService.Model;

namespace WcfService.DAL
{
    public class PersonDb1
    {
        private SqlCommand cmd;
        private DbConnection dbCon;

        public Person Login(Person p)
        {
            string w = "username = '" + p.UserName + "' AND password = '" + p.Password + "'";
            Person pers = this.SingleWhere(w, false);
            return pers;
        }

        public List<Person> GetAllTeachers()
        {
            string w = "userType = '1'";
            List<Person> teachers = this.MiscWhere(w, false);
            return teachers;
        }

        public List<Person> GetAllTeachersBySubject(string subject)
        {
            string w = "subject = '" + subject + "'";
            List<Person> teachersBySubject = this.MiscWhere(w, false);
            return teachersBySubject;
        }

        private string BuildQuery(string where)
        {
            string q = "select * from Person";
            if (where != null && where.Trim().Length > 0)
            {
                q += " where " + where;
            }
            return q;
        }

        private Person BuildPerson(SqlDataReader dr)
        {
            Person pers = null;
            try
            {
                pers = new Person();
                pers.UserType = Convert.ToInt32(dr["userType"]);
                if (pers.UserType == 1)
                {
                    Teacher teacher = new Teacher();
                    teacher.Id = Convert.ToInt32(dr["pid"]);
                    teacher.Name = dr["name"].ToString();
                    teacher.Email = dr["email"].ToString();
                    teacher.Phone = dr["phone"].ToString();
                    teacher.Subject = dr["subject"].ToString();

                    cmd.Connection.Close();
                    return teacher;
                }
                else
                {
                    Child child = new Child();
                    child.Id = Convert.ToInt32(dr["pid"]);
                    child.Name = dr["name"].ToString();
                    child.Email = dr["email"].ToString();
                    child.Phone = dr["phone"].ToString();
                    child.Grade = dr["grade"].ToString();

                    cmd.Connection.Close();
                    return child;
                }
            }
            catch
            {
                throw;
            }
        }

        public Person SingleWhere(string where, Boolean retrieveAssociation)
        {
            List<Person> persons = MiscWhere(where, retrieveAssociation);
            if (persons.Count > 0)
            {
                return persons[0];
            }
            return null;
        }

        private List<Person> MiscWhere(string where, Boolean retrieveAssociation)
        {
            List<Person> persons = new List<Person>();

            try
            {
                cmd = new SqlCommand();
                cmd.CommandText = BuildQuery(where);

                dbCon = new DbConnection();
                cmd.Connection = dbCon.GetConnection();
                cmd.Connection.Open();

                cmd.CommandType = CommandType.Text;
                SqlDataReader dr = cmd.ExecuteReader();

                Person hw = null;
                while (dr.Read())
                {
                    hw = BuildPerson(dr);
                    persons.Add(hw);
                }
                dr.Close();
            }
            catch
            {
                throw;
            }
            return persons;
        }
    }
}