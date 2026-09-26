using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer
{
    public static class clsGetTestResultByTestAppointmentID
    {
        private static string Query = @"
SELECT TOP 1 Test.TestResult
FROM Test
INNER JOIN TestAppointments
    ON TestAppointments.TestAppointmentID = Test.AppointmentOfTestID
INNER JOIN LocalDrivingLicenseApplications
    ON TestAppointments.TestAppointmentForLocalDrivingLicenseAppID
       = LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID
WHERE LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID
      = @LocalDrivingLicenseApplicationID
AND TestAppointments.AppointmentTestTypeID = @TestTypeID
ORDER BY TestAppointments.AppointmentDateTime DESC ;  -- Vision Test ID (EX)  ";

        public static bool? GetTestResultByTestAppointmentID(int LocalDrivingLicenseApplicationID, int TestTypeID)
        {
            SqlConnection connection = dbSettings.DbConnection();
            bool? result = null;
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(Query, connection);
                cmd.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
                cmd.Parameters.AddWithValue("@TestTypeID", TestTypeID);
                object res = cmd.ExecuteScalar();
                if(res != null )
                {
                    if (Convert.ToInt32(res) == 1) result = true; // pass
                    else if (Convert.ToInt32(res) == 0) result = false; // fail
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
