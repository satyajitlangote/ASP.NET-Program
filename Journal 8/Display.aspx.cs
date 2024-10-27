using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Display : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["Name"] != null && Session["Age"] != null)
        {
            lblName.Text = Session["Name"].ToString();
            lblAge.Text = Session["Age"].ToString();
        }
        else
        {
            lblName.Text = "No data in session";
            lblAge.Text = "No data in session";
        }
    }
}