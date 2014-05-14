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
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Submit(object sender, EventArgs e)
        {
            //Response.Redirect("reserve.aspx");
            string userid = name.Text;
            string password1 = password.Text;
            Label3.Visible = true;
            Label3.Text = "hi";
                //Declare Connection by passing the connection string from the web config file
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["dbString"].ConnectionString);
                //Open the connection
                conn.Open();
                //Declare the sql command

                SqlCommand cmd1 = new SqlCommand("select userid from login where userid = '" + userid + "' and password= '" + password1 + "'", conn);
                
            string CurrentName;
CurrentName = (string)cmd1.ExecuteScalar();
            
            
             if (CurrentName != null)
         
            {
                Label3.Text = "Login successful";
               // Session["main_name"] = name1;
               // Response.Redirect("userProfile.aspx");
            }
            else
            {
                Label3.Text = "Login Failed! Please check the login name/password !";
            }
            cmd1.Dispose();
            conn.Close(); 
            
            /*int validation = Convert.ToInt16(cmd1.ExecuteScalar());
                Label3.Visible = true;
                Label3.Text = validation.ToString();
                if (validation != 0)
                {
                    Label3.Visible = true;
                    Label3.Text = "Success";
                }
                else
                {
                    Label3.Visible = true;
                    Label3.Text = "Failed";
                }
                cmd1.Dispose();
                conn.Close();
            */
            
        }
    }
}