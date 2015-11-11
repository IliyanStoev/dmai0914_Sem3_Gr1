using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WcfService.DAL;


using WcfService.Model;
namespace WcfService.BLL
{
    public class UserCtrl
    {
        public Person Login(string UserName, string Password)
        {
            Person p = new Person();
            p.UserName = UserName;
            p.Password = Password;
            LoginDb logDb = new LoginDb();
             Person pers = logDb.Login(p);
            return pers;
        }
    }
}