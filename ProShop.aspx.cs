using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ProShop : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        DropDownList newlist = new DropDownList();
        newlist = DropDownListGold;
        ClubBaistSampleHandler RequestDirector;
        RequestDirector = new ClubBaistSampleHandler();
        List<string> Reserve;
        Reserve = RequestDirector.Gettime(DateTime.Today.ToString("yyyy/MM/dd"));
        foreach (string Time in Reserve)
        {
            DropDownListBooked.Items.Add(new ListItem(Time));
            DropDownListBooked.DataBind();
            DropDownListGold.Items.FindByValue(Time).Enabled = false;
            DropDownListGold.DataBind();
        }
    }
    protected void FindMember_Click(object sender, EventArgs e)
    {
        ClubBaistSampleHandler RequestDirector;
        RequestDirector = new ClubBaistSampleHandler();
        Member MemberInfo;
        MemberInfo = new Member();

        MemberInfo = RequestDirector.MemberInfo(MemberNo.Text);
        MemberName.Text = MemberInfo.MemberName;
        Mebershiplevel.Text = MemberInfo.Role;
        Phone.Text = MemberInfo.Phone;
    }
    protected void BookedTime_Click(object sender, EventArgs e)
    {
        DropDownListGold.Visible = false;
        string memberno = (string)Session["memberno"];
        string membername = (string)Session["membername"];
        ClubBaistSampleHandler RequestDirector;
        RequestDirector = new ClubBaistSampleHandler();
        Reserveteetimes TeeTimeInfo;
        TeeTimeInfo = new Reserveteetimes();
        TeeTimeInfo.MemberNo = memberno;
        TeeTimeInfo.date = DateTime.Today.ToString("yyyy/MM/dd");
        TeeTimeInfo.time1 = DropDownListBooked.SelectedItem.ToString();
        TeeTimeInfo = RequestDirector.GetTeetimeUser(TeeTimeInfo);


        Player1.Text = TeeTimeInfo.Player1;
        Player2.Text = TeeTimeInfo.Player2;
        Player3.Text = TeeTimeInfo.Player3;
        NumberOfCarts.Text = Convert.ToString(TeeTimeInfo.NoofCarts);

       
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        string role = (string)Session["role"];
        string memberno = (string)Session["memberno"];
        if (DropDownListGold.Visible == true)
        {
            ClubBaistSampleHandler RequestDirector;
            RequestDirector = new ClubBaistSampleHandler();
            Reserveteetimes Reserve = new Reserveteetimes();
            Reserve.MemberNo = MemberNo.Text;
            Reserve.NoofCarts = Convert.ToInt32(NumberOfCarts.Text);
            Reserve.Player1 = Player1.Text;
            Reserve.Player2 = Player2.Text;
            Reserve.Player3 = Player3.Text;
            Reserve.date = DateTime.Today.ToString("yyyy/MM/dd");
            Reserve.time1 = DropDownListGold.SelectedItem.ToString();
            Reserve.Phone = Phone.Text;
            Boolean Confirmation;
            Confirmation = RequestDirector.AddMember(Reserve);
            if (Confirmation)
            {
                Msg.Text = "Tee Time Reserved";
            }
            else
            {
                Msg.Text = "Tee Time Not Reserved";
            }
        }
        else if (DropDownListGold.Visible == false)
        {

            string memberno1 = (string)Session["memberno"];
            ClubBaistSampleHandler RequestDirector;
            RequestDirector = new ClubBaistSampleHandler();
            Reserveteetimes TeeTimeInfo;
            TeeTimeInfo = new Reserveteetimes();
            TeeTimeInfo.MemberNo = memberno1;
            TeeTimeInfo.NoofCarts = Convert.ToInt32(NumberOfCarts.Text);
            TeeTimeInfo.Player1 = Player1.Text;
            TeeTimeInfo.Player2 = Player2.Text;
            TeeTimeInfo.Player3 = Player3.Text;
            TeeTimeInfo.date = DateTime.Today.ToString("yyyy/MM/dd");
            TeeTimeInfo.time1 = DropDownListBooked.SelectedItem.ToString();

            Boolean Confirmation;
            Confirmation = RequestDirector.ModifyTeeTime(TeeTimeInfo);
            if (Confirmation)
            {
                Response.Write("Your Tee Time Updated");
            }
        }

        
    }
}