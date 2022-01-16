using System.Collections.Generic;
using ProjectS07group4.UploadData;
namespace ProjectS07group4.AdminManager
{
    public class Users : GeneralUploadData 
    {
        private AdminApartment adminApartment = new AdminApartment();

        public int ID
        {
            get; private set;
        }
        public string UserEmail
        {
            get; private set;
        }
        public string UserPassword
        {
            get; private set;
        }
        public int UserApartmentID
        {
            get; private set;
        }
        protected internal Apartment UserApartment
        {
            get;
            private set;
        }
        protected internal List<Schedule> UserSchedule
        {
            get;
            private set;
        }
        public List<Agreement> UserAgreements
        {
            get;
            private set;
        }
        public Users(int userID2, string name2, string password2, int apartmentID2)
        {
            this.ID = userID2;
            this.UserEmail = name2;
            this.UserPassword = password2;
            this.UserApartmentID = apartmentID2;
            UserApartment = apartment.UploadUserApartment(this);
            UserSchedule = schedule.SchedulesForUser(this);
            UserAgreements = agreement.GetAgreements(this);
        }
        public void UpdateUser(string email,string password, int apartmentID)
        {
            this.UserEmail = email;
            this.UserPassword = password;
            this.UserApartmentID = apartmentID;
        foreach (Apartment x in adminApartment.AllApartments)
                if (x.ID == this.UserApartmentID)
                    UserApartment = x;
        }
        
    }
}
