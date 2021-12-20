using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Agreement
    {
        public int ID { get; private set; }
        public string CreatedUserID { get; private set; }
        public int ApartmentID { get; private set; }
        public string AgreementForUserID { get; private set; }

        public string AgreementText { get; private set; }
        public string Process { get; private set; }
        public string StartDate { get; private set; }
        public string EndDate { get; private set; }



        public Agreement(int ID, string createdUserID, int apartmentID, string agreementForUserID, string agreementText,
            string process, string startDate, string endDate)
        {
            this.ID = ID;
            this.CreatedUserID = createdUserID;
            this.ApartmentID = apartmentID;
            this.AgreementForUserID= agreementForUserID;
            this.AgreementText = agreementText;
            this.Process = process;
            this.StartDate = startDate;
            this.EndDate = endDate;
        }
    }
}
