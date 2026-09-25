using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace BussinessLogicLayer
{
    public sealed class clsVisionTests : clsAbTestAppointments
    {
        enMode Mode;
        // Add will be with local driving license application ID and update will be with  appointment ID
        public clsVisionTests(int LocalDrivingLicenseApplicationID) : base(LocalDrivingLicenseApplicationID)// Add New Appointment For Vision Test
        {
            Mode = enMode.Add;
            this.TestAppointmentID = -1;

            this.TestTypeID = (int)clsTestTypes.enTestTypes.VisionTest;
            this.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            this.PaidFees = clsTestTypes.FindTestType(this.TestTypeID).TestTypeFee;
            this.CreatedByUserID = clsCurrentLoggedInUser.User.UserID;
            this.IsLocked = false;
        }

        protected  override bool AddNewTestAppointment()
        {
            this.TestAppointmentID = clsAddNewTestAppointment.AddNewTestAppointment(TestTypeID:this.TestTypeID , LocalDrivingLicenseApplicationID: this.LocalDrivingLicenseApplicationID,
                AppointmentDateTime: this.AppointmentDateTime , PaidFees: this.PaidFees , CreatedByUserID: this.CreatedByUserID , IsLocked: this.IsLocked);

            return (TestAppointmentID != -1);
        }

        public static DataTable GetAllVisionTestAppointements(int LocalDrivingLicenseApplicationID)
        {
            return clsGetAllTestAppointmentsForSpecificLocalDrivingLicenseAppID.GetAllVisionTestAppointments(LocalDrivingLicenseApplicationID: LocalDrivingLicenseApplicationID
                , (int)clsTestTypes.enTestTypes.VisionTest);
        }

        private bool IsVisionAppointmentAlreadyExists()
        {
            return clsCheckIfHasAppointmentAlreadyOrNot.HasAppointmentAlready(clsCheckIfHasAppointmentAlreadyOrNot.enTestType.VisionTest, this.LocalDrivingLicenseApplicationID);
        }

        public override bool Save()
        {
            switch (this.Mode)
            {
                case enMode.Add:
                    {
                        if (IsVisionAppointmentAlreadyExists())
                        {
                            OnSaveGetError?.Invoke("Vision Test Appointment Already Exists For This Application");
                            return false;
                        }

                       else  if (this.AddNewTestAppointment())
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
                        break; // temp
                    }
            }

            return false;
        }

        public Action<string> OnSaveGetError;

        public static int GetNumOfTrialsOfVisionTest(int LocalDrivingLicenseApplicationID)
        {
            return clsGetNumOfTrialsOfTest.GetNumOfTrials(clsGetNumOfTrialsOfTest.enTestType.VisionTest , LocalDrivingLicenseApplicationID);
        }

        internal static bool LockVisionTestAppointment(int TestAppointmentID)
        {
            return clsLockTestAppointment.LockTestAppointment(TestAppointmentID,(int)clsTestTypes.enTestTypes.VisionTest);
        }



    }
}
