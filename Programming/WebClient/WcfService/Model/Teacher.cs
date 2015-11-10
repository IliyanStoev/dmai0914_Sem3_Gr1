using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WcfService.Model
{
    [DataContract]
    public class Teacher : Person
    {
        [DataMember]
        public string Subject { get; set; }

        
        public Teacher()
        {

        }

        public Teacher(string UserName, string Name, string Phone, string Email, string Password, string Subject, int Type)
        {
            this.UserName = UserName;
            this.Name = Name;
            this.Phone = Phone;
            this.Email = Email;
            this.Password = Password;
            this.Subject = Subject;
            this.UserType = Type;


        }
    }
}