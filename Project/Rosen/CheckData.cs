using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Project
{
    class CheckData
    {
        private readonly string dataLink = "Server=mssql.fhict.local;Database=dbi484379;User Id=dbi484379;Password=1234;";
        private bool CheckQuantityOfApartment(int id, int quantity)
        {
            bool check = false;
            int count = 0;
            SqlConnection con = new SqlConnection(@dataLink);
            con.Open();

            SqlCommand cmd = new SqlCommand("Select Apartment from UsersData where Apartment = '" + id + "'", con);

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                count++;
            }
            con.Close();
            if (count < quantity)
                check = true;

            return check;
        }
        public List<int> AddApartmentIDstoComboBox()
        {
            List<int> ids = new List<int>();
            List<int> roomMax = new List<int>();
            List<int> items = new List<int>();
            SqlConnection con = new SqlConnection(@dataLink);
            con.Open();

            SqlCommand cmd = new SqlCommand("Select * from ApartmentsData", con);

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ids.Add(Convert.ToInt32(dr.GetValue(0)));
                roomMax.Add(Convert.ToInt32(dr.GetValue(6)));

            }
            con.Close();
            for (int i = 0; i < ids.Count; i++)
            {
                if (CheckQuantityOfApartment(ids[i], roomMax[i]) == true)
                    items.Add(ids[i]);
            }
            return items;
        }

        public List<int> AddApartmentIds()
        {
            List<int> ids = new List<int>();
            SqlConnection con = new SqlConnection(@dataLink);
            con.Open();

            SqlCommand cmd = new SqlCommand("Select * from ApartmentsData", con);

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ids.Add(Convert.ToInt32(dr.GetValue(0)));
            }

            return ids;
        }
        public List<int> AddUserIds(int addUserIds)
        {
            List<int> ids = new List<int>();
            SqlConnection con = new SqlConnection(@dataLink);
            con.Open();

            SqlCommand cmd = new SqlCommand("Select * from UsersData where Apartment = '" + addUserIds + "'", con);

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ids.Add(Convert.ToInt32(dr.GetValue(0)));
            }

            return ids;
        }

        protected internal int GetQuantity(int id)
        {
            int quant = 0;
            SqlConnection con = new SqlConnection(@dataLink);
            con.Open();

            SqlCommand cmd = new SqlCommand("Select RoomsInApartment from ApartmentsData where ID = '" + id + "'", con);

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                quant = Convert.ToInt32(dr.GetValue(0));
            }

            return quant;
        }
        protected internal bool CheckQuantity(int id, int quantity)
        {
            bool check = false;
            int count = 0;
            SqlConnection con = new SqlConnection(@dataLink);
            con.Open();

            SqlCommand cmd = new SqlCommand("Select Apartment from UsersData where Apartment = '" + id + "'", con);

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                count++;
            }
            con.Close();
            if (count < quantity)
                check = true;

            return check;
        }
    }
}
