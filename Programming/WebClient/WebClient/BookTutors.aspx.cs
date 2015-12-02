using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using WebClient.WCFWebReference;
using WebClient.VModel;

namespace WebClient
{
    public partial class BookTutors : System.Web.UI.Page
    {
        private List<TutoringTime> allTutoringTimes;
        private List<Teacher> allTutoringTeachers = new List<Teacher>();
        private List<string> allTutoringSubjects = new List<string>();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (LogIn.child == null)
            {
                Response.Redirect("LogIn.aspx");
            }

            Service1Client service = new Service1Client();
            allTutoringTimes = service.GetAllAvailableTutoringTimes().OfType<TutoringTime>().ToList();
            SetAllTutorsAndSubjects(allTutoringTimes);


            if (!Page.IsPostBack)
            {

                SetSubjectsToComboBox(allTutoringSubjects);

                SetTeachersToComboBox(allTutoringTeachers);

                SetDataToTutorTable(new List<TutorTableView>());
            }

        }
        protected void BookingCalendar_DayRender(object sender, DayRenderEventArgs e)
        {
            e.Day.IsSelectable = false;
            if (e.Day.Date < DateTime.Today)
            {
                e.Cell.Font.Italic = true;
                e.Cell.BackColor = System.Drawing.Color.DimGray;
                e.Cell.BorderColor = System.Drawing.Color.Gray;
                e.Cell.ForeColor = System.Drawing.Color.Gray;
                e.Cell.Font.Name = "Courier New";
            }

            if (e.Day.Date.DayOfWeek == DayOfWeek.Saturday || e.Day.Date.DayOfWeek == DayOfWeek.Sunday)
            {
                e.Cell.ForeColor = System.Drawing.Color.Red;
            }

            Service1Client service = new Service1Client();

            if (!Page.IsPostBack)
            {
                foreach (DateTime d in GetAllAvailableTutoringDates(allTutoringTimes))
                {
                    if (e.Day.Date.Equals(d))
                    {
                        e.Cell.BackColor = System.Drawing.Color.Green;
                        e.Day.IsSelectable = true;
                    }
                }
            }
            else
            {
                //Select available dates by subject
                if (SubjectDrL.SelectedValue != "Select subject")
                {

                    foreach (DateTime d in GetAllAvailableTutoringDates(GetAllAvailableTutoringTimesForSubject(SubjectDrL.SelectedValue)))
                    {
                        if (e.Day.Date.Equals(d))
                        {
                            e.Cell.BackColor = System.Drawing.Color.Green;
                            e.Day.IsSelectable = true;
                        }
                    }
                }
                //this part of code is repeating need to try to refactor
                else
                {
                    foreach (DateTime d in GetAllAvailableTutoringDates(allTutoringTimes))
                    {
                        if (e.Day.Date.Equals(d))
                        {
                            e.Cell.BackColor = System.Drawing.Color.Green;
                            e.Day.IsSelectable = true;
                        }
                    }
                }
                //Select available dates by teacher
                if (TeacherDrL.SelectedValue != "Select teacher")
                {
                    e.Day.IsSelectable = false;
                    e.Cell.BackColor = System.Drawing.Color.White;
                    if (e.Day.Date < DateTime.Today)
                    {
                        e.Cell.Font.Italic = true;
                        e.Cell.BackColor = System.Drawing.Color.DimGray;
                        e.Cell.BorderColor = System.Drawing.Color.Gray;
                        e.Cell.ForeColor = System.Drawing.Color.Gray;
                        e.Cell.Font.Name = "Courier New";
                    }

                    foreach (DateTime d in GetAllAvailableTutoringDates(GetAllAvailableTutoringTimesForTeacher(TeacherDrL.SelectedValue)))
                    {
                        if (e.Day.Date.Equals(d))
                        {
                            e.Cell.BackColor = System.Drawing.Color.Green;
                            e.Day.IsSelectable = true;
                        }
                    }
                }
            }

        }

