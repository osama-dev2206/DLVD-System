using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer
{
    public static class clsDisableLicenseByLicID
    {
        private static string Query = @"Update Licenses 
Set IsActive = 0
where Licenses.LicenseID = @LicenseID ;";


        public static bool DisableLicense(int LicenseID)
        {
            bool Result = false;
            SqlConnection connection = dbSettings.DbConnection();
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(Query, connection);
                cmd.Parameters.AddWithValue("@LicenseID", LicenseID);
                int ? NumOfAffectedRows = cmd.ExecuteNonQuery();
                if(NumOfAffectedRows.HasValue && NumOfAffectedRows.Value > 0)
                {
                    Result = true;
                }
            }
            catch { }
            finally
            {
                connection.Close();
            }
            return Result;
           
        }

    }
}
