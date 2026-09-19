using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace BussinessLogicLayer
{
    public  class clsTestTypes
    {
        public int TestTypeID { get; private set; }
        public string TestTypeTitle { get;  set; }
        public string TestTypeDescription { get; set; }
        public decimal TestTypeFee { get; set; }

        public clsTestTypes()
        {
            this.TestTypeID = -1;
            this.TestTypeTitle = string.Empty;
            this.TestTypeFee = 0.0m;
            this.TestTypeDescription = string.Empty;
        }

        public static DataTable GetAllTestTypes()
        {
            return clsGetAllAppTypes.GetAllAppTypes();
        }




    }
}
