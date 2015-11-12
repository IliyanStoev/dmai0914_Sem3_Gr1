﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace WebClient
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (LogIn.pers != null)
            {
                userNameLi.InnerText = "Logged in as: " + LogIn.pers.Name;
                loggingLi.InnerText = "Log out";
            }
        }

        protected void loggingLi_ServerClick(object sender, EventArgs e)
        {
            if (loggingLi.InnerText.Equals("Log in"))
            {
                Response.Redirect("LogIn.aspx");
            }
            else if (loggingLi.InnerText.Equals("Log out"))
            {
                LogIn.pers = null;
                Response.Redirect("Default.aspx");
            }
        }

    }
}