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

        public enum enTestTypes { VisionTest=1 , WrittenTest = 2, PracticalTest = 3 }

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
            return clsGetAllTestTypes.GetAllTestTypes();
        }

        public static clsTestTypes FindTestType(int TestTypeId)
        {
            if (!int.TryParse(TestTypeId.ToString(), out _)) return null;

            DataTable dt = clsFindTestType.FindTestType(TestTypeId);
            clsTestTypes testTypes = null;

            foreach(DataRow R in dt.Rows)
            {
                testTypes = new clsTestTypes
                    (
                    testTypeID: Convert.ToInt32(R["TestTypeID"]) ,
                    testTypeTitle: R["TestTypeTitle"].ToString() ,
                    testTypeDescription : R["TestTypeDescription"].ToString() ,
                    testTypeFee: Convert.ToDecimal(R["TestTypeFees"])
                    );
            }

            return testTypes;
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
