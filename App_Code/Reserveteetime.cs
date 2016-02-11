using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;


///Reserving Tee time 
public class Reserveteetime
{
    public Boolean Addtime(Reserveteetimes Reserve )
	{       
        Boolean Success = false;
        SqlConnection StudentConnection;
        StudentConnection = new SqlConnection();
        StudentConnection.ConnectionString = "Data Source= (localDB)\\v11.0;Initial Catalog=GolfClubBAIST;Integrated Security = True";

        SqlCommand StudentCommand;
        StudentCommand = new SqlCommand();
        StudentCommand.CommandType = CommandType.StoredProcedure;
        StudentCommand.Connection = StudentConnection;
        StudentCommand.CommandText = "AddTeeTime";

        SqlParameter MemberNo;
        MemberNo = new SqlParameter();
        MemberNo.ParameterName = "@MemberNumber";
        MemberNo.SqlDbType = SqlDbType.VarChar;
        MemberNo.Value = Reserve.MemberNo;
        MemberNo.Direction = ParameterDirection.Input;
        StudentCommand.Parameters.Add(MemberNo);

        SqlParameter NoofCarts;
        NoofCarts = new SqlParameter();
        NoofCarts.ParameterName = "@NoofCarts";
        NoofCarts.SqlDbType = SqlDbType.VarChar;
        NoofCarts.Value = Reserve.NoofCarts;
        NoofCarts.Direction = ParameterDirection.Input;
        StudentCommand.Parameters.Add(NoofCarts);

          SqlParameter Player1;
          Player1 = new SqlParameter();
          Player1.ParameterName = "@Player1";
          Player1.SqlDbType = SqlDbType.VarChar;
          Player1.Value = Reserve.Player1;
          Player1.Direction = ParameterDirection.Input;
          StudentCommand.Parameters.Add(Player1);

          SqlParameter Player2;
          Player2 = new SqlParameter();
          Player2.ParameterName = "@Player2";
          Player2.SqlDbType = SqlDbType.VarChar;
          Player2.Value = Reserve.Player2;
          Player2.Direction = ParameterDirection.Input;
          StudentCommand.Parameters.Add(Player2);

          SqlParameter Player3;
          Player3 = new SqlParameter();
          Player3.ParameterName = "@Player3";
          Player3.SqlDbType = SqlDbType.VarChar;
          Player3.Value = Reserve.Player3;
          Player3.Direction = ParameterDirection.Input;
          StudentCommand.Parameters.Add(Player3);

        SqlParameter date;
        date = new SqlParameter();
        date.ParameterName = "@Date";
        date.SqlDbType = SqlDbType.VarChar;
        date.Value = Reserve.date;
        date.Direction = ParameterDirection.Input;
        StudentCommand.Parameters.Add(date);

          SqlParameter time;
          time = new SqlParameter();
          time.ParameterName = "@Time";
          time.SqlDbType = SqlDbType.VarChar;
          time.Value = Reserve.time1;
          time.Direction = ParameterDirection.Input;
          StudentCommand.Parameters.Add(time);

          


        StudentConnection.Open();

        StudentCommand.ExecuteNonQuery();

        StudentConnection.Close();


        Success = true;
        return Success;
	}


// Getting tee time for reserving 
    public List<string> Gettime(string date)
    {
        //List<Reserveteetimes> Availableteetime = new List<Reserveteetimes>();
        Reserveteetimes bookedtimes = new Reserveteetimes();
        SqlConnection StudentConnection;
        StudentConnection = new SqlConnection();
        StudentConnection.ConnectionString = "Data Source= (localDB)\\v11.0;Initial Catalog=GolfClubBAIST;Integrated Security = True";

        SqlCommand StudentCommand;
        StudentCommand = new SqlCommand();
        StudentCommand.CommandType = CommandType.StoredProcedure;
        StudentCommand.Connection = StudentConnection;
        StudentCommand.CommandText = "GetTeeTime";

        SqlParameter programcode;
        programcode = new SqlParameter();
        programcode.ParameterName = "@Date";
        programcode.SqlDbType = SqlDbType.Date;
        programcode.Value = date;
        programcode.Direction = ParameterDirection.Input;
        StudentCommand.Parameters.Add(programcode);
        
        StudentConnection.Open();
        SqlDataReader BAIS3150Reader;
        BAIS3150Reader = StudentCommand.ExecuteReader();
        string Tee;
        while (BAIS3150Reader.Read())
        {
            //Reserveteetimes Availableteetime;
            //Availableteetime = new Reserveteetimes();
                
            Tee= (string)BAIS3150Reader["Time"];
            bookedtimes.Availableteetime.Add(Tee); 
           
        }
        
        StudentConnection.Close();
        return bookedtimes.Availableteetime;


    }

// Getting tee time for update and cancel
    public List<string> teetimesUpdate(string date)
    {
        //List<Reserveteetimes> Availableteetime = new List<Reserveteetimes>();
        Reserveteetimes bookedtimes = new Reserveteetimes();
        SqlConnection StudentConnection;
        StudentConnection = new SqlConnection();
        StudentConnection.ConnectionString = "Data Source= (localDB)\\v11.0;Initial Catalog=GolfClubBAIST;Integrated Security = True";

        SqlCommand StudentCommand;
        StudentCommand = new SqlCommand();
        StudentCommand.CommandType = CommandType.StoredProcedure;
        StudentCommand.Connection = StudentConnection;
        StudentCommand.CommandText = "GetTeeTime";

        SqlParameter programcode;
        programcode = new SqlParameter();
        programcode.ParameterName = "@Date";
        programcode.SqlDbType = SqlDbType.VarChar;
        programcode.Value = Convert.ToDateTime(date);
        programcode.Direction = ParameterDirection.Input;
        StudentCommand.Parameters.Add(programcode);




        StudentConnection.Open();
        SqlDataReader BAIS3150Reader;
        BAIS3150Reader = StudentCommand.ExecuteReader();
        string Tee;
        while (BAIS3150Reader.Read())
        {
            //Reserveteetimes Availableteetime;
            //Availableteetime = new Reserveteetimes();

            Tee = (string)BAIS3150Reader["Time"];
            bookedtimes.Availableteetime.Add(Tee);

        }

        StudentConnection.Close();
        return bookedtimes.Availableteetime;


    }

