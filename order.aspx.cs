using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Web.Configuration;
using System.Data;
using System.Windows.Forms;

public partial class order : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
            SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["connectionstring"].ConnectionString);
            con.Open();

            String email = Session["Email"].ToString();
            
            SqlCommand cmdd = new SqlCommand("select * from [user] where email='" + email + "'", con);
            Session["userid"] = cmdd.ExecuteScalar();//storing userid in seesion from above query

            String userid = Session["userid"].ToString();//coverting session to string
            
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            //cmd.CommandText = "SELECT        cart.*, product.* FROM            cart INNER JOIN product ON cart.product_id = product.product_id";
            cmd.CommandText = "select [user].address from cart join [user] on cart.user_id = [user].user_id where cart.user_id='" + userid + "' ";
            //string a = cmd.ExecuteScalar().ToString();
            //Address.Text = cmd.ExecuteScalar().ToString();
            //MessageBox.Show(a);
            Label1.Text = cmd.ExecuteScalar().ToString();
            con.Close();
    }//pageload
    protected void update(object sender, EventArgs e)
    {
        if(Address.Text != "" )
        {
            SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["connectionstring"].ConnectionString);
        con.Open();
        String email = Session["Email"].ToString();

        SqlCommand cmdd = new SqlCommand("select * from [user] where email='" + email + "'", con);
        Session["userid"] = cmdd.ExecuteScalar();//storing userid in seesion from above query

        string userid = Session["userid"].ToString();//coverting session to string
        string updatedAddress = Address.Text;
        string update = "update [user] set address='" + updatedAddress + "' where user_id='" + userid + "' ";
        SqlCommand cmmd = new SqlCommand(update, con);
        int p = cmmd.ExecuteNonQuery();
        if (p != 0)
        {
            //MessageBox.Show("update");
            Response.Redirect("placeorder.aspx");

            //Response.Redirect(Request.RawUrl);// used to refresh / reload page
        }
        con.Close();
        }//if
        else
        {

            //MessageBox.Show("else");
            Response.Redirect("placeorder.aspx");

        }//esle

    }//update

   
}//main
