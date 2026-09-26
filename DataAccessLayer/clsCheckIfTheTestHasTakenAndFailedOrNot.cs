using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer
{
    public static class clsCheckIfTheTestHasTakenAndFailedOrNot
    {
        private static string Query = @"Select R = 'T'
from (

Select Test.TestID,Test.TestResult , Test.AppointmentOfTestID , LocalDrivingLicenseApplicationID 
, TestAppointments.IsLocked
from Test 
Inner Join TestAppointments On TestAppointments.TestAppointmentID = Test.AppointmentOfTestID
Inner Join LocalDrivingLicenseApplications On 
LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = 
TestAppointments.TestAppointmentForLocalDrivingLicenseAppID  
where TestAppointmentID = @TestAppointmentID -- Specific TestAppointment ID
and Test.TestResult = 0 -- Failed 
and TestAppointments.IsLocked = 1 -- Test Finished
and TestAppointments.AppointmentTestTypeID = @TestTypeID -- Vision Test ID

) R ;
";
        public static bool HasTakenTestAndFailed(int TestAppointmentID, int TestTypeID)
        {
            SqlConnection connection = dbSettings.DbConnection();
            bool result = false;
            try
            {
                connection.Open();  
                SqlCommand cmd = new SqlCommand(Query, connection);
                cmd.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);   
                cmd.Parameters.AddWithValue("@TestTypeID", TestTypeID);

                object queryResult = cmd.ExecuteScalar();
                if(queryResult?.ToString() == "T")
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
