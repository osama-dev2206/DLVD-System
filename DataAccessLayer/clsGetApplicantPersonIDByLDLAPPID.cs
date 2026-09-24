using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer
{
    public static class clsGetApplicantPersonIDByLDLAPPID
    {

        private static string Query = @"Select Applications.ApplicantPersonID
from Applications 
Inner Join LocalDrivingLicenseApplications On 
LocalDrivingLicenseApplications.LApplicationID = Applications.ApplicationID
where LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID ;";


        public static int GetApplicantPersonIDByLDLAPPID(int LocalDrivingLicenseApplicationID)
        {
            int Result = -1;
            SqlConnection connection = dbSettings.DbConnection();
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(Query, connection);
                cmd.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
                object reader = cmd.ExecuteScalar();
                if (reader is not null && int.TryParse(reader.ToString() , out int ID))
                {
                    Result = ID;
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
