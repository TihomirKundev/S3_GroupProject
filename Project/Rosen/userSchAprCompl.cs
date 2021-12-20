using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace Project
{
    class userSchAprCompl
    {
        public void sendComplaint(Complaint complaintM)
        {
            UploadComplaintData complaint = new UploadComplaintData();
            complaint.sendComplaint(complaintM);
        }
        public Apartment userApartment()
        {
            UploadApartmentData apartmentData = new UploadApartmentData();
            return apartmentData.uploadUserApartment();
        }
        public List<Schedule> scheduleForUser()
        {
            UploadScheduleData schedule = new UploadScheduleData();
            return schedule.schedulesForUser();
        }
      
    }
}
