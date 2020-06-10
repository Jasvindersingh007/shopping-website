using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class js_cart : System.Web.UI.Page
{
    string s;
    string t;
    string[] a = new string[5];
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void displaycart(object sender, EventArgs e)
    {
        DataTable dt = new DataTable();
        dt.Columns.AddRange(new DataColumn[2] { new DataColumn("product_id"), new DataColumn("product_name") });

        if (Request.Cookies["aa"] != null)
        {
            s = Convert.ToString(Request.Cookies["aa"].Value);

            string[] strArr = s.Split('|');

            for (int i = 0; i < strArr.Length; i++)
            {
                t = Convert.ToString(strArr[i].ToString());
                string[] strArr1 = t.Split(',');
                for (int j = 0; j < strArr1.Length; j++)
                {
                    a[j] = strArr1[j].ToString();

                }
                dt.Rows.Add(a[0].ToString(), a[1].ToString());
            }

        }
        d1.DataSource = dt;
        d1.DataBind();

    }
}