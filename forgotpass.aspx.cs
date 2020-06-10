using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Drawing;
using System.Net;
using System.Net.Mail;
using System.Web.Configuration;

public partial class forgotpass : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void send(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
        con.Open();
        SqlCommand cmd = con.CreateCommand();
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = "select email, password from [user] where email='" + Email.Text + "'";
        
        SqlDataReader sdr = cmd.ExecuteReader();
        if (sdr.Read())
        {
            string username = sdr["email"].ToString();
            string password = sdr["password"].ToString();

            MailMessage mm = new MailMessage("321yoyosingh@gmail.com", Email.Text);
            mm.Subject = "Your Password !";
            mm.Body = string.Format("hello: your Email_id is <h1>{0} </h1><br/> Your Password is <h1>{1}<h1/>", username, password);
            mm.IsBodyHtml = true;
            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.EnableSsl = true;
            NetworkCredential nc = new NetworkCredential();
            nc.UserName = "321yoyosingh@gmail.com";
            nc.Password = "gmail@password";
            smtp.UseDefaultCredentials = true;
            smtp.Credentials = nc;
            smtp.Port = 587;
            smtp.Send(mm);
            Label1.Text = "your password is sent to " + Email.Text;
            Label1.ForeColor = Color.Green;
        }
        else
        {
            Label1.Text = "wrong email " + Email.Text;
            Label1.ForeColor = Color.Red;
        }    
    }
}