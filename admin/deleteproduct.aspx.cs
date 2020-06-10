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
using System.IO;

public partial class admin_deleteproduct : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //pro_id.Text = "";
        //pro_name.Text = "";
        SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
        con.Open();
        SqlCommand view = con.CreateCommand();
        view.CommandType = CommandType.Text;
        view.CommandText = "SELECT * FROM product";
        view.ExecuteNonQuery();
        DataTable dt = new DataTable();
        SqlDataAdapter da = new SqlDataAdapter(view);
        da.Fill(dt);
        GridView1.DataSource = dt;
        GridView1.DataBind();
        con.Close();


    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["connectionstring"].ConnectionString);

        String query = "delete from product where product_id='" + pro_id.Text + "' OR product_name='" + pro_name.Text +"' ";
        SqlCommand cmd = new SqlCommand(query, con);
        con.Open();
        //cmd.ExecuteNonQuery();
        int k = cmd.ExecuteNonQuery();
        if (k != 0)
        {
            //Label3.Text = "Record Inserted Succesfully into the Database";
            //Label3.ForeColor = System.Drawing.Color.CornflowerBlue;
            MessageBox.Show("product deleted");
           //Response.Redirect("addproduct.aspx");
        }
        con.Close();

        
    }
}