using System;
using System.Collections.Generic;
using System.Text;

namespace BussinessLogicLayer
{
    public sealed class clsInternationalLicense
    {
        public int InternationalLicenseID { get;  private set; }
        public DateTime IssueDateTime { get; private set; }
        public DateOnly ExpirationDate { get; private set; }
        public byte IsActive { get; private set; }
        public int UserID { get; private set; }
        public int DriverID { get; private set; }
        public int LicenseID { get; private set; }
        public int ApplicationID { get; private set; }

        enum enMode { Add =1 , Update = 2 }
        enMode Mode;
        clsApplications InternationApplication;

        // For Adding
        public clsInternationalLicense( int LicenseID)
        {
            Mode = enMode.Add;

            this.InternationalLicenseID = -1; // Intilization 
            this.IssueDateTime = DateTime.Now;
            // Exp Date IDK know 
            this.IsActive = 1;
            this.UserID = clsCurrentLoggedInUser.User.UserID;
            this.LicenseID = LicenseID;

            clsLicenses license = clsLicenses.
            this.DriverID = DriverID;

     
            this.InternationApplication = new clsApplications();
         
        }

    }


}
