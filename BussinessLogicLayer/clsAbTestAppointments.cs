using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace BussinessLogicLayer
{
    public abstract class clsAbTestAppointments 
    {
        public int TestAppointmentID { get; protected set; }
        public int TestTypeID { get; protected set; }
        public int LocalDrivingLicenseApplicationID { get; protected set; }
        public DateTime AppointmentDateTime { get; set; }
        public decimal PaidFees { get; protected set; }
        public int CreatedByUserID { get; protected set; }
        public bool IsLocked { get;  set; }
        public bool RetakeApplication { get; protected set; }

        protected enum enMode { Add =1 , Update =2 }

       protected abstract  bool AddNewTestAppointment();

        public abstract bool Save();

        /// will be used for update existing appointment for vision test and will be used to get the appointment details by appointment ID
        protected abstract  DataTable GetAppointmentByAppointmentID(int TestAppointmentID);

        protected abstract bool UpdateAppointmentDateTime();

        protected clsAbTestAppointments(int LocalDrivingLicenseApplicationID)
        {
            if(clsLocalDrivingLicenseApplications.GetApplicationStatusByLocalLicenseApplicationID(LocalDrivingLicenseApplicationID) == 
                clsApplications.enApplicationStatus.Cancelled)
            {
                throw new InvalidOperationException(
           "Cannot create a test appointment for a cancelled application.");
            }
        }


    }
}
