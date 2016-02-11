using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterPage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string memberno = (string)Session["memberno"];
        string membername = (string)Session["membername"];
        string role = (string)Session["role"];
        if (role == "Gold")
        {
            Standing.Enabled = true;
        }


    }
    protected void Reserve_Click(object sender, EventArgs e)
    {
        Response.Redirect("ReserveTeeTime.aspx");
    }
    protected void Cancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("CancelTeeTime.aspx");
    }
    protected void Update_Click(object sender, EventArgs e)
    {
        Response.Redirect("UpdateTeeTime.aspx");
    }
    protected void Standing_Click(object sender, EventArgs e)
    {
        string s4 = (string)Session["role"];
        if (s4 == "Gold")
        {
            Standing.Enabled = true;
        }
        Response.Redirect("StandingReservation.aspx");
    }
}