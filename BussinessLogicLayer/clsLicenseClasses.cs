
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace BussinessLogicLayer
{
    public sealed class clsLicenseClasses
    {
        public int LicenseClassID { get; set; }
        public string ClassName { get; set; }
        public string ClassDescription { get; set; }
        public byte MinimumAllowedAge { get; set; }
        public short DefaultValidityLength { get; set; }
        public decimal ClassFees { get; set; }

        private clsLicenseClasses(int LicenseClassID, string ClassName, string ClassDescription, byte MinAllowedAge, short DefaultValidityLength, decimal ClassFees)
        {
            this.LicenseClassID = LicenseClassID;
            this.ClassName = ClassName;
            this.ClassDescription = ClassDescription;
            this.MinimumAllowedAge = MinAllowedAge;
            this.DefaultValidityLength = DefaultValidityLength;
            this.ClassFees = ClassFees;
        }

        public clsLicenseClasses()
        {

        }

        public static DataTable GetAll_LicenseClassses()
        {
            return clsGetAllLicenseClasses.GetAllLicenseClasses();
        }

        public static int GetLicenseClassIDByClassName(string ClassName)
        {
            if (String.IsNullOrEmpty(ClassName)) return -1;
            ClassName = ClassName.Trim();

            return DataAccessLayer.clsGetLicenseClassIDByItsName.GetLicenseClassIDByItsName(ClassName);

        }


        public static clsLicenseClasses FindLicenseClassByID(int LicenseClassID)
        {
            if (!int.TryParse(LicenseClassID.ToString(), out int ID)) return null; // invalid id

            clsLicenseClasses licenseClass = null;

            DataTable dt = clsFindLicenseClasssByClassID.FindLicenseClassByClassID(LicenseClassID); // get license class by id
            foreach (DataRow row in dt.Rows)
            {
                licenseClass = new clsLicenseClasses(
                    LicenseClassID: Convert.ToInt32(row["LicenseClassID"]),
                    ClassName: row["ClassName"].ToString(),
                    ClassDescription: row["ClassDescription"].ToString(),
                    MinAllowedAge: Convert.ToByte(row["MinimumAllowedAge"]),
                    DefaultValidityLength: Convert.ToInt16(row["DefaultValidityLength"]),
                    ClassFees: Convert.ToDecimal(row["ClassFees"])
                );
            }
            return licenseClass;

        }


    }
}
