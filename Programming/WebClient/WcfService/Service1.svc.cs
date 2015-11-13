using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WcfService.BLL;
using WcfService.Model;

namespace WcfService
{
   
    public class Service1 : IService1
    {
        public Person Login(string User, string Password)
        {
         UserCtrl userCtrl = new UserCtrl();

         return userCtrl.Login(User, Password);
        }

        public int SubmitHomework(int childId, int assignmentId, DateTime date, string diskName)
        {
            HomeworkCtrl hwCtrl = new HomeworkCtrl();

            return hwCtrl.SubmitHomework(childId, assignmentId, date, diskName);
        }

    }
}
