﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WcfService.Model
{
    [DataContract]
    public class Person
    {
        [DataMember]
        public string UserName { get; set; }
        public string Name { get; set; }
         [DataMember]
        public string Phone { get; set; }
         [DataMember]
        public string Email { get; set; }
         [DataMember]
        public string Password { get; set; }
         [DataMember]
        public int UserType { get; set; }




    }
}