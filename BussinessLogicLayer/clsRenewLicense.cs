using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Text;

namespace BussinessLogicLayer
{
    public sealed class clsRenewLicense
    {
        private clsLicenses ?OldLicense = null;
        private clsLicenses? NewLicense = null;
        private clsApplications RenewApplication;
        public int ApplicationID = -1;
      public  int LicenseID { private set;  get; }
        public string  ? Notes { set; get; } = string.Empty;

        public clsRenewLicense(int OldLicenseID)
        {
            LicenseID = -1; 
            OldLicense = clsLicenses.GetLicenseObjByLicenseID(OldLicenseID); // Get the old license object by its ID
            clsApplications OldLicenseApp = clsApplications.GetApplicationObjByAppID(OldLicense.LicenseApplicationID); // Get the application object associated with the old license
            
            if (OldLicense !=null && OldLicenseApp != null)
            {
                RenewApplication = new clsApplications();
                RenewApplication.ApplicantPersonID = OldLicenseApp.ApplicantPersonID;
                RenewApplication.ApplicationDateTime = DateTime.Now;
                RenewApplication.ApplicationTypeID = (byte)clsApplicationTypes.enApplicationTypes.RenewDrivingLicense;
                RenewApplication.ApplicationStatus = (byte)clsApplications.enApplicationStatus.New;
                RenewApplication.LastStatusDateTime = DateTime.Now;
                RenewApplication.PaidFee = clsApplicationTypes.FindAppObjByAppID((byte)clsApplicationTypes.enApplicationTypes.RenewDrivingLicense).ApplicationFees;
                RenewApplication.CreatedByUserID = clsCurrentLoggedInUser.User.UserID;
    

               bool Res =  RenewApplication.SaveApplication();
                this.ApplicationID = RenewApplication.ApplicationID;

                if(!Res)
                {
                    throw new Exception("Error in saving the new application for license renewal.");
                }

                NewLicense = 
                    new clsLicenses(ApplicationID: ApplicationID , ApplicantPersonID: RenewApplication.ApplicantPersonID,
                    LicenseClassID: OldLicense.LicenseClassID , issueReason: clsLicenses.enIssueReason.Renew); // Create a new license (with the same info of old Lic) 
                
            }


        }
        private bool IsTheOldLicenseExpired()
        {
            return OldLicense.ExpirationDate < DateOnly.FromDateTime(DateTime.Now);
        }

        public bool Save()
        {
            this.NewLicense.Notes = Notes; // if there is note  

 

            if (OldLicense.IsActive  &&IsTheOldLicenseExpired() && NewLicense.Save())
            {
                this.LicenseID = NewLicense.LicenseID;
                clsInternationalLicense.DeactivateInternationalLicenseByLicID(LicenseID: OldLicense.LicenseID);// if there exists international license associated with the old license, we will disable it as well
                this.RenewApplication.UpdateApplicationStatus(clsApplications.enApplicationStatus.Completed); // make the application As completed

                return  clsLicenses.DisableLicenseByLicenseID(OldLicense.LicenseID) ; // Disable the old license
            }
            return false;
        }


        public static DataTable LicenseSummaryInfo(int RLicenseID)
        {
            return clsGetSummaryInfoForRenewLicense.GetSummaryInfo(RLicenseID);
        }

    }
}
