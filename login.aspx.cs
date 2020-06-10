using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Configuration;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

public partial class login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Login_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["connectionstring"].ConnectionString);
            con.Open();
            SqlCommand scmd = new SqlCommand("select count (*) as cnt from [user] where email=@email and password=@pwd", con);

            scmd.Parameters.AddWithValue("email", Email.Text);
            scmd.Parameters.AddWithValue("pwd", pass.Text);


            if (scmd.ExecuteScalar().ToString() == "1")
            {
                //MessageBox.Show("YOU ARE GRANTED WITH ACCESS");
                Session["Email"] = Email.Text;
                Response.Redirect("index.aspx");


            }

            else
            {
                MessageBox.Show("YOU ARE NOT GRANTED WITH ACCESS");
                Response.Redirect("register.aspx");


            }


            con.Close();
    }
}