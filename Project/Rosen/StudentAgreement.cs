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
        UploadAgreementData agreements = new UploadAgreementData();
        
        public List<Agreement> agreementConnectedToUser(int changeData)
        {
            UploadAgreementData agreements= new UploadAgreementData();
            return agreements.agreementsConnectedToUser(changeData);
        }
        public void approveAgreement(int ID,string approvedNotApproved)
        {
            agreements.approveAgreement(ID, approvedNotApproved);
        }
        public DataTable usersInTheSameApartment()
        {
            return agreements.usersInTheSameApartment();
        }
        public void createAgreement(Agreement makeAgreement)
        {
            agreements.createAgreement(makeAgreement);
        }
    }
}
