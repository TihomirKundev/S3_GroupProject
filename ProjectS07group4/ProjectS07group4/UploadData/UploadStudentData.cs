using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
namespace ProjectS07group4.UploadData
{
    class UploadStudentData : DataBaseLink
    {
        public List<User> UsersInTheSameApartment(User user)
        {
            List<User> users = new List<User>();
            SqlConnection conn = new SqlConnection(this.@getLink());
            SqlCommand cmd = new SqlCommand("SELECT * FROM UsersData Where ID != '" + user.UserIdentity + "' AND " +
                "Apartment = '" + user.UserApartmentID + "'", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                int id = Convert.ToInt32(dr["ID"]);
                string username = Convert.ToString(dr["Username"]);



                users.Add(new User(id, username, "", 0));
            }
            conn.Close();
            return users;
        }
        public List<AdminManager.Users> AllUsers()
        {
            List<AdminManager.Users> users = new List<AdminManager.Users>();
            SqlConnection conn = new SqlConnection(this.@getLink());
            SqlCommand cmd = new SqlCommand("SELECT * FROM UsersData", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                int ID = Convert.ToInt32(dr["ID"]);
                string email = Convert.ToString(dr["Username"]);
                string password = Convert.ToString(dr["Password"]);
                int apartment = Convert.ToInt32(dr["Apartment"]);

                users.Add(new AdminManager.Users(ID, email, password, apartment));
            }
            conn.Close();
            return users;
        }

        public void ModifyUsersData(string option,int userID, string email,string password,int apartmentID)
        {
            SqlConnection con = new SqlConnection(this.@getLink());
            con.Open();
            SqlCommand cmd = new SqlCommand("");
            if (option == "Insert")
            {
                cmd = new SqlCommand("insert into UsersData values (@Username, @Password, @Apartment)", con);
                cmd.Parameters.AddWithValue("@Username", email);
                cmd.Parameters.AddWithValue("@Password", password);
                cmd.Parameters.AddWithValue("@Apartment", apartmentID);

            }
            else if (option == "Update")
            {
                cmd = new SqlCommand("Update UsersData set Username=@Username,Password=@Password,Apartment=@Apartment where ID='" + @userID + "'", con);
                cmd.Parameters.AddWithValue("@Username", email);
                cmd.Parameters.AddWithValue("@Password", password);
                cmd.Parameters.AddWithValue("@Apartment", apartmentID);
                cmd.Parameters.AddWithValue("@ID", userID);
            }
            else
            {
                cmd = new SqlCommand("DELETE FROM UsersData WHERE ID = '" + @userID + "'", con);
                cmd.Parameters.AddWithValue("@ID", userID);
            }
            cmd.ExecuteNonQuery();
            con.Close();
        }

    }
}
