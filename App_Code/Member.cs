using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
  /// <summary>
    /// Summary description for Member
    /// </summary>
    public class Member
    {
        private string _MemberNumber;
        private string _UserID;
        private string _MemberName;
        private string _Phone;
        private string _password;
        private bool _isvalid;
        private string role;
        public string MemberNumber

        {
            get
            {
                return _MemberNumber;
            }
            set
            {
                 _MemberNumber = value;
            }
        }
        public string UserID
        {
            get
            {
                return _UserID;
            }
            set
            {
                _UserID = value;
            }
        }
        public string MemberName
        {
            get
            {
                return _MemberName;
            }
            set
            {
                _MemberName = value;
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
        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                _password = value;
            }
        }
        public bool IsValid
        {
            get
            {
                return _isvalid;
            }
            set
            {
                _isvalid = value;
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
    }
