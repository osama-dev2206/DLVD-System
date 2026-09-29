using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace BussinessLogicLayer
{
    public class clsDrivers
    {
        public int DriverID { get; private set; }   
        public int DriverPersonID { get; internal set; }
        public int CreatedByUserID { get; internal set; }
        public DateOnly CreatedDate { get; private set; }

        enum enMode { Add = 1, Edit = 2 }
        enMode Mode;

        internal clsDrivers() // Add
        {
            Mode = enMode.Add;
            DriverID = -1;
            this.CreatedDate = DateOnly.FromDateTime(DateTime.Now);
        }

        private clsDrivers(int DriverID, int DriverPersonID, int CreatedByUserID, DateOnly CreatedDate) // Edit
        {
            Mode = enMode.Edit;
            this.DriverID = DriverID;
            this.DriverPersonID = DriverPersonID;
            this.CreatedByUserID = CreatedByUserID;
            this.CreatedDate = CreatedDate;
        }
        
        private bool AddNewDriver()
        {
            this.DriverID = clsAddNewDriver.AddNewDriver(this.DriverPersonID , this.CreatedByUserID , this.CreatedDate);
            return (DriverID != -1);
        }

        internal static bool IsDriverExists( int DriverPersonID)
        {
            return clsCheckIfThePersonIsDriverOrNot.CheckIfThePersonIsDriverOrNot(DriverPersonID);
        }

        internal static clsDrivers FindDriverByPersonID(int DriverPersonID)
        {
            DataTable dt = clsFindDriverByPersonID.FindDriverByPersonID(DriverPersonID);
            clsDrivers driver= null;
            foreach (DataRow dr in dt.Rows)
            {
       driver = new 
               clsDrivers(Convert.ToInt32(dr["DriverID"]), Convert.ToInt32(dr["DriverPersonID"]),
               Convert.ToInt32(dr["CreatedByUserID"]), 
               DateOnly.FromDateTime(Convert.ToDateTime(dr["CreatedDate"])));

            
            }
            return driver;
        }

        internal bool Save()
        {
            switch(this.Mode)
            {
                case enMode.Add:
                    
                        if (AddNewDriver())
                        {
                            this.Mode = enMode.Edit;
                            return true;
                        }
                    else 
                        return false;
            }
            return false;
        }


    }
}
