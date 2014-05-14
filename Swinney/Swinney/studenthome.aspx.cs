using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data.SqlClient;
using System.Configuration;

using System.Net.Mail;


namespace Swinney
{
    public partial class studenthome : System.Web.UI.Page
    {
        string court1;
        string court2;
        string court3;
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["dbString"].ConnectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * from items", conn);
            SqlDataReader myReader = cmd.ExecuteReader();

            if (myReader.HasRows)
            {
                myReader.Read();
                TextBox2.Text = myReader["available"].ToString();
                myReader.Read();
                TextBox3.Text = myReader["available"].ToString();
                myReader.Read();
                TextBox4.Text = myReader["available"].ToString();
                myReader.Read();
                TextBox12.Text = myReader["available"].ToString();
                string court1 = myReader["available"].ToString();
                myReader.Read();
                TextBox13.Text = myReader["available"].ToString();
                string court2 = myReader["available"].ToString();
                myReader.Read();
                TextBox14.Text = myReader["available"].ToString();
                string court3 = myReader["available"].ToString();
                myReader.Read();
                TextBox5.Text = myReader["available"].ToString();
                myReader.Read();
                TextBox6.Text = myReader["available"].ToString();
                myReader.Read();
                TextBox7.Text = myReader["available"].ToString();
                myReader.Read();
                TextBox10.Text = myReader["available"].ToString();
                myReader.Read();
                TextBox11.Text = myReader["available"].ToString();
            }
            else
            {
                Console.Write("1");
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            int c1 = Convert.ToInt32(court1);
            int c2 = Convert.ToInt32(court2);
            int c3 = Convert.ToInt32(court3);
            int i = 1;
            while (i > 0)
            {
                string stdid = Session["userid"].ToString();
                string stdmail;
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["dbStrings"].ConnectionString);
                SqlCommand cmd = new SqlCommand("select mailid from maildb where studentid='" + stdid + "'", conn);
                SqlDataReader myReader = cmd.ExecuteReader();
                myReader.Read();
                stdmail = myReader["mailid"].ToString();
                cmd.ExecuteReader();


                if ((c1 > 0) || (c2 > 0) || (c3 > 0))
                {

                    MailMessage message = new MailMessage();
                    message.From = new MailAddress("sshy3@mail.umkc.edu", "Admin", System.Text.Encoding.UTF8);
                    message.Subject = "Swinney Notification";
                    message.To.Add(stdmail);
                    message.Body = "Players Left! Courts are Available";
                    message.IsBodyHtml = true;
                    message.SubjectEncoding = System.Text.Encoding.UTF8;
                    SmtpClient client = new SmtpClient();
                    client.Port = 25;
                    client.Host = "smtp.gmail.com";
                    client.EnableSsl = true;
                    client.UseDefaultCredentials = false;
                    client.Credentials = new System.Net.NetworkCredential("sshy3@mail.umkc.edu", "Ssv2014!");
                    client.Send(message);
                    return;
                }
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("home.aspx");
        }
    }
}
