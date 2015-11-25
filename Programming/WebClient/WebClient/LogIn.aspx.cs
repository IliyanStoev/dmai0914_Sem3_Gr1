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
        public static Person pers;

        protected void Page_Load(object sender, EventArgs e)
        {
            

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Service1Client service = new WCFWebReference.Service1Client();
           
            
            string userName = UserNameTB.Text;
            string password = UserPasswordTB.Text.GetHashCode().ToString();
            
            pers = service.Login(userName, password);
            
           if (pers!=null) 
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