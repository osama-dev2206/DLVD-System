using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
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

        int ApplicantPersonID { get; set; } // This will be set when the license is associated with a driver (private)

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

        private clsLicenses(int LicenseID, int ApplicationID, int DriverID, int ClassID, DateOnly IssueDate, DateOnly ExpirationDate, string ? Notes, decimal PaiedFees, bool IsActive, enIssueReason IssueReason, int CreatedByUserID)
        {
            Mode = enMode.Edit;

            this.LicenseID = LicenseID;
            this.LicenseApplicationID = ApplicationID;
            this.LicenseDriverID = DriverID;
            this.LicenseClassID = ClassID;
            this.IssueDate = IssueDate;
            this.ExpirationDate = ExpirationDate;
            this.Notes = Notes;
            this.PaiedFees = PaiedFees;
            this.IsActive = IsActive;
            this.IssueReason = IssueReason;
            this.CreatedByUserID = CreatedByUserID;
            // Get the ApplicantPersonID from the application object
            this.ApplicantPersonID = clsApplications.GetApplicationObjByAppID(ApplicationID).ApplicantPersonID;
        }

        private bool AddNewLicense()
        {
            this.LicenseID =
                clsAddNewLicense.AddNewLicense(this.LicenseApplicationID, this.LicenseDriverID, this.LicenseClassID, this.IssueDate, this.ExpirationDate, this.Notes, this.PaiedFees, this.IsActive, (byte)this.IssueReason, this.CreatedByUserID);
        
            return(LicenseID !=-1); 
        }

        clsDrivers Driver = new clsDrivers();
        private void AddNewDriver()
        {
            Driver.CreatedByUserID = this.CreatedByUserID;
            Driver.DriverPersonID = this.ApplicantPersonID;
            Driver.Save();
        }
        private void UpdateMainApplication()
        {
            clsApplications app = clsApplications.GetApplicationObjByAppID(this.LicenseApplicationID);
            app.ApplicationStatus = (byte)clsApplications.enApplicationStatus.Completed;
            app.LastStatusDateTime = DateTime.Now;
            app.SaveApplication(); // update the main application
        }


        public   Action<string> OnSaveGetError;
        public Action<int> GetLicenseIDAfterSaving;

        public bool Save()
        {
            switch (this.Mode)
            {
                case enMode.Add:
                    {

                        if(!clsDrivers.IsDriverExists(this.ApplicantPersonID)) // if the driver does not exist, we need to add a new driver first
                        {
                            AddNewDriver(); //add the new driver
                            if (Driver.DriverID != -1)
                            {
                                this.LicenseDriverID = Driver.DriverID; // set the LicenseDriverID to the newly created driver's ID
                            }
                            else
                            {
                                OnSaveGetError?.Invoke("Failed to add new driver.");
                            }

                        }

                        else // Exists
                        {
                          clsDrivers  D =   clsDrivers.FindDriverObjByPersonID(this.ApplicantPersonID);
                            this.LicenseDriverID = D.DriverID;
                        }

                        if (this.AddNewLicense())
                        {
                            this.Mode = enMode.Edit; // Change mode to Edit after successful addition
                            GetLicenseIDAfterSaving.Invoke(this.LicenseID); // Notify the caller with the new LicenseID)

                            UpdateMainApplication(); // as the license is added successfully, we need to update the main application status to Completed
                            return true;
                        }
                        else
                        {
                            OnSaveGetError?.Invoke("Failed to add new license.");
                            return false;
                        }

                    
                    }
            }
            return false;
        }


        public static DataTable GetLicenseInfoByApplicationID(int ApplicationID)
        {
            return clsGetDriverLicenseInfo.GetDriverLicenseInfoByApplicationID(ApplicationID);
        }


        public static DataTable GetAllLicenseByApplicantID(int ApplicantID)
        {
            return clsLicenseHistory.GetLicenseHistoryByApplicantID(ApplicantID);
        }

        public static DataTable GetLicenseByLicenseID(int LicenseID)
        {
            return clsGetLicenseInfoByID.GetLicenseByLicenseID(LicenseID);
        }

        public static clsLicenses GetLicenseObjByLicenseID(int LicenseID)
        {
            DataTable dt = GetLicenseByLicenseID(LicenseID);
            clsLicenses ? license = null;
            if (dt != null)
            {
                foreach(DataRow R in dt.Rows)
                {
                    license = new clsLicenses
                        (
                        LicenseID: Convert.ToInt32(R["LicenseID"]) ,
                        ApplicationID : Convert.ToInt32(R["LicApplicationID"]) ,
                        DriverID: Convert.ToInt32(R["LicDriverID"]) ,
                        ClassID: Convert.ToInt32(R["ClassOfLicenseID"]) ,
                        IssueDate: DateOnly.FromDateTime(Convert.ToDateTime(R["IssueDate"])) ,
                        ExpirationDate: DateOnly.FromDateTime(Convert.ToDateTime(R["ExpirationDate"])),
                        Notes : R["Notes"]?.ToString() ,
                        PaiedFees: Convert.ToDecimal(R["PaiedFees"]) ,
                        IsActive: Convert.ToBoolean(R["IsActive"]) ,
                        IssueReason: (enIssueReason)Convert.ToByte(R["IssueReason"]) ,
                        CreatedByUserID: Convert.ToInt32(R["CreatedByUserID"])
                        );
                }
            }
            return license;
        }


        // Check if the license is active or not by LicenseID
        internal static bool IsPersonHasThisLicenseActive(int ApplicantPersonID , int LicenseClassID)
        {
            return clsCheckLicenseExistense.CheckIfPersonHasActiveLicenseOfClass( PersonID: ApplicantPersonID ,  LicenseClassID: LicenseClassID);
        }



        }

}
