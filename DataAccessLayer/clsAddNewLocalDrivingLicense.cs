using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer
{
    public static class clsAddNewLocalDrivingLicense
    {
        private static string Query = @"Insert Into LocalDrivingLicenseApplications
values (   @ApplicationID  ,   @LicenseClassID );
Select SCOPE_IDENTITY();";

        public static int AddNewLocalDrivingLicenseApplication(int ApplicationID, int LicenseClassID)
        {
            int NewLocalDrivingLicenseApplicationID = -1;
            SqlConnection connection = dbSettings.DbConnection();
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(Query, connection);
                cmd.Parameters.AddWithValue("@ApplicationID", ApplicationID);
                cmd.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);

                object result = cmd.ExecuteScalar();
                if(result != null && int.TryParse(result.ToString(), out int newId))
                {
                    NewLocalDrivingLicenseApplicationID = newId;
                }
            }
            catch { }
            finally
            {
                connection.Close();
            }
            return NewLocalDrivingLicenseApplicationID;
        }

    }
}
