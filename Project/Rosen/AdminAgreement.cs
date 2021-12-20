using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace Project
{
    class AdminAgreement
    {
        private readonly string dataLink = "Server=mssql.fhict.local;Database=dbi484379;User Id=dbi484379;Password=1234;";
        private UploadAgreementData agreements = new UploadAgreementData();
        private DataTable agreementsDataTable;
        public AdminAgreement()
        {
            getAgreements = agreements.allAgreements();
        }
        public List<Agreement> getAgreements
        {
            get;
            private set;
        }
        public void deleteAgreement(Agreement deleteAgr)
        {
            agreements.deleteStudentAgreement(deleteAgr);
            getAgreements = agreements.allAgreements();
        }
    }
}
