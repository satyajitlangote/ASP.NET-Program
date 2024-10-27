<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            height: 288px;
            background-color: #FFCC99;
        }
        .auto-style2 {
            width: 192px;
        }
        .auto-style3 {
            width: 333px;
        }
        #form1 {
            height: 289px;
        }
        .auto-style4 {
            width: 192px;
            height: 26px;
        }
        .auto-style5 {
            width: 333px;
            height: 26px;
        }
        .auto-style6 {
            height: 26px;
            width: 417px;
        }
        .auto-style7 {
            width: 417px;
        }
    </style>
</head>
<body style="width: 1084px; height: 352px">
    <div style="margin-bottom: 94px">
    
    <form id="form1" runat="server" style="border: thin solid #000000; background-color: #FFCC66; width: 927px;">
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">Enter User Name :-</td>
                <td class="auto-style3">
                    <asp:TextBox ID="TextBox1" runat="server" Width="356px"></asp:TextBox>
                </td>
                <td class="auto-style7">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" Display="Dynamic" ErrorMessage="You must Enter the Name" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">Password :-</td>
                <td class="auto-style5">
                    <asp:TextBox ID="TextBox2" runat="server" OnTextChanged="TextBox2_TextChanged" Width="356px"></asp:TextBox>
                </td>
                <td class="auto-style6">
                    <asp:CustomValidator ID="CustomValidator1" runat="server" ControlToValidate="TextBox2" Display="Dynamic" ErrorMessage="*Enter Password" ForeColor="Red" OnServerValidate="CustomValidator1_ServerValidate1" ValidateEmptyText="True"></asp:CustomValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Confirm Password :-</td>
                <td class="auto-style3">
                    <asp:TextBox ID="TextBox3" runat="server" Width="356px"></asp:TextBox>
                </td>
                <td class="auto-style7">
                    <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="TextBox2" ControlToValidate="TextBox3" Display="Dynamic" ErrorMessage="Password Mismatch" ForeColor="Red" SetFocusOnError="True"></asp:CompareValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Email ID :-</td>
                <td class="auto-style3">
                    <asp:TextBox ID="TextBox4" runat="server" Width="356px"></asp:TextBox>
                </td>
                <td class="auto-style7">
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox4" Display="Dynamic" ErrorMessage="Must Enter Email" ForeColor="Red" SetFocusOnError="True" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">PIN Code :-</td>
                <td class="auto-style3">
                    <asp:TextBox ID="TextBox5" runat="server" Width="356px"></asp:TextBox>
                </td>
                <td class="auto-style7">
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="TextBox5" Display="Dynamic" ErrorMessage="Enter pin code" ForeColor="Red" SetFocusOnError="True" ValidationExpression="\d{6}"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Date of Birth :-</td>
                <td class="auto-style3">
                    <asp:TextBox ID="TextBox6" runat="server" OnTextChanged="TextBox6_TextChanged" Width="356px"></asp:TextBox>
                </td>
                <td class="auto-style7">
                    <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="TextBox6" Display="Dynamic" ErrorMessage="Date of Birth 18 to 48" ForeColor="Red" MaximumValue="18" MinimumValue="48" SetFocusOnError="True" Type="Date"></asp:RangeValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">Mobile No :-</td>
                <td class="auto-style5">
                    <asp:TextBox ID="TextBox7" runat="server" Width="356px"></asp:TextBox>
                </td>
                <td class="auto-style6">
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="TextBox7" Display="Dynamic" ErrorMessage="Mobile Number" ForeColor="Red" ValidationExpression="\d{10}"></asp:RegularExpressionValidator>
                </td>
            </tr>
        </table>
        <asp:Button ID="Button1" runat="server" Height="40px" OnClick="Button1_Click" style="margin-top: 24px" Text="Submit" BackColor="#FFCC99" BorderStyle="Solid" BorderWidth="2px" />
        <asp:ValidationSummary ID="ValidationSummary2" runat="server" ForeColor="Red" />
    </form>
    
    </div>
   
    </body>
</html>
