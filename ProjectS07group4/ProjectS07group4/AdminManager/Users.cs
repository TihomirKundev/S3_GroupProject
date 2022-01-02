using System.Collections.Generic;
using ProjectS07group4.UploadData;
namespace ProjectS07group4.AdminManager
{
    public class Users
    {
        private UploadApartmentData apartment = new UploadApartmentData();
        private UploadScheduleData schedule = new UploadScheduleData();
        private UploadAgreementData agreement = new UploadAgreementData();
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
        public Users(int userID2, string name2, string password2, int apartmentID2)
        {
            this.ID = userID2;
            this.UserEmail = name2;
            this.UserPassword = password2;
            this.UserApartmentID = apartmentID2;
            GetApartment = apartment.UploadUserApartment(this);
            GetSchedules = schedule.SchedulesForUser(this);
            GetAgreements = agreement.GetAgreements(this);
        }
        public Users(string updateSchedules)
        {
            GetSchedules = schedule.SchedulesForUser(this);
        }
        protected internal Apartment GetApartment
        {
            get;
            private set;
        }
        protected internal List<Schedule> GetSchedules
        {
            get;
            private set;
        }
        public List<Agreement> GetAgreements
        {
            get;
            private set;
        }
    }
}
