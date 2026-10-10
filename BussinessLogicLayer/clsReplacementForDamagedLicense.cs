using System;
using System.Collections.Generic;
using System.Text;

namespace BussinessLogicLayer
{
    public sealed class clsReplacementForDamagedLicense
    {
        public enum enReplacementFor { DamagedLicense = 1, LostLicense = 2 }
        enReplacementFor ReplacementFor;
        public clsApplications ?ApplicationForReplacement { private get; set; }
        public clsLicenses ? OldLicense { get; private set; }
        public clsLicenses? NewLicense { get; private set; }
        public int ApplicationID { get; private set; }
        

        public clsReplacementForDamagedLicense(enReplacementFor @For , int OldLicenseID)
        {
            OldLicense = clsLicenses.GetLicenseObjByLicenseID(OldLicenseID);
            this.ReplacementFor = @For;

            if (OldLicense != null)
            {
                ApplicationForReplacement = new clsApplications();
                ApplicationForReplacement.ApplicantPersonID = clsApplications.GetApplicationObjByAppID(OldLicense.LicenseApplicationID).ApplicantPersonID;
                ApplicationForReplacement.ApplicationDateTime = DateTime.Now;
                if (@For == enReplacementFor.DamagedLicense) 
                {
                    ApplicationForReplacement.ApplicationTypeID 
                        = clsApplicationTypes.FindAppObjByAppID((byte)clsApplicationTypes.enApplicationTypes.ReplacementForDamagedDrivingLicense).ApplicationTypeID;

                    ApplicationForReplacement.PaidFee = clsApplicationTypes.FindAppObjByAppID((byte)clsApplicationTypes.enApplicationTypes.ReplacementForDamagedDrivingLicense).ApplicationFees;
                }
                else if (@For == enReplacementFor.LostLicense)
                {
                    ApplicationForReplacement.ApplicationTypeID
                        = clsApplicationTypes.FindAppObjByAppID((byte)clsApplicationTypes.enApplicationTypes.ReplacementForLostDrivingLicense).ApplicationTypeID;

                    ApplicationForReplacement.PaidFee = clsApplicationTypes.FindAppObjByAppID((byte)clsApplicationTypes.enApplicationTypes.ReplacementForLostDrivingLicense).ApplicationFees;
                }

                ApplicationForReplacement.ApplicationStatus = (byte)clsApplications.enApplicationStatus.New;
                ApplicationForReplacement.LastStatusDateTime = DateTime.Now;
                ApplicationForReplacement.CreatedByUserID = clsCurrentLoggedInUser.User.UserID;

            }


        }

        void SetNewLicense()
        {
            if (ReplacementFor == enReplacementFor.DamagedLicense)
            {
                this.NewLicense = new clsLicenses(ApplicationID: this.ApplicationID,
               ApplicantPersonID: ApplicationForReplacement.ApplicantPersonID, LicenseClassID: this.OldLicense.LicenseClassID, clsLicenses.enIssueReason.ReplacementForDamage);
            }
             if(ReplacementFor == enReplacementFor.LostLicense)
            {
                this.NewLicense = new clsLicenses(ApplicationID: this.ApplicationID,
            ApplicantPersonID: ApplicationForReplacement.ApplicantPersonID, LicenseClassID: this.OldLicense.LicenseClassID, clsLicenses.enIssueReason.ReplacementForLost);
            }
        }

        public bool Save()
        { 
            if(ApplicationForReplacement is null || OldLicense is null )
            {
                return false;
            }

            if(ApplicationForReplacement.SaveApplication())
            {
                this.ApplicationID = ApplicationForReplacement.ApplicationID; // after saving the application, we can get the ApplicationID

                SetNewLicense(); // set the new license based on the replacement type

                if(NewLicense != null && NewLicense.Save() // save the new license to the database
                {
                    ApplicationForReplacement.UpdateApplicationStatus(clsApplications.enApplicationStatus.Completed); // update the application status to completed
                    return clsLicenses.DisableLicenseByLicenseID(OldLicense.LicenseID); // disable the old license
                     
                }
            }

            return false;
        }


    }

}
