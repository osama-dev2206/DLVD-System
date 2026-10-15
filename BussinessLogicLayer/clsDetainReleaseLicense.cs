using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.Remoting;
using System.Text;

namespace BussinessLogicLayer
{
    public class clsDetainReleaseLicense
    {
        public int DetainID { get; private set; }
        public int LicenseID { get; private set; }
        public DateTime DetainDateTime { get; private set; }
        public decimal FineFees { get;  set; }
        public bool IsReleased { get; private set; }
        public int CreatedByUserID { get; private set; }
        public DateTime? ReleasedDateTime { get; private set; } 
        public int ? ReleasedByUserID { get; private set; }
        public int ? ReleaseApplicationID { get; private set; }

        public  clsApplications  ? ReleaseApplication { get; private set; } // if the license is released then it will have a release application object
        private clsLicenses ? license = null;

        enum enMode { Detain = 1 , Release =2 }
        enMode Mode;

        // Detain = Means you want to detain license,detain license doesnot require any applications //
        public clsDetainReleaseLicense(int LicenseID )
        {
            this.Mode = enMode.Detain;
            ReleaseApplication = null; // as it is detained now so no release application is created yet

            this.LicenseID = LicenseID;
            this.license = clsLicenses.GetLicenseObjByLicenseID(LicenseID: LicenseID);

            this.DetainDateTime = DateTime.Now;
            // Fees will be handled by user
            this.IsReleased = false;
            this.CreatedByUserID = clsCurrentLoggedInUser.User.UserID;

            // as it is detained now //
            this.ReleasedDateTime = null;  
            this.ReleasedByUserID = null;
            this.ReleaseApplicationID = null;
        }

        private clsDetainReleaseLicense(int DetainID , int LicenseID , DateTime DetainDateTime, decimal FineFees, bool IsReleased, int CreatedByUserID, DateTime? ReleasedDateTime, int? ReleasedByUserID, int? ReleaseApplicationID)
        {
            this.Mode = enMode.Release; // if you search and the license is already detained then you can release it by using this constructor

            this.DetainID = DetainID;
            this.LicenseID = LicenseID;
            this.DetainDateTime = DetainDateTime;
            this.FineFees = FineFees;
            this.IsReleased = IsReleased;
            this.CreatedByUserID = CreatedByUserID;
            this.ReleasedDateTime = ReleasedDateTime;
            this.ReleasedByUserID = ReleasedByUserID;
            this.ReleaseApplicationID = ReleaseApplicationID;
            // get license object
            this.license = clsLicenses.GetLicenseObjByLicenseID(LicenseID: LicenseID);
        }

        public static bool IsLicenseDetained(int LicenseID)
        {
            return clsIsLicenseDetained.IsLicenseDetained(LicenseID);
        }

        public static clsDetainReleaseLicense ? GetDetainReleaseLicenseObjByLicenseID(int LicenseID)
        {
            var dt = clsFindDetainedLicenseByLicneseID.GetDetainedLicense(LicenseID: LicenseID);

            if (dt is null || dt.Rows.Count <= 0) return null;

            clsDetainReleaseLicense obj = new clsDetainReleaseLicense(LicenseID: LicenseID);

            foreach(DataRow R in dt.Rows)
            {
                obj = new clsDetainReleaseLicense(
                     DetainID: Convert.ToInt32(R["DetainID"]),
                    LicenseID: Convert.ToInt32(R["DLicenseID"]),
                    DetainDateTime: Convert.ToDateTime(R["DetainDateTime"]),
                    FineFees: Convert.ToDecimal(R["FineFees"]),
                    IsReleased: Convert.ToBoolean(R["IsReleased"]),
                    CreatedByUserID: Convert.ToInt32(R["CreatedByUserID"]),
                    ReleasedDateTime: R["ReleasedDateTime"] is DBNull ? null : (DateTime?)Convert.ToDateTime(R["ReleasedDateTime"]),
                    ReleasedByUserID: R["ReleasedByUserID"] is DBNull ? null : (int?)Convert.ToInt32(R["ReleasedByUserID"]),
                    ReleaseApplicationID: R["ReleaseApplicationID"] is DBNull ? null : (int?)Convert.ToInt32(R["ReleaseApplicationID"])
                );
            }
            return obj;
        }

