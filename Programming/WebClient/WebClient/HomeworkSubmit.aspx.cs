using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebClient
{
    public partial class HomeworkSubmit : System.Web.UI.Page
    {
        string diskName = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (LogIn.pers == null)
            {
                Response.Redirect("LogIn.aspx");
            } 
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string userName = "admin";
            string fileExtension = System.IO.Path.GetExtension(FileUpload1.FileName);
            string fileName = Guid.NewGuid().ToString();
            string newFileName = fileName + fileExtension;
            string directoryName = Server.MapPath(userName);
            if (!System.IO.Directory.Exists(directoryName))
            {
                System.IO.Directory.CreateDirectory(directoryName);
            }
            diskName = System.IO.Path.Combine(userName, newFileName);
            diskName = Server.MapPath(diskName);
            string friendlyName = FileUpload1.FileName;
            int size = FileUpload1.FileBytes.Length;
            //save on disk
            //save in database
            //save user id in database
            FileUpload1.SaveAs(diskName);

            SaveToDatabase();

        }

        private int SaveToDatabase()
        {
            int childId = LogIn.pers.Id;
            int assignmentId = 1;
            DateTime date = DateTime.Now;

            WCFWebReference.Service1Client client = new WCFWebReference.Service1Client();

            return client.SubmitHomework(childId, assignmentId, date, diskName);
        }
    }
}