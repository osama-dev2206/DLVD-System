using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer
{
    public static class clsReleaseLicnese
    {
        private static string Query = @"Update DetainedLicenses
Set ISReleased = 1 , 
ReleasedDateTime = @ReleasedDateTime , 
ReleasedByUserID = @ReleasedByUserID , 
ReleaseApplicationID = @ReleaseApplicationID
where DLicenseID = @LicenseID ;";

        public static bool ReleaseLicense(int LicenseID, DateTime ?ReleasedDateTime, int? ReleasedByUserID, int ?ReleaseApplicationID)
        {
            SqlConnection connection = dbSettings.DbConnection();
            bool res = false;

            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(Query, connection);
                cmd.Parameters.AddWithValue("@LicenseID", LicenseID);
                cmd.Parameters.AddWithValue("@ReleasedDateTime", ReleasedDateTime);
                cmd.Parameters.AddWithValue("@ReleasedByUserID", ReleasedByUserID);
                cmd.Parameters.AddWithValue("@ReleaseApplicationID", ReleaseApplicationID);

    
                int  NumOfAffectedRows = cmd.ExecuteNonQuery();
    
                if(NumOfAffectedRows > 0)
                {
                    res = true;
                }

            }
            catch { }
            finally
            {
                connection.Close();
            }

            return res;
        }

    }
}
