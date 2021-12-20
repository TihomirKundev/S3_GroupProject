using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Project
{
    class UploadStudentData
    {
        private readonly string dataLink = "Server=mssql.fhict.local;Database=dbi484379;User Id=dbi484379;Password=1234;";


        public List<User> AllUsersCheck()
        {
            List<User> users = new List<User>();
            SqlConnection conn = new SqlConnection(@dataLink);
            SqlCommand cmd = new SqlCommand("SELECT * FROM UsersData", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                int id = Convert.ToInt32(dr["ID"]);
                string username = Convert.ToString(dr["Username"]);
                string password = Convert.ToString(dr["Password"]);
                int apartment = Convert.ToInt32(dr["Apartment"]);


                users.Add(new User(id,username,password,apartment));
            }
            conn.Close();
            return users;
        }
        public void ModifyUsersData(string option, User user)
        {
            SqlConnection con = new SqlConnection(@dataLink);
            con.Open();
            SqlCommand cmd = new SqlCommand("");
            if (option == "Insert")
            {
                cmd = new SqlCommand("insert into UsersData values (@Username,@Password, @Apartment)", con);
                cmd.Parameters.AddWithValue("@Username", user.userEmail);
                cmd.Parameters.AddWithValue("@Password", user.userPassword);
                cmd.Parameters.AddWithValue("@Apartment", user.userApartmentID);
            }else if(option == "Update")
            {
                cmd = new SqlCommand("Update UsersData set Username =@Username,Password=@Password,Apartment=@Apartment where ID='" + @user.userIdentity+ "'", con);
                cmd.Parameters.AddWithValue("@Username", user.userEmail);
                cmd.Parameters.AddWithValue("@Password", user.userPassword);
                cmd.Parameters.AddWithValue("@Apartment", user.userApartmentID);
                cmd.Parameters.AddWithValue("@ID", user.userIdentity);
            }
            else
            {
                cmd = new SqlCommand("DELETE FROM UsersData WHERE ID = '"+user.userIdentity+"'", con);
                cmd.Parameters.AddWithValue("@ID", user.userIdentity);
            }
            cmd.ExecuteNonQuery();
            con.Close();
        }

    }
}
