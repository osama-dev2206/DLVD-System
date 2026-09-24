using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer
{
    public static class clsCheckIfTestHasFinishedOrNot
    {
        private static string Query = @"Select R = 'T' 
From TestAppointments 
Inner Join TestTypes On TestTypes.TestTypeID = TestAppointments.AppointmentTestTypeID
Inner Join LocalDrivingLicenseApplications On
LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = 
TestAppointments.TestAppointmentForLocalDrivingLicenseAppID
Inner Join Applications On Applications.ApplicationID = LocalDrivingLicenseApplications.LApplicationID
Inner Join Test On Test.AppointmentOfTestID = TestAppointments.TestAppointmentID

where TestTypeID = @TestTypeID -- vision,written,practical 
And 
Applications.ApplicantPersonID = @PersonID -- applicant person id
and
Test.TestResult =1 ;"; // wil return  T is the person Has Completed Test and Passed It 


        public static bool CheckIfTestHasFinishedOrNot(int TestTypeID, int PersonID)
        {
                  bool Result = false;
            SqlConnection connection = dbSettings.DbConnection();
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(Query, connection);
                cmd.Parameters.AddWithValue("@TestTypeID", TestTypeID);
                cmd.Parameters.AddWithValue("@PersonID", PersonID);

                object reader = cmd.ExecuteScalar();
     
                if(reader is not null && reader.ToString() == "T")
                {
                    Result = true;
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