        private bool Add()
        {
            this.DetainID =
                clsAddNewDetainedLicense.AddNewLicenseToDetainedLicenses( LicenseID:this.LicenseID, DetainDT: this.DetainDateTime,   FineFees: this.FineFees, 
                CreatedByUserID:  this.CreatedByUserID, IsReleased: this.IsReleased);
            return (this.DetainID != -1);
        }

       private bool IsLicenseDetainedBefore()
        {
            return clsIsLicenseDetained.IsLicenseDetained(this.LicenseID);
        }
        
        private bool CheckBeforeSave()
        {
            if (this.license is not null)
            {
                return (this.license.IsActive && clsLicenses.IsLicenseStillValid(this.LicenseID) && !IsLicenseDetainedBefore()); // will return true if the conditions are true
            }
                return false; 
        }

        private bool? AddNewReleaseApplication()
        {
            this.ReleaseApplication = new clsApplications();
            ReleaseApplication.ApplicantPersonID =clsApplications.GetApplicationObjByAppID( this.license.LicenseApplicationID).ApplicantPersonID;
            ReleaseApplication.ApplicationDateTime = DateTime.Now;
            ReleaseApplication.ApplicationTypeID = clsApplicationTypes.FindAppObjByAppID((int)clsApplicationTypes.enApplicationTypes.ReleaseDetainedDrivingLicense).ApplicationTypeID;
            ReleaseApplication.ApplicationStatus = (byte)clsApplications.enApplicationStatus.New;
            ReleaseApplication.LastStatusDateTime = DateTime.Now;
            ReleaseApplication.PaidFee = clsApplicationTypes.FindAppObjByAppID((int)clsApplicationTypes.enApplicationTypes.ReleaseDetainedDrivingLicense).ApplicationFees;
            ReleaseApplication.CreatedByUserID = clsCurrentLoggedInUser.User.UserID;

           return ReleaseApplication?.SaveApplication(); // save the application and get the application id
        }

        private bool ReleaseLicense() // release is actually update detained license record 
        {
            bool ?res = AddNewReleaseApplication();
            if (res is not null && res == true)
            {
                this.ReleasedDateTime = DateTime.Now;
                this.ReleasedByUserID = clsCurrentLoggedInUser.User.UserID;
                this.ReleaseApplicationID = this.ReleaseApplication.ApplicationID;
              

               bool R =  clsReleaseLicnese.ReleaseLicense(LicenseID: this.LicenseID, ReleasedDateTime: this.ReleasedDateTime,
           ReleasedByUserID: ReleasedByUserID,
           ReleaseApplicationID: ReleaseApplicationID);

                if(R)
                {
                    this.IsReleased = true;
                    return true; // if the license is released successfully then return true
                }
                else
                    return false; // if the license is not released successfully then return false

            }
            else
            {
                return false; // if the application is not created then return false
            }

        }

        public Action<int> OnSaveGetDetainInfo;
        public bool Save()
        {
            switch (this.Mode)
            {
                case enMode.Detain:
                    {
                        if (CheckBeforeSave()) // if the check is ok then .......
                        {
                            OnSaveGetDetainInfo?.Invoke(this.DetainID);
                          return  Add(); // add new license as detained license 
                        }
                        else
                            return false;
                    }

                case enMode.Release:
                    {
                        if(this.IsReleased) // if the license is already released then return false
                        {
                            return false;
                        }
                        else return ReleaseLicense();
                    }

            }
            return false;
        }


    }

    
}
