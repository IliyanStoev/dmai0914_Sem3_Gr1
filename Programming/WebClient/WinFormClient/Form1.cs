using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using WinFormClient.WCFWebReference;



namespace WinFormClient
{
    public partial class Form1 : Form
    {
        public static Person pers;
       
         public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {


            Service1Client service = new WCFWebReference.Service1Client();
            Person pers;

            string userName = textBox1.Text;
            string password = textBox2.Text;

             pers = service.Login(userName, password);

            if (pers != null)
            {
                panel1.Visible = true;
                
            }
            else
            {
                label4.Visible = true;
            }



        }
    }
}
