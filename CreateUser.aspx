<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CreateUser.aspx.cs" Inherits="CreateUser" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
     UserId&nbsp;&nbsp; :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="UserId" runat="server" Text=""></asp:TextBox><br />
    Password:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; : <asp:TextBox ID="Password" runat="server" Text=""></asp:TextBox><br />
    <asp:Button ID="Submit" runat="server" Text="Submit" OnClick="Submit_Click" /><br />
    <asp:Label ID="Msg" runat="server" Text=""></asp:Label>
    </div>
    </form>
</body>
</html>
