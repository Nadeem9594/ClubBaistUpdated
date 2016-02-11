using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class LoginRequest : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       
    }

    protected void Submit_Click(object sender, EventArgs e)
    {
        ClubBaistSampleHandler RequestDirector;
        RequestDirector = new ClubBaistSampleHandler();
        Member AuthenticatedUser;
        AuthenticatedUser = new Member();
        AuthenticatedUser = RequestDirector.Login(UserId.Text, Password.Text);
        if (AuthenticatedUser.IsValid == false)
        {
            Response.Write("Invalid");
        }
        else
        {
            Session["membername"] = AuthenticatedUser.MemberName;
            Session["memberno"] = AuthenticatedUser.MemberNumber;
            Session["role"] = AuthenticatedUser.Role;
            
            if (AuthenticatedUser.Role == "Clerk")
            {
                Response.Redirect("ClerkReservation.aspx");
            }
            else
            Response.Redirect("MasterPage.aspx");
        }
    }
}