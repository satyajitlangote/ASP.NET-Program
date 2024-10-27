<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            height: 483px;
        }
        .auto-style4 {
            height: 23px;
        }
        .auto-style5 {
            width: 167px;
        }
        .auto-style6 {
            height: 23px;
            width: 167px;
        }
        .auto-style9 {
            height: 23px;
            width: 190px;
        }
        .auto-style10 {
            width: 190px;
        }
        .auto-style11 {
            height: 23px;
            width: 160px;
        }
        .auto-style12 {
            width: 160px;
        }
        .auto-style13 {
            height: 23px;
            width: 182px;
        }
        .auto-style14 {
            width: 182px;
        }
        .auto-style15 {
            width: 182px;
            height: 137px;
        }
        .auto-style16 {
            width: 167px;
            height: 137px;
        }
        .auto-style17 {
            width: 190px;
            height: 137px;
        }
        .auto-style18 {
            width: 160px;
            height: 137px;
        }
        .auto-style19 {
            height: 137px;
        }
        .auto-style20 {
            width: 182px;
            height: 117px;
        }
        .auto-style21 {
            width: 167px;
            height: 117px;
        }
        .auto-style22 {
            width: 190px;
            height: 117px;
        }
        .auto-style23 {
            width: 160px;
            height: 117px;
        }
        .auto-style24 {
            height: 117px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <p id="Medical System" title="Medical  System" style="font-family: 'Times New Roman', Times, serif; font-size: xx-large; font-weight: 200; font-style: normal; font-variant: normal; text-transform: capitalize; color: #800000; background-color: #FFFF00; text-align: center; word-spacing: normal; letter-spacing: normal; border: medium solid #800000">
            Medical System</p>
        <table class="auto-style1">
            <tr>
                <td class="auto-style13" style="font-family: 'Times New Roman'; font-size: x-large; font-weight: 300; font-style: normal; font-variant: normal; text-transform: capitalize; color: #000000">ID:-</td>
                <td class="auto-style6">
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style9"></td>
                <td class="auto-style11"></td>
                <td class="auto-style4"></td>
            </tr>
            <tr>
                <td class="auto-style14" style="font-family: 'Time new roman'; font-size: x-large; font-weight: 100; font-style: normal; font-variant: normal; text-transform: capitalize; color: #000000">Customer Name:-</td>
                <td class="auto-style5">
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style10">&nbsp;</td>
                <td class="auto-style12">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style14" style="font-family: 'Times New Roman', Times, serif; font-size: x-large; font-weight: 100; font-style: normal; font-variant: normal; text-transform: capitalize; color: #000000">mobile no:-</td>
                <td class="auto-style5">
                    <asp:TextBox ID="TextBox3" runat="server" TextMode="Number"></asp:TextBox>
                </td>
                <td class="auto-style10">&nbsp;</td>
                <td class="auto-style12">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style15" style="font-family: &quot;Times New Roman&quot;, Times, serif; font-size: x-large; font-weight: 100; font-style: normal; font-variant: normal">Blood Group:-<br />
                    <br />
                    <asp:Label ID="Label7" runat="server" Text="Address"></asp:Label>
                    :-</td>
                <td class="auto-style16">
                    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                    <br />
                    <br />
                    <br />
                    <asp:TextBox ID="TextBox5" runat="server" TextMode="MultiLine"></asp:TextBox>
                </td>
                <td class="auto-style17"></td>
                <td class="auto-style18"></td>
                <td class="auto-style19"></td>
            </tr>
            <tr>
                <td class="auto-style20">&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btninsert" runat="server" BackColor="White" Font-Bold="True" Font-Size="Medium" ForeColor="#CC0000" OnClick="btninsert_Click" Text="Insert" Width="148px" />
                </td>
                <td class="auto-style21">
                    <asp:Button ID="btnupdate" runat="server" BackColor="White" Font-Bold="True" Font-Size="Medium" ForeColor="#CC0000" Text="Update" Width="165px" OnClick="btnupdate_Click" />
                </td>
                <td class="auto-style22">&nbsp;&nbsp;
                    <asp:Button ID="btndelete" runat="server" BackColor="Red" Font-Bold="True" Font-Size="Medium" ForeColor="White" Text="Delete" Width="165px" />
                </td>
                <td class="auto-style23">&nbsp;<asp:Button ID="btnsearch" runat="server" BackColor="White" Font-Bold="True" Font-Size="Medium" ForeColor="#CC0000" Text="Search" Width="165px" />
                </td>
                <td class="auto-style24"></td>
            </tr>
        </table>
        <br />
        <asp:Label ID="Label6" runat="server" Text="Label"></asp:Label>
        <br />
        <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" DataKeyNames="Id" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:BoundField DataField="Id" HeaderText="Id" ReadOnly="True" SortExpression="Id" />
                <asp:BoundField DataField="CustomerName" HeaderText="CustomerName" SortExpression="CustomerName" />
                <asp:BoundField DataField="mobileno" HeaderText="mobileno" SortExpression="mobileno" />
                <asp:BoundField DataField="Bloodgrp" HeaderText="Bloodgrp" SortExpression="Bloodgrp" />
                <asp:BoundField DataField="Address" HeaderText="Address" SortExpression="Address" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [Medical]"></asp:SqlDataSource>
        <br />
    </form>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
</body>
</html>
