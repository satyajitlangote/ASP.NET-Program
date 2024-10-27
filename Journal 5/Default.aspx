<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Enter Name:-<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <br />
        Select Courses:-
        <asp:RadioButton ID="RadioButton1" runat="server" GroupName="course" OnCheckedChanged="RadioButton1_CheckedChanged" Text="BCA" />
        <asp:RadioButton ID="RadioButton2" runat="server" GroupName="course" Text="BBA" />
        <asp:RadioButton ID="RadioButton3" runat="server" GroupName="course" Text="MCA" />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        Hobbies:-<asp:CheckBox ID="CheckBox1" runat="server" Text="swimming" />
        <asp:CheckBox ID="CheckBox2" runat="server" Text="playing" />
        <asp:CheckBox ID="CheckBox3" runat="server" Text="Reading" />
        <asp:CheckBox ID="CheckBox4" runat="server" Text="Listen Music" />
        <br />
        <br />
        Select Country:-<asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem>Select country</asp:ListItem>
            <asp:ListItem>India</asp:ListItem>
            <asp:ListItem>United state</asp:ListItem>
            <asp:ListItem>UK</asp:ListItem>
            <asp:ListItem>Russia</asp:ListItem>
            <asp:ListItem>Japan</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        DOB:-<asp:Calendar ID="Calendar1" runat="server" OnSelectionChanged="Calendar1_SelectionChanged" BackColor="White" BorderColor="Black" Font-Names="Verdana" Font-Size="9pt" ForeColor="Black" Height="250px" Width="330px" BorderStyle="Solid" CellSpacing="1" NextPrevFormat="ShortMonth">
            <DayHeaderStyle ForeColor="#333333" Height="8pt" Font-Bold="True" Font-Size="8pt" />
            <DayStyle BackColor="#CCCCCC" />
            <NextPrevStyle Font-Size="8pt" ForeColor="White" Font-Bold="True" />
            <OtherMonthDayStyle ForeColor="#999999" />
            <SelectedDayStyle BackColor="#333399" ForeColor="White" />
            <TitleStyle BackColor="#333399" Font-Bold="True" Font-Size="12pt" ForeColor="White" Height="12pt" BorderStyle="Solid" />
            <TodayDayStyle BackColor="#999999" ForeColor="White" />
        </asp:Calendar>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        <asp:ImageButton ID="ImageButton1" runat="server" Height="206px" ImageUrl="~/Image/445566.jpg" Width="325px" OnClick="ImageButton1_Click1" />
    
        <br />
        <br />
        <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">LinkButton</asp:LinkButton>
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
    
    </div>
    </form>
</body>
</html>
