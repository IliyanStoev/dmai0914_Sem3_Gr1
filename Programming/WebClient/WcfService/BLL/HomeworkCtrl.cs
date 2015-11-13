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
    }
}