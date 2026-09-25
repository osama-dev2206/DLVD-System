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

            return  clsCheckIfTestHasFinishedOrNot.CheckIfTestHasFinishedOrNot(TestTypeID:(int)clsTestTypes.enTestTypes.VisionTest, LocalApplicationID: LocalDrivingLicenseApplication);
        }

        public static bool CheckIfWrittenTestHasCompletedOrNot(int LocalDrivingLicenseApplication)
        {

            return clsCheckIfTestHasFinishedOrNot.CheckIfTestHasFinishedOrNot(TestTypeID: (int)clsTestTypes.enTestTypes.WrittenTest, LocalApplicationID: LocalDrivingLicenseApplication);
        }

        public static bool CheckIfStreetTestHasCompletedOrNot(int LocalDrivingLicenseApplication) // street test is also known as practical test
        {
            return clsCheckIfTestHasFinishedOrNot.CheckIfTestHasFinishedOrNot(TestTypeID: (int)clsTestTypes.enTestTypes.PracticalTest, LocalApplicationID: LocalDrivingLicenseApplication);
        }



    }
}
