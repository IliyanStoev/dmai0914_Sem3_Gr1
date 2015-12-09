using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using WcfService.Model;

namespace WcfService.DAL
{
    [DataContract]
    public class AssignmentDb1
    {
        private SqlCommand cmd;
        private DbConnection dbCon;
        int result;

        public int CreateAssignment(Assignment ass)
        {
            try
            {
                cmd = new SqlCommand();
                cmd.CommandText = "INSERT INTO Assignment(subject, title, exercise, date, deadline, teacherId) VALUES(@subject, @title, @exercise, @date, @deadline, @teacherId)";
                cmd.Parameters.AddWithValue("subject", ass.Subject);
                cmd.Parameters.AddWithValue("title", ass.Title);
                cmd.Parameters.AddWithValue("exercise", ass.Exercise);
                cmd.Parameters.AddWithValue("date", ass.Date);
                cmd.Parameters.AddWithValue("deadline", ass.Deadline);
                cmd.Parameters.AddWithValue("teacherId", ass.Teacher.Id);

                dbCon = new DbConnection();
                cmd.Connection = dbCon.GetConnection();
                cmd.Connection.Open();

                cmd.CommandType = CommandType.Text;
                result = cmd.ExecuteNonQuery();

            }
            catch (Exception)
            {

                throw;
            }

            finally
            {
                cmd.Connection.Close();
            }
            return result;
        }

        public Assignment GetAssignment(int id)
        {
            string w = "aid = '" + id + "'";
            Assignment asg = this.SingleWhere(w, true);
            return asg;
        }

        public List<Assignment> GetAllAssignments()
        {
            return MiscWhere("", true);
        }

        public List<Assignment> GetAllAssignmentsByTeacherId(int teacherId)
        {
            string w = "teacherId = '" + teacherId + "'";
            return MiscWhere(w, true);
        }

        private string BuildQuery(string where)
        {
            string q = "select * from Assignment";
            if (where != null && where.Trim().Length > 0)
            {
                q += " where " + where;
            }
            return q;
        }

        private Assignment BuildAssignment(SqlDataReader dr)
        {
            Assignment asg = null;
            try
            {
                asg = new Assignment();
                asg.Id = Convert.ToInt32(dr["aid"]);
                asg.Subject = dr["subject"].ToString();
                asg.Title = dr["title"].ToString();
                asg.Exercise = dr["exercise"].ToString();
                asg.Teacher = new Teacher(Convert.ToInt32(dr["teacherId"].ToString()));
            }
            catch
            {
                throw;
            }
            return asg;
        }

        public Assignment SingleWhere(string where, Boolean retrieveAssociation)
        {
            List<Assignment> asgs = MiscWhere(where, retrieveAssociation);
            if (asgs.Count > 0)
            {
                return asgs[0];
            }
            return null;
        }

        private List<Assignment> MiscWhere(string where, Boolean retrieveAssociation)
        {
            List<Assignment> asgs = new List<Assignment>();

            try
            {
                cmd = new SqlCommand();
                cmd.CommandText = BuildQuery(where);

                dbCon = new DbConnection();
                cmd.Connection = dbCon.GetConnection();
                cmd.Connection.Open();

                cmd.CommandType = CommandType.Text;
                SqlDataReader dr = cmd.ExecuteReader();

                Assignment asg = null;
                while (dr.Read())
                {
                    asg = BuildAssignment(dr);
                    if (retrieveAssociation)
                    {
                        PersonDb persDb = new PersonDb();
                        int pid = asg.Teacher.Id;
                        Person teacher = persDb.SingleWhere("pid = '" + pid + "'", false);
                        asg.Teacher = teacher;
                    }
                    asgs.Add(asg);
                }
                dr.Close();
            }
            catch
            {
                throw;
            }
            return asgs;
        }
    }
}