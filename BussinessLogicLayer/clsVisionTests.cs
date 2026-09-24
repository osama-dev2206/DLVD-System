using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace BussinessLogicLayer
{
    public sealed class clsVisionTests : clsAbTestAppointments
    {
        enMode Mode;
      public clsVisionTests(int LocalDrivingLicenseApplicationID) // Add New Appointment For Vision Test
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

        public override bool Save()
        {
            switch (this.Mode)
            {
                case enMode.Add:
                    if(this.AddNewTestAppointment())
                    {
                        this.Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

            }

            return false;
        }

    }
}
