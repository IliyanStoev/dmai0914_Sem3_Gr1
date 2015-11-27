using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WcfService.DAL;
using WcfService.Model;

namespace WcfService.BLL
{
    public class TutoringTimeCtrl
    {
        public int CreateTutoringTime(DateTime date, bool availability, int teacherId, string time)
        {
            TutoringTime tt = new TutoringTime();
            tt.Date = date;
            tt.Available = availability;
            tt.Teacher = new Teacher(teacherId);
            tt.Time = time;

            TutoringTimeDb ttDb = new TutoringTimeDb();

            return ttDb.CreateTutoringTime(tt);
        }
    }
}