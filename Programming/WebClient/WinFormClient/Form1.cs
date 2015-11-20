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
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Service1Client winService = new WinformReference.Service1Client();
            string subject = tbSubject.Text;
            string title = tbAssTitle.Text;
            string exercise = tbExercise.Text;
            DateTime date = datePick.Value;
            DateTime deadline = deadlinePick.Value;


            winService.CreateAssignment(1, subject, title, exercise, date, deadline);
        }

        
    }
}
