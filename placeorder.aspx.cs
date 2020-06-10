using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Web.Configuration;
using System.Data;

public partial class placeorder : System.Web.UI.Page
{
    string str;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["Email"] != null)
        {
            SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["connectionstring"].ConnectionString);
            con.Open();

            String email = Session["Email"].ToString();

            SqlCommand cmdd = new SqlCommand("select * from [user] where email='" + email + "'", con);
            Session["userid"] = cmdd.ExecuteScalar();//storing userid in seesion from above query

            String userid = Session["userid"].ToString();//coverting session to string

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            
            cmd.CommandText = "select *,(price * qty) as itemtotal from cart join product on cart.product_id = product.product_id where cart.user_id='" + userid + "' ";
            cmd.ExecuteNonQuery();
            DataTable dtt = new DataTable();
            SqlDataAdapter daa = new SqlDataAdapter(cmd);
            daa.Fill(dtt);
            Repeater2.DataSource = dtt;
            Repeater2.DataBind();
            //Session["total"] = cmd.ExecuteScalar();
            //Label3.Text = Session["total"].ToString();

            cmd.CommandText = "select count(*) from cart join product on cart.product_id = product.product_id where cart.user_id='" + userid + "' ";
            object count = cmd.ExecuteScalar();

            //count = count + 1;
            Label50.Text = count.ToString();

            cmd.CommandText = "select [user].address from cart join [user] on cart.user_id = [user].user_id where cart.user_id='" + userid + "' ";
            //string a = cmd.ExecuteScalar().ToString();
            //Address.Text = cmd.ExecuteScalar().ToString();
            //MessageBox.Show(a);
            Label1.Text = cmd.ExecuteScalar().ToString();
        }
        else
        {
            System.Windows.Forms.MessageBox.Show("you need to loign to add to your cart");            
        } 


    }//page load


    public string grandtotal()
    {
        int a = 10;

        SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
        con.Open();

        String email = Session["Email"].ToString();
        SqlCommand cmdd = new SqlCommand("select * from [user] where email='" + email + "'", con);
        Session["userid"] = cmdd.ExecuteScalar();//storing userid in seesion from above query

        String userid = Session["userid"].ToString();//coverting session to string

        SqlCommand cmd = con.CreateCommand();
        cmd.CommandType = CommandType.Text;
        //cmd.CommandText = "SELECT        cart.*, product.* FROM            cart INNER JOIN product ON cart.product_id = product.product_id";
        cmd.CommandText = "select * from cart join product on cart.product_id = product.product_id where cart.user_id='" + userid + "' ";
        int k = cmd.ExecuteNonQuery();
        if (k != 0)
        {

            str = "select sum((price * qty)) as grandtotal from cart join product on cart.product_id = product.product_id where cart.user_id='" + userid + "' ";

            SqlCommand ccmd = new SqlCommand(str, con);

            string Total = ccmd.ExecuteScalar().ToString();

            con.Close();

            con.Dispose();

            ccmd.Dispose();

            return Total;

        }
        return Convert.ToString(a);

    }

    protected void submit(object sender, EventArgs e)
    {
        
        System.Windows.Forms.MessageBox.Show("hello");            
    }
    protected void hello(object sender, EventArgs e)
    {

        System.Windows.Forms.MessageBox.Show("hello");
    }

}