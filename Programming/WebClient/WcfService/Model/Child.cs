using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WcfService.Model
{
    [DataContract]
    public class Child : Person
    {
        [DataMember]
        public int Grade { get; set; }


        public Child()
        {

        }
        public Child(string UserName, string Name, string Phone, string Email, string Password, int Grade, int Type)
        {
            this.UserName = UserName;
            this.Name = Name;
            this.Phone = Phone;
            this.Email = Email;
            this.Password = Password;
            this.Grade = Grade;
            this.UserType = Type;
        }
    }
}