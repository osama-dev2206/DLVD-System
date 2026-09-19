using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace BussinessLogicLayer
{
    public  class clsAppTypes // this class is used to manage the application types in the system (update and search is the only allowed functionality)
    {
        public int ApplicationTypeID { private set; get; }
        public string ApplicationTypeTitle {  set; get; }
        public decimal ApplicationFees { set; get; }
        
        public clsAppTypes()
        {

        }

        private clsAppTypes(int appTypeID, string appTypeTitle, decimal appFees)
        {
            this.ApplicationTypeID = appTypeID;
            this.ApplicationTypeTitle = appTypeTitle;
            this.ApplicationFees = appFees;
        }

        public static clsAppTypes FindAppObjByAppID(int AppID)
        {
            if (!int.TryParse(AppID.ToString(), out int appTypeID))
                return null;

            DataTable dt = DataAccessLayer.clsFindAppTypeByAppID.GetAppByAppID(appTypeID);

            clsAppTypes App = null;

            foreach (DataRow R in dt.Rows)
            {
                App = new clsAppTypes(Convert.ToInt32(R["ApplicationTypeID"]), R["ApplicationTypeTitle"].ToString(), Convert.ToDecimal(R["ApplicationFees"]));
            }

            return App;
        }


        public static DataTable GetAllAppTypes()
        {
            return DataAccessLayer.clsGetAllAppTypes.GetAllAppTypes();
        }

        private  bool UpdateAppType()
        {
            return clsUpdateAppType.UpdateAppType(this.ApplicationTypeID,this.ApplicationTypeTitle,this.ApplicationFees); 
        }

        public bool Save()
        {
            if(UpdateAppType())
            {
                return true;
            }
            else 
                return false;
        }



    }
}
