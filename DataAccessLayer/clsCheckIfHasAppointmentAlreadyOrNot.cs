using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer
{
    public static class clsCheckIfHasAppointmentAlreadyOrNot
    {
        private static SqlConnection connection;

        static clsCheckIfHasAppointmentAlreadyOrNot()
        {
            connection = dbSettings.DbConnection();
        }

        public enum enTestType { VisionTest = 1, WrittenTest = 2, StressTest = 3 }
        private static bool ImplementQuery(enTestType testType, dynamic value)
        {
            switch (testType)
            {
                case enTestType.VisionTest:
                    return @SqlCmd(@"Select R='T'
from TestAppointments
Inner Join TestTypes On TestTypes.TestTypeID = TestAppointments.AppointmentTestTypeID
Inner Join LocalDrivingLicenseApplications on
LocalDrivingLicenseApplicationID = TestAppointments.TestAppointmentForLocalDrivingLicenseAppID

Where LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID =@LocalDrivingLicenseApplicationID
and TestTypes.TestTypeID = 1 ;-- if has appointment (vision Test)", "@LocalDrivingLicenseApplicationID", value);

                    case enTestType.WrittenTest:
                    return @SqlCmd(@"Select R='T'
from TestAppointments
Inner Join TestTypes On TestTypes.TestTypeID = TestAppointments.AppointmentTestTypeID
Inner Join LocalDrivingLicenseApplications on
LocalDrivingLicenseApplicationID = TestAppointments.TestAppointmentForLocalDrivingLicenseAppID

Where LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID =@LocalDrivingLicenseApplicationID
and TestTypes.TestTypeID = 2 ;-- if has appointment (written Test)", "@LocalDrivingLicenseApplicationID", value);

                    case enTestType.StressTest:
                    return @SqlCmd(@"Select R='T'
from TestAppointments
Inner Join TestTypes On TestTypes.TestTypeID = TestAppointments.AppointmentTestTypeID
Inner Join LocalDrivingLicenseApplications on
LocalDrivingLicenseApplicationID = TestAppointments.TestAppointmentForLocalDrivingLicenseAppID

Where LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID =@LocalDrivingLicenseApplicationID
and TestTypes.TestTypeID = 3 ;-- if has appointment (stress(practical) Test)", "@LocalDrivingLicenseApplicationID", value);

            }
            return false;
        }

        private static bool @SqlCmd(string Query, string Paramter, dynamic value)
        {
            SqlCommand cmd = new SqlCommand(Query, connection);
            cmd.Parameters.AddWithValue(Paramter, value);
            object R = cmd.ExecuteScalar();
            if (R is not null && R.ToString() == "T")
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public static bool HasAppointmentAlready(enTestType testType, dynamic value)
        {
            bool Result = false;
            try
            {
                connection.Open();
               Result=  ImplementQuery(enTestType.VisionTest, value);
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
