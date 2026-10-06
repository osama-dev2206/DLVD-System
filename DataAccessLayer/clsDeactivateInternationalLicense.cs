using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer
{
    public static class clsDeactivateInternationalLicense
    {
        private static string Query = @"     Update InternationalLicenses
     Set IsActive = 0 
     where LicenseID =  @LicenseID ; ";

        public static bool DeactivateInternationalLicense(int LicenseID)
        {
            SqlConnection connection = dbSettings.DbConnection();
            bool result = false;
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(Query, connection);
                cmd.Parameters.AddWithValue("@LicenseID", LicenseID);
                int ? NumOfAffectedRows = cmd.ExecuteNonQuery();
                if(NumOfAffectedRows > 0) result = true;
            }
            catch { }
            finally
            {
                connection.Close();
            }
            return result;
        }


    }
}
