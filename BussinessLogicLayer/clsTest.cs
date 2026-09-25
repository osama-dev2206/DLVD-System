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
                            return false;
                        }
                    }
  
            }
            return false;
        }


        public Action<int> OnTestSaveGetTestID; 

    }
}
