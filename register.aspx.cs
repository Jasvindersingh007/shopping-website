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

public partial class register : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void save(object sender, EventArgs e)
    {
        if (pwd.Text == "" || cpwd.Text == "")
        {
            MessageBox.Show("Please enter values");
            return;
        }
        if (pwd.Text != cpwd.Text)
        {
            MessageBox.Show("confirm password not matching with new passsword");
            //  S_cpwd.Focus();
            return;
        }
        SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["connectionstring"].ConnectionString);
        con.Open();
        SqlCommand cmd = new SqlCommand("userreg", con); //sp_helptext sp_text          to spect sp_text code. 
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("email", email.Text);
        cmd.Parameters.AddWithValue("pwd", pwd.Text);


        int k = cmd.ExecuteNonQuery();
        if (k != 0)
        {
            Label3.Text = "check email account and activate your account";
            Label3.ForeColor = System.Drawing.Color.CornflowerBlue;
            Response.Redirect("activation.aspx");
        }
        con.Close();
    }
}