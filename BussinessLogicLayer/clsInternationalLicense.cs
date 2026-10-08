using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
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
      public clsApplications? InternationalNewApplication { private set; get; }
        clsLicenses ? license = null;

        // For Adding
        public clsInternationalLicense(int LicenseID) // send the local driving license id 
        {
            Mode = enMode.Add;
            this.InternationalLicenseID = -1; // Intilization 

            this.IssueDateTime = DateTime.Now;
            this.IsActive = true;
            this.UserID = clsCurrentLoggedInUser.User.UserID;
            this.LicenseID = LicenseID;

            license = clsLicenses.GetLicenseObjByLicenseID(LicenseID); // to get license driver id

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
                return ;
            }

            this.InternationalNewApplication.ApplicantPersonID = clsApplications.GetApplicationObjByAppID(license.LicenseApplicationID).ApplicantPersonID; // get the applicant person id from license 
            this.InternationalNewApplication.ApplicationDateTime = DateTime.Now;
            this.InternationalNewApplication.ApplicationTypeID = (byte)clsApplicationTypes.enApplicationTypes.NewInternationalDrivingLicense;
            this.InternationalNewApplication.ApplicationStatus = (byte)clsApplications.enApplicationStatus.New;
            this.InternationalNewApplication.LastStatusDateTime = DateTime.Now;
            this.InternationalNewApplication.PaidFee = clsApplicationTypes.FindAppObjByAppID((int)clsApplicationTypes.enApplicationTypes.NewInternationalDrivingLicense).ApplicationFees;
            this.InternationalNewApplication.CreatedByUserID = clsCurrentLoggedInUser.User.UserID;



        }

        private bool CheckBeforeAdd()
        {
            /*
             * 1. check if the application has created successfully or not
             * 2. check if the license is null or not
             * 3. check if the license is active or not
             */
            if (InternationalNewApplication is null || license is null  )
            {
                return false;
            }
            else if(!clsLicenses.IsLicenseStillValid(LicenseID: this.license.LicenseID))
            {
                OnActionGetError?.Invoke("Your License Is Expired !!!");
                return false;
            }
            else if (!clsLicenses.IsPersonHasThisLicenseActive(ApplicantPersonID: this.InternationalNewApplication.ApplicantPersonID, LicenseClassID: license.LicenseClassID) )
            {
                OnActionGetError?.Invoke("Your License Isn't Active !!!");
                return false;
            }
            else if (license.LicenseClassID != (byte)clsLicenseClasses.enLicenseClasses.Class3)
            {
                OnActionGetError?.Invoke("Your License Class Must Be Class 3 Type !!!");
                return false;
            }
            else if(IsPersonHasActiveInternationalLicense())
            {
                OnActionGetError?.Invoke("This Person Has Already International License !!!");
                return false;

            }
            return true;
        }

        private bool Add()
        {
            if (CheckBeforeAdd() == false)
            {
                return false;
            }

            this.InternationalLicenseID =
                clsAddNewInternationalLicense.AddNewInternationalLicense(this.IssueDateTime , this.ExpirationDate, this.IsActive, this.UserID, this.DriverID, this.LicenseID, this.ApplicationID);
            return (this.InternationalLicenseID != -1);
        }

        public Action<string> OnActionGetError;
        public Action<int,int> OnSaveGetInterLicID;
        public bool Save()
        {
            if (!this.InternationalNewApplication.SaveApplication()) // Save the application to get the application id
            {
                OnActionGetError?.Invoke("Error in saving application for International License");
                return false;
            }

            this.ApplicationID = this.InternationalNewApplication.ApplicationID; // set the application id to the international license

            switch (this.Mode)
            {
                case enMode.Add:
                    if (this.Add())
                    {
                        this.Mode = enMode.Update;
                        OnSaveGetInterLicID?.Invoke(this.InternationalLicenseID , this.ApplicationID);
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


        public static DataTable GetInternationalLicenseDataView(int PersonID)
        {
            return clsGetInternationalLicenseInfo.GetTable(PersonID);
        }

        //  Check If There Is Active International License For This Person Or Not 
        internal  bool IsPersonHasActiveInternationalLicense()
        {
            return clsCheckIfThePersonHasInternationalLicenseOrNot.CheckIfThePersonHasInternationalLicenseOrNot(this.InternationalNewApplication.ApplicantPersonID);
        }

        // Please Note : LicenseID --> local license id (not international license id)

        public static DataTable GetInternationalLicenseInfo(int LicenseID)
        {
            return clsGetInternationalLicInfo.GetInternationalLicenseInfoByLicenseID(LicenseID);
        }

        public static DataTable GetInternationalApplicationInfo(int LicenseID)
        {
            return clsGetInternationalLicAppInfo.GetInfo(LicenseID: LicenseID);
        }

        public static DataTable GetAll_InternatioanlLicensesApps()
        {
            return clsInternationalLicensesAppsView.GetApps();
        }


        public static DataTable GetLicAppByAppID(int ApplicationID)
        {
            return clsFindInternationalLicenseBy.GetTable(clsFindInternationalLicenseBy.enFindInternationalLicenseBy.ApplicationID, ApplicationID);
        }

        static public DataTable GetLicAppByDriverID(int DriverID)
        {
            return clsFindInternationalLicenseBy.GetTable(clsFindInternationalLicenseBy.enFindInternationalLicenseBy.DriverID, DriverID);
        }

        public static DataTable GetLicAppByLicenseID(int LicenseID)
        {
            return clsFindInternationalLicenseBy.GetTable(clsFindInternationalLicenseBy.enFindInternationalLicenseBy.LicenseID, LicenseID);
        }

        public static DataTable GetLicAppByInternationalLicenseID(int InternationalLicenseID)
        {
            return clsFindInternationalLicenseBy.GetTable(clsFindInternationalLicenseBy.enFindInternationalLicenseBy.InternationalLicenseID, InternationalLicenseID);
        }

        internal static bool DeactivateInternationalLicenseByLicID(int LicenseID)
        {
            return clsDeactivateInternationalLicense.DeactivateInternationalLicense(LicenseID);
        }

        }


}
