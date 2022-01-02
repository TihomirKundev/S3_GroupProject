using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Complaint
    {
        public int ApartmentID { get; private set; }
        public string ComplaintMessage { get; private set; }

        public Complaint(int apartmentID, string complaintMessage)
        {
            this.ApartmentID = apartmentID;
            this.ComplaintMessage= complaintMessage;
        }

    }
}
