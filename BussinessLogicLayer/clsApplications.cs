namespace BussinessLogicLayer
{
    public  class clsApplications
    {
        public int ApplicationID { get;  internal set; }
        public int ApplicantPersonID { get; internal set; }
        public DateTime ApplicationDateTime { get; internal set; }
        public int ApplicationTypeID { get; internal set; } // new , renew, Other
        public byte ApplicationStatus{ get; internal set; }  // tinyint in db
        public DateTime LastStatusDateTime { get; internal set; }
        public decimal PaiedFee { get; internal set; }
        public int CreatedByUserID { get; internal set; }

        internal enum enApplicationStatus : byte { New = 1, Cancelled = 2, Completed = 3 }

    }
}
