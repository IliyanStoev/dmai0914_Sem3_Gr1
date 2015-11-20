using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WcfService.DAL;
using WcfService.Model;

namespace WcfService.BLL
{
    public class AssignmentCtrl
    {

        public int CreateAssignment(int teacherId, string subject, string title, string exercise, DateTime date, DateTime deadline)
        {
            UserCtrl usCtrl = new UserCtrl();

            Assignment ass = new Assignment();
            ass.teacher = usCtrl.GetPerson(teacherId);
            ass.subject = subject;
            ass.title = title;
            ass.exercise = exercise;
            ass.date = date;
            ass.deadline = deadline;

            AssignmentDb assDb = new AssignmentDb();

            return assDb.CreateAssignment(ass);
        }
    }
}