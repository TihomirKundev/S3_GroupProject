using System;
using System.Collections.Generic;
namespace ProjectS07group4.UploadData
{
    public class GeneralUploadData 
    {
        private static UploadApartmentData uploadApartmentData = new UploadApartmentData();
        private static UploadScheduleData uploadScheduleData = new UploadScheduleData();
        private static UploadAgreementData uploadAgreementData = new UploadAgreementData();
        private static UploadStudentData uploadStudentData = new UploadStudentData();
        private static UploadComplaintData uploadComplaintData = new UploadComplaintData();

        protected UploadApartmentData apartment {
            get { return uploadApartmentData; }
        }
        protected UploadScheduleData schedule
        {
            get { return uploadScheduleData; }
        }
        protected UploadAgreementData agreement
        {
            get { return uploadAgreementData; }
        }
        protected UploadStudentData users
        {
            get { return uploadStudentData; }
        }
        protected UploadComplaintData complaint
        {
            get { return uploadComplaintData; }
        }

    }
}
