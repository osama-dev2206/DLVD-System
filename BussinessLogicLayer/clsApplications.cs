using DataAccessLayer;
using System.Data;

namespace BussinessLogicLayer
{
    public sealed class clsApplications
    {
        public int ApplicationID { get;  private set; } // i will handle it here only 
        public int ApplicantPersonID { get; internal set; }
        public DateTime ApplicationDateTime { get; internal set; }
        public int ApplicationTypeID { get; internal set; } // new , renew, Other
        public byte ApplicationStatus{ get;  set; }  // tinyint in db ( completed, cancelled, new)
        public DateTime LastStatusDateTime { get; internal set; }
        public decimal PaiedFee { get; internal set; }
        public int CreatedByUserID { get; internal set; }

        public enum enApplicationStatus : byte { New = 1, Cancelled = 2, Completed = 3 }

        public enum enStatus { Add = 1, Edit = 2 }
        private enStatus status;

        internal clsApplications() // Add new application
        {
            status = enStatus.Add;
            this.ApplicationID = -1; // default value for new application
        }


        private clsApplications(int ApplicationID ,int ApplicantPersonID , DateTime ApplicationDateTime , int ApplicationTypeID , byte ApplicationStatus,  decimal PaiedFee , int CreatedByUserID) // Update  application
        {
            status = enStatus.Edit;

            this.ApplicationID = ApplicationID;
            this.ApplicantPersonID = ApplicantPersonID;
            this.ApplicationDateTime = ApplicationDateTime;
            this.ApplicationTypeID = ApplicationTypeID;
            this.ApplicationStatus = ApplicationStatus;
            this.LastStatusDateTime = DateTime.Now;
            this.PaiedFee = PaiedFee;
            this.CreatedByUserID = CreatedByUserID;
        }


        private bool AddApplicationToApplicationTable()
        {
            this.ApplicationID =  DataAccessLayer.clsAddNewApplicationToApplicationTable.AddNewApplication(
                 ApplicantPersonID: this.ApplicantPersonID , ApplicationDateTime: this.ApplicationDateTime , 
                 ApplicationTypeID: this.ApplicationTypeID, ApplicationStatus: this.ApplicationStatus,
                 LastStatusDateTime: this.LastStatusDateTime, PaidFees: this.PaiedFee, CreatedByUserID: this.CreatedByUserID);

            return (ApplicationID !=-1);
        }

        private bool UpdateApplication()
        {
            return clsUpdateApplication.UpdateApplication(this.ApplicationID,this.ApplicationStatus , DateTime.Now);
        }

         internal bool DeleteApplication()
        {
            return DataAccessLayer.clsDeleteApplication.DeleteApplication(this.ApplicationID);
        }


        internal bool SaveApplication()
        {
            switch (this.status)
            {
                case enStatus.Add:
                    {
                        if (AddApplicationToApplicationTable())
                        {
                            this.status = enStatus.Edit;
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }

                case enStatus.Edit:
                    {
                        return UpdateApplication();
                    }
            }

            return false;
        }

        public static clsApplications GetApplicationObjByAppID(int AppID)
        {
            if(!int.TryParse(AppID.ToString(), out int ApplicationID))
            {
                return null;
            }

            DataTable dt = DataAccessLayer.clsGetApplicationByAppID.GetApplication(ApplicationID);
            clsApplications app = null; 
            foreach(DataRow R in dt.Rows)
            {
                app = new clsApplications(
                    ApplicationID: Convert.ToInt32(R["ApplicationID"]),
                    ApplicantPersonID: Convert.ToInt32(R["ApplicantPersonID"]),
                    ApplicationDateTime: Convert.ToDateTime(R["ApplicationDateTime"]),
                    ApplicationTypeID: Convert.ToInt32(R["ApplicationTypeID"]),
                    ApplicationStatus: Convert.ToByte(R["ApplicationStatus"]),
                    PaiedFee: Convert.ToDecimal(R["PaidFees"]),
                    CreatedByUserID: Convert.ToInt32(R["CreatedByUserID"])
                );
            }

           return app;
        }

        public static DataTable GetApplicationObjDetailsByApplicationID(int AppID)
        {
            return clsGetDetailedAppInfoByApplicationID.GetInfo(AppID);
        }



    }
}
