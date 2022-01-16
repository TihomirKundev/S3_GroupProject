using System.Collections.Generic;
using ProjectS07group4.UploadData;
namespace ProjectS07group4 
{
    public class User : GeneralUploadData
    {
        public int UserIdentity { 
            get; private set; 
        }
        public string UserEmail { 
            get; private set; }
        public string UserPassword { 
            get; private set; }
        public int UserApartmentID { 
            get; private set; }
        public Apartment GetApartment
        {
            get;
            private set;
        }
        public List<Schedule> GetSchedules
        {
            get;
            private set;
        }
        public List<Agreement> GetAgreementsUserMade
        {
            get;
            private set;
        }
        public List<Agreement> GetAgreementsForUser
        {
            get;
            private set;
        }
        public List<User> UsersInTheSameApartment
        {
            get;
            private set;
        }
        public User(int userID2, string name2, string password2, int apartmentID2)
        {
            this.UserIdentity = userID2;
            this.UserEmail = name2;
            this.UserPassword = password2;
            this.UserApartmentID = apartmentID2;
            GetApartment = apartment.UploadUserApartment(this);
            GetSchedules = schedule.SchedulesForUser(this);
            GetAgreementsUserMade = agreement.AgreementsFromUser(this);
            GetAgreementsForUser = agreement.AgreementsForUser(this);
            UsersInTheSameApartment = users.UsersInTheSameApartment(this);
        }
        public void SendAgreement(string forUser, string agreemenText, string startDate, string endDate,string forUserName)
         {
             Agreement createAgr = new Agreement(0, forUser, agreemenText, "Waiting for respond", startDate, endDate);
             GetAgreementsUserMade.Add(new Agreement(0,forUserName,agreemenText,"Waiting for respond",startDate,endDate));
            
             agreement.CreateAgreement(createAgr, this);
         }
        public void ApproveDontApproveAgreement(Agreement approve)
         {
             for (int i = 0; i < GetAgreementsForUser.Count; i++)
             {
                 if (GetAgreementsForUser[i].ID == approve.ID)
                 {
                     GetAgreementsForUser[i] = approve;
                     agreement.ApproveAgreement(GetAgreementsForUser[i]);
                 }
             }
         }
        public void SendComplaint(string message)
        {
            UploadData.UploadComplaintData createComplaint = new UploadComplaintData();
            createComplaint.SendComplaint(this.UserApartmentID, message);
        }
       
    }
}
