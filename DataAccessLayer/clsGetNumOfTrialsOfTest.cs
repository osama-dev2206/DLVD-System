using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer
{
    public static class clsGetNumOfTrialsOfTest
    {
        public enum enTestType { VisionTest = 1, WrittenTest = 2, StreetTest = 3 }

        private static string Query(enTestType testType  )
        {
            switch (testType)
            {
                case enTestType.VisionTest:
                    return @"-- Get Num Of Trials For Vision Test ---------
Select Count(*) as NumOfTrials
From Test
Inner Join TestAppointments On TestAppointments.TestAppointmentID = Test.AppointmentOfTestID
Inner Join LocalDrivingLicenseApplications On 
LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = 
TestAppointments.TestAppointmentForLocalDrivingLicenseAppID

where LocalDrivingLicenseApplicationID =@LocalDrivingLicenseApplicationID -- Local Driving License Application ID
and TestAppointments.AppointmentTestTypeID = 1 ; -- Vision Test ID" ;

                case enTestType.WrittenTest:
                    return @"-- Get Num Of Trials For Vision Test ---------
Select Count(*) as NumOfTrials
From Test
Inner Join TestAppointments On TestAppointments.TestAppointmentID = Test.AppointmentOfTestID
Inner Join LocalDrivingLicenseApplications On 
LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = 
TestAppointments.TestAppointmentForLocalDrivingLicenseAppID

where LocalDrivingLicenseApplicationID =@LocalDrivingLicenseApplicationID -- Local Driving License Application ID
and TestAppointments.AppointmentTestTypeID = 2 ; -- Written Test ID";

                case enTestType.StreetTest:
                    return @"-- Get Num Of Trials For Vision Test ---------
Select Count(*) as NumOfTrials
From Test
Inner Join TestAppointments On TestAppointments.TestAppointmentID = Test.AppointmentOfTestID
Inner Join LocalDrivingLicenseApplications On 
LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = 
TestAppointments.TestAppointmentForLocalDrivingLicenseAppID

where LocalDrivingLicenseApplicationID =@LocalDrivingLicenseApplicationID -- Local Driving License Application ID
and TestAppointments.AppointmentTestTypeID = 3 ; -- Street Test ID";


            }
            return "";
        }


        public static int GetNumOfTrials(enTestType testType, int LocalDrivingLicenseApplicationID)
        {
            SqlConnection connection = dbSettings.DbConnection();
            int numOfTrials = -1;
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(Query(testType), connection);
                cmd.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);

                object result = cmd.ExecuteScalar();

                if(result is not null && int.TryParse(result.ToString(), out int trials))
                {
                    numOfTrials = trials;
                }

            }
            catch { }
            finally
            {
                connection.Close();
            }
            
            return numOfTrials;
        }




    }
}
