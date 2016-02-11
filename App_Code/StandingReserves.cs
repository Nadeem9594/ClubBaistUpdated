using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
/// <summary>
/// Summary description for StandingReserves
/// </summary>
public class StandingReserves
{
    public Boolean Addtime(StandingReserve Reserve)
    {
        Boolean Success = false;
        SqlConnection StudentConnection;
        StudentConnection = new SqlConnection();
        StudentConnection.ConnectionString = "Data Source= (localDB)\\v11.0;Initial Catalog=ClubBAIST;Integrated Security = True";

        SqlCommand StudentCommand;
        StudentCommand = new SqlCommand();
        StudentCommand.CommandType = CommandType.StoredProcedure;
        StudentCommand.Connection = StudentConnection;
        StudentCommand.CommandText = "StandingReservationtime";

        SqlParameter MemberNo;
        MemberNo = new SqlParameter();
        MemberNo.ParameterName = "@MemberNo";
        MemberNo.SqlDbType = SqlDbType.VarChar;
        MemberNo.Value = Reserve.MemberNo;
        MemberNo.Direction = ParameterDirection.Input;
        StudentCommand.Parameters.Add(MemberNo);

        SqlParameter MemberNo1;
        MemberNo1 = new SqlParameter();
        MemberNo1.ParameterName = "@MemberNo1";
        MemberNo1.SqlDbType = SqlDbType.VarChar;
        MemberNo1.Value = Reserve.MemberNo1;
        MemberNo1.Direction = ParameterDirection.Input;
        StudentCommand.Parameters.Add(MemberNo1);

        SqlParameter MemberNo2;
        MemberNo2 = new SqlParameter();
        MemberNo2.ParameterName = "@MemberNo2";
        MemberNo2.SqlDbType = SqlDbType.VarChar;
        MemberNo2.Value = Reserve.MemberNo2;
        MemberNo2.Direction = ParameterDirection.Input;
        StudentCommand.Parameters.Add(MemberNo2);

        SqlParameter MemberNo3;
        MemberNo3 = new SqlParameter();
        MemberNo3.ParameterName = "@MemberNo3";
        MemberNo3.SqlDbType = SqlDbType.VarChar;
        MemberNo3.Value = Reserve.MemberNo3;
        MemberNo3.Direction = ParameterDirection.Input;
        StudentCommand.Parameters.Add(MemberNo3);

        SqlParameter NoofCarts;
        NoofCarts = new SqlParameter();
        NoofCarts.ParameterName = "@Time";
        NoofCarts.SqlDbType = SqlDbType.VarChar;
        NoofCarts.Value = Reserve.time;
        NoofCarts.Direction = ParameterDirection.Input;
        StudentCommand.Parameters.Add(NoofCarts);

        SqlParameter RequestedStartDate;
        RequestedStartDate = new SqlParameter();
        RequestedStartDate.ParameterName = "@RequestedStartDate";
        RequestedStartDate.SqlDbType = SqlDbType.VarChar;
        RequestedStartDate.Value = Reserve.RequestedStartDate;
        RequestedStartDate.Direction = ParameterDirection.Input;
        StudentCommand.Parameters.Add(RequestedStartDate);

        SqlParameter Noofplayer;
        Noofplayer = new SqlParameter();
        Noofplayer.ParameterName = "@RequestedEndDate";
        Noofplayer.SqlDbType = SqlDbType.VarChar;
        Noofplayer.Value = Reserve.RequestedEndDate;
        Noofplayer.Direction = ParameterDirection.Input;
        StudentCommand.Parameters.Add(Noofplayer);

        SqlParameter date;
        date = new SqlParameter();
        date.ParameterName = "@Day";
        date.SqlDbType = SqlDbType.VarChar;
        date.Value = Reserve.day;
        date.Direction = ParameterDirection.Input;
        StudentCommand.Parameters.Add(date);

       
        StudentConnection.Open();

        StudentCommand.ExecuteNonQuery();

        StudentConnection.Close();


        Success = true;
        return Success;
    }

    public List<string> Gettime(string day)
    {
        //List<Reserveteetimes> Availableteetime = new List<Reserveteetimes>();
        StandingReserve bookedtimes = new StandingReserve();
        SqlConnection StudentConnection;
        StudentConnection = new SqlConnection();
        StudentConnection.ConnectionString = "Data Source= (localDB)\\v11.0;Initial Catalog=ClubBaist;Integrated Security = True";

        SqlCommand StudentCommand;
        StudentCommand = new SqlCommand();
        StudentCommand.CommandType = CommandType.StoredProcedure;
        StudentCommand.Connection = StudentConnection;
        StudentCommand.CommandText = "GetStandingTeeTime";

        SqlParameter programcode;
        programcode = new SqlParameter();
        programcode.ParameterName = "@Day";
        programcode.SqlDbType = SqlDbType.VarChar;
        programcode.Value = day;
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
}