using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace BussinessLogicLayer
{
    public  sealed class clsTest
    {
        public int TestID { get; private set; }
        public int AppointmentIDOfTest { get; private set; }
        public byte TestResult { get;  set; } // pass =1  , fail =0 

        public string ? Notes { get;  set; }

        public int CreatedByUserID { get; private set; }

        enum enMode { Add = 1, Update = 2 }
        enMode Mode;

        public clsTest(int AppointmentIDOfTest)
        {
            Mode = enMode.Add;
            this.TestID = -1;
            this.AppointmentIDOfTest = AppointmentIDOfTest;
            this.CreatedByUserID = clsCurrentLoggedInUser.User.UserID;
        }

        private bool AddNewTest()
        {
            this.TestID = clsAddNewTest.AddNewTest(AppointmentIDOfTest: this.AppointmentIDOfTest, TestResult: this.TestResult, Notes: this.Notes, CreatedByUserID: this.CreatedByUserID);
            return (this.TestID != -1);
        }

        public bool Save()
        {
            if(clsVisionTests.IsVisionTestAppointmentLocked(this.AppointmentIDOfTest))
            {
                OnTestSaveGetError?.Invoke("You cannot save the test because the appointment is locked.");
                return false; // if the test appointment is locked, do not allow saving the test
            }

            switch (this.Mode)
            {
                case enMode.Add:
                    {
                        if (this.AddNewTest())
                        {
                            this.Mode = enMode.Update;
                            OnTestSaveGetTestID?.Invoke(this.TestID);
                            return clsVisionTests.LockVisionTestAppointment(this.AppointmentIDOfTest); // lock the test appointment after saving the test
                        }
                        else
                        {
                            OnTestSaveGetError?.Invoke("Failed To Save Test Results!");
                            return false;
                        }
                    }
  
            }
            return false;
        }

        internal enum enTestResult {None =-1 , Pass = 1, Fail = 0 }

        internal static enTestResult GetTestResultEnum(int  LocalDrivingLicenseApplication , int TestTypeID)
        {
            bool ? Res = clsGetTestResultByTestAppointmentID.GetTestResultByTestAppointmentID(LocalDrivingLicenseApplication, TestTypeID);
            if (Res == null)
                return enTestResult.None;
            else if (Res == true)
                return enTestResult.Pass;
            else if (Res == false)
                return enTestResult.Fail;
            else  return enTestResult.None;
        }

        public Action<int> OnTestSaveGetTestID; 
        public Action<string> OnTestSaveGetError;

    }
}
