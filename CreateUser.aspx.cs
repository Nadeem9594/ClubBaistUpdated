using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CreateUser : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Submit_Click(object sender, EventArgs e)
    {
        ClubBaistSampleHandler RequestDirector;
        RequestDirector = new ClubBaistSampleHandler();
        Boolean Cofirmation;
        Cofirmation = RequestDirector.AddUser(UserId.Text, Password.Text);
        if (Cofirmation)
        {
            Msg.Text = "Success! UserAdded";
        }
    }
}