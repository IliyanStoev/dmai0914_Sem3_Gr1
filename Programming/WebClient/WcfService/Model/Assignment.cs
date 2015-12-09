using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WcfService.Model
{
    [KnownType(typeof(Assignment))]
    [DataContract]
    public class Assignment
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Subject { get; set; }
        [DataMember]
        public string Title { get; set; }
        [DataMember]
        public string Exercise { get; set; }
        [DataMember]
        public DateTime Date { get; set; }
        [DataMember]
        public DateTime Deadline { get; set; }
        [DataMember]
        public Teacher Teacher { get; set; }


        public Assignment(int id)
        {
            this.Id = id;
        }

        public Assignment()
        {

        }
    }
}