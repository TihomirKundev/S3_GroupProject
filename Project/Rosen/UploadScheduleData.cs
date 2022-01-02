using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Project
{
    class UploadScheduleData
    {
        private readonly string dataLink = "Server=mssql.fhict.local;Database=dbi484379;User Id=dbi484379;Password=1234;";

        public List<Schedule> SchedulesForUser(User user)
        {
            List<Schedule> schedulesForUser = new List<Schedule>();
            SqlConnection con = new SqlConnection(@dataLink);
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Schedule WHERE UserID = '" + user.UserID + "'", con);
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
                schedulesForUser.Add(new Schedule(ID,apartmentID,userID,day,job));
            }
            con.Close();
            return schedulesForUser;
        }
        

        public List<Schedule> AllSchedules()
        {
            List<Schedule> schedules = new List<Schedule>();
            SqlConnection con = new SqlConnection(@dataLink);
            SqlCommand cmd = new SqlCommand("Select *  from Schedule", con);
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

                schedules.Add(new Schedule(ID, apartmentID, userID,day,job));
            }
            con.Close();
            return schedules;
        }
        public void ModifyScheduleData(string option, Schedule schedule)
        {
            SqlConnection con = new SqlConnection(@dataLink);
            con.Open();
            SqlCommand cmd = new SqlCommand("");
            if (option == "Insert")
            {
                cmd = new SqlCommand("insert into Schedule values (@ApartmentID,@UserID, @Day, @job)", con);
                cmd.Parameters.AddWithValue("@ApartmentID", schedule.ApartmentID);
                cmd.Parameters.AddWithValue("@UserID", schedule.UserID);
                cmd.Parameters.AddWithValue("@Day", schedule.Day);
                cmd.Parameters.AddWithValue("@job", schedule.Job);
            }
            else if (option == "Update")
            {
                cmd = new SqlCommand("Update Schedule set ApartmentID=@ApartmentID,UserID=@UserID,Day=@Day,job=@job where ID='" + @schedule.ID + "'", con);
                cmd.Parameters.AddWithValue("@ApartmentID", schedule.ApartmentID);
                cmd.Parameters.AddWithValue("@UserID", schedule.UserID);
                cmd.Parameters.AddWithValue("@Day", schedule.Day);
                cmd.Parameters.AddWithValue("@job", schedule.Job);
                cmd.Parameters.AddWithValue("@ID", schedule.ID);
            }
            else
            {
                cmd = new SqlCommand("DELETE FROM Schedule WHERE ID = '" + schedule.ID + "'", con);
                cmd.Parameters.AddWithValue("@ID", schedule.ID);
            }
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public List<String> ShowDataInComboBoxesForSchedule(int id)
        {
            List<string> str = new List<string>();
            SqlConnection con = new SqlConnection(@dataLink);
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from Schedule a WHERE a.ID='" + id + "'", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                str.Add(dr.GetValue(0).ToString());
                str.Add(dr.GetValue(1).ToString());
                str.Add(dr.GetValue(2).ToString());
                str.Add(dr.GetValue(3).ToString());
                str.Add(dr.GetValue(4).ToString());
            }
            con.Close();
            return str;
        }
    }
}
