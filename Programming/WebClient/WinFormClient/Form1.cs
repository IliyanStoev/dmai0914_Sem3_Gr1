using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormClient.WinformReference;

namespace WinFormClient
{
    public partial class Form1 : Form
    {
        private string[] subjects = { "Math", "Literature", "English" };
        private Person person;
        public Form1()
        {
            InitializeComponent();
            tabControl1.TabPages.Remove(tabAssignments);
            tabControl1.TabPages.Remove(tabHomeworks);
            cbSubject.DataSource = subjects;

        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            LogIn();
        }

        private void LogIn()
        {
            string userName = tbUsername.Text;
            string password = tbPass.Text.GetHashCode().ToString();

            Service1Client winService = new Service1Client();

            person = winService.Login(userName, password);

            if (person != null && person.Id == 1)
            {
                tabControl1.TabPages.Remove(tabLogin);
                tabControl1.TabPages.Add(tabAssignments);
                tabControl1.TabPages.Add(tabHomeworks);
            }

            else
            {
                MessageBox.Show("Username or password is incorrect, please try again :)");
            }
        }

        private void btnCreateAss_Click(object sender, EventArgs e)
        {
            CreateAssignment();
        }

        private void CreateAssignment()
        {
            int teacherId = person.Id;
            string title = tbTitle.Text;
            string subject = cbSubject.SelectedValue.ToString();
            string exercise = tbExercise.Text;
            DateTime date = startDate.Value;
            DateTime deadline = deadlineDate.Value;
            if (deadline < date)
            {
                MessageBox.Show("Deadline must be greater than Starting Date");

            }
            else
            {
                Service1Client winService = new Service1Client();
                int i = winService.CreateAssignment(teacherId, subject, title, exercise, date, deadline);

                if (i == 1)
                {
                    MessageBox.Show("Assignment Succesfully created");
                    tbTitle.Text = "";
                    cbSubject.ResetText();
                    tbExercise.Text = "";
                    startDate.ResetText();
                    deadlineDate.ResetText();
                }

                else
                {
                    MessageBox.Show("Something went wrong");
                }
            }
        }
    }
}
