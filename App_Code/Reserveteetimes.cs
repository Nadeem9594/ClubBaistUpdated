using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Reserveteetimes
/// </summary>
public class Reserveteetimes
{
         private string _MemberNo;
        private string  _Player1;
        private string _Player2;
        private string  _Player3;
        private int _NoofCarts;
        private string _date;
        public List<string> _Availableteetime = new List<string>();
        private string _time1;
        private string _Phone;
        private string role;

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
        public string Phone
        {
            get
            {
                return _Phone;
            }
            set
            {
                _Phone = value;
            }
        }
        public string Player1
        {
            get
            {
                return _Player1;
            }
            set
            {
                _Player1 = value;
            }
        }
        public string Player2
        {
            get
            {
                return _Player2;
            }
            set
            {
                _Player2 = value;
            }
        }
        public string Player3
        {
            get
            {
                return _Player3;
            }
            set
            {
                _Player3 = value;
            }
        }
        public int NoofCarts
        {
            get
            {
                return _NoofCarts;
            }
            set
            {
                _NoofCarts = value;
            }
        }
        public string date
        {
            get
            {
                return _date;
            }
            set
            {
                _date = value;
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
        public string Role
        {
            get
            {
                return role;

            }
            set
            {
                role = value;
            }
        }
          public string time1
        {
            get
            {
                return _time1;
            }
            set
            {
                _time1 = value;
            }
        }
    }
