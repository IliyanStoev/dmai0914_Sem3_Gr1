using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WcfService.BLL;

namespace WcfService
{
   
    public class Service1 : IService1
    {
        public bool Login(string User, string Password)
        {
            UserCtrl userCtrl = new UserCtrl();
            
         bool Login = userCtrl.Login(User, Password);

         return Login;
            
        }

    }
}
