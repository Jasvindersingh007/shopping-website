using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class main : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["Email"] != null)
        {

            Label100.Text = Session["email"].ToString();
            loginbtn.Visible = false;
            createaccount.Visible = false;
            logoutbtn.Visible = true;
        }
        
        
        
    }
    

}
