using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WcfService.Model;

namespace WcfService.DAL
{
    public class TutoringTimeDb
    {
        private SqlCommand comm;
        private DbConnection dbCon;
        int result;

        public int CreateTutoringTime(TutoringTime tt)
        {
            try
            {
                comm = new SqlCommand();
                comm.CommandText = "INSERT INTO TutoringTime(date, availability, teacherId, time) VALUES(@date, @availability, @teacherId, @time)";
                comm.Parameters.AddWithValue("date", tt.Date);
                comm.Parameters.AddWithValue("availability", tt.Available);
                comm.Parameters.AddWithValue("teacherId", tt.Teacher.Id);
                comm.Parameters.AddWithValue("time", tt.Time);

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