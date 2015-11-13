using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfService.Model
{
    public class Homework
    {
        public Person Child { get; set; }
        public Assignment Assignment { get; set; }
        public DateTime Date { get; set; }
        public int Id { get; set; }
        public string DiskName { get; set; }

    }
}