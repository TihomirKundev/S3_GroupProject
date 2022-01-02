using System.Collections.Generic;
using ProjectS07group4.UploadData;

namespace ProjectS07group4.AdminManager
{
    class AdminComplaint
    {
        private readonly UploadComplaintData complaints = new UploadComplaintData();
        public List<Complaint> AllComplaints { get; private set; }
        public AdminComplaint()
        {
            AllComplaints = complaints.AllComplaints();
        }
        public void DeleteComplaintData(int id)
        {
            for (int i = 0; i < AllComplaints.Count; i++)
            {
                if (AllComplaints[i].ID == id)
                    AllComplaints.RemoveAt(i);
            }
            complaints.DeleteComplainMessages(new Complaint(id, 0, ""));
        }
    }
}
