using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
namespace ProjectS07group4.UploadData
{
    public class UploadApartmentData : DataBaseLink
    {
        public Apartment UploadUserApartment(User user) 
        {
            SqlConnection con = new SqlConnection(this.getLink());
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM ApartmentsData WHERE ID = '" + @user.UserApartmentID + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                int ID = Convert.ToInt32(dr["ID"]);
                string address = Convert.ToString(dr["Address"]);
                double price = Convert.ToDouble(dr["Price"]);
                string propertyType = Convert.ToString(dr["PropertyType"]);
                string interior = Convert.ToString(dr["Interior"]);
                int bedrooms = Convert.ToInt32(dr["Bedrooms"]);
                int roomsInApartment = Convert.ToInt32(dr["RoomsInApartment"]);
                con.Close();

                return new Apartment(ID, address, price, propertyType, interior, bedrooms, roomsInApartment);
            }
            return null;
        }

   
        public Apartment UploadUserApartment(AdminManager.Users user) 
        {
            SqlConnection con = new SqlConnection(this.getLink());
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM ApartmentsData WHERE ID = '" + @user.UserApartmentID + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                int ID = Convert.ToInt32(dr["ID"]);
                string address = Convert.ToString(dr["Address"]);
                double price = Convert.ToDouble(dr["Price"]);
                string propertyType = Convert.ToString(dr["PropertyType"]);
                string interior = Convert.ToString(dr["Interior"]);
                int bedrooms = Convert.ToInt32(dr["Bedrooms"]);
                int roomsInApartment = Convert.ToInt32(dr["RoomsInApartment"]);
                con.Close();

                return new Apartment(ID, address, price, propertyType, interior, bedrooms, roomsInApartment);
            }
            return null;
        }

        public List<Apartment> AllApartments()
        {
            List<Apartment> apartments = new List<Apartment>();
            SqlConnection conn = new SqlConnection(this.@getLink());
            SqlCommand cmd = new SqlCommand("SELECT * FROM ApartmentsData", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                int ID = Convert.ToInt32(dr["ID"]);
                string address = Convert.ToString(dr["Address"]);
                double price = Convert.ToDouble(dr["Price"]);
                string propertyType = Convert.ToString(dr["PropertyType"]);
                string interior = Convert.ToString(dr["Interior"]);
                int bedrooms = Convert.ToInt32(dr["Bedrooms"]);
                int roomsInApartment = Convert.ToInt32(dr["RoomsInApartment"]);
                apartments.Add(new Apartment(ID, address, price, propertyType, interior, bedrooms, roomsInApartment));
            }
            conn.Close();
            return apartments;
        }
        public void ModifyUserApartment(string option, int id, string address, double price, string propertyType,
            string interior,int bedrooms, int roomsInApartment)
        {
            SqlConnection con = new SqlConnection(this.@getLink());
            con.Open();
            SqlCommand cmd = new SqlCommand("");
            if (option == "Insert")
            {
                cmd = new SqlCommand("insert into ApartmentsData values (@Address, @Price, @PropertyType,@Interior,@Bedrooms,@RoomsInApartment)", con);
                cmd.Parameters.AddWithValue("@Address", address);
                cmd.Parameters.AddWithValue("@Price", price);
                cmd.Parameters.AddWithValue("@PropertyType", propertyType);
                cmd.Parameters.AddWithValue("@Interior", interior);
                cmd.Parameters.AddWithValue("@Bedrooms", bedrooms);
                cmd.Parameters.AddWithValue("@RoomsInApartment", roomsInApartment);
            }
            else if (option == "Update")
            {
                cmd = new SqlCommand("Update ApartmentsData set Address=@Address,Price=@Price,PropertyType=@PropertyType ,Interior=@Interior," +
                    "Bedrooms=@Bedrooms, RoomsInApartment = @RoomsInApartment where ID='" + @id + "'", con);
                cmd.Parameters.AddWithValue("@Address", address);
                cmd.Parameters.AddWithValue("@Price", price);
                cmd.Parameters.AddWithValue("@PropertyType", propertyType);
                cmd.Parameters.AddWithValue("@Interior", interior);
                cmd.Parameters.AddWithValue("@Bedrooms", bedrooms);
                cmd.Parameters.AddWithValue("@RoomsInApartment", roomsInApartment);
                cmd.Parameters.AddWithValue("@ID", id);
            }
            else
            {
                cmd = new SqlCommand("DELETE FROM ApartmentsData WHERE ID = '" + @id + "'", con);
                cmd.Parameters.AddWithValue("@ID", id);
            }
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
