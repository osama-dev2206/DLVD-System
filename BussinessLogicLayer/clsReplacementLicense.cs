using System;
using System.Collections.Generic;
using System.Text;

namespace BussinessLogicLayer
{
    public sealed class clsReplacementLicense
    {
        public enum enReplacementFor { DamagedLicense = 1, LostLicense = 2 }
        enReplacementFor ReplacementFor;
        public clsApplications ?ApplicationForReplacement {  get; private set; }
        public clsLicenses ? OldLicense { get; private set; }
        public clsLicenses? NewLicense { get; private set; }
        public int ApplicationID { get; private set; }
        
        enum enReplacementTime { First =1 , Second =2 } // we will use his to avoid duplicate replacement applications for the same license in the same session (as the object will still in memory and the user can click the issue button again)
        enReplacementTime replacementTime;
        public clsReplacementLicense(enReplacementFor @For , int OldLicenseID)
        {
            OldLicense = clsLicenses.GetLicenseObjByLicenseID(OldLicenseID);
            this.ReplacementFor = @For;
            replacementTime = enReplacementTime.First; // default value

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

        private void SetNewLicense()
        {
            if (ReplacementFor == enReplacementFor.DamagedLicense)
            {
                this.NewLicense = new clsLicenses(ApplicationID: this.ApplicationID,
               ApplicantPersonID: ApplicationForReplacement.ApplicantPersonID, LicenseClassID: this.OldLicense.LicenseClassID, clsLicenses.enIssueReason.ReplacementForDamage,
               this.OldLicense.IssueDate , this.OldLicense.ExpirationDate);
            }
             if(ReplacementFor == enReplacementFor.LostLicense)
            {
                this.NewLicense = new clsLicenses(ApplicationID: this.ApplicationID,
            ApplicantPersonID: ApplicationForReplacement.ApplicantPersonID, LicenseClassID: this.OldLicense.LicenseClassID, clsLicenses.enIssueReason.ReplacementForLost,
            this.OldLicense.IssueDate, this.OldLicense.ExpirationDate);
            }
          
        }

        public bool Save()
        { 
            if(ApplicationForReplacement is null || OldLicense is null )
            {
                return false;
            }

            if(replacementTime == enReplacementTime.First && ApplicationForReplacement.SaveApplication())
            {
                this.ApplicationID = ApplicationForReplacement.ApplicationID; // after saving the application, we can get the ApplicationID

                SetNewLicense(); // set the new license based on the replacement type

                if( this.OldLicense.IsActive && clsLicenses.IsLicenseStillValid(this.OldLicense.LicenseID)&&
                    NewLicense != null && NewLicense.Save() )// save the new license to the database
                {
                    clsInternationalLicense.DeactivateInternationalLicenseByLicID(this.OldLicense.LicenseID);
                    ApplicationForReplacement.UpdateApplicationStatus(clsApplications.enApplicationStatus.Completed); // update the application status to completed

                    this.replacementTime = enReplacementTime.Second; // set the replacement time to second to avoid duplicate replacement applications for the same license in the same session

                    return clsLicenses.DisableLicenseByLicenseID(OldLicense.LicenseID); // disable the old license
                     
                }
            }

            return false;
        }


    }

}
