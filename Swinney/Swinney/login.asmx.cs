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
               
                    SqlCommand cmd1 = new SqlCommand("select count(*) from info where userid = '" + userid + "' and password= '" + password + "'", conn);
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
        [WebMethod]
       public void dataentry( string stdid, string category, string court1, string item11,string item22)
        {
 //Declare Connection by passing the connection string from the web config file
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["dbString"].ConnectionString);
            //Open the connection
            conn.Open();
            //Declare the sql command

            SqlCommand cmd2 = new SqlCommand("INSERT INTO content (studentid, category, Court, item1, item2) VALUES ('"+stdid+"', '"+category+"','"+court1+"','"+item11+"','"+item22+"')",conn);
            cmd2.ExecuteNonQuery();
            cmd2.Dispose();
            conn.Close();
    }
           [WebMethod]
        public int deletestd(string stdid)
        {
            try
            {
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["dbString"].ConnectionString);
                conn.Open();

                SqlCommand cmd1 = new SqlCommand("update items set available=available+1 where itemname=(select item1 from content where studentid='" + stdid + "')", conn);
                cmd1.ExecuteNonQuery();
                cmd1.Dispose();
                SqlCommand cmd2 = new SqlCommand("update items set available=available+1 where itemname=(select item2 from content where studentid='" + stdid + "')", conn);
                cmd2.ExecuteNonQuery();
                cmd2.Dispose();
                SqlCommand cmd3 = new SqlCommand("update items set available=available+1 where itemname=(select court from content where studentid='" + stdid + "')", conn);
                cmd3.ExecuteNonQuery();
                cmd3.Dispose();
                SqlCommand cmd4 = new SqlCommand("delete from content where studentid='" + stdid + "'", conn);
                int validation = Convert.ToInt16(cmd4.ExecuteNonQuery());
                cmd4.Dispose();
                conn.Close();
                if (validation >=1)
                { return 1; }
                else return 0;
            }
               catch(Exception e)
            {
                return -1;
            }
        }
}
}