    // Getting all information of the time reserved by the golf member 
    public Reserveteetimes Getteetime(Reserveteetimes Reserve)
    {

        Reserveteetimes Teetimeinfo;
        Teetimeinfo = new Reserveteetimes();
        SqlConnection StudentConnection;
        StudentConnection = new SqlConnection();
        StudentConnection.ConnectionString = "Data Source= (localDB)\\v11.0;Initial Catalog=GolfClubBAIST;Integrated Security = True";


        SqlCommand StudentCommand;
        StudentCommand = new SqlCommand();
        StudentCommand.CommandType = CommandType.StoredProcedure;
        StudentCommand.Connection = StudentConnection;
        StudentCommand.CommandText = "GetTeeTimeInfo";

        SqlParameter studentid;
        studentid = new SqlParameter();
        studentid.ParameterName = "@MemberNumber";
        studentid.SqlDbType = SqlDbType.VarChar;
        studentid.Value = Reserve.MemberNo;
        studentid.Direction = ParameterDirection.Input;
        StudentCommand.Parameters.Add(studentid);

        SqlParameter date;
        date = new SqlParameter();
        date.ParameterName = "@Date";
        date.SqlDbType = SqlDbType.VarChar;
        date.Value = Reserve.date;
        date.Direction = ParameterDirection.Input;
        StudentCommand.Parameters.Add(date);

        SqlParameter time;
        time = new SqlParameter();
        time.ParameterName = "@Time";
        time.SqlDbType = SqlDbType.VarChar;
        time.Value = Reserve.time1;
        time.Direction = ParameterDirection.Input;
        StudentCommand.Parameters.Add(time);

        StudentConnection.Open();
        SqlDataReader BAIS3150Reader;
        BAIS3150Reader = StudentCommand.ExecuteReader();

        while (BAIS3150Reader.Read())
        {

            Teetimeinfo.MemberNo = (string)BAIS3150Reader["MemberNumber"];
            Teetimeinfo.NoofCarts = (int)BAIS3150Reader["NoofCarts"];
            Teetimeinfo.Player1 = (string)BAIS3150Reader["Player1"];
            Teetimeinfo.Player2 = (string)BAIS3150Reader["Player2"];
            Teetimeinfo.Player3 = (string)BAIS3150Reader["Player3"];
            Teetimeinfo.time1 = (string)BAIS3150Reader["Time"];
            
            Teetimeinfo.date = Convert.ToDateTime(BAIS3150Reader["Date"]).ToString("yyyy/MM/dd"); 

        }

        StudentConnection.Close();
        return Teetimeinfo;
    }

// Updating players no of players and no of carts  Scenario Modifying tee time  
    public Boolean UpdateCustomer(Reserveteetimes TeeTimeUpdate)
    {
        Boolean Success = false;
        SqlConnection StudentConnection;
        StudentConnection = new SqlConnection();
        StudentConnection.ConnectionString = "Data Source= (localDB)\\v11.0;Initial Catalog=GolfClubBAIST;Integrated Security = True";

        SqlCommand StudentCommand;
        StudentCommand = new SqlCommand();
        StudentCommand.CommandType = CommandType.StoredProcedure;
        StudentCommand.Connection = StudentConnection;
        StudentCommand.CommandText = "UpdateTeeTime";

        SqlParameter MemberNo;
        MemberNo = new SqlParameter();
        MemberNo.ParameterName = "@MemberNumber";
        MemberNo.SqlDbType = SqlDbType.VarChar;
        MemberNo.Value = TeeTimeUpdate.MemberNo;
        MemberNo.Direction = ParameterDirection.Input;
        StudentCommand.Parameters.Add(MemberNo);


        SqlParameter NoofCarts;
        NoofCarts = new SqlParameter();
        NoofCarts.ParameterName = "@NoofCarts";
        NoofCarts.SqlDbType = SqlDbType.VarChar;
        NoofCarts.Value = TeeTimeUpdate.NoofCarts;
        NoofCarts.Direction = ParameterDirection.Input;
        StudentCommand.Parameters.Add(NoofCarts);

        SqlParameter Player1;
        Player1 = new SqlParameter();
        Player1.ParameterName = "@Player1";
        Player1.SqlDbType = SqlDbType.VarChar;
        Player1.Value = TeeTimeUpdate.Player1;
        Player1.Direction = ParameterDirection.Input;
        StudentCommand.Parameters.Add(Player1);

        SqlParameter Player2;
        Player2 = new SqlParameter();
        Player2.ParameterName = "@Player2";
        Player2.SqlDbType = SqlDbType.VarChar;
        Player2.Value = TeeTimeUpdate.Player2;
        Player2.Direction = ParameterDirection.Input;
        StudentCommand.Parameters.Add(Player2);

        SqlParameter Player3;
        Player3 = new SqlParameter();
        Player3.ParameterName = "@Player3";
        Player3.SqlDbType = SqlDbType.VarChar;
        Player3.Value = TeeTimeUpdate.Player3;
        Player3.Direction = ParameterDirection.Input;
        StudentCommand.Parameters.Add(Player3);

        SqlParameter date;
        date = new SqlParameter();
        date.ParameterName = "@Date";
        date.SqlDbType = SqlDbType.VarChar;
        date.Value = TeeTimeUpdate.date;
        date.Direction = ParameterDirection.Input;
        StudentCommand.Parameters.Add(date);

        SqlParameter time;
        time = new SqlParameter();
        time.ParameterName = "@Time";
        time.SqlDbType = SqlDbType.VarChar;
        time.Value = TeeTimeUpdate.time1;
        time.Direction = ParameterDirection.Input;
        StudentCommand.Parameters.Add(time);
        
        StudentConnection.Open();

        StudentCommand.ExecuteNonQuery();

        StudentConnection.Close();

        Success = true;
        return Success;
    }

