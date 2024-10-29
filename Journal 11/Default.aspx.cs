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
    SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\RAHUL\JOURNAL 11\APP_DATA\DATABASE.MDF;Integrated Security=True");
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            PopGrid();
        }
    }
    void PopGrid()
    {
        
        SqlCommand cmd = new SqlCommand("Select * From Student Order By StudentName desc", con);
        
        
        GridView1.DataBind();
        con.Close();
    }
    protected void btninsert_Click(object sender, EventArgs e)
    {
        SqlCommand cmd = new SqlCommand("Insert into Student(StudentName,Mobileno,Address,DOB)values(@StudentName,@Mobileno,@Address,@DOB)", con);
        //cmd.Parameters.AddWithValue("@Id",TextBox1.Text);
        cmd.Parameters.AddWithValue("@StudentName", TextBox2.Text);
        cmd.Parameters.AddWithValue("@Mobileno", TextBox3.Text);
        cmd.Parameters.AddWithValue("@Address", TextBox4.Text);
        cmd.Parameters.AddWithValue("@DOB", TextBox5.Text);

        con.Open();
        Label6.Text = cmd.ExecuteNonQuery().ToString();
        con.Close();
    }
    
    protected void btnupdate_Click(object sender, EventArgs e)
    {
        SqlCommand cmd = new SqlCommand("update Student set StudentName=@StudentName, Mobileno=@Mobileno, Address=@Address, DOB=@DOB  where ID=@Id", con);
        cmd.Parameters.AddWithValue("@Id", TextBox1.Text);
        cmd.Parameters.AddWithValue("@StudentName", TextBox2.Text);
        cmd.Parameters.AddWithValue("@Mobileno", TextBox3.Text);
        cmd.Parameters.AddWithValue("@Address", TextBox4.Text);
        cmd.Parameters.AddWithValue("@DOB", TextBox5.Text);
        con.Open();
        Label6.Text = "Record Updated Successfully";
        Label6.Text = cmd.ExecuteNonQuery().ToString();
        con.Close();
        PopGrid();
    }
    protected void btndelete_Click(object sender, EventArgs e)
    {
        SqlCommand cmd = new SqlCommand("Delete From Student where Id=@Id", con);
        cmd.Parameters.AddWithValue("@Id", TextBox1.Text);
        con.Open();
        Label6.Text = cmd.ExecuteNonQuery().ToString();
        Label6.Text = "Record Deleted successfully";
        con.Close();
        PopGrid();
    }
    protected void btnsearch_Click(object sender, EventArgs e)
    {
        SqlCommand cmd = new SqlCommand("Select * from Student Where Id=@Id", con);
        cmd.Parameters.AddWithValue("@Id", TextBox1.Text);
        con.Open();
        SqlDataReader dr = cmd.ExecuteReader();
        if (dr.Read())
        {
            TextBox2.Text = dr["StudentName"].ToString();
            TextBox3.Text = dr["MobileNo"].ToString();
            TextBox4.Text = dr["Address"].ToString();
            TextBox5.Text = dr["DOB"].ToString();
            Label6.Text = "Record Found";
        }
        else
        {
            TextBox2.Text = " ";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
            Label6.Text = "Record Not Found";
        }
    }
}