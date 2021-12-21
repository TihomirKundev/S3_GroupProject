using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Project
{
    class AdminComplaint
    {
        private readonly UploadComplaintData complaints = new UploadComplaintData();
        public List<Complaint> GetComplaints { get; private set; }
        public AdminComplaint()
        {
            GetComplaints = complaints.AllComplaints(); ;
        }
        public void DeleteComplaint(Complaint deleteComplaint)
        {
            complaints.DeleteComplainMessages(deleteComplaint);
            GetComplaints = complaints.AllComplaints(); 
        }
    }
}
