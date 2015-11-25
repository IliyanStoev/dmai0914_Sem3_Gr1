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
            ass.teacher = usCtrl.GetTeacher(teacherId);
            ass.subject = subject;
            ass.title = title;
            ass.exercise = exercise;
            ass.date = date;
            ass.deadline = deadline;

            AssignmentDb assDb = new AssignmentDb();

            return assDb.CreateAssignment(ass);
        }
        public ListForObjects GetAllAssignmentsByTeacherId(int teacherId)
        {
            AssignmentDb asDB = new AssignmentDb();
            UserCtrl userCtrl = new UserCtrl();
            ListForObjects list = new ListForObjects();
            ListForObjects l = asDB.GetAllAssignmentsByTeacherId(teacherId);
            foreach(Object o in l.Asl){
                Assignment a = (Assignment)o;
                a.teacher = userCtrl.GetTeacher(a.teacher.Id);
                list.Asl.Add(a);
            }
            return list;
        }
        public Assignment GetAssignmentById(int id)
        {
            AssignmentDb asDB = new AssignmentDb();
            UserCtrl userCtrl = new UserCtrl();
            Assignment a = asDB.GetAssignmentById(id);
            a.teacher = userCtrl.GetTeacher(a.teacher.Id);
            return a;
        }
    }
}