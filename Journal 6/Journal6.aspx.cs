using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Journal2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (FileUpload1.HasFile)
        {
            String fnm = FileUpload1.FileName;
            String ext = System.IO.Path.GetExtension(fnm).ToString();
            if (ext == ".jpg" || ext == ".jpeg" || ext == ".png" || ext == ".gif")
            {
                FileUpload1.SaveAs(Server.MapPath("~//uploads//") + fnm.ToString());
                Image1.ImageUrl = ("~//uploads//") + fnm.ToString();
                Label1.Text = "File Uploaded Successfully";
            }
            else
                Label1.Text = "You have chosen Wrong File";
        }
        else
            Label1.Text = "Please select File";
    }
}