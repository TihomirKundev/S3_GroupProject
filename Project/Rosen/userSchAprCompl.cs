using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace Project
{
    class UserSchAprCompl
    {
        public void SendComplaint(Complaint complaintM)
        {
            UploadComplaintData complaint = new UploadComplaintData();
            complaint.SendComplaint(complaintM);
        }
        public Apartment UserApartment()
        {
            UploadApartmentData apartmentData = new UploadApartmentData();
            return apartmentData.UploadUserApartment();
        }
        public List<Schedule> ScheduleForUser()
        {
            UploadScheduleData schedule = new UploadScheduleData();
            return schedule.SchedulesForUser();
        }
      
    }
}
