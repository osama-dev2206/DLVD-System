using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace BussinessLogicLayer
{
    public sealed class clsWrittenTest : clsAbTestAppointments
    {
        enMode Mode;
        // Add will be with local driving license application ID and update will be with  appointment ID
        public clsWrittenTest(int LocalDrivingLicenseApplicationID) : base(LocalDrivingLicenseApplicationID)// Add New Appointment For Vision Test
        {
            Mode = enMode.Add;
            this.TestAppointmentID = -1;

            this.TestTypeID = (int)clsTestTypes.enTestTypes.WrittenTest;
            this.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            this.PaidFees = clsTestTypes.FindTestType(this.TestTypeID).TestTypeFee;
            this.CreatedByUserID = clsCurrentLoggedInUser.User.UserID;
            this.IsLocked = false;
        }

        private clsWrittenTest(int TestAppointmentID, int TestTypeID, int LocalDrivingLicenseApplicationID
            , DateTime AppointmentDateTime, decimal PaidFees, int CreatedByUserID, bool IsLocked) // Update Existing Appointment For Vision Test(from database)
        {
            Mode = enMode.Update;
            this.TestAppointmentID = TestAppointmentID;
            this.TestTypeID = TestTypeID;
            this.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            this.AppointmentDateTime = AppointmentDateTime;
            this.PaidFees = PaidFees;
            this.CreatedByUserID = CreatedByUserID;
            this.IsLocked = IsLocked;
        }



        public static clsWrittenTest GetWrittenTestAppointmentByAppointmentID(int TestAppointmentID)
        {
            DataTable dt = clsGetAppointmentByAppointmentID.GetAppointmentByAppointmentID(TestAppointmentID); // change 
            if (dt != null && dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                return new clsWrittenTest(
                    TestAppointmentID: Convert.ToInt32(row["TestAppointmentID"]),
                    TestTypeID: Convert.ToInt32(row["AppointmentTestTypeID"]),
                    LocalDrivingLicenseApplicationID: Convert.ToInt32(row["TestAppointmentForLocalDrivingLicenseAppID"]),
                    AppointmentDateTime: Convert.ToDateTime(row["AppointmentDateTime"]),
                    PaidFees: Convert.ToDecimal(row["PaidFees"]),
                    CreatedByUserID: Convert.ToInt32(row["CreatedByUserID"]),
                    IsLocked: Convert.ToBoolean(row["IsLocked"])
                );
            }
            else
            {
                return null;
            }
        }

        public static DataTable GetAllWrittenTestAppointements(int LocalDrivingLicenseApplicationID)// Get All Vision Test Appointments For Specific Local Driving License Application ID
        {
            return clsGetAllTestAppointmentsForSpecificLocalDrivingLicenseAppID.GetAllVisionTestAppointments(LocalDrivingLicenseApplicationID: LocalDrivingLicenseApplicationID
                , (int)clsTestTypes.enTestTypes.WrittenTest);
        }

        private bool IsWrittenAppointmentAlreadyExists()
        {
            return clsCheckIfHasAppointmentAlreadyOrNot.HasAppointmentIsNotLocked((int)clsTestTypes.enTestTypes.WrittenTest, this.LocalDrivingLicenseApplicationID);
        }



        protected override bool UpdateAppointmentDateTime()
        {
            if (this.AppointmentDateTime == DateTime.MinValue)
            {
                OnSaveGetError?.Invoke("Appointment Date Time is not valid");
                return false;
            }
            return clsUpdateTestAppointment.UpdateTestAppointmentDateTime(this.TestAppointmentID, this.AppointmentDateTime);
        }

        private bool IsThePerviousAppointmentHasFinished()
        {
            return clsCheckIfThereIsOpenAppointmentBefore.CheckIfThereIsRetakeApplicationBefore(this.LocalDrivingLicenseApplicationID, (int)clsTestTypes.enTestTypes.WrittenTest);
        }

        public Action<int> OnSaveGetTheRetakeID;

        public override bool Save()
        {
            switch (this.Mode)
            {
                case enMode.Add:
                    {
                        clsTest.enTestResult Res = clsTest.GetTestResultEnum(this.LocalDrivingLicenseApplicationID, (int)clsTestTypes.enTestTypes.WrittenTest);

                          if (IsWrittenAppointmentAlreadyExists()) // has not taken test yet
                        {
                            OnSaveGetError?.Invoke("This Application Has Already Appointment For Written Test");
                            return false;
                        }

                        if (Res == clsTest.enTestResult.Pass)
                        {
                            OnSaveGetError?.Invoke("This Application Has Already Successed No Need For New Test");
                            return false;
                        }

                        else if (IsThePerviousAppointmentHasFinished() && Res == clsTest.enTestResult.Fail)
                        {
                            // The Retake  Process
                            clsRetakeTest retakeTest = new clsRetakeTest(this.TestAppointmentID, this.TestTypeID,
                            this.LocalDrivingLicenseApplicationID, this.AppointmentDateTime, this.PaidFees, this.CreatedByUserID, this.IsLocked);
                            if (retakeTest.Save())
                            {
                                OnSaveGetTheRetakeID?.Invoke(retakeTest.TestAppointmentID);
                                this.Mode = enMode.Update;
                                return true;
                            }
                            else
                            {
                                OnSaveGetError?.Invoke("Failed To Save The New Application Or Retake Test Appointment");
                                return false;
                            }

                        }

                        
  

                        else if (this.AddNewTestAppointment()) // Normal Add New 
                        {
                            this.Mode = enMode.Update;
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }

                case enMode.Update:
                    {
                        if (IsWrittenTestAppointmentLocked(this.TestAppointmentID))
                        {
                            OnSaveGetError?.Invoke("The Appointment Is Locked You Cann't Edit It");
                            return false;
                        }
                        else return UpdateAppointmentDateTime();
                    }
            }

            return false;
        }

        public Action<string> OnSaveGetError;

        public static int GetNumOfTrialsOfWrittenTest(int LocalDrivingLicenseApplicationID)
        {
            return clsGetNumOfTrialsOfTest.GetNumOfTrials(clsGetNumOfTrialsOfTest.enTestType.WrittenTest, LocalDrivingLicenseApplicationID);
        }

        internal static bool LockWrittenTestAppointment(int TestAppointmentID)
        {
            return clsLockTestAppointment.LockTestAppointment(TestAppointmentID, (int)clsTestTypes.enTestTypes.WrittenTest);
        }

        internal static bool IsWrittenTestAppointmentLocked(int TestAppointmentID)
        {
            return clsIsTestAppointmentLocked.IsAppointmentLocked(TestAppointmentID, (int)clsTestTypes.enTestTypes.WrittenTest);
        }


    }
}
