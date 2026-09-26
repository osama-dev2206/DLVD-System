using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace BussinessLogicLayer
{
    internal sealed class  clsRetakeTest : clsAbTestAppointments
    {
        clsApplications? RetakeTestApplication;
        int  RetakeTestApplicationID { get; set; }
        internal clsRetakeTest(int TestAppointmentID, int TestTypeID, int LocalDrivingLicenseApplicationID
            , DateTime AppointmentDateTime, decimal PaidFees, int CreatedByUserID, bool IsLocked) : base(LocalDrivingLicenseApplicationID)
        {
            this.TestAppointmentID = TestAppointmentID;
            this.TestTypeID = TestTypeID;
            this.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            this.AppointmentDateTime = AppointmentDateTime;
            this.PaidFees = PaidFees;
            this.CreatedByUserID = CreatedByUserID;
            this.IsLocked = IsLocked;

            // Make New Application 
            RetakeTestApplication = new clsApplications();

            RetakeTestApplication?.ApplicantPersonID = clsLocalDrivingLicenseApplications.GetApplicantPersonIDByLDLApplicationID(LocalDrivingLicenseApplicationID);
            RetakeTestApplication?.ApplicationDateTime = DateTime.Now;
            RetakeTestApplication?.ApplicationTypeID = (int)clsApplicationTypes.enApplicationTypes.RetakeTest;
            RetakeTestApplication?.ApplicationStatus = (int)clsApplications.enApplicationStatus.New;
            RetakeTestApplication?.LastStatusDateTime= DateTime.Now;
            RetakeTestApplication?.PaiedFee =clsApplicationTypes.FindAppObjByAppID((int)clsApplicationTypes.enApplicationTypes.RenewDrivingLicense).ApplicationFees;
            RetakeTestApplication?.CreatedByUserID = clsCurrentLoggedInUser.User.UserID;

            RetakeTestApplication?.SaveApplication();
            RetakeTestApplicationID = RetakeTestApplication.ApplicationID; // after saving we will get the application ID 

        }

        // Save the retake test appointment and the new application

        protected override  bool AddNewTestAppointment()
        {
            this.TestAppointmentID = clsAddNewTestAppointment.AddNewTestAppointment(TestTypeID: this.TestTypeID, LocalDrivingLicenseApplicationID: this.LocalDrivingLicenseApplicationID,
                AppointmentDateTime: this.AppointmentDateTime, PaidFees: this.PaidFees, CreatedByUserID: this.CreatedByUserID, IsLocked: this.IsLocked,
                RetakeApplicationID: RetakeTestApplicationID);

            return (TestAppointmentID != -1);
        }

        protected override bool UpdateAppointmentDateTime()
        {

            RetakeTestApplication.LastStatusDateTime = DateTime.Now;
            return true;
        }



        public  override bool Save()
        {
            if (AddNewTestAppointment())
            {
                 UpdateAppointmentDateTime();
                RetakeTestApplication.ApplicationStatus =(int) clsApplications.enApplicationStatus.Completed;
                RetakeTestApplication.SaveApplication(); // save the new update 
                return true;
            }
            else
            {
                return false;
            }
           
        }

        // Donot Care
        protected override DataTable   GetAppointmentByAppointmentID(int TestAppointmentID)
        {
            return null;
        }


    }
}
