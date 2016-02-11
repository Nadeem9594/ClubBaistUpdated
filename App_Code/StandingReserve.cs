using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for StandingReserve
/// </summary>
public class StandingReserve
{
    private string _MemberNo;
    private string _MemberNo1;
    private string _MemberNo2;
    private string _MemberNo3;
    private string _RequestedStartDate;
    private string _RequestedEndDate;
    private string _day;
    private string _time;
    public List<string> _Availableteetime = new List<string>();    
    
    public string MemberNo
    {
        get
        {
            return _MemberNo;
        }
        set
        {
            _MemberNo = value;
        }
    }
    public string time
    {
        get
        {
            return _time;
        }
        set
        {
            _time = value;
        }
    }
    public string day
    {
        get
        {
            return _day;
        }
        set
        {
            _day = value;
        }
    }
    public string MemberNo1
    {
        get
        {
            return _MemberNo1;
        }
        set
        {
            _MemberNo1 = value;
        }
    }
    public string MemberNo2
    {
        get
        {
            return _MemberNo2;
        }
        set
        {
            _MemberNo2 = value;
        }
    }
    public string MemberNo3
    {
        get
        {
            return _MemberNo3;
        }
        set
        {
            _MemberNo3 = value;
        }
    }
    public string RequestedStartDate
    {
        get
        {
            return _RequestedStartDate;
        }
        set
        {
            _RequestedStartDate = value;
        }
    }
    public string RequestedEndDate
    {
        get
        {
            return _RequestedEndDate;
        }
        set
        {
            _RequestedEndDate = value;
        }
    }
    public List<string> Availableteetime
    {
        get
        {
            return _Availableteetime;
        }
        set
        {
            _Availableteetime = value;
        }
    }
}