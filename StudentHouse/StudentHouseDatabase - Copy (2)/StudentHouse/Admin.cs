using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace StudentHouse
{
    class admin
    {
        private string name="group04", password="1234";

        public bool checkLogIn(string name, string password)
        {
            if (this.name == name && this.password == password)
                return true;
            return false;
        }
        public void changeName(int ID, string newData)
        {
            SqlConnection con = new SqlConnection(@"Server=mssql.fhict.local;Database=dbi484379;User Id=dbi484379;Password=1234;");
            con.Open();
            SqlCommand cmd = new SqlCommand("Update UsersData set Username=@Username where ID=@ID", con);
            cmd.Parameters.AddWithValue("@Username", newData);
            cmd.Parameters.AddWithValue("@ID", ID);

            cmd.ExecuteNonQuery();
            con.Close();

        }
        public void changePassword(int ID, string newData)
        {
            SqlConnection con = new SqlConnection(@"Server=mssql.fhict.local;Database=dbi484379;User Id=dbi484379;Password=1234;");
            con.Open();
            SqlCommand cmd = new SqlCommand("Update UsersData set Password=@Password where ID=@ID", con);
            cmd.Parameters.AddWithValue("@Password", newData);
            cmd.Parameters.AddWithValue("@ID", ID);

            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void changeApartment(int ID, string newData)
        {
            adminForm a = new adminForm();

            SqlConnection con = new SqlConnection(@"Server=mssql.fhict.local;Database=dbi484379;User Id=dbi484379;Password=1234;");
            con.Open();
            SqlCommand cmd = new SqlCommand("Update UsersData set Apartment=@Apartment where ID=@ID", con);
            cmd.Parameters.AddWithValue("@Apartment", newData);
            cmd.Parameters.AddWithValue("@ID", ID);

            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void createApartmentData(string gender, string price, string propertyType, string interior, string bedRooms, string Rooms)
        {
            SqlConnection con = new SqlConnection(@"Server=mssql.fhict.local;Database=dbi484379;User Id=dbi484379;Password=1234;");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into ApartmentsData values (@Gender,@Price, @PropertyType," +
                "@Interior,@Bedrooms, @Rooms)", con);

            cmd.Parameters.AddWithValue("@Gender", gender);
            cmd.Parameters.AddWithValue("@Price", price);
            cmd.Parameters.AddWithValue("@PropertyType", propertyType);
            cmd.Parameters.AddWithValue("@Interior", interior);
            cmd.Parameters.AddWithValue("@Bedrooms", bedRooms);
            cmd.Parameters.AddWithValue("@Rooms", Rooms);

            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void updateApartmentData(int ID, string gender, string price, string propertyType, string interior, string bedRooms, string Rooms)
        {
            SqlConnection con = new SqlConnection(@"Server=mssql.fhict.local;Database=dbi484379;User Id=dbi484379;Password=1234;");
            con.Open();
            SqlCommand cmd = new SqlCommand("Update ApartmentsData set Gender=@Gender,Price=@Price," +
                "PropertyType=@PropertyType,Interior=@Interior, Bedrooms=@Bedrooms," +
                "Rooms=@Rooms where ID=@ID", con);
            cmd.Parameters.AddWithValue("@ID", ID);
            cmd.Parameters.AddWithValue("@Gender", gender);
            cmd.Parameters.AddWithValue("@Price", price);
            cmd.Parameters.AddWithValue("@PropertyType", propertyType);
            cmd.Parameters.AddWithValue("@Interior", interior);
            cmd.Parameters.AddWithValue("@Bedrooms", bedRooms);
            cmd.Parameters.AddWithValue("@Rooms", Rooms);

            cmd.ExecuteNonQuery();
            con.Close();

        }

        public void deleteApartmentsData(int id)
        {
            SqlConnection con = new SqlConnection(@"Server=mssql.fhict.local;Database=dbi484379;User Id=dbi484379;Password=1234;");
            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM ApartmentsData WHERE ID = @ID", con);

            cmd.Parameters.AddWithValue("@ID", id);
            cmd.ExecuteNonQuery();


            con.Close();

        }

        public void createScheduleData(int apartmentID, string eventMessage, string timeForEvent)
        {
            SqlConnection con = new SqlConnection(@"Server=mssql.fhict.local;Database=dbi484379;User Id=dbi484379;Password=1234;");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Schedule values (@ApartmentID,@Event, @DateAndTime )", con);

            cmd.Parameters.AddWithValue("@ApartmentID", apartmentID);
            cmd.Parameters.AddWithValue("@Event", eventMessage);
            cmd.Parameters.AddWithValue("@DateAndTime", timeForEvent);
       

            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void updateScheduleData(int ID, int apartmentID, string eventMessage, string timeForEvent)
        {
            SqlConnection con = new SqlConnection(@"Server=mssql.fhict.local;Database=dbi484379;User Id=dbi484379;Password=1234;");
            con.Open();
            SqlCommand cmd = new SqlCommand("Update Schedule set ApartmentID=@ApartmentID,Event=@Event, DateAndTime=@DateAndTime where ID=@ID", con);
            cmd.Parameters.AddWithValue("@ID", ID);
            cmd.Parameters.AddWithValue("@ApartmentID", apartmentID);
            cmd.Parameters.AddWithValue("@Event", eventMessage);
            cmd.Parameters.AddWithValue("@DateAndTime", timeForEvent);
         

            cmd.ExecuteNonQuery();
            con.Close();

        }

        public void deleteScheduleData(int id)
        {
            SqlConnection con = new SqlConnection(@"Server=mssql.fhict.local;Database=dbi484379;User Id=dbi484379;Password=1234;");
            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM Schedule WHERE ID = @ID", con);

            cmd.Parameters.AddWithValue("@ID", id);
            cmd.ExecuteNonQuery();
            con.Close();

        }
    }
}
