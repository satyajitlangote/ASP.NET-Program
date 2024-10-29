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
    SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\Rahul\Journal 12\App_Data\Database.mdf;Integrated Security=True");
                                           
    protected void Page_Load(object sender, EventArgs e)
    {
        RangeValidator1.MinimumValue = DateTime.Now.AddYears(-45).ToShortDateString();
        RangeValidator1.MaximumValue = DateTime.Now.AddYears(-18).ToShortDateString();
    }
    protected void TextBox10_TextChanged(object sender, EventArgs e)
    {

    }
    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }
    protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
    {
        int len = args.Value.Length;
        if (len > 0 && len <= 9)
            args.IsValid = true;
        else
            args.IsValid = false;
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlCommand cmd = new SqlCommand("Insert into student(fname,mname,lname,dob,city,state,country,pincode,email,mobile,course)values(@fname,@mname,@lname,@dob,@city,@state,@country,@pincode,@email,@mobile,@course)", con);
        cmd.Parameters.AddWithValue("@fname", TextBox1.Text);
        cmd.Parameters.AddWithValue("@mname", TextBox2.Text);
        cmd.Parameters.AddWithValue("@lname", TextBox3.Text);
        cmd.Parameters.AddWithValue("@dob", TextBox4.Text.ToString());
        cmd.Parameters.AddWithValue("@city", TextBox5.Text);
        cmd.Parameters.AddWithValue("@state", TextBox6.Text);
        cmd.Parameters.AddWithValue("@country", TextBox7.Text);
        cmd.Parameters.AddWithValue("@pincode", TextBox8.Text);
        cmd.Parameters.AddWithValue("@email", TextBox9.Text);
        cmd.Parameters.AddWithValue("@mobile", TextBox10.Text);
        string course = string.Empty;
        if (RadioButton1.Checked)
        {
            course = RadioButton1.Text;
        }
        else if (RadioButton2.Checked)
        {
            course = RadioButton2.Text;
        }
        else if (RadioButton3.Checked)
        {
            course = RadioButton3.Text;
        }
        else if (RadioButton4.Checked)
        {
            course = RadioButton4.Text;
        }
        else if (RadioButton5.Checked)
        {
            course = RadioButton5.Text;
        }
        else
        {
            Response.Write("Please select a course");
        }
        cmd.Parameters.AddWithValue("@course", course);
        con.Open();
       
        Label6.Text = "Registered Successfully";
        con.Close();
    }
    protected void TextBox4_TextChanged(object sender, EventArgs e)
    {

    }
}