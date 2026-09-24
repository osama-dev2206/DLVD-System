using System;
using System.Collections.Generic;
using System.Text;

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

    }
}
