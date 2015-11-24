using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WcfService.DAL;
using WcfService.Model;

namespace WcfService.BLL
{
    public class HomeworkCtrl
    {
        public int SubmitHomework(int childId, int assignmentId, DateTime date, string diskName)
        {
            UserCtrl userCtrl = new UserCtrl();

            Homework hw = new Homework();
            hw.Child = userCtrl.GetPerson(childId);
            hw.Assignment = new Assignment(assignmentId);
            hw.Date = date;
            hw.DiskName = diskName;

            HomeworkDb hwDb = new HomeworkDb();

            return hwDb.SubmitHomework(hw);
        }
        public ListForObjects GetAllHomeworksByID(int assignmentId)
        {
            HomeworkDb hwDb = new HomeworkDb();
            UserCtrl userCtrl = new UserCtrl();
            AssignmentCtrl assgnmentCtrl = new AssignmentCtrl();
            ListForObjects l = hwDb.GetAllHomeworksById(assignmentId);
            ListForObjects list = new ListForObjects();
            foreach (Object o in l.Asl)
            {
                Homework hw = (Homework)o;
                hw.Child = userCtrl.GetChild(hw.Child.Id);
                hw.Assignment = assgnmentCtrl.GetAssignmentById(hw.Assignment.Id);
                list.Asl.Add(hw);
            }
            return list;
        }
        public Homework GetHomeworkById(int id)
        {
            HomeworkDb hwDb = new HomeworkDb();
            return hwDb.GetHomeworkById(id);
        }
    }
}