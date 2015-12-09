using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WcfService.Model;

namespace WcfService.DAL
{
    public class TutoringTimeDb1
    {
        private SqlCommand cmd;
        private DbConnection dbCon;
        int result;

        public int CreateTutoringTime(TutoringTime tt)
        {
            try
            {
                cmd = new SqlCommand();
                cmd.CommandText = "INSERT INTO TutoringTime(date, time, teacherId) VALUES(@date, @time, @teacherId)";
                cmd.Parameters.AddWithValue("date", tt.Date);
                cmd.Parameters.AddWithValue("time", tt.Time);
                cmd.Parameters.AddWithValue("teacherId", tt.Teacher.Id);

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

        public int RemoveTutoringTime(TutoringTime tt)
        {
            int result;
            string sqlDate = tt.Date.ToString("yyyy/MM/dd");

            try
            {
                cmd = new SqlCommand();
                cmd.CommandText = "DELETE FROM TutoringTime WHERE date =(@date) AND time = (@time) AND teacherId = (@teacherId)";
                cmd.Parameters.AddWithValue("date", sqlDate);
                cmd.Parameters.AddWithValue("time", tt.Time);
                cmd.Parameters.AddWithValue("teacherId", tt.Teacher.Id);

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

        //public TutoringTime GetTutoringTime(int id)
        //{
        //    string w = "ttid = '" + id + "'";
        //    TutoringTime tt = this.SingleWhere(w, true);
        //    return tt;
        //}

        //public List<TutoringTime> GetAllTutoringTimes()
        //{
        //    return MiscWhere("", true);
        //}
        public List<TutoringTime> GetAllAvailableTutoringTimes()
        {
            string w = 
        }

        public List<TutoringTime> GetAllTutoringTimesByTeacher(int teacherId)
        {
            string w = "teacherId = '" + teacherId + "'";
            return MiscWhere(w, true);
        }

        public TutoringTime GetExactTutoringTime(TutoringTime tt)
        {
            string sqlDate = tt.Date.ToString("yyyy/MM/dd");

            string w = "date = '" + sqlDate + "' AND time = '" + tt.Time + "' AND teacherId = '" + tt.Teacher.Id + "'";
            return SingleWhere(w, true);
        }

        private string BuildQuery(string where)
        {
            string q = "select * from TutoringTime";
            if (where != null && where.Trim().Length > 0)
            {
                q += " where " + where;
            }
            return q;
        }

        private TutoringTime BuildTutoringTime(SqlDataReader dr)
        {
            TutoringTime tt = null;
            try
            {
                tt = new TutoringTime();
                tt.Id = Convert.ToInt32(dr["ttid"]);
                tt.Date = Convert.ToDateTime(dr["date"]);
                tt.Time = dr["time"].ToString();
                tt.Teacher = new Teacher(Convert.ToInt32(dr["teacherId"]));
                if (dr["childId"] != typeof(DBNull))
                {
                    tt.Child = new Child(Convert.ToInt32(dr["childId"]));
                }
                //if (dr["childId"] != typeof(DBNull) || Convert.ToInt32(dr["childId"]) != 0)
                //{
                //    tt.Child = new Child(Convert.ToInt32(dr["childId"]));
                //}
            }
            catch
            {
                throw;
            }
            return tt;
        }

        public TutoringTime SingleWhere(string where, Boolean retrieveAssociation)
        {
            List<TutoringTime> tts = MiscWhere(where, retrieveAssociation);
            if (tts.Count > 0)
            {
                return tts[0];
            }
            return null;
        }

        private List<TutoringTime> MiscWhere(string where, Boolean retrieveAssociation)
        {
            List<TutoringTime> tts = new List<TutoringTime>();

            try
            {
                cmd = new SqlCommand();
                cmd.CommandText = BuildQuery(where);

                dbCon = new DbConnection();
                cmd.Connection = dbCon.GetConnection();
                cmd.Connection.Open();

                cmd.CommandType = CommandType.Text;
                SqlDataReader dr = cmd.ExecuteReader();

                TutoringTime tt = null;
                while (dr.Read())
                {
                    tt = BuildTutoringTime(dr);
                    if (retrieveAssociation)
                    {
                        PersonDb persDb = new PersonDb();
                        int pid = tt.Teacher.Id;
                        Teacher teacher = persDb.SingleWhere("pid = '" + pid + "'", false);
                        tt.Teacher = teacher;

                        if (tt.Child != null)
                        {
                            Child child = persDb.SingleWhere("pid = '" + pid + "'", false);
                            tt.Child = child;
                        }
                    }
                    tts.Add(tt);
                }
                dr.Close();
            }
            catch
            {
                throw;
            }
            return tts;
        }
    }
}