using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer
{
    public static class clsGetApplicationStatusByLocalLicenseAppID
    {
        private static string Query = @"
 Select Applications.ApplicationStatus 
 from Applications
 Inner Join LocalDrivingLicenseApplications On
 LocalDrivingLicenseApplications.LApplicationID = Applications.ApplicationID
 where LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID;";


        public static byte GetApplicationStatusByLocalLicenseAppID(int LocalDrivingLicenseApplicationID)
        {
            SqlConnection connection = dbSettings.DbConnection();
            byte ApplicationStatus = 0;
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(Query, connection);
                command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
                object result = command.ExecuteScalar();
                if(result != null && result != DBNull.Value)
                {
                    ApplicationStatus = Convert.ToByte(result);
                }
            }
            catch { }
            finally
            {
                connection.Close();
            }
            return ApplicationStatus;
        }


    }
}
