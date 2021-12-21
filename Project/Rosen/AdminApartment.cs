using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Project
{
    class AdminApartment
    {
        private readonly UploadApartmentData uploadApartmentData = new UploadApartmentData();
        private readonly CheckData checkData = new CheckData();
        public List<Apartment> AllApartmentsData { get; private set; }
        public List<Apartment> ApartmentsAndUser { get; private set; }
        public AdminApartment()
        {
            AllApartmentsData = uploadApartmentData.AllApartments();
            ApartmentsAndUser = uploadApartmentData.UploadDataWapartments();
        }
        public void ModifyApartmentData(string option, Apartment apartment)
        {
            uploadApartmentData.ModifyApartmentData(option, apartment);
            AllApartmentsData = uploadApartmentData.AllApartments();
            ApartmentsAndUser = uploadApartmentData.UploadDataWapartments();
        }
        public List<String> ApartmentDataInfo(int apartmentID)
        {
            return uploadApartmentData.ApartmentDataInfo(apartmentID);
        }
        public int QuantityOfRooms(Apartment apartment)
        {
            return uploadApartmentData.QuantityOfRooms(apartment);
        }
        public List<int> AddApartmentIDstoComboBox()
        {
            AllApartmentsData = uploadApartmentData.AllApartments();
            ApartmentsAndUser = uploadApartmentData.UploadDataWapartments();
            return checkData.AddApartmentIDstoComboBox();
        }
      
    }
}
