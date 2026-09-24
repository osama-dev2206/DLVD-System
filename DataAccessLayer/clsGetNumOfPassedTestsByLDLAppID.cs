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
Applications.ApplicantPersonID = @ApplicantPersonID ;";


        public static int GetNumOfPassedTestsByLDLAppID(int ApplicantPersonID)
        {
            SqlConnection connection = dbSettings.DbConnection();
            int numOfPassedTests = 0;
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(Query, connection);
                command.Parameters.AddWithValue("@ApplicantPersonID", ApplicantPersonID);

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
