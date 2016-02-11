<%@ Page Language="C#" AutoEventWireup="true" CodeFile="LoginRequest.aspx.cs" Inherits="LoginRequest" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    UserId&nbsp;&nbsp; : <asp:TextBox ID="UserId" runat="server" Text=""></asp:TextBox><br />
    Password:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; : <asp:TextBox ID="Password" runat="server" Text=""></asp:TextBox><br />
    <asp:Button ID="Submit" runat="server" Text="Submit" OnClick="Submit_Click" /><br />
    </form>
</body>
</html>
