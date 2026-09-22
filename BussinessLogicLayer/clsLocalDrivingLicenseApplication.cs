using System;
using System.Collections.Generic;
using System.Text;

namespace BussinessLogicLayer
{
    public class clsLocalDrivingLicenseApplications // composition 
    {
        public int LocalDrivingLicenseApplicationID { get; private set; }
        public int ApplicationID { get; private set; }
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




    }


}
