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
            
         Person pers = userCtrl.Login(User, Password);

         return pers;
            
        }

    }
}
