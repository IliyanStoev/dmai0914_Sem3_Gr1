using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WcfService.Model;

namespace WcfService.DAL
{
    public class AssignmentDb
    {
        private SqlCommand comm;
        private DbConnection dbCon;
        int result;


        public int CreateAssignment(Assignment ass)
        {
            try
            {
                comm = new SqlCommand();
                comm.CommandText = "INSERT INTO Assignment(subject, title, exercise, date, deadline, pid) VALUES(@subject, @title, @exercise, @date, @deadline, @pid)";
                comm.Parameters.AddWithValue("subject", ass.subject);
                comm.Parameters.AddWithValue("title", ass.title);
                comm.Parameters.AddWithValue("exercise", ass.exercise);
                comm.Parameters.AddWithValue("date", ass.date);
                comm.Parameters.AddWithValue("deadline", ass.deadline);
                comm.Parameters.AddWithValue("pid", ass.teacher.Id);

                dbCon = new DbConnection();
                comm.Connection = dbCon.GetConnection();
                comm.Connection.Open();

                comm.CommandType = CommandType.Text;
                result = comm.ExecuteNonQuery();

            }
            catch (Exception)
            {

                throw;
            }

            finally
            {
                comm.Connection.Close();
            }
            return result;
        }
    }
}