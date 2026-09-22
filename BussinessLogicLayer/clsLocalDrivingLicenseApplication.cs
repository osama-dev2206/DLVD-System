using System;
using System.Collections.Generic;
using System.Text;

namespace BussinessLogicLayer
{
    public class clsLocalDrivingLicenseApplications // composition 
    {
        public int LocalDrivingLicenseApplicationID { get; private set; }
        public int LicenseClassID { get;  set; }
        public clsApplications Application { get; private set;  } // composition

        enum enMode { Add = 1, Edit = 2 }
        enMode mode;
        public clsLocalDrivingLicenseApplications(int ApplicantPersonID) // Add new 
        {
            mode = enMode.Add;
            Application = new clsApplications();
            DateTime @Now = DateTime.Now ;

            Application.ApplicantPersonID = ApplicantPersonID;
            Application.ApplicationDateTime = @Now;
            Application.ApplicationTypeID = (byte)clsApplicationTypes.enApplicationTypes.NewLocalDrivingLicense; // new local driving license application
            Application.ApplicationStatus = (byte)clsApplications.enApplicationStatus.New;
            Application.LastStatusDateTime = @Now;
            Application.PaiedFee = clsApplicationTypes.FindAppObjByAppID((byte)clsApplicationTypes.enApplicationTypes.NewLocalDrivingLicense).ApplicationFees; // get the fees for new local driving license application
            Application.CreatedByUserID = clsCurrentLoggedInUser.User.UserID;
        }

        private bool AddNewLocalDrivingLicenseApplicationToDB()
        {
            if(this.Application.ApplicationID ==-1) return false; // application not added to DB yet

            this.LocalDrivingLicenseApplicationID = 
                DataAccessLayer.clsAddNewLocalDrivingLicense.AddNewLocalDrivingLicenseApplication(ApplicationID: this.Application.ApplicationID, LicenseClassID: this.LicenseClassID);

            return (LocalDrivingLicenseApplicationID != -1);
        }

        public bool SaveLocalDrivingLicenseApplication()
        {
            switch (this.mode)
            {
                case enMode.Add:
                    if(this.Application.SaveApplication()) // add the application to db first to get application id 
                    {
                        if (this.AddNewLocalDrivingLicenseApplicationToDB()) // add to local driving license application table
                        {
                            this.mode = enMode.Edit; // change mode to edit after successful addition
                            return true;
                        }
                        else
                        {
                            this.Application.DeleteApplication(); //delete app lication from db if failed to add to local driving license application table
                            return false; // failed to add to local driving license application table
                        }

                    }
                    else
                    {
                        return false; // failed to add application to db
                    }
            }

            return false; // default return false if mode is not add
        }






    }


}