    // For deleting tee time 
    public Boolean deleteteetime(Reserveteetimes Reserve )
    {
        Boolean Success = false;
        SqlConnection StudentConnection;
        StudentConnection = new SqlConnection();
        StudentConnection.ConnectionString = "Data Source= (localDB)\\v11.0;Initial Catalog=GolfClubBAIST;Integrated Security = True";

        SqlCommand StudentCommand;
        StudentCommand = new SqlCommand();
        StudentCommand.CommandType = CommandType.StoredProcedure;
        StudentCommand.Connection = StudentConnection;
        StudentCommand.CommandText = "DeleteTeeTime";

        SqlParameter MemberNo;
        MemberNo = new SqlParameter();
        MemberNo.ParameterName = "@MemberNumber";
        MemberNo.SqlDbType = SqlDbType.VarChar;
        MemberNo.Value = Reserve.MemberNo;
        MemberNo.Direction = ParameterDirection.Input;
        StudentCommand.Parameters.Add(MemberNo);

        SqlParameter date;
        date = new SqlParameter();
        date.ParameterName = "@Date";
        date.SqlDbType = SqlDbType.VarChar;
        date.Value = Reserve.date;
        date.Direction = ParameterDirection.Input;
        StudentCommand.Parameters.Add(date);

        SqlParameter time;
        time = new SqlParameter();
        time.ParameterName = "@Time";
        time.SqlDbType = SqlDbType.VarChar;
        time.Value = Reserve.time1;
        time.Direction = ParameterDirection.Input;
        StudentCommand.Parameters.Add(time);

        StudentConnection.Open();

        StudentCommand.ExecuteNonQuery();

        StudentConnection.Close();

        Success = true;
        return Success;
    }

}