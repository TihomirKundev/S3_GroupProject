using System;
using System.Collections.Generic;
using ProjectS07group4.UploadData;

namespace ProjectS07group4.AdminManager
{
    class AdminApartment
    {
        private readonly UploadApartmentData apartments = new UploadApartmentData();
        public List<Apartment> AllApartments { get; private set; }
        public AdminApartment()
        {
            AllApartments = apartments.AllApartments();
        }
        public int QuantityOfRooms(Apartment apartment, List<Users> allUsers)
        {
            int count = 0;
            for (int i = 0; i < allUsers.Count; i++)
                if (apartment.ID == allUsers[i].UserApartmentID)
                    count++;

            return count;
        }
        public void AddApartmentData(string address, double price, string propertyType, string interior,
        int bedrooms, int roomsInApartment)
        {
            apartments.ModifyUserApartment("Insert", 0, address, price, propertyType, interior, bedrooms, roomsInApartment);
            AllApartments.Add(apartments.AllApartments()[AllApartments.Count]);
        }
        public void UpdateApartmentData(int id, string address, double price, string propertyType, string interior,
           int bedrooms, int roomsInApartment)
        {
            Apartment updateA = new Apartment(id, address, price, propertyType, interior, bedrooms, roomsInApartment);
            int apartmentI = 0;
            for (int i = 0; i < AllApartments.Count; i++)
            {
                if (AllApartments[i].ID == id)
                {
                    apartmentI = i;
                    break;
                }
            }
            AllApartments[apartmentI] = updateA;
            apartments.ModifyUserApartment("Update", id, address, price, propertyType, interior, bedrooms, roomsInApartment);
        }
        public void DeleteApartmentData(int id)
        {
            for (int i = 0; i < AllApartments.Count; i++)
            {
                if (AllApartments[i].ID == id)
                    AllApartments.RemoveAt(i);
            }
            apartments.ModifyUserApartment("Delete", id, "", 0, "", "", 0, 0);
        }
        private bool CheckQuantityOfApartment(int id, int quantity, List<Users> AllUsers)
        {
            bool check = false;
            int count = 0;
            foreach (Users x in AllUsers)
                if (x.UserApartmentID == id)
                    count++;

            if (count < quantity)
                check = true;
            return check;
        }
        public List<int> AddApartmentIDstoComboBox(List<Users> AllUsers)
        {
            List<int> items = new List<int>();

            for (int i = 0; i < AllApartments.Count; i++)
            {
                if (CheckQuantityOfApartment(AllApartments[i].ID, AllApartments[i].RoomsInApartment,AllUsers) == true)
                    items.Add(AllApartments[i].ID);
            }
            return items;
        }
        public List<String> ApartmentDataInfo(int apartmentID)
        {
            List<string> str = new List<string>();
            for (int i = 0; i < AllApartments.Count; i++)
                if (AllApartments[i].ID == apartmentID)
                {
                    str.Add(AllApartments[i].ID.ToString());
                    str.Add(AllApartments[i].Address);
                    str.Add(AllApartments[i].Price.ToString());
                    str.Add(AllApartments[i].PropertyType);
                    str.Add(AllApartments[i].Interior);
                    str.Add(AllApartments[i].Bedrooms.ToString());
                    str.Add(AllApartments[i].RoomsInApartment.ToString());
                }
            return str;
        }
    }
}
