using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using WebClient.WCFWebReference;

namespace WebClient
{
    public partial class BookTutors : System.Web.UI.Page
    {
        private List<Teacher> teachers = new List<Teacher>();
        private List<string> subjects = new List<string>();
        private List<Teacher> sortedTeacherList = new List<Teacher>();
        protected void Page_Load(object sender, EventArgs e)
        {
            BookingCalendar.SelectedDate = DateTime.Today;
            //BookingCalendar.SelectedDates =

            Service1Client service = new Service1Client();
            //teachers = service.GetAllTeachers();



            addAllSubjectsToCheckBox();
            SubjectDrL.DataSource = subjects;
            SubjectDrL.DataBind();


            TeacherDrL.DataSource = GetAllTeachersToCheckBox();
            TeacherDrL.DataBind();

            TutorTable.DataSource = new List<Teacher>();
            TutorTable.DataBind();
        }
        public void addAllSubjectsToCheckBox()
        {
            subjects.Add("Select subject");
            subjects.Add("Math");
            subjects.Add("Literature");
            subjects.Add("English");
        }
        public List<string> GetAllTeachersToCheckBox()
        {
            List<string> list = new List<string>();
            list.Add("Select teacher");

            //foreach(Teacher t : teachers){
            //    string name = t.Name;
            //    list.Add(t);
            //}
            return list;
        }

        protected void BookingCalendar_DayRender(object sender, DayRenderEventArgs e)
        {
            if (e.Day.Date < DateTime.Today)
            {
                e.Cell.Font.Italic = true;
                e.Day.IsSelectable = false;
                e.Cell.BackColor = System.Drawing.Color.DimGray;
                e.Cell.BorderColor = System.Drawing.Color.Gray;
                e.Cell.ForeColor = System.Drawing.Color.Gray;
                e.Cell.Font.Name = "Courier New";
            }
            //Set Default properties
            e.Day.IsSelectable = false;
            e.Cell.BackColor = System.Drawing.Color.Gray;
            //Now loop through the list of dates and make it
            //Selectable
            //foreach (DateTime d in listDates)
            //{
            //    Calendar1.SelectedDates.Add(d);
            //    if (e.Day.IsSelected)
            //    {
            //        e.Cell.BackColor = System.Drawing.Color.Green;
            //        e.Day.IsSelectable = true;
            //    }
            //}
        }

        protected void SubjectDrL_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!SubjectDrL.SelectedValue.Equals("Select subject"))
            {
                foreach (Teacher t in teachers)
                {
                    if (t.Subject == SubjectDrL.SelectedValue)
                    {
                        sortedTeacherList.Add(t);
                    }
                }
                SetSortedListToTeacherDropBox();
            }
        }

        protected void TeacherDrL_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void SetSortedListToTeacherDropBox()
        {
            List<string> list = new List<string>();
            list.Add("Select teacher");
            foreach (Teacher t in sortedTeacherList)
            {
                list.Add(t.Name);
            }
            TeacherDrL.DataSource = list;
            TeacherDrL.DataBind();
        }

    }
}