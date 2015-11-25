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
        public Object Login(string UserName, string Password)
        {
            Person p = new Person();
            p.UserName = UserName;
            p.Password = Password;
            LoginDb logDb = new LoginDb();

            return logDb.Login(p);
        }

        public Object GetPerson(int id)
        {
            Person p = new Person();
            p.Id = id;
            LoginDb logDb = new LoginDb();
            return logDb.GetPerson(p);
        }

        //public Teacher GetTeacher(int id)
        //{
        //    PersonDb persDb = new PersonDb();
        //    return persDb.GetTeacher(GetPerson(id));
        //}
        //public Child GetChild(int id)
        //{
        //    PersonDb persDb = new PersonDb();
        //    return persDb.GetChild(GetPerson(id));
        //}
    }
}