﻿using System;
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
        private ListForObjects list;
        public Form1()
        {
            InitializeComponent();
            tabControl1.TabPages.Remove(tabAssignments);
            tabControl1.TabPages.Remove(tabHomeworks);
            cbSubject.DataSource = subjects;

            //Removes the anoying first empty column in table
            dataGridView1.RowHeadersVisible = false;

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

            if (person != null && person.UserType == 1)
            {
                tabControl1.TabPages.Remove(tabLogin);
                tabControl1.TabPages.Add(tabAssignments);
                tabControl1.TabPages.Add(tabHomeworks);
                    List<String> strings = new List<string>();
                    list = winService.GetAllAssignmentsForTeacherById(person.Id);
                    foreach (Object o in list.Asl)
                    {
                        Assignment a = (Assignment)o;
                        strings.Add(a.title);

                    }
                //creates new data and replaces the data in drop down list
                    DataSet ds = new DataSet();
                    BindingSource bs = new BindingSource();
                    bs.DataSource = strings;
                    comboBox1.DataSource = bs;
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBox1.SelectedIndex;
            Object o = list.Asl.ElementAt(index);
            Assignment a = (Assignment)o;
            int assignmentIndex = a.Id;
            Service1Client winService = new Service1Client();
            ListForObjects hl = winService.GetAllHomeworksById(assignmentIndex);
            List<Homework> homeworks = new List<Homework>();
            foreach (Object ob in hl.Asl)
            {
                Homework h = (Homework)ob;
                homeworks.Add(h);
                
            }
            //makes a new List with two attributes of childs name and the path
            //To avoid makeing a new wrapper and instead of child objects address it displays its name
            List<Tuple<string, string>> nameList = new List<Tuple<string, string>>();
            foreach(Homework hmw in homeworks)
            {
                nameList.Add(new Tuple<string, string>(hmw.Child.Name, hmw.DiskName));
            }
            //If there are columns it removes the last button column so that the other columns
            //don't lose their indexes after data change
            if (dataGridView1.Columns.Count > 0)
            {
                dataGridView1.Columns.Remove("Download");
            }
            //Creates new data and replaces the data in the table
            DataSet ds = new DataSet();
            BindingSource bs = new BindingSource();
            bs.DataSource = nameList;
            dataGridView1.DataSource = bs;
            dataGridView1.Columns[0].HeaderText = "Name";
            dataGridView1.Columns[1].HeaderText = "Path";


            //Adds the button column as the last column
            DataGridViewButtonColumn btnCol = new DataGridViewButtonColumn();
            btnCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            btnCol.Text = "Download";
            btnCol.Name = "Download";
            btnCol.UseColumnTextForButtonValue = true;
            btnCol.HeaderText = "Download";
            dataGridView1.Columns.Add(btnCol);
            
        }
    }
}
