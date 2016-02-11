<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MasterPage.aspx.cs" Inherits="MasterPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button ID="Reserve" runat="server" Text="Reserve" style="width: 89px" OnClick="Reserve_Click" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Cancel" runat="server" Text="Cancel" OnClick="Cancel_Click" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Update" runat="server" Text="Upadate" OnClick="Update_Click" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Standing" runat="server" Text="Standing"  Enabled="false" OnClick="Standing_Click" />
        <br />
        <h2>
            Welcome to Club Baist 
        </h2>
    </div>
    </form>
</body>
</html>
