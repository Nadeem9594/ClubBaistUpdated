using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class UpdateTeeTime : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string membername = (string)Session["s1"];
        string memberno1 = (string)Session["s2"];


    }

    protected void ConfirmDelete_Click(object sender, EventArgs e)
    {
        string memberno = (string)Session["memberno"];
        ClubBaistSampleHandler RequestDirector;
        RequestDirector = new ClubBaistSampleHandler();
        Reserveteetimes TeeTimeInfo;
        TeeTimeInfo = new Reserveteetimes();
        TeeTimeInfo.MemberNo = memberno;
        TeeTimeInfo.NoofCarts = Convert.ToInt32(NoOfCarts.Text);
        TeeTimeInfo.Player1 = Player1.Text;
        TeeTimeInfo.Player2 = Player2.Text;
        TeeTimeInfo.Player3 = Player3.Text;
        TeeTimeInfo.date = Date1.Text;
        TeeTimeInfo.time1 = Time.Text;

        Boolean Confirmation;
        Confirmation = RequestDirector.ModifyTeeTime(TeeTimeInfo);
        if (Confirmation)
        {
            Response.Write("Your Tee Time Updated");
        }
    }


    protected void Delete_Click1(object sender, EventArgs e)
    {
        string membername = (string)Session["membername"];
        string memberno1 = (string)Session["memberno"];
        ClubBaistSampleHandler RequestDirector;
        RequestDirector = new ClubBaistSampleHandler();
        Reserveteetimes TeeTimeInfo;
        TeeTimeInfo = new Reserveteetimes();
        TeeTimeInfo.MemberNo = memberno1;
        TeeTimeInfo.date = ACalendar.SelectedDate.ToString("yyyy/MM/dd");
        TeeTimeInfo.time1 = DropDownList3.SelectedItem.ToString();
        TeeTimeInfo = RequestDirector.GetTeetimeUser(TeeTimeInfo);

        MemberNo.Text = memberno1;
        MemberName.Text = membername;
        Player1.Text = TeeTimeInfo.Player1;
        Player2.Text = TeeTimeInfo.Player2;
        Player3.Text = TeeTimeInfo.Player3;
        NoOfCarts.Text = Convert.ToString(TeeTimeInfo.NoofCarts);
        Date1.Text = Convert.ToString(TeeTimeInfo.date);
        Time.Text = TeeTimeInfo.time1;


    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        DropDownList newlist = new DropDownList();
        newlist = DropDownList3;
        ClubBaistSampleHandler RequestDirector;
        RequestDirector = new ClubBaistSampleHandler();
        List<string> Reserve;
        Reserve = RequestDirector.Gettime(ACalendar.SelectedDate.ToShortDateString());
        foreach (string Time in Reserve)
        {
            DropDownList3.Items.Add(new ListItem(Time));
            DropDownList3.DataBind();
        }
    }
}