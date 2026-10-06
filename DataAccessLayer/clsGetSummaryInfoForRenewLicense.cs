using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DataAccessLayer
{
    public static class clsGetSummaryInfoForRenewLicense
    {
        private static string Query = @"
     Select Licenses.LicenseID ,
     Licenses.IssueDate,Licenses.ExpirationDate , LicenseFees = 
     (
     Select LicenseClasses.ClassFees from LicenseClasses
     where LicenseClasses.LicenseClassID = Licenses.ClassOfLicenseID
     ) ,
     TotalFees =
     (
     Licenses.PaidFees + ApplicationFees
     )
     from Licenses
     Inner Join Applications On Applications.ApplicationID = Licenses.LicApplicationID
     Inner Join ApplicationTypes on Applications.ApplicationTypeID = ApplicationTypes.ApplicationTypeID
     where LicenseID = @LicenseID ";
        public static DataTable GetSummaryInfo(int RLicenseID)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = dbSettings.DbConnection();
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(Query,connection);
                cmd.Parameters.AddWithValue("@LicenseID", RLicenseID);

                using(SqlDataReader R = cmd.ExecuteReader())
                {
                    dt.Load(R);
                }
            }
            catch { }
            finally
            {
                connection.Close();
            }
            return dt;
        }


    }
}
