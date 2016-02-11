<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ClerkReservation.aspx.cs" Inherits="ClerkReservation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    </head>
<body>
    <form id="form1" runat="server">
    
    <div>
          

    &nbsp;Member No :&nbsp;&nbsp;
        <asp:TextBox ID="MemberNo" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="FindMember" runat="server" Text="FindMember" OnClick="FindMember_Click" />
        <br />
        <br />
        Member Name&nbsp; :
        <asp:Label ID="MemberName" runat="server" Text="" ></asp:Label>
        <br />
        Membership Level :
        <asp:Label ID="Mebershiplevel" runat="server" Text="" ></asp:Label>
        <br />
        Phone :
         <asp:Label ID="Phone" runat="server"  Text=""></asp:Label>
        
        <br />
    
          <tr>
              <td>
       Select Your Date :
              </td>  
              <td>
              <asp:Calendar ID="ACalendar" runat="server" ></asp:Calendar>
                  </td>
                  </tr>
          <tr>
              <td colspan="2" class="auto-style1">
        <asp:Button ID="FindTeeTime" runat="server" Text="FindTime" OnClick="Button1_Click" /> 
                  </td>
           </tr>
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
        <br />
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

                  &nbsp;<br />
        &nbsp;

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
              <br />
              Player2 :
              </td>
              <td><asp:TextBox ID="Player2" runat="server"></asp:TextBox></td>
       </tr>
          <tr>
          <td>
              <br />
              Player3 :
              </td>
              <td><asp:TextBox ID="Player3" runat="server"></asp:TextBox></td>
       </tr>
          <tr>
              <td>   
        <br />
        Number oF Carts : </td> <td><asp:TextBox ID="NumberOfCarts" runat="server"></asp:TextBox> </td> </tr>
          <tr>  <td> 
        <br />
        Phone : </td> <td> <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox> </td></tr> 
        <tr>
      <td colspan="2">  <asp:Button ID="Button1" runat="server" Text="ReserveTime" OnClick="Button2_Click" /> </td>
        </tr>
          <tr> <td colspan="2"> 
        <br />
        <asp:Label ID="Label1" runat="server"></asp:Label></td>  </tr>
          <tr>  <td> 
        <br />
&nbsp;</tr><tr><td colspan="2"><asp:Label ID="Msg" runat="server"></asp:Label></td>  </tr>
          </table>
        <br />
    </div>
    </form>
    
   
  
</body>
</html>
