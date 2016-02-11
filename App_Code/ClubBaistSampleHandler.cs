using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


/// <summary>
/// Summary description for ClubBaistSampleHandler
/// </summary>
public class ClubBaistSampleHandler
{
    public Boolean AddUser(string UserId, string Password)
    {
        Users UserManager;
        UserManager = new Users();
        Boolean Success;
        Success = UserManager.AddUser(UserId, Password);
        return Success;
    }

    public Boolean AddMember(Reserveteetimes Reserve)
    {
        Reserveteetime reservemanager;
        reservemanager = new Reserveteetime();
        Boolean Confirmation;
        Confirmation = reservemanager.Addtime(Reserve);
        return Confirmation;
    }

    public Boolean AddStandingTime(StandingReserve Reserve)
    {
        StandingReserves reservemanager;
        reservemanager = new StandingReserves();
        Boolean Confirmation;
        Confirmation = reservemanager.Addtime(Reserve);
        return Confirmation;
    }

    public List<string> GetStandingtime(string day)
    {
        StandingReserves reservemanager;
        reservemanager = new StandingReserves();

        List<string> Enrolledtime = new List<string>();
        Enrolledtime = reservemanager.Gettime(day);
        return Enrolledtime;
    }


    public List<string> Gettime(string date)
    {
        Reserveteetime reservemanager;
        reservemanager = new Reserveteetime();
      
        List<string> Enrolledtime = new List<string>();
        Enrolledtime = reservemanager.Gettime(date);
        return Enrolledtime;
    }

    public Member Login(string UserID, string Password)
    {

        Member AuthenticatedMember;
        AuthenticatedMember = new Member();

        Users UserManager;
        UserManager = new Users();

        AuthenticatedMember = UserManager.GetUser(UserID, Password);
        return AuthenticatedMember;

    }

    public Reserveteetimes GetTeetimeUser(Reserveteetimes Reserve)
    {
        Reserveteetime User;
        User = new Reserveteetime();
        Reserveteetimes Teetimeinfo;
        Teetimeinfo = new Reserveteetimes();
        Teetimeinfo = User.Getteetime(Reserve);
        return Teetimeinfo;
    }

    public Boolean ModifyTeeTime(Reserveteetimes Teetimeupdate)
    {
        Reserveteetime CustomerManager;
        CustomerManager = new Reserveteetime();
        Boolean Confirmation;
        Confirmation = CustomerManager.UpdateCustomer(Teetimeupdate);
        return Confirmation;
    }

    public Boolean deleteteetime(Reserveteetimes Reserve)
    {
        Reserveteetime CustomerManager;
        CustomerManager = new Reserveteetime();
        Boolean Confirmation;
        Confirmation = CustomerManager.deleteteetime(Reserve);
        return Confirmation;
    }

    public Member MemberInfo(string MemberNo)
    {
        Member Memberinfo;
        Memberinfo = new Member();
        Members user;
        user = new Members();
        Memberinfo = user.MemberInformation(MemberNo);
        return Memberinfo;
    }
   
}