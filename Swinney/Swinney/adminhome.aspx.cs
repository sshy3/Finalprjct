using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data.SqlClient;
using System.Configuration;

namespace Swinney
{
    public partial class adminhome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        SqlConnection conn=new SqlConnection(ConfigurationManager.ConnectionStrings["dbString"].ConnectionString);
        conn.Open();
        SqlCommand cmd = new SqlCommand ("SELECT * from items",conn);
        SqlDataReader myReader=cmd.ExecuteReader();

        if (myReader.HasRows)
        {
            myReader.Read();
            TextBox2.Text = myReader["available"].ToString();
            myReader.Read();
            TextBox3.Text = myReader["available"].ToString();
            myReader.Read();
            TextBox4.Text = myReader["available"].ToString();
            myReader.Read();
            TextBox9.Text = myReader["available"].ToString();
            myReader.Read();
            TextBox10.Text = myReader["available"].ToString();
            myReader.Read();
            TextBox11.Text = myReader["available"].ToString();
            myReader.Read();
            TextBox5.Text = myReader["available"].ToString();
            myReader.Read();
            TextBox6.Text = myReader["available"].ToString();
            myReader.Read();
            TextBox7.Text = myReader["available"].ToString();
            myReader.Read();
            TextBox8.Text = myReader["available"].ToString();
            myReader.Read();
            TextBox12.Text = myReader["available"].ToString();
        }
        else
        {
            Console.Write("1");
        }
       
        myReader.Close();
        conn.Close();
           }


        public void Button1_Click(object sender, EventArgs e)
        {
            string stdid = studentid.Text;
            string category = categ.SelectedItem.Value;
            string court1 = court.SelectedItem.Value;
            string item11 = item1.SelectedItem.Value;
            string item22 = item2.SelectedItem.Value;
            Swinney.login1 s1 = new Swinney.login1();
            s1.dataentry(stdid, category, court1, item11, item22);
            SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["dbString"].ConnectionString);
            conn1.Open();
            SqlCommand cmd=new SqlCommand("update items set available=available-1 where itemname='"+court1+"'",conn1);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            SqlCommand cmd1 = new SqlCommand("update items set available=available-1 where itemname='" + item11 + "'", conn1);
            cmd1.ExecuteNonQuery();
            cmd1.Dispose();
            SqlCommand cmd2 = new SqlCommand("update items set available=available-1 where itemname='" + item22 + "'", conn1);
            cmd2.ExecuteNonQuery();
            cmd2.Dispose();
            conn1.Close();
            Response.Redirect("adminhome.aspx");
            
        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {
           // Connection by passing the connection string from the web config file
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["dbString"].ConnectionString);
            //Open the connection
            conn.Open();
            //Declare the sql command

            
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string stdid = studentid.Text;
            Swinney.login1 s1 = new Swinney.login1();
            int a=s1.deletestd( stdid);
            if (a>=1)
            {
                Response.Write("<script>alert('Student Checkedout');</script>");
                Response.Redirect("adminhome.aspx");
            }
           

        }
    }
}