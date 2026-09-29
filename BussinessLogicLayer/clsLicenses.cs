using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace BussinessLogicLayer
{
    public class clsLicenses
    {
        public int LicenseID { get; private set; }
        public int LicenseApplicationID { get; private set; }
        public int LicenseDriverID { get; private set; }
        public int LicenseClassID { get;  private set; }
        public DateOnly IssueDate { get; private set; }
        public DateOnly ExpirationDate { get; private set; }

        public string ? Notes { get;  set; }
        public decimal PaiedFees { get; private set; }
        public bool IsActive { get;  set; }

        public enum enIssueReason : byte { FirstTime = 1 , Renew=2 , ReplacementForDamage = 3 , ReplacementForLost  = 4 }

        public enIssueReason IssueReason { get; private set; }

        public int CreatedByUserID { get; private set; }

        private enum enMode { Add = 1, Edit = 2 }
        enMode Mode;

        int ApplicantPersonID { get; set; } // This will be set when the license is associated with a driver

        // Add New License
        public clsLicenses(int ApplicationID , int LicenseClassID)
        {
            Mode = enMode.Add;

            this.LicenseID = -1;
            this.LicenseApplicationID = ApplicationID;
            this.LicenseDriverID = -1; // initial value will be set later
            this.LicenseClassID = LicenseClassID;
            this.IssueDate = DateOnly.FromDateTime(DateTime.Now);
            this.ExpirationDate = IssueDate.AddMonths(clsLicenseClasses.FindLicenseClassByID(LicenseClassID).DefaultValidityLength); // Set ExpirationDate based on the default validity length of the license class
            // notes can be set later
            this.PaiedFees = clsLicenseClasses.FindLicenseClassByID(LicenseClassID).ClassFees; // Set PaiedFees based on the default fees of the license class
            this.IsActive = true; // New license is active by default
            this.IssueReason = enIssueReason.FirstTime; // Default issue reason for new license
            this.CreatedByUserID = clsCurrentLoggedInUser.User.UserID; // Set CreatedByUserID to the current logged-in user's ID

            this.ApplicantPersonID = clsApplications.GetApplicationObjByAppID(ApplicationID).ApplicantPersonID; // Get the ApplicantPersonID from the application object
        }

       private bool AddNewLicense()
        {
            this.LicenseID =
                clsAddNewLicense.AddNewLicense(this.LicenseApplicationID, this.LicenseDriverID, this.LicenseClassID, this.IssueDate, this.ExpirationDate, this.Notes, this.PaiedFees, this.IsActive, (byte)this.IssueReason, this.CreatedByUserID);
        
            return(LicenseID !=-1); 
        }


        public bool Save()
        {

            return false;
        }

    }



}
