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
        RangeValidator1.MinimumValue = DateTime.Now.AddYears(-48).ToShortDateString();
        RangeValidator1.MaximumValue = DateTime.Now.AddYears(-18).ToShortDateString();
    }
    protected void TextBox2_TextChanged(object sender, EventArgs e)
    {

    }
    protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
    {
        int len = args.Value.Length;
        if (len >= 8 && len <= 10)
            args.IsValid = true;
        else
            args.IsValid = false;
    }
    protected void TextBox6_TextChanged(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {

    }
    protected void CustomValidator1_ServerValidate1(object source, ServerValidateEventArgs args)
    {
       
    }
}