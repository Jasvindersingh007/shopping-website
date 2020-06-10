using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Web.Configuration;
using System.Data;
//using System.Windows.Forms;



public partial class cart : System.Web.UI.Page
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
            //cmd.CommandText = "SELECT        cart.*, product.* FROM            cart INNER JOIN product ON cart.product_id = product.product_id";
            cmd.CommandText = "select *,(price * qty) as itemtotal from cart join product on cart.product_id = product.product_id where cart.user_id='" + userid + "' ";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            Repeater1.DataSource = dt;
            Repeater1.DataBind();
            
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


        }
        else
        {
            //MessageBox.Show("you need to loign to add to your cart");            
        } 






    } //page-load


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


    
    protected void remove(object sender, EventArgs e)
    {
        int customerId = int.Parse(((sender as LinkButton).NamingContainer.FindControl("Label1") as Label).Text);
        //string customerId = ((sender as LinkButton).NamingContainer.FindControl("Label1") as Label).Text;
        
        SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["connectionstring"].ConnectionString);
        con.Open();
        String query = "delete from cart where product_id='" + customerId + "' ";
        SqlCommand cmd = new SqlCommand(query, con);
        
        //cmd.ExecuteNonQuery();
        int k = cmd.ExecuteNonQuery();
        if (k != 0)
        {
            //Label3.Text = "Record Inserted Succesfully into the Database";
            //Label3.ForeColor = System.Drawing.Color.CornflowerBlue;
            //MessageBox.Show("product deleted");
            Response.Redirect(Request.RawUrl);// used to refresh / reload page
        }
        con.Close();

    }
    protected void update(object sender, EventArgs e)
    {
        int productId = int.Parse(((sender as LinkButton).NamingContainer.FindControl("Label1") as Label).Text);
        //string customerId = ((sender as LinkButton).NamingContainer.FindControl("Label1") as Label).Text;

        SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["connectionstring"].ConnectionString);

        String query = "delete from cart where product_id='" + productId + "' ";
        SqlCommand cmd = new SqlCommand(query, con);
        con.Open();
        //cmd.ExecuteNonQuery();
        int k = cmd.ExecuteNonQuery();
        if (k != 0)
        {
            //Label3.Text = "Record Inserted Succesfully into the Database";
            //Label3.ForeColor = System.Drawing.Color.CornflowerBlue;
            //MessageBox.Show("product deleted");
            Response.Redirect(Request.RawUrl);// used to refresh / reload page
        }
        con.Close();

    }
    protected void plus(object sender, EventArgs e)
    {
        int cartid = int.Parse(((sender as LinkButton).NamingContainer.FindControl("Label2") as Label).Text);
        SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["connectionstring"].ConnectionString);
        con.Open();

        String query = "select qty from cart where cart_id='" + cartid + "' ";
        SqlCommand cmd = new SqlCommand(query, con);
        int k = Convert.ToInt32(cmd.ExecuteScalar().ToString());
        int incement = k + 1;
        String update = "update cart set qty= '" + incement + "' where cart_id='" +cartid+ "'";
        SqlCommand cmmd = new SqlCommand(update, con);
       
        int p = cmmd.ExecuteNonQuery();
        if (p != 0)
        {
            Response.Redirect(Request.RawUrl);// used to refresh / reload page
        }
        con.Close();


    }

    protected void minus(object sender, EventArgs e)
    {
        
        int cartid = int.Parse(((sender as LinkButton).NamingContainer.FindControl("Label2") as Label).Text);
        SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["connectionstring"].ConnectionString);
        con.Open();

        String query = "select qty from cart where cart_id='" + cartid + "' ";
        SqlCommand cmd = new SqlCommand(query, con);
        int k = Convert.ToInt32(cmd.ExecuteScalar().ToString());
        if (k <= 1)
        {
            String del = "delete from cart where cart_id='" + cartid + "' ";
            SqlCommand d = new SqlCommand(del, con);
            int p =  d.ExecuteNonQuery();
            if (p != 0)
            {
                Response.Redirect(Request.RawUrl);// used to refresh / reload page
            }
        }
        else
        {

            int incement = k - 1;
            String update = "update cart set qty= '" + incement + "' where cart_id='" + cartid + "'";
            SqlCommand cmmd = new SqlCommand(update, con);

            int p = cmmd.ExecuteNonQuery();
            if (p != 0)
            {
                Response.Redirect(Request.RawUrl);// used to refresh / reload page
            }
        }
        con.Close();

    }
}