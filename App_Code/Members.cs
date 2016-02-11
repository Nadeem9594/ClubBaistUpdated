using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data.SqlClient;
using System.Data;



    /// <summary>
    /// Summary description for Members
    /// </summary>
    public class Members
    {
        public Member FindMember(string UserID)
        {
            Member CurrentMember;
            CurrentMember = new Member();

            SqlConnection StudentConnection;
            StudentConnection = new SqlConnection();
            StudentConnection.ConnectionString = "Data Source= (localDB)\\v11.0;Initial Catalog=GolfClubBAIST;Integrated Security = True";

            SqlCommand StudentCommand;
            StudentCommand = new SqlCommand();
            StudentCommand.CommandType = CommandType.StoredProcedure;
            StudentCommand.Connection = StudentConnection;
            StudentCommand.CommandText = "FindMember";

            SqlParameter membernumber;
            membernumber = new SqlParameter();
            membernumber.ParameterName = "@UserID";
            membernumber.SqlDbType = SqlDbType.VarChar;
            membernumber.Value = UserID;
            membernumber.Direction = ParameterDirection.Input;
            StudentCommand.Parameters.Add(membernumber);

            StudentConnection.Open();
            SqlDataReader BAIS3150Reader;
            BAIS3150Reader = StudentCommand.ExecuteReader();

            while (BAIS3150Reader.Read())
            {
                CurrentMember.MemberNumber = (string)BAIS3150Reader["MemberNumber"];
                CurrentMember.MemberName = (string)BAIS3150Reader["MemberName"];
                CurrentMember.Phone = (string)BAIS3150Reader["Phone"];
                CurrentMember.Role = (string)BAIS3150Reader["Role"];

            }
            return CurrentMember;
        }

         public Member MemberInformation(string MemberNo)
        {
            Member CurrentMember;
            CurrentMember = new Member();

            SqlConnection StudentConnection;
            StudentConnection = new SqlConnection();
            StudentConnection.ConnectionString = "Data Source= (localDB)\\v11.0;Initial Catalog=GolfClubBAIST;Integrated Security = True";

            SqlCommand StudentCommand;
            StudentCommand = new SqlCommand();
            StudentCommand.CommandType = CommandType.StoredProcedure;
            StudentCommand.Connection = StudentConnection;
            StudentCommand.CommandText = "FindMemberName";

            SqlParameter studentid;
            studentid = new SqlParameter();
            studentid.ParameterName = "@MemberNo";
            studentid.SqlDbType = SqlDbType.VarChar;
            studentid.Value = MemberNo;
            studentid.Direction = ParameterDirection.Input;
            StudentCommand.Parameters.Add(studentid);

            StudentConnection.Open();
            SqlDataReader BAIS3150Reader;
            BAIS3150Reader = StudentCommand.ExecuteReader();
            while (BAIS3150Reader.Read())
            {

                CurrentMember.MemberName = (string)BAIS3150Reader["MemberName"];
                CurrentMember.Phone = (string)BAIS3150Reader["Phone"];
                CurrentMember.Role = (string)BAIS3150Reader["Role"];

            }
           

            StudentConnection.Close();
            return CurrentMember;
        }
    }
