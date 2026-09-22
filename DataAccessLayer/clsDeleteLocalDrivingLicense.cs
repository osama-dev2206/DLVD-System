using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer
{
    public static class clsDeleteLocalDrivingLicense
    {
        private static string Query = @"
Delete LocalDrivingLicenseApplications
where LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = @LocalAppID;";

        public static bool DeleteLocalDrivingLicenseApplication(int LocalDrivingLicenseApplicationID)
        {
            SqlConnection connection = dbSettings.DbConnection();
            bool result = false;
            try 
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(Query, connection);
                cmd.Parameters.AddWithValue("@LocalAppID", LocalDrivingLicenseApplicationID);

              if(  cmd?.ExecuteNonQuery() > 0) 
                    result =true;
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
