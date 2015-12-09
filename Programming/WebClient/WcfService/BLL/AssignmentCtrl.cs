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
            PersonCtrl usCtrl = new PersonCtrl();

            Assignment ass = new Assignment();
            ass.Teacher = (Teacher)usCtrl.GetPerson(teacherId);
            ass.Subject = subject;
            ass.Title = title;
            ass.Exercise = exercise;
            ass.Date = date;
            ass.Deadline = deadline;

            AssignmentDb assDb = new AssignmentDb();

            return assDb.CreateAssignment(ass);
        }
        
        public ListForObjects GetAllAssignmentsByTeacherId(int teacherId)
        {
            AssignmentDb asDB = new AssignmentDb();
            PersonCtrl userCtrl = new PersonCtrl();
            ListForObjects list = new ListForObjects();
            ListForObjects l = asDB.GetAllAssignmentsByTeacherId(teacherId);
            foreach (Object o in l.Asl)
            {
                Assignment a = (Assignment)o;
                a.Teacher = (Teacher)userCtrl.GetPerson(a.Teacher.Id);
                list.Asl.Add(a);
            }
            return list;
        }

        public List<Assignment> GetAllAssignments()
        {
            AssignmentDb asDB = new AssignmentDb();
            List<Assignment> asgs = asDB.GetAllAssignments();

            return asgs;
        }
    }
}