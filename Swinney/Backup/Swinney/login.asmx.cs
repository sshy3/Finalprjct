using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data.SqlClient;
using System.Configuration;

namespace Swinney
{
    /// <summary>
    /// Summary description for login1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class login1 : System.Web.Services.WebService
    {

        [WebMethod]
        public int student_login(string userid, string password)
        {
            try
            {
                
                //Declare Connection by passing the connection string from the web config file
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["dbString"].ConnectionString);
                //Open the connection
                conn.Open();
                //Declare the sql command
               
                    SqlCommand cmd1 = new SqlCommand("select count(*) from login where userid = '" + userid + "' and password= '" + password + "'", conn);
                    int validation = Convert.ToInt16(cmd1.ExecuteScalar());
                    if (validation != 0)
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                    cmd1.Dispose();
                    conn.Close();
                
            }
            catch (Exception e)
            {
                return -1;
            }
        }
    }
}
