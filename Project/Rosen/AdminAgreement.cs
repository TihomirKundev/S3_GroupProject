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
        private readonly UploadAgreementData agreements = new UploadAgreementData();
        public List<Agreement> GetAgreements { get; private set; }
        public AdminAgreement()
        {
            GetAgreements = agreements.AllAgreements();
        }
        public void DeleteAgreement(Agreement deleteAgr)
        {
            agreements.DeleteStudentAgreement(deleteAgr);
            GetAgreements = agreements.AllAgreements();
        }
    }
}