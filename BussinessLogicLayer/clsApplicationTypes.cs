using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace BussinessLogicLayer
{
    public class clsApplicationTypes // this class is used to manage the application types in the system (update and search is the only allowed functionality)
    {
        public int ApplicationTypeID { private set; get; }
        public string ApplicationTypeTitle { set; get; }
        public decimal ApplicationFees { set; get; }

        public clsApplicationTypes()
        {
            ApplicationTypeID = -1;
            ApplicationTypeTitle = string.Empty;
            ApplicationFees = -1;
        }

        private clsApplicationTypes(int appTypeID, string appTypeTitle, decimal appFees)
        {
            this.ApplicationTypeID = appTypeID;
            this.ApplicationTypeTitle = appTypeTitle;
            this.ApplicationFees = appFees;
        }

        public static clsApplicationTypes FindAppObjByAppID(int AppID)
        {
            if (!int.TryParse(AppID.ToString(), out int appTypeID))
                return null;

            DataTable dt = DataAccessLayer.clsFindAppTypeByAppID.GetAppByAppID(appTypeID);

            clsApplicationTypes App = null;

            foreach (DataRow R in dt.Rows)
            {
                App = new clsApplicationTypes(Convert.ToInt32(R["ApplicationTypeID"]), R["ApplicationTypeTitle"].ToString(), Convert.ToDecimal(R["ApplicationFees"]));
            }

            return App;
        }


        public static DataTable GetAllAppTypes()
        {
            return DataAccessLayer.clsGetAllAppTypes.GetAllAppTypes();
        }

        private bool UpdateAppType()
        {
            return clsUpdateAppType.UpdateAppType(this.ApplicationTypeID, this.ApplicationTypeTitle, this.ApplicationFees);
        }

        public bool Save()
        {
            if (UpdateAppType())
            {
                return true;
            }
            else
                return false;
        }

        internal enum enApplicationTypes : byte
        {
            NewLocalDrivingLicense = 1, RenewDrivingLicense = 2, ReplacementForLostDrivingLicense = 3 , ReplacementForDamagedDrivingLicense = 4,
            ReleaseDetainedDrivingLicense = 5, NewInternationalDrivingLicense = 6, RetakeTest = 7
        }


    }
}
