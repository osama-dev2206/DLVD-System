using DataAccessLayer;

namespace BussinessLogicLayer
{
    public  class clsApplications
    {
        public int ApplicationID { get;  private set; } // i will handle it here only 
        public int ApplicantPersonID { get; internal set; }
        public DateTime ApplicationDateTime { get; internal set; }
        public int ApplicationTypeID { get; internal set; } // new , renew, Other
        public byte ApplicationStatus{ get; internal set; }  // tinyint in db
        public DateTime LastStatusDateTime { get; internal set; }
        public decimal PaiedFee { get; internal set; }
        public int CreatedByUserID { get; internal set; }

        internal enum enApplicationStatus : byte { New = 1, Cancelled = 2, Completed = 3 }

        private enum enStatus { Add = 1, Edit = 2 }
        private enStatus status;

        internal clsApplications() // Add new application
        {
            status = enStatus.Add;
            this.ApplicationID = -1; // default value for new application
        }

        internal int CheckApplicationExistence() // this check if the person has applied for the same application type without finishing the previous application of the same type
        {
          return clsIsPersonHasRegisteredBeforeInApplication.IsPersonHasRegisteredBefore(PersonID: this.ApplicantPersonID, AppTypeID: this.ApplicationTypeID);
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
            return false;
        }

        /*CUATION : DONOT DELETE THE RECORD FROM APPLICATIONS TABLE AFTER DELETING IT FROM LOCAL DRIVING LICENSE */
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



    }
}
