using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class StandingReservation : System.Web.UI.Page
{
    string S = "Njangaria1";
    protected void Page_Load(object sender, EventArgs e)
    {
        string memberno = (string)Session["memberno"];
        string membername = (string)Session["membername"];
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        DropDownList newlist = new DropDownList();
        newlist = DropDownList1;
        ClubBaistSampleHandler RequestDirector;
        RequestDirector = new ClubBaistSampleHandler();
        List<string> Reserve;
        Reserve = RequestDirector.GetStandingtime(DropDownList2.SelectedItem.ToString());
        foreach (string Time in Reserve)
        {
            DropDownList1.Items.FindByValue(Time).Enabled = false;
            DropDownList1.DataBind();
        }

    }

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        DropDownList newlist = new DropDownList();
        newlist = DropDownList1;
        ClubBaistSampleHandler RequestDirector;
        RequestDirector = new ClubBaistSampleHandler();
        List<string> Reserve;
        Reserve = RequestDirector.GetStandingtime(DropDownList2.SelectedItem.ToString());
        foreach (string Time in Reserve)
        {
            DropDownList1.Items.FindByValue(Time).Enabled = false;
            DropDownList1.DataBind();
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        ClubBaistSampleHandler RequestDirector;
        RequestDirector = new ClubBaistSampleHandler();
        StandingReserve Reserve = new StandingReserve();
        Reserve.MemberNo = S;
        Reserve.RequestedStartDate = TextBox2.Text;
        Reserve.RequestedEndDate = TextBox3.Text;
        Reserve.day = DropDownList2.SelectedItem.ToString();
        Reserve.time = DropDownList1.SelectedItem.ToString();
        Reserve.MemberNo1 = TextBox1.Text;
        Reserve.MemberNo2 = TextBox4.Text;
        Reserve.MemberNo3 = TextBox5.Text;
        Reserve.MemberNo = S;
        Boolean Confirmation;
        Confirmation = RequestDirector.AddStandingTime(Reserve);
        if (Confirmation)
        {
            Msg.Text = " Standing Tee Time Reserved";
        }
        else
        {
            Msg.Text = "Standing Tee Time Not Reserved";
        }
    }
}