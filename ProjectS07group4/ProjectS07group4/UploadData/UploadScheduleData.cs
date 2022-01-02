using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
namespace ProjectS07group4.UploadData
{
    class UploadScheduleData : DataBaseLink
    {
        public List<Schedule> SchedulesForUser(User user) 
        {
            List<Schedule> schedulesForUser = new List<Schedule>();
            SqlConnection con = new SqlConnection(this.getLink());
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Schedule WHERE UserID = '" + user.UserIdentity + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                int ID = Convert.ToInt32(dr["ID"]);
                int apartmentID = Convert.ToInt32(dr["ApartmentID"]);
                int userID = Convert.ToInt32(dr["UserID"]);
                string day = Convert.ToString(dr["Day"]);
                string job = Convert.ToString(dr["Job"]);
                schedulesForUser.Add(new Schedule(ID, apartmentID, userID, day, job));
            }
            con.Close();
            return schedulesForUser;
        }
        public List<Schedule> SchedulesForUser(AdminManager.Users user)
        {
            List<Schedule> schedulesForUser = new List<Schedule>();
            SqlConnection con = new SqlConnection(this.getLink());
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Schedule WHERE UserID = '" + user.ID + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                int ID = Convert.ToInt32(dr["ID"]);
                int apartmentID = Convert.ToInt32(dr["ApartmentID"]);
                int userID = Convert.ToInt32(dr["UserID"]);
                string day = Convert.ToString(dr["Day"]);
                string job = Convert.ToString(dr["Job"]);
                schedulesForUser.Add(new Schedule(ID, apartmentID, userID, day, job));
            }
            con.Close();
            return schedulesForUser;
        }
        public void ModifyScheduleData(string option, int id, int apartmentID,int userID,string day,string job)
        {
            SqlConnection con = new SqlConnection(this.@getLink());
            con.Open();
            SqlCommand cmd = new SqlCommand("");
            if (option == "Insert")
            {
                cmd = new SqlCommand("insert into Schedule values (@ApartmentID,@UserID, @Day, @job)", con);
                cmd.Parameters.AddWithValue("@ApartmentID", apartmentID);
                cmd.Parameters.AddWithValue("@UserID", userID);
                cmd.Parameters.AddWithValue("@Day", day);
                cmd.Parameters.AddWithValue("@job", job);
            }
            else if (option == "Update")
            {
                cmd = new SqlCommand("Update Schedule set ApartmentID=@ApartmentID,UserID=@UserID,Day=@Day,job=@job where ID='" + @id + "'", con);
                cmd.Parameters.AddWithValue("@ApartmentID", apartmentID);
                cmd.Parameters.AddWithValue("@UserID", userID);
                cmd.Parameters.AddWithValue("@Day", day);
                cmd.Parameters.AddWithValue("@job", job);
                cmd.Parameters.AddWithValue("@ID", id);
            }
            else
            {
                cmd = new SqlCommand("DELETE FROM Schedule WHERE ID = '" + id + "'", con);
                cmd.Parameters.AddWithValue("@ID", id);
            }
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
