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
        private UploadComplaintData complaints = new UploadComplaintData();
        private readonly string dataLink = "Server=mssql.fhict.local;Database=dbi484379;User Id=dbi484379;Password=1234;";
        public AdminComplaint()
        {
            getComplaints = complaints.AllComplaints(); ;
        }
        public List<Complaint> getComplaints
        {
            get;
            private set;
        }
        public void DeleteComplaint(Complaint deleteComplaint)
        {
            complaints.DeleteComplainMessages(deleteComplaint);
            getComplaints = complaints.AllComplaints(); 
        }
    }
}
