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
public partial class admin_addproduct : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["connectionstring"].ConnectionString);
        f1.SaveAs(Server.MapPath("imagepath/" + f1.FileName)); //will save in imagepath folder under admin
        //f1.SaveAs(Server.MapPath("~/imagepath/" + f1.FileName)); //will save in imagespath folder
        string link = "imagepath/" + Path.GetFileName(f1.PostedFile.FileName);

        String query = "insert into [product](product_id,product_name,stock,price,old_price,imagename) values('" + pro_id.Text + "','" + pro_name.Text + "','" + stock.Text + "','" + price.Text + "','" + old_price.Text + "','" + link + "')";
        SqlCommand cmd = new SqlCommand(query, con);
        con.Open();
        //cmd.ExecuteNonQuery();
        int k = cmd.ExecuteNonQuery();
        if (k != 0)
        {
            //Label3.Text = "Record Inserted Succesfully into the Database";
            //Label3.ForeColor = System.Drawing.Color.CornflowerBlue;
            MessageBox.Show("new product added");
            Response.Redirect("addproduct.aspx");
        }
        con.Close();


    }
}