using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Reporting;
using CrystalDecisions.Shared;
using System.IO;

public partial class _Default : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\Sanveda Dot Net Pratical\Journal 13\App_Data\Database.mdf;Integrated Security=True");
    ReportDocument rprt = new ReportDocument();
    string filepath;

    public void pdfdemo()
    {

        Response.Clear();
        filepath = Server.MapPath("~/" + "demo.pdf");
        rprt.ExportToDisk(ExportFormatType.PortableDocFormat, filepath);
        FileInfo fileinfo = new FileInfo(filepath);
        Response.AddHeader("Content-Disposition", "inline;filenam=demo.pdf");
        Response.ContentType = "application/pdf";
        Response.WriteFile(fileinfo.FullName);

    }
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        rprt.Load(Server.MapPath("~/CrystalReport.rpt"));
        rprt.FileName = Server.MapPath("~/CrystalReport.rpt");
        SqlCommand cmd = new SqlCommand("select * from Student", con);
        SqlDataAdapter sda = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        sda.Fill(ds, "Student");
        rprt.SetDataSource(ds);
        CrystalReportViewer1.ReportSource = rprt;
        CrystalReportViewer1.DataBind();
        pdfdemo();
    }
}