using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WcfService.Model;

namespace WcfService.DAL
{
    public class HomeworkDb1
    {
        private SqlCommand cmd;
        private DbConnection dbCon;
        int result;

        public int SubmitHomework(Homework hw)
        {
            try
            {
                cmd = new SqlCommand();
                cmd.CommandText = "INSERT INTO Homework(childId, assignmentId, date, diskName) VALUES(@childId, @HomeworkId, @date, @diskName)";
                cmd.Parameters.AddWithValue("childId", hw.Child.Id);
                cmd.Parameters.AddWithValue("assignmentId", hw.Assignment.Id);
                cmd.Parameters.AddWithValue("date", hw.Date);
                cmd.Parameters.AddWithValue("diskName", hw.DiskName);

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

        public List<Homework> GetAllHomeworkByAssignment(int assignmentId)
        {
            string w = "assignmentId = '" + assignmentId + "'";
            return MiscWhere(w, true);
        }

        public List<Homework> GetAllHomeworkByChild(int childId)
        {
            string w = "childId = '" + childId + "'";
            return MiscWhere(w, true);
        }

        public Homework GetHomeworkById(int id)
        {
            string w = "hid = '" + id + "'";
            return SingleWhere(w, true);
        }

        private string BuildQuery(string where)
        {
            string q = "select * from Homework";
            if (where != null && where.Trim().Length > 0)
            {
                q += " where " + where;
            }
            return q;
        }

        private Homework BuildHomework(SqlDataReader dr)
        {
            Homework hw = null;
            try
            {
                hw = new Homework();
                hw.Id = Convert.ToInt32(dr["hid"]);
                hw.Child = new Child(Convert.ToInt32(dr["childId"]));
                hw.Assignment = new Assignment(Convert.ToInt32(dr["assignmentId"]));
                hw.Date = Convert.ToDateTime(dr["date"]);
                hw.DiskName = (dr["diskName"].ToString());
            }
            catch
            {
                throw;
            }
            return hw;
        }

        public Homework SingleWhere(string where, Boolean retrieveAssociation)
        {
            List<Homework> hws = MiscWhere(where, retrieveAssociation);
            if (hws.Count > 0)
            {
                return hws[0];
            }
            return null;
        }

        private List<Homework> MiscWhere(string where, Boolean retrieveAssociation)
        {
            List<Homework> hws = new List<Homework>();

            try
            {
                cmd = new SqlCommand();
                cmd.CommandText = BuildQuery(where);

                dbCon = new DbConnection();
                cmd.Connection = dbCon.GetConnection();
                cmd.Connection.Open();

                cmd.CommandType = CommandType.Text;
                SqlDataReader dr = cmd.ExecuteReader();

                Homework hw = null;
                while (dr.Read())
                {
                    hw = BuildHomework(dr);
                    if (retrieveAssociation)
                    {
                        PersonDb persDb = new PersonDb();
                        int childId = hw.Child.Id;
                        Person child = persDb.SingleWhere("pid = '" + childId + "'", false);
                        hw.Child = child;

                        AssignmentDb asgDb = new AssignmentDb();
                        int assignmentId = hw.Assignment.Id;
                        Assignment asg = asgDb.SingleWhere("aid = '" + assignmentId + "'", false);
                        hw.Assignment = asg;
                    }
                    hws.Add(hw);
                }
                dr.Close();
            }
            catch
            {
                throw;
            }
            return hws;
        }
    }
}