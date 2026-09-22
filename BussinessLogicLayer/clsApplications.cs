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

        private bool AddApplicationToApplicationTable()
        {
            this.ApplicationID =  DataAccessLayer.clsAddNewApplicationToApplicationTable.AddNewApplication(
                 ApplicantPersonID: this.ApplicantPersonID , ApplicationDateTime: this.ApplicationDateTime , 
                 ApplicationTypeID: this.ApplicationTypeID, ApplicationStatus: this.ApplicationStatus,
                 LastStatusDateTime: this.LastStatusDateTime, PaidFees: this.PaiedFee, CreatedByUserID: this.CreatedByUserID);

            return (ApplicationID !=-1);
        }

        internal bool SaveApplication()
        {
            switch(this.status)
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

            }

            return false;
        }

         internal bool DeleteApplication()
        {
            return DataAccessLayer.clsDeleteApplication.DeleteApplication(this.ApplicationID);
        }




        }
}
