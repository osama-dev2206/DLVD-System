using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer
{
    public static class clsUpdateApplicationStatusUsingLocalDriving
    {
        private static string Query = @"
Update Applications
Set 
ApplicationStatus = @AppLicationStatus ,
LastStatusDateTime = @LastStatusDateTime
where Applications.ApplicationID 
= 
(
Select LocalDrivingLicenseApplications.LApplicationID
from LocalDrivingLicenseApplications
where LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID
); ";

        public static bool UpdateApplicationStatus(int LocalDrivingLicenseApplicationID, byte ApplicationStatus, DateTime LastStatusDateTime)
        {
               SqlConnection connection = dbSettings.DbConnection();
            bool Result = false;
            try
            {
                connection.Open();
                SqlCommand cmd= new SqlCommand(Query, connection);
              cmd.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
                cmd.Parameters.AddWithValue("@AppLicationStatus", ApplicationStatus);
                cmd.Parameters.AddWithValue("@LastStatusDateTime", LastStatusDateTime);
                int ?  rowsAffected = cmd.ExecuteNonQuery();
                Result = rowsAffected > 0;
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
