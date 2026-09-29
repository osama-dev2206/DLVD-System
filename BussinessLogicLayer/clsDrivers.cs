using DataAccessLayer;
using System;
using System.Collections.Generic;
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
            this.CreatedDate = DateOnly.FromDateTime(DateTime.Now);
        }

        private bool AddNewDriver()
        {
            this.DriverID = clsAddNewDriver.AddNewDriver(this.DriverPersonID , this.CreatedByUserID , this.CreatedDate);
            return (DriverID != -1);
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
