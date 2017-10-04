using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.Web.Security;

namespace PlurtechTest
{
    public partial class Login : System.Web.UI.Page
    {
        protected void ValidateUser(object sender, EventArgs e)
        {
            if (Login1.UserName.ToLower() == "1" && Login1.Password == "1")
            { 
                FormsAuthentication.RedirectFromLoginPage(Login1.UserName, Login1.RememberMeSet);
                return;
            }
            else
                Login1.FailureText = "Username and/or password is incorrect.";
        }
    }
}