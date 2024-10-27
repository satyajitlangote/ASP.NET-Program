<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Journal6.aspx.cs" Inherits="Journal2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:FileUpload ID="FileUpload1" runat="server" />
        <br />
        <br />
        <asp:Label ID="Label1" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Image ID="Image1" runat="server" BorderStyle="Solid" BorderWidth="1px" Height="234px" Width="422px" />
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Upload" />
    
    </div>
    </form>
</body>
</html>
