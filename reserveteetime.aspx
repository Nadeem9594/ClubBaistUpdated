<%@ Page Language="C#" AutoEventWireup="true" CodeFile="reserveteetime.aspx.cs" Inherits="reserveteetime" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    &nbsp;
       Welcome : <asp:Label ID="Name" runat="server"></asp:Label>
    </div>
      <table>
          <tr>
              <td>
       Select Your Date :
              </td>  
              <td>
              <asp:Calendar ID="ACalendar" runat="server" ></asp:Calendar>
                  </td>
                  </tr>
          <tr>
              <td colspan="2">
        <asp:Button ID="FindTeeTime" runat="server" Text="FindTime" OnClick="Button1_Click" /> 
                  <br />
                  <br />
                  Booked Tee Time Are :

        <asp:DropDownList ID="DropDownListBooked" runat="server"  >                          
                                                           
            
        </asp:DropDownList>
                  &nbsp;&nbsp;&nbsp;&nbsp;
                  <asp:Button ID="BookedTime" runat="server" Text="BookedTime" OnClick="BookedTime_Click" />
                  </td>
           </tr>
          <tr> 
              <td>
      Available Tee Time Are :
                  </td>
              <td> 
          <asp:DropDownList ID="DropDownListGold" runat="server" >
             <asp:ListItem>7:00AM</asp:ListItem>
             <asp:ListItem>7:07AM</asp:ListItem>
             <asp:ListItem>7:14AM</asp:ListItem>
             <asp:ListItem>7:21AM</asp:ListItem>
             <asp:ListItem>7:28AM</asp:ListItem>
             <asp:ListItem>7:35AM</asp:ListItem>
             <asp:ListItem>7:42AM</asp:ListItem>
             <asp:ListItem>7:49AM</asp:ListItem>
             <asp:ListItem>7:56AM</asp:ListItem>
             <asp:ListItem>8:04AM</asp:ListItem>
             <asp:ListItem>8:11AM</asp:ListItem>
             <asp:ListItem>8:18AM</asp:ListItem>
             <asp:ListItem>8:25AM</asp:ListItem>
             <asp:ListItem>8:32AM</asp:ListItem>
             <asp:ListItem>8:39AM</asp:ListItem>
             <asp:ListItem>8:46AM</asp:ListItem>
             <asp:ListItem>8:54AM</asp:ListItem>
             <asp:ListItem>9:00AM</asp:ListItem>
             <asp:ListItem>9:07AM</asp:ListItem>
             <asp:ListItem>9:14AM</asp:ListItem>
             <asp:ListItem>9:21AM</asp:ListItem>
             <asp:ListItem>9:28AM</asp:ListItem>
             <asp:ListItem>9:35AM</asp:ListItem>
             <asp:ListItem>9:42AM</asp:ListItem>
             <asp:ListItem>9:49AM</asp:ListItem>
             <asp:ListItem>9:56AM</asp:ListItem>
             <asp:ListItem>10:04AM</asp:ListItem>
             <asp:ListItem>10:11AM</asp:ListItem>
             <asp:ListItem>10:18AM</asp:ListItem>
             <asp:ListItem>10:25AM</asp:ListItem>
             <asp:ListItem>10:32AM</asp:ListItem>
             <asp:ListItem>10:39AM</asp:ListItem>
             <asp:ListItem>10:46AM</asp:ListItem>
             <asp:ListItem>10:54AM</asp:ListItem>
             <asp:ListItem>10:01AM</asp:ListItem>
             <asp:ListItem>11:00AM</asp:ListItem>
             <asp:ListItem>11:07AM</asp:ListItem>
             <asp:ListItem>11:14AM</asp:ListItem>
             <asp:ListItem>11:21AM</asp:ListItem>
             <asp:ListItem>11:28AM</asp:ListItem>
             <asp:ListItem>11:35AM</asp:ListItem>
             <asp:ListItem>11:42AM</asp:ListItem>
             <asp:ListItem>11:49AM</asp:ListItem>
             <asp:ListItem>11:56AM</asp:ListItem>
             <asp:ListItem>12:04AM</asp:ListItem>
             <asp:ListItem>12:11AM</asp:ListItem>
             <asp:ListItem>12:18AM</asp:ListItem>
             <asp:ListItem>12:25AM</asp:ListItem>
             <asp:ListItem>12:32AM</asp:ListItem>
             <asp:ListItem>12:39AM</asp:ListItem>
             <asp:ListItem>12:46AM</asp:ListItem>
             <asp:ListItem>12:54AM</asp:ListItem>   
                               
                                                           
            
        </asp:DropDownList>

                  </td>
              </tr>
          <tr>
          <td>
              Player1 :
              </td>
              <td><asp:TextBox ID="Player1" runat="server"></asp:TextBox></td>
       </tr>
          <tr>
          <td>
              Player2 :
              </td>
              <td><asp:TextBox ID="Player2" runat="server"></asp:TextBox></td>
       </tr>
          <tr>
          <td>
              Player3 :
              </td>
              <td><asp:TextBox ID="Player3" runat="server"></asp:TextBox></td>
       </tr>
          <tr>
              <td>   Number oF Carts : </td> <td><asp:TextBox ID="NumberOfCarts" runat="server"></asp:TextBox> </td> </tr>
          <tr>  <td> Phone : </td> <td> <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox> </td></tr> 
        <tr>
      <td colspan="2">  <asp:Button ID="ReserveTime" runat="server" Text="ReserveTime" OnClick="Button2_Click" /> </td>
        </tr>
          <tr> <td colspan="2"> <asp:Label ID="Msg" runat="server"></asp:Label>
              <br />
              Member No:
              <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
              </td>  </tr>
          </table>
    </form>
</body>
</html>
