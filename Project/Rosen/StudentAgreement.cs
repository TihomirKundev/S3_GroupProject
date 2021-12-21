using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace Project
{
    class StudentAgreement
    {
        private readonly UploadAgreementData agreements = new UploadAgreementData();
        
        public List<Agreement> AgreementConnectedToUser(int changeData)
        {
            UploadAgreementData agreements= new UploadAgreementData();
            return agreements.AgreementsConnectedToUser(changeData);
        }
        public void ApproveAgreement(int ID,string approvedNotApproved)
        {
            agreements.ApproveAgreement(ID, approvedNotApproved);
        }
        public DataTable UsersInTheSameApartment()
        {
            return agreements.UsersInTheSameApartment();
        }
        public void CreateAgreement(Agreement makeAgreement)
        {
            agreements.CreateAgreement(makeAgreement);
        }
    }
}
