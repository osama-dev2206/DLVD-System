using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer
{
    public static class clsGetNumOfPassedTestsByLDLAppID
    {

        private static string Query = @"
Select Count(*) as NumOfPassedTests 
from Test
Inner Join TestAppointments on Test.AppointmentOfTestID = TestAppointments.TestAppointmentID
Inner Join LocalDrivingLicenseApplications On LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID
= TestAppointments.TestAppointmentForLocalDrivingLicenseAppID
Inner Join Applications On Applications.ApplicationID = LocalDrivingLicenseApplications.LApplicationID
where Test.TestResult = 1 and
LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID;";


        public static int GetNumOfPassedTestsByLDLAppID(int LocalDrivingLicenseApplicationID)
        {
            SqlConnection connection = dbSettings.DbConnection();
            int numOfPassedTests = 0;
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(Query, connection);
                command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);

                object result = command.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    numOfPassedTests = Convert.ToInt32(result);
                }
                connection.Close();
         
            }
     catch  {           }
            finally
            {
                connection.Close();
            }

            return numOfPassedTests;
        }


    }
}
