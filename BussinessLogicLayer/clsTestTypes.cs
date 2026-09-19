using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Contracts;
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

        private clsTestTypes(int testTypeID, string testTypeTitle, string testTypeDescription, decimal testTypeFee)
        {
            this.TestTypeID = testTypeID;
            this.TestTypeTitle = testTypeTitle;
            this.TestTypeDescription = testTypeDescription;
            this.TestTypeFee = testTypeFee;
        }

        public static DataTable GetAllTestTypes()
        {
            return clsGetAllAppTypes.GetAllAppTypes();
        }

        private bool Update()
        {
            return clsUpdateTestType.UpdateTestType(this.TestTypeID, this.TestTypeTitle, this.TestTypeDescription, this.TestTypeFee);
        }

        public bool Save()
        {
            return (Update());

        }

    }
}