        protected void SubjectDrL_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Teacher> sortedTeacherList = new List<Teacher>();
            if (!SubjectDrL.SelectedValue.Equals("Select subject"))
            {
                foreach (Teacher t in allTutoringTeachers)
                {
                    if (t.Subject == SubjectDrL.SelectedValue)
                    {
                        sortedTeacherList.Add(t);
                    }
                }
                SetTeachersToComboBox(sortedTeacherList);
            }
            else
            {
                SetTeachersToComboBox(allTutoringTeachers);
            }
            SetDataToTutorTable(new List<TutorTableView>());
            BookingCalendar.SelectedDates.Clear();
        }

        protected void TeacherDrL_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = TeacherDrL.SelectedValue;
            List<Teacher> sortedTeacherList = new List<Teacher>();
            foreach (Teacher t in allTutoringTeachers)
            {
                if (t.Name == TeacherDrL.SelectedValue)
                {
                    SubjectDrL.SelectedValue = t.Subject;
                }
            }
            foreach (Teacher t in allTutoringTeachers)
            {
                if (t.Subject == SubjectDrL.SelectedValue)
                {
                    sortedTeacherList.Add(t);
                }
            }
            SetTeachersToComboBox(sortedTeacherList);
            TeacherDrL.SelectedValue = name;
            SetDataToTutorTable(new List<TutorTableView>());
            BookingCalendar.SelectedDates.Clear();
        }

        protected void BookingCalendar_SelectionChanged(object sender, EventArgs e)
        {
            List<TutorTableView> viewTable = new List<TutorTableView>();
            if (TeacherDrL.SelectedValue != "Select teacher")
            {
                foreach (TutoringTime tt in allTutoringTimes)
                {
                    if (tt.Teacher.Name == TeacherDrL.SelectedValue && tt.Date == BookingCalendar.SelectedDate)
                    {
                        TutorTableView ttv = new TutorTableView();
                        ttv.Name = tt.Teacher.Name;
                        ttv.Subject = tt.Teacher.Subject;
                        ttv.Time = tt.Time;
                        viewTable.Add(ttv);
                    }
                }
            }
            else if (SubjectDrL.SelectedValue != "Select subject")
            {
                foreach (TutoringTime tt in allTutoringTimes)
                {
                    if (tt.Teacher.Subject == SubjectDrL.SelectedValue && tt.Date == BookingCalendar.SelectedDate)
                    {
                        TutorTableView ttv = new TutorTableView();
                        ttv.Name = tt.Teacher.Name;
                        ttv.Subject = tt.Teacher.Subject;
                        ttv.Time = tt.Time;
                        viewTable.Add(ttv);
                    }
                }
            }
            else
            {
                foreach (TutoringTime tt in allTutoringTimes)
                {
                    if (tt.Date == BookingCalendar.SelectedDate)
                    {
                        TutorTableView ttv = new TutorTableView();
                        ttv.Name = tt.Teacher.Name;
                        ttv.Subject = tt.Teacher.Subject;
                        ttv.Time = tt.Time;
                        viewTable.Add(ttv);
                    }
                }
            }
            SetDataToTutorTable(viewTable);
        }

        //Sets all the data to lists that are used to populate comboBoxes
        public void SetAllTutorsAndSubjects(List<TutoringTime> list)
        {
            foreach (TutoringTime tt in list)
            {
                //Checks if the date has not passed
                if (tt.Date >= DateTime.Today)
                {
                    //checks if teacher is not already added
                    //and adds it to list if it doesn't
                    if (!CheckIfTeacherExistsInList(tt))
                    {
                        allTutoringTeachers.Add(tt.Teacher);

                        //also checks for subjects so they don't repeat
                        //and adds it to list if it doesn't
                        if (!CheckIfSubjectExistsInList(tt))
                        {
                            allTutoringSubjects.Add(tt.Teacher.Subject);
                        }
                    }
                }
            }
        }
        //This method is used to check if the list of teachers for combo box 
        //allready contains the given teacher
        public bool CheckIfTeacherExistsInList(TutoringTime tt)
        {
            bool teacherExistsInList = false;
            foreach (Teacher t in allTutoringTeachers)
            {
                if (t.Id == tt.Teacher.Id)
                {
                    teacherExistsInList = true;
                }
            }
            return teacherExistsInList;
        }
        //This method is used to check if the list of subjects for combo box 
        //allready contains the given subject
        public bool CheckIfSubjectExistsInList(TutoringTime tt)
        {
            bool subjectExistsInList = false;
            foreach (string sub in allTutoringSubjects)
            {
                if (sub == tt.Teacher.Subject)
                {
                    subjectExistsInList = true;
                }
            }
            return subjectExistsInList;
        }
        public List<DateTime> GetAllAvailableTutoringDates(List<TutoringTime> list)
        {
            List<DateTime> dateList = new List<DateTime>();
            foreach (TutoringTime tt in list)
            {
                if (tt.Date >= DateTime.Today)
                {
                    dateList.Add(tt.Date);
                }
            }
            return dateList;
        }
        public void SetTeachersToComboBox(List<Teacher> teachers)
        {
            List<string> teacherNames = new List<string>();
            teacherNames.Add("Select teacher");
            foreach (Teacher t in teachers)
            {
                teacherNames.Add(t.Name);
            }
            TeacherDrL.DataSource = teacherNames;
            TeacherDrL.DataBind();
        }
        public void SetSubjectsToComboBox(List<string> subjects)
        {
            List<string> list = new List<string>();
            list.Add("Select subject");
            foreach (string s in subjects)
            {
                list.Add(s);
            }
            SubjectDrL.DataSource = list;
            SubjectDrL.DataBind();
        }
        public void SetDataToTutorTable(List<TutorTableView> list)
        {
            TutorTable.DataSource = list;
            TutorTable.DataBind();
        }
        public List<TutoringTime> GetAllAvailableTutoringTimesForSubject(string subject)
        {
            List<TutoringTime> sorted = new List<TutoringTime>();
            foreach (TutoringTime tt in allTutoringTimes)
            {
                if (tt.Teacher.Subject == subject)
                {
                    sorted.Add(tt);
                }
            }
            return sorted;
        }
        public List<TutoringTime> GetAllAvailableTutoringTimesForTeacher(string teachersName)
        {
            List<TutoringTime> sorted = new List<TutoringTime>();
            foreach (TutoringTime tt in allTutoringTimes)
            {
                if (tt.Teacher.Name == teachersName)
                {
                    sorted.Add(tt);
                }
            }
            return sorted;
        }

        protected void TutorTable_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Book")
            {
                int rowindex = Convert.ToInt32(e.CommandArgument);
                GridViewRow gvr = TutorTable.Rows[rowindex];
                string name = gvr.Cells[0].Text;
                string time = gvr.Cells[2].Text;
                Service1Client service = new Service1Client();
                foreach (TutoringTime tt in allTutoringTimes)
                {
                    if (tt.Time == time && tt.Teacher.Name == name && tt.Date == BookingCalendar.SelectedDate)
                    {
                        if (service.GetTtTimesByTime(tt.Date, time, tt.Teacher.Id).Child == null)
                        {
                            service.RegisterBooking(LogIn.child.Id, tt.Id);
                            Page.ClientScript.RegisterStartupScript(this.GetType(), "Script", "<script>alert('Your booking was successful!')</script>");
                            
                        }
                        else
                        {
                            Page.ClientScript.RegisterStartupScript(this.GetType(), "Script", "<script>alert('Sorry mate, someone booked it faster than you!')</script>");
                        }

                    }
                }
            }
            Service1Client service1 = new Service1Client();
            allTutoringTimes = service1.GetAllAvailableTutoringTimes().OfType<TutoringTime>().ToList();
            SetAllTutorsAndSubjects(allTutoringTimes);
            BookingCalendar.SelectedDates.Clear();

            SetSubjectsToComboBox(allTutoringSubjects);

            SetTeachersToComboBox(allTutoringTeachers);

            SetDataToTutorTable(new List<TutorTableView>());
            SubjectDrL.SelectedValue = "Select subject";
            TeacherDrL.SelectedValue = "Select teacher";
        }
    }
}