using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfService.Model
{
    public class Assignment
    {
        public int Id { get; set; }

        public Assignment(int id)
        {
            this.Id = id;
        }

        public Assignment()
        {

        }
    }
}