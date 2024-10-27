using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Journal8 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        String unm = TextBox1.Text;
        String pass = TextBox2.Text;
        if (unm == "Abhishek" && pass == "abhigote@444")
            Server.Transfer("success.aspx");
        else
            Response.Redirect("failure.aspx");
    }
    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }
}