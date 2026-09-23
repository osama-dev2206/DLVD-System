using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer
{
    public static class clsDeleteApplicationByApplicationID
    {
        private static string Query = @"Delete Applications 
 where Applications.ApplicationID =
(
Select LocalDrivingLicenseApplications.LApplicationID
from LocalDrivingLicenseApplications
where LocalDrivingLicenseApplicationID =  @LocalDrivingLicenseApplicationID ) ;" ;


        public static bool DeleteApplicationByLocalDrivingLicenseApplicationID(int LocalDrivingLicenseApplicationID)
        {
            SqlConnection connection = dbSettings.DbConnection();
            bool res    = false;
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(Query,connection);
                cmd.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
                int ? rowsAffected = cmd.ExecuteNonQuery();

                if(rowsAffected is not null && rowsAffected > 0)
                    res = true;
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
