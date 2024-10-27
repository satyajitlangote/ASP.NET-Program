using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class _Default : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(@" Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\RAHUL\JOURNAL 10\APP_DATA\DATABASE.MDF;Integrated Security=True");
    
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btninsert_Click(object sender, EventArgs e)
    {
        SqlCommand cmd = new SqlCommand("Insert into Medical(CustomerName,mobileno,Bloodgrp,Address)values(@CustomerName,@mobileno,@Bloodgrp,@Address)", con);
        
        //cmd.Parameters.AddWithValue("@Id",TextBox1.Text);
        cmd.Parameters.AddWithValue("@CustomerName", TextBox2.Text);
        cmd.Parameters.AddWithValue("@mobileno", TextBox3.Text);
        cmd.Parameters.AddWithValue("@Bloodgrp", TextBox4.Text);
        cmd.Parameters.AddWithValue("@Address", TextBox5.Text);
        con.Open();
        Label6.Text = cmd.ExecuteNonQuery().ToString();
        con.Close();
    }
    protected void btnupdate_Click(object sender, EventArgs e)
    {


    }
}