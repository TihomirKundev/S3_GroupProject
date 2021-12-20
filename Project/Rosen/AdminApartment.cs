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
        private UploadApartmentData uploadApartmentData = new UploadApartmentData();
        private CheckData checkData = new CheckData();
        private DataTable apartments, apartmentAndUsers;
        public AdminApartment()
        {
            allApartmentsData = uploadApartmentData.AllApartments();
            apartmentsAndUser = uploadApartmentData.UploadDataWapartments();
        }


        public List<Apartment> allApartmentsData
        {
            get;
            private set;
        }
        public List<Apartment> apartmentsAndUser
        {
            get;
            private set;
        }
        public void ModifyApartmentData(string option, Apartment apartment)
        {
            uploadApartmentData.ModifyApartmentData(option, apartment);
            allApartmentsData = uploadApartmentData.AllApartments();
            apartmentsAndUser = uploadApartmentData.UploadDataWapartments();
        }
        public List<String> apartmentDataInfo(int apartmentID)
        {
            return uploadApartmentData.apartmentDataInfo(apartmentID);
        }
        public int quantityOfRooms(Apartment apartment)
        {
            return uploadApartmentData.quantityOfRooms(apartment);
        }
   
        
        public List<int> addApartmentIDstoComboBox()
        {
            allApartmentsData = uploadApartmentData.AllApartments();
            apartmentsAndUser = uploadApartmentData.UploadDataWapartments();
            return checkData.addApartmentIDstoComboBox();
        }
      
    }
}
