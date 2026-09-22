using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer
{
    public static class clsUpdateLocalDrivingLic
    {
        private static string Query = @"
Update LocalDrivingLicenseApplications
Set LLicenseClassID = @LicenseClassID
where LocalDrivingLicenseApplicationID =   @LocalDrivingLicenseApplicationID ;";

        public static bool UpdateLocalDrivingLicenseApplication(int LocalDrivingLicenseApplicationID, int LicenseClassID)
        {
            SqlConnection connection = dbSettings.DbConnection();
            bool result = false;
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(Query, connection);
                cmd.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
                cmd.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);

                int ? NumOfAffectedRows = cmd.ExecuteNonQuery();
                if(NumOfAffectedRows is not null &&NumOfAffectedRows > 0)
                {
                    result = true;
                }

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
