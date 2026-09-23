using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
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

        // donot forget to record the last status date time when editing the application//
        private clsLocalDrivingLicenseApplications(int LocalDrivingLicenseApplicationID, int LicenseClassID, clsApplications Application  ) // Edit existing
        {

            mode = enMode.Edit;
            this.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            this.LicenseClassID = LicenseClassID;
            this.Application = Application;
        }

        private bool AddNewLocalDrivingLicenseApplicationToDB()
        {
            if(this.Application.ApplicationID ==-1) return false; // application not added to DB yet

            this.LocalDrivingLicenseApplicationID = 
                DataAccessLayer.clsAddNewLocalDrivingLicense.AddNewLocalDrivingLicenseApplication(ApplicationID: this.Application.ApplicationID, LicenseClassID: this.LicenseClassID);

            return (LocalDrivingLicenseApplicationID != -1);
        }

        // Find the local driving license application by local driving license application id and return the object of clsLocalDrivingLicenseApplications (it will fill application object as well)
        public static clsLocalDrivingLicenseApplications FindLocalDrivingLicenseApplicationByLocalID(int LocalDrivingLicenseApplicationID)
        {
            if(!int.TryParse(LocalDrivingLicenseApplicationID.ToString(), out int ID)) return null; // invalid id

            clsLocalDrivingLicenseApplications local = null;
            DataTable dt = clsGetLocalDrivingApp.GetLocalDrivingApplicationByLocalDrivingLicenseApplication(LocalDrivingLicenseApplicationID); // get local driving license application

            foreach (DataRow row in dt.Rows)
            {
                local = new clsLocalDrivingLicenseApplications(
                    LocalDrivingLicenseApplicationID: Convert.ToInt32(row["LocalDrivingLicenseApplicationID"]),
                    LicenseClassID: Convert.ToInt32(row["LLicenseClassID"]),
                    Application: clsApplications.GetApplicationObjByAppID(Convert.ToInt32(row["LApplicationID"])) // get application
                );
            }

            return local;
        }


        private int CheckApplicationExistence() // this check if the person has applied for the same application type without finishing the previous application of the same type
        {
            return clsIsPersonHasRegisteredBeforeInApplication.IsPersonHasRegisteredBefore(PersonID: this.Application.ApplicantPersonID, LicenseClassID:this.LicenseClassID);
        }


        private bool CheckBeforeSave()
        {
            int ID = this.CheckApplicationExistence();
            if (ID ==-1)
            {
                return true;
            }
            else
            {
                OnSaveErrorGetMessage?.Invoke($"The person has already applied for the same application type with Application ID : {ID} .");
                return false;
            }
        }

        private bool UpdateLocalDrivingLicenseApplicationInDB()
        {
            return clsUpdateLocalDrivingLic.UpdateLocalDrivingLicenseApplication(this.LocalDrivingLicenseApplicationID, this.LicenseClassID);
        }

        public bool SaveLocalDrivingLicenseApplication()
        {
            switch (this.mode)
            {
                case enMode.Add:
                    {
                        if(!CheckBeforeSave()) return false; // check if the application is valid to save

                        if (this.Application.SaveApplication()) // add the application to db first to get application id 
                        {
                            if (this.AddNewLocalDrivingLicenseApplicationToDB()) // add to local driving license application table
                            {
                              this.mode = enMode.Edit; // change mode to edit after successful addition (temp)
                                OnSaveSuccessGetAppID?.Invoke(this.LocalDrivingLicenseApplicationID);
                                return true;
                            }
                            else
                            {
                                this.Application.DeleteApplication(); //delete app lication from db if failed to add to local driving license application table
                                OnSaveErrorGetMessage?.Invoke("failed to add to local driving license application table");
                                return false; // 
                            }

                        }
                        else
                        {
                            OnSaveErrorGetMessage?.Invoke("failed to add application to db");
                            return false; // failed to add application to db
                        }

                    }

                case enMode.Edit:
                    {
                      // 1. update main application 
                      if(this.Application.SaveApplication()) // Update the application in db first
                        {

                            if(this.UpdateLocalDrivingLicenseApplicationInDB())
                            {
                                return true; // successfully updated
                            }
                            else
                            {
                                OnSaveErrorGetMessage?.Invoke("failed to update local driving license application in db");
                                return false; // failed to update local driving license application in db
                            }

                        }
                        else
                        {
                            OnSaveErrorGetMessage?.Invoke("failed to update application in db");
                            return false; // failed to update application in db
                        }

                    }

            }

            return false; // default return false if mode is not add
        }

        public bool Delete()
        {
            return clsDeleteLocalDrivingLicense.DeleteLocalDrivingLicenseApplication(this.LocalDrivingLicenseApplicationID) && this.Application.DeleteApplication();
        }

        public Action<string> OnSaveErrorGetMessage;
        public Action<int> OnSaveSuccessGetAppID; // used to get application id (local driving license application id) after successful save to db




    }


}
