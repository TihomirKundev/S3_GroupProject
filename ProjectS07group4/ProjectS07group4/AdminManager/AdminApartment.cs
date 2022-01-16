using System;
using System.Collections.Generic;
using ProjectS07group4.UploadData;
namespace ProjectS07group4.AdminManager
{
    public class AdminApartment : GeneralUploadData
    {
        public List<Apartment> AllApartments { get; private set; }
        public AdminApartment()
        {
            AllApartments = apartment.AllApartments();
        }
        

        public void DeleteComplaint(Complaint complaint)
        {
            foreach (Apartment x in AllApartments)
                if (x.ID == complaint.ApartmentID)
                    x.DeleteComplaintData(complaint.ID);
            
        }
        public List<Complaint> GetAllComplaints()
        {
            List<Complaint> m = new List<Complaint>();

            foreach (Apartment x in AllApartments)
            {
                if (x.apartmentComplaints.Count > 0)
                    foreach (Complaint x2 in x.apartmentComplaints)
                        m.Add(x2);
            }
            return m;
        }
        public Complaint GetComplaint(int id)
        {
            foreach (Apartment x in AllApartments)
            {
                foreach(Complaint x2 in x.apartmentComplaints)
                if (x2.ID == id)
                    return x2;
            }
            return null;
        }
        public Apartment GetApartment(int id)
        {
            foreach (Apartment x in AllApartments)
            {
                    if (x.ID == id)
                        return x;
            }
            return null;
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
            apartment.ModifyUserApartment("Insert", 0, address, price, propertyType, interior, bedrooms, roomsInApartment);
            AllApartments.Add(apartment.AllApartments()[AllApartments.Count]);
        }
        public void UpdateApartmentData(int id, string address, double price, string propertyType, string interior,
           int bedrooms, int roomsInApartment)
        {
            for (int i = 0; i < AllApartments.Count; i++)
            {
                if (AllApartments[i].ID == id)
                {
                    AllApartments[i].UpdateApartment(address, price, propertyType, interior, bedrooms, roomsInApartment);
                    break;
                }
            }
            apartment.ModifyUserApartment("Update", id, address, price, propertyType, interior, bedrooms, roomsInApartment);
        }
        
        public void DeleteApartmentData(Apartment apartmentInfo)
        {
            for (int i = 0; i < AllApartments.Count; i++)
            {
                if (AllApartments[i].ID == apartmentInfo.ID)
                {
                    foreach (Complaint x in AllApartments[i].apartmentComplaints)
                    {
                        complaint.DeleteComplainMessages(x);
                    }
                    users.UpdateUserApartmentToNull(apartmentInfo);
                    agreement.DeleteAgreementData(apartmentInfo);
                    schedule.DeleteScheduleData(apartmentInfo);
                    AllApartments.RemoveAt(i);
                    break;
                }
            }

            apartment.ModifyUserApartment("Delete", apartmentInfo.ID, "", 0, "", "", 0, 0);

        }
   
        private bool CheckQuantityOfApartment(Apartment apartmentInfo, int quantity, List<Users> AllUsers)
        {
            bool check = false;
            int count = 0;
            foreach (Users x in AllUsers)
                if (x.UserApartmentID == apartmentInfo.ID)
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
                if (CheckQuantityOfApartment(GetApartment(AllApartments[i].ID), AllApartments[i].RoomsInApartment, AllUsers) == true)
                    items.Add(AllApartments[i].ID);
            }
            return items;
        }
        public List<String> ApartmentDataInfo(Apartment apartmentInfo)
        {
            List<string> str = new List<string>();
            for (int i = 0; i < AllApartments.Count; i++)
                if (AllApartments[i].ID == apartmentInfo.ID)
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
