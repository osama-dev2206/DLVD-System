using DataAccessLayer;
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
        public bool IsActive { get; private set; }
        public int UserID { get; private set; }
        public int DriverID { get; private set; }
        public int LicenseID { get; private set; }
        public int ApplicationID { get; private set; }

        enum enMode { Add =1 , Update = 2 }
        enMode Mode;
        clsApplications ? InternationalNewApplication = null;

        // For Adding
        public clsInternationalLicense(int LicenseID) // send the local driving license id 
        {
            Mode = enMode.Add;
            this.InternationalLicenseID = -1; // Intilization 

            this.IssueDateTime = DateTime.Now;
            this.IsActive = true;
            this.UserID = clsCurrentLoggedInUser.User.UserID;
            this.LicenseID = LicenseID;

            clsLicenses license = clsLicenses.GetLicenseObjByLicenseID(LicenseID); // to get license driver id

            if(license is null)
            {
                OnActionGetError?.Invoke("Error in getting license info by license id");
                return;
            }

            this.DriverID = license.LicenseDriverID;
            this.ExpirationDate = license.ExpirationDate; // international license cannot be exist without local license 

            // New Application For International License
            this.InternationalNewApplication = new clsApplications();

            if(InternationalNewApplication is null)
            {
                OnActionGetError?.Invoke("Error in creating new application for International License");
                return;
            }

            this.InternationalNewApplication.ApplicantPersonID = clsApplications.GetApplicationObjByAppID(license.LicenseApplicationID).ApplicantPersonID; // get the applicant person id from license 
            this.InternationalNewApplication.ApplicationDateTime = DateTime.Now;
            this.InternationalNewApplication.ApplicationTypeID = (byte)clsApplicationTypes.enApplicationTypes.NewInternationalDrivingLicense;
            this.InternationalNewApplication.ApplicationStatus = (byte)clsApplications.enApplicationStatus.New;
            this.InternationalNewApplication.LastStatusDateTime = DateTime.Now;
            this.InternationalNewApplication.PaidFee = clsApplicationTypes.FindAppObjByAppID((int)clsApplicationTypes.enApplicationTypes.NewInternationalDrivingLicense).ApplicationFees;
            this.InternationalNewApplication.CreatedByUserID = clsCurrentLoggedInUser.User.UserID;

            this.InternationalNewApplication.SaveApplication(); // Save the application to get the application id
            this.ApplicationID = this.InternationalNewApplication.ApplicationID; // set the application id to the international license

        }

        private bool Add()
        {
            if (InternationalNewApplication is null) return false;

            this.InternationalLicenseID =
                clsAddNewInternationalLicense.AddNewInternationalLicense(this.IssueDateTime , this.ExpirationDate, this.IsActive, this.UserID, this.DriverID, this.LicenseID, this.ApplicationID);
            return (this.InternationalLicenseID != -1);
        }

        public Action<string> OnActionGetError;

        public bool Save()
        {
            switch(this.Mode)
            {
                case enMode.Add:
                    if (this.Add())
                    {
                        this.Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        OnActionGetError?.Invoke("Error in adding new International License");
                        return false;
                    }
            }

            return false;
        }



    }


}
