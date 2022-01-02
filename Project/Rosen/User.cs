using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class User
    {
        private Apartment apartment;
        private List<Schedule> schedules = new List<Schedule>();
        private List<Agreement> agreements = new List<Agreement>();
        private Complaint complaint;
        private Schedule schedule;
        private Agreement agreement;
2
        public int UserIdentity { get; private set; }
        public string UserEmail { get; private set; }
        public string UserPassword { get; private set; }

        public User(int userID, string email, string password)
        {
            UserIdentity = userID;
            UserEmail = email;
            UserPassword = password;
        }
        public void SendComplaint(Complaint complaint, Apartment apartment)
        {
            
        }
        public Apartment UserApartment(User user)
        {
           
        }
        public List<Schedule> ScheduleForUser(User user)
        {
            
        }
        public List<Agreement> AgreementConnectedToUser(User user)
        {

        }
        public void ApproveAgreement(User user, Agreement agreement)
        {

        }
        public DataTable UsersInTheSameApartment()
        {

        }
        public void CreateAgreement(Agreement agreement)
        {

        }
    }
}
