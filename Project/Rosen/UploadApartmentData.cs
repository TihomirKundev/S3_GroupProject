using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Project
{
    class UploadApartmentData
    {
        private readonly string dataLink = "Server=mssql.fhict.local;Database=dbi484379;User Id=dbi484379;Password=1234;";
        public Apartment UploadUserApartment()
        {
            Apartment apartmentUser = new Apartment();
            SqlConnection con = new SqlConnection(@dataLink);
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM ApartmentsData WHERE ID = '" + User.ApartmentID+ "'", con);
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

                apartmentUser=new Apartment(ID, address, price, propertyType, interior, bedrooms, roomsInApartment);
            }
            con.Close();
            return apartmentUser;
        }
        public List<Apartment> UploadDataWapartments()
        {
            List<Apartment> apartments = new List<Apartment>();
            SqlConnection con = new SqlConnection(@dataLink);
            SqlCommand cmd = new SqlCommand("Select u.ID,u.Username,a.ID as Apartment," +
                "a.Address, a.Price,a.PropertyType, a.Interior, a.Bedrooms, a.RoomsInApartment From UsersData u inner join ApartmentsData a ON u.Apartment = a.ID", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                int ID = Convert.ToInt32(dr["ID"]);
                string email = Convert.ToString(dr["Username"]);
                int apartmentID = Convert.ToInt32(dr["Apartment"]); 
                string address = Convert.ToString(dr["Address"]);
                double price = Convert.ToDouble(dr["Price"]);
                string propertyType = Convert.ToString(dr["PropertyType"]);
                string interior = Convert.ToString(dr["Interior"]);
                int bedrooms = Convert.ToInt32(dr["Bedrooms"]);
                int roomsInApartment = Convert.ToInt32(dr["RoomsInApartment"]);
                apartments.Add(new Apartment(ID,email,apartmentID, address, price,propertyType, interior, bedrooms, roomsInApartment));
            }
            con.Close();
            return apartments;
        }
        public List<Apartment> AllApartments()
        {
            List<Apartment> apartments = new List<Apartment>();
            SqlConnection conn = new SqlConnection(@dataLink);
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
        public void ModifyApartmentData(string option, Apartment apartment)
        {
            SqlConnection con = new SqlConnection(@dataLink);
            con.Open();
            SqlCommand cmd = new SqlCommand("");
            if (option == "Insert")
            {
                cmd = new SqlCommand("insert into ApartmentsData values (@Address, @Price, @PropertyType,@Interior,@Bedrooms,@RoomsInApartment)", con);
                cmd.Parameters.AddWithValue("@Address", apartment.Address);
                cmd.Parameters.AddWithValue("@Price", apartment.Price);
                cmd.Parameters.AddWithValue("@PropertyType", apartment.PropertyType);
                cmd.Parameters.AddWithValue("@Interior", apartment.Interior);
                cmd.Parameters.AddWithValue("@Bedrooms", apartment.Bedrooms);
                cmd.Parameters.AddWithValue("@RoomsInApartment", apartment.RoomsInApartment);

            }
            else if (option == "Update")
            {
                cmd = new SqlCommand("Update ApartmentsData set Address=@Address,Price=@Price,PropertyType=@PropertyType ,Interior=@Interior," +
                    "Bedrooms=@Bedrooms, RoomsInApartment = @RoomsInApartment where ID='" + @apartment.ID+ "'", con);
                cmd.Parameters.AddWithValue("@Address", apartment.Address);
                cmd.Parameters.AddWithValue("@Price", apartment.Price);
                cmd.Parameters.AddWithValue("@PropertyType", apartment.PropertyType);
                cmd.Parameters.AddWithValue("@Interior", apartment.Interior);
                cmd.Parameters.AddWithValue("@Bedrooms", apartment.Bedrooms);
                cmd.Parameters.AddWithValue("@RoomsInApartment", apartment.RoomsInApartment);
                cmd.Parameters.AddWithValue("@ID", apartment.ID);
            }
            else
            {
                cmd = new SqlCommand("DELETE FROM ApartmentsData WHERE ID = '" + @apartment.ID + "'", con);
                cmd.Parameters.AddWithValue("@ID", apartment.ID);
            }
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public int QuantityOfRooms(Apartment apartment)
        {
            SqlConnection conn = new SqlConnection(@dataLink);
            SqlCommand cmd = new SqlCommand("SELECT * FROM UsersData Where Apartment = '"+apartment.ID+"'", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            int id = dt.Rows.Count;
            conn.Close();
            return id;
        }
        public List<String> ApartmentDataInfo(int id)
        {
            List<string> str = new List<string>();
            SqlConnection con = new SqlConnection(@dataLink);
            con.Open();
            //SqlCommand cmd = new SqlCommand("Select * from Apartments a inner join Users u ON a.ID=u.ID WHERE a.ID='"+1+"'", con);
            SqlCommand cmd = new SqlCommand("Select * from ApartmentsData a WHERE a.ID='" + id + "'", con);

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                str.Add(dr.GetValue(0).ToString());
                str.Add(dr.GetValue(1).ToString());
                str.Add(dr.GetValue(2).ToString());
                str.Add(dr.GetValue(3).ToString());
                str.Add(dr.GetValue(4).ToString());
                str.Add(dr.GetValue(5).ToString());
                str.Add(dr.GetValue(6).ToString());


            }
            con.Close();
            return str;
        }

     
      
        
    }
}
