﻿using System;
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
        private DbConnection dbCon;
        int result;

        public int SubmitHomework(Homework hw)
        {
            try
            {
                comm = new SqlCommand();
                comm.CommandText = "INSERT INTO Homework(childId, assignmentId, date, diskName) VALUES(@childId, @assignmentId, @date, @diskName)";
                comm.Parameters.AddWithValue("childId", hw.Child.Id);
                comm.Parameters.AddWithValue("assignmentId", hw.Assignment.Id);
                comm.Parameters.AddWithValue("date", hw.Date);
                comm.Parameters.AddWithValue("diskName", hw.DiskName);

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