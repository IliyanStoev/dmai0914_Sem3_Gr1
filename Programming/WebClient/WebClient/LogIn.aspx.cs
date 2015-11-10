using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebClient.WCFWebReference;

namespace WebClient
{
    public partial class LogIn : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Service1Client service = new WCFWebReference.Service1Client();
            string userName = TextBox1.Text;
            string password = TextBox2.Text;
           bool LoggedIn = service.Login(userName, password);
           if (LoggedIn) 
           {
               Response.Redirect("Default.aspx");
           }
           else
           {
               Response.Redirect("kur");
           }
           
        }
    }
}