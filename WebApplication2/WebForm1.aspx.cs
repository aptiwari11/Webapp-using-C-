using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
namespace WebApplication2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == true)
            {
                lblmsg.Text = "Record Inserted Succesfully into the Database";
                lblmsg.ForeColor = System.Drawing.Color.CornflowerBlue;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=Anand\SQLExpress;Initial Catalog=CUSTOMER;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("INSERT INTO CUSTOMER(ID, NAME, DESCRIPTION, EMAIL, DOB) VALUES(@ID,@NAME,@DESCRIPTION,@EMAIL,@DOB)", con);

            cmd.Parameters.AddWithValue("@ID", TextBox1.Text);
            cmd.Parameters.AddWithValue("@NAME", TextBox2.Text);
            cmd.Parameters.AddWithValue("@DESCRIPTION", TextBox3.Text);
            cmd.Parameters.AddWithValue("@EMAIL", TextBox4.Text);
            cmd.Parameters.AddWithValue("@DOB", TextBox5.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        
       }
    }
}