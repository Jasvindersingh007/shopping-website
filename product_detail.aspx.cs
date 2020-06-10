using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Web.Configuration;
using System.Data;
using System.Windows.Forms;

public partial class product_detail : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
    int id;
    private SqlDataReader verify;
    private SqlDataReader veerify;


    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["id"] == null)
        {
            Response.Redirect("index.aspx");
        }
        else
        {
            ////loading product detail page
            id = Convert.ToInt32(Request.QueryString["id"].ToString());
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from product where product_id=" + id + "";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            d1.DataSource = dt;
            d1.DataBind();

            con.Close();
            /////loading completed



        }
    }


    protected void cart(object sender, EventArgs e)
    {

        SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["connectionstring"].ConnectionString);

        /////geting user id of th user loding in 
        String user = Session["Email"].ToString();
        con.Open();

        SqlCommand cmddd = new SqlCommand("select * from [user] where email='" + user + "'", con);
        Session["userid"] = cmddd.ExecuteScalar();
        con.Close();
        //////storing user_id in value session


        String userid = Session["userid"].ToString();
        String pid = Request.QueryString["id"];
        String date = DateTime.Today.ToString();

        con.Open();
        string str = "select * from cart join product on cart.product_id = product.product_id where cart.user_id='" + userid + "' AND cart.product_id='" + pid + "' ";
        SqlCommand cmd = new SqlCommand(str,con);
        veerify = cmd.ExecuteReader();
        if (veerify.Read())
        {
          //  string data = veerify[0].ToString();
          //  MessageBox.Show(data);
            con.Close();
            con.Open();
            
            int qty = Int32.Parse(DropDownList1.Text);
            String selectqty = "select cart.qty from cart join product on cart.product_id = product.product_id where cart.user_id='" + userid + "' AND cart.product_id='"+ pid +"' ";
            SqlCommand ccmd = new SqlCommand(selectqty, con);
            int k = Convert.ToInt32(ccmd.ExecuteScalar().ToString());
            int incement = k + qty;

            String getcartid = "select cart.cart_id from cart join product on cart.product_id = product.product_id where cart.user_id='" + userid + "' AND cart.product_id='" + pid + "' ";
            SqlCommand ccd = new SqlCommand(getcartid, con);
            int cartid = Convert.ToInt32(ccd.ExecuteScalar().ToString());
            
            String update = "update cart set qty= '" + incement + "' where cart.cart_id='" + cartid + "' ";
            SqlCommand cmmd = new SqlCommand(update, con);
            int p = cmmd.ExecuteNonQuery();
            if (p != 0)
            {
                MessageBox.Show("update");
                Response.Redirect("cart.aspx");
                
//                Response.Redirect(Request.RawUrl);// used to refresh / reload page
            }
            con.Close();

            
        }
        else
        {

            con.Close();
            con.Open();
            string qty = DropDownList1.Text;
            String query = "insert into [cart](user_id, qty, product_id,date) values('" + userid + "','" + qty + "','" + pid + "','" + date + "')";
            SqlCommand cmmd = new SqlCommand(query, con);
            //con.Open();
            int k = cmmd.ExecuteNonQuery();
            if (k != 0)
            {
                //Label3.Text = "Record Inserted Succesfully into the Database";
                // Label3.ForeColor = System.Drawing.Color.CornflowerBlue;
                MessageBox.Show("new product added now you are being retrived to ***Cart page***");
                Response.Redirect("cart.aspx");
            }
            con.Close();
        }
        con.Close();
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        String user = Session["Email"].ToString();
        con.Open();

        SqlCommand cmddd = new SqlCommand("select * from [user] where email='" + user + "'", con);
        Session["userid"] = cmddd.ExecuteScalar();
        con.Close();
        //////storing user_id in value session


        String userid = Session["userid"].ToString();
        String pid = Request.QueryString["id"];
        String date = DateTime.Today.ToString();



        con.Open();
        SqlCommand cmd = new SqlCommand("select * from cart join product on cart.product_id = product.product_id where cart.user_id='" + userid + "' AND cart.product_id='"+ pid +"' ",con);
        verify = cmd.ExecuteReader();
        if (verify.Read())
        {
            MessageBox.Show("update");
        }
        else
        {
            MessageBox.Show("insert");
        }
        con.Close();
    }


    
}