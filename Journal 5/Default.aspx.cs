using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("~/Image/src.webp");
    }
    protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    {
       
        
            Label1.Text="Date of Birth:"+Calendar1.SelectedDate.ToString();
        
    }
    protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
    {
        
        if (RadioButton1.Checked)
        {
            Label2.Text = RadioButton1.Text;
        }
        else if(RadioButton2.Checked)
        {
            Label2.Text=RadioButton2.Text;
        }
        else if (RadioButton3.Checked)
        {
            Label2.Text = RadioButton3.Text;
        }
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Label3.Text="Name:-"+TextBox1.Text;
    }
    protected void ImageButton1_Click1(object sender, ImageClickEventArgs e)
    {

    }
}