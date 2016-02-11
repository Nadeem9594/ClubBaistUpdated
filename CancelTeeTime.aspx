<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CancelTeeTime.aspx.cs" Inherits="CancelTeeTime" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    &nbsp;<asp:Label ID="MemberNo" runat="server" Text="Label">

        </asp:Label><br /><asp:Label ID="MemberName" runat="server" Text=""> </asp:Label><br />
             <asp:Calendar ID="ACalendar" runat="server" ></asp:Calendar><br />
          
        <asp:Button ID="FindTeeTime" runat="server" Text="FindTime" OnClick="Button1_Click" /> 
                      
        <br />
        Your Booked&nbsp; Tee Time Are :
                  
        <asp:DropDownList ID="DropDownList3" runat="server">
        </asp:DropDownList>
                  
        <br />
        <asp:Button ID="Delete" runat="server" Text="Delete" OnClick="Delete_Click1" />
                  
       <br />
        <br />
        <br />
        Your Tee Is Booked On : <asp:Label ID="Time" runat="server" Text="Label"></asp:Label><br /> <br />
        Date :<asp:Label ID="Date1" runat="server"></asp:Label>
        <br />
        <br />
        Player 1 :<asp:Label ID="Player1" runat="server"></asp:Label><br /><br />
        Player 2 :<asp:Label ID="Player2" runat="server"></asp:Label><br />
        <br />
        Player 3 :<asp:Label ID="Player3" runat="server"></asp:Label>
        <br />
        No of Carts :  <asp:Label ID="NoOfCarts" runat="server"></asp:Label><br />
        <br />
        <br />
        <br />
        
       
       
        <asp:Label ID="Chnage" runat="server" Text="Want To Cancel your Tee Time"></asp:Label><br />
        <asp:Button ID="ConfirmDelete" runat="server" Text="CancelYourTeeTime" OnClick="ConfirmDelete_Click" />
    </div>
    </form>
</body>
</html>
