using DataAccessLayer;
using System;
using System.Collections.Generic;
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

        private clsLicenses ? license = null;

        enum enMode { Detain = 1 , Release =2 }
        enMode Mode;

        // Detain = Means you want to detain license,detain license doesnot require any applications //
        public clsDetainReleaseLicense(int LicenseID )
        {
            this.Mode = enMode.Detain;

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

        public static bool IsLicenseDetained(int LicenseID)
        {
            return clsIsLicenseDetained.IsLicenseDetained(LicenseID);
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

        public Action<int> OnSaveGetDetainInfo;
        public bool Save()
        {
            switch (this.Mode)
            {
                case enMode.Detain:
                    {
                        if (CheckBeforeSave()) // if the check is ok then .......
                        {
                            OnSaveGetDetainInfo?.Invoke(this.LicenseID);
                          return  Add(); // add new license as detained license 
                        }
                        else
                            return false;
                    }
                  

            }
            return false;
        }


    }

    
}
