using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace BussinessLogicLayer
{
    public static  class clsCheckTests
    {

        public static bool CheckIfVisionTestHasCompletedOrNot(int LocalDrivingLicenseApplication)
        {
           int ApplicantPersonID = clsLocalDrivingLicenseApplications.GetApplicantPersonIDByLDLApplicationID(LocalDrivingLicenseAppID: LocalDrivingLicenseApplication);
           return  clsCheckIfTestHasFinishedOrNot.CheckIfTestHasFinishedOrNot(TestTypeID:(int)clsTestTypes.enTestTypes.VisionTest, PersonID:ApplicantPersonID);
        }

        public static bool CheckIfWrittenTestHasCompletedOrNot(int LocalDrivingLicenseApplication)
        {
            int ApplicantPersonID = clsLocalDrivingLicenseApplications.GetApplicantPersonIDByLDLApplicationID(LocalDrivingLicenseAppID: LocalDrivingLicenseApplication);
            return clsCheckIfTestHasFinishedOrNot.CheckIfTestHasFinishedOrNot(TestTypeID: (int)clsTestTypes.enTestTypes.WrittenTest, PersonID: ApplicantPersonID);
        }

        public static bool CheckIfStreetTestHasCompletedOrNot(int LocalDrivingLicenseApplication) // street test is also known as practical test
        {
            int ApplicantPersonID = clsLocalDrivingLicenseApplications.GetApplicantPersonIDByLDLApplicationID(LocalDrivingLicenseAppID: LocalDrivingLicenseApplication);
            return clsCheckIfTestHasFinishedOrNot.CheckIfTestHasFinishedOrNot(TestTypeID: (int)clsTestTypes.enTestTypes.PracticalTest, PersonID: ApplicantPersonID);
        }



    }
}
