using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WcfService.Model;

namespace WcfService.DAL
{
    public class HomeworkDb
    {
        private SqlCommand comm;

        public int SubmitHomework(Homework hw)
        {
            comm = new SqlCommand();
            comm.CommandText = "INSERT INTO Homework(childId, assignmentId, date, diskName) VALUES(@childId, @assignmentId, @date, @diskName)";
            comm.Parameters.AddWithValue("childId", hw.Child.Id);
            comm.Parameters.AddWithValue("assignmentId", hw.Assignment.Id);
            comm.Parameters.AddWithValue("date", hw.Date);
            comm.Parameters.AddWithValue("diskName", hw.DiskName);

            comm.Connection = DbConnection.GetInstance().GetConnection();
            comm.Connection.Open();

            comm.CommandType = CommandType.Text;
            return comm.ExecuteNonQuery();
        }
    }
}