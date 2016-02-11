using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;


public class Users
{
    public Boolean AddUser(string UserId, string Password)
    {
        Boolean Success = false;
        SqlConnection StudentConnection;
        StudentConnection = new SqlConnection();
        StudentConnection.ConnectionString = "Data Source= (localDB)\\v11.0;Initial Catalog=GolfClubBaist;Integrated Security = True";

        SqlCommand StudentCommand;
        StudentCommand = new SqlCommand();
        StudentCommand.CommandType = CommandType.StoredProcedure;
        StudentCommand.Connection = StudentConnection;
        StudentCommand.CommandText = "AddUser";

        SqlParameter _UserId;
        _UserId = new SqlParameter();
        _UserId.ParameterName = "@UserId";
        _UserId.SqlDbType = SqlDbType.VarChar;
        _UserId.Value = UserId;
        _UserId.Direction = ParameterDirection.Input;
        StudentCommand.Parameters.Add(_UserId);

        SqlParameter password;
        password = new SqlParameter();
        password.ParameterName = "@Password";
        password.SqlDbType = SqlDbType.VarChar;
        password.Value = Password;
        password.Direction = ParameterDirection.Input;
        StudentCommand.Parameters.Add(password);


        StudentConnection.Open();

        StudentCommand.ExecuteNonQuery();

        StudentConnection.Close();


        Success = true;
        return Success;
    }

    public Member GetUser(string UserId, string Password)
    {
        Member AuthenticatedUser;
        AuthenticatedUser = new Member();
        Boolean Success = false;
        SqlConnection StudentConnection;
        StudentConnection = new SqlConnection();
        StudentConnection.ConnectionString = "Data Source= (localDB)\\v11.0;Initial Catalog=GolfClubBaist;Integrated Security = True";

        SqlCommand StudentCommand;
        StudentCommand = new SqlCommand();
        StudentCommand.CommandType = CommandType.StoredProcedure;
        StudentCommand.Connection = StudentConnection;
        StudentCommand.CommandText = "GetUser";

        SqlParameter programcode;
        programcode = new SqlParameter();
        programcode.ParameterName = "@UserId";
        programcode.SqlDbType = SqlDbType.VarChar;
        programcode.Value = UserId;
        programcode.Direction = ParameterDirection.Input;
        StudentCommand.Parameters.Add(programcode);

      
        StudentConnection.Open();

        StudentCommand.ExecuteNonQuery();       

        SqlDataReader BAIS3150Reader;
        BAIS3150Reader = StudentCommand.ExecuteReader();
        while (BAIS3150Reader.Read())
        {
            AuthenticatedUser.Password = BAIS3150Reader["Password"].ToString();

        }
        StudentConnection.Close();
        if (AuthenticatedUser.Password == Password)
        {
            Members CurrentMember;
            CurrentMember = new Members();
            AuthenticatedUser = CurrentMember.FindMember(UserId);
            AuthenticatedUser.IsValid = true;
        }
        else
        {
            AuthenticatedUser.IsValid = false;
        }

        return AuthenticatedUser;
    }
}