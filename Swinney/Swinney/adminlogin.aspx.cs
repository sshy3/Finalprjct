using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data.SqlClient;
using System.Configuration;

namespace Swinney
{
    public partial class adminlogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Submit(object sender, EventArgs e)
        {
            string userid = name.Text;
            string password1 = password.Text;
            swinney.login1 s1 = new swinney.login1();
            int a = s1.student_login(userid,password1);
            
            if (a == 1)
            {
               

                Session["userid"] = userid;
                Label3.Text = "Login successful";
                Response.Redirect("adminhome.aspx");

            }
            else
            {
               
                Label3.Text = "Login Failed";
            }
            
           
            
        }
    }
}