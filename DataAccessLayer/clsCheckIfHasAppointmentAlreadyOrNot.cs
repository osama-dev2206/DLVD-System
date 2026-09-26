using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
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
        private static bool ImplementQuery(enTestType testType, int LocalLicenseApplicationID , dynamic TestTypeID)
        {
            switch (testType)
            {
                case enTestType.VisionTest:
                    return @SqlCmd(@"
Select R = 'T'
From TestAppointments
where TestAppointments.TestAppointmentForLocalDrivingLicenseAppID =@LocalDrivingLicenseApplicationID
and TestAppointments.AppointmentTestTypeID =@TestTypeID  -- vision ex ;", Paramter1: "@LocalDrivingLicenseApplicationID", value1:LocalLicenseApplicationID, 
Paramter2: "@TestTypeID",  value2 : TestTypeID );

                    case enTestType.WrittenTest:
                    return false;

                    case enTestType.StressTest:
                    return false;

            }
            return false;
        }

        private static bool @SqlCmd(string Query, string Paramter1,int value1 , string Paramter2 , int value2)
        {
            SqlCommand cmd = new SqlCommand(Query, connection);
            cmd.Parameters.AddWithValue(Paramter1, value1);
            cmd.Parameters.AddWithValue(Paramter2, value2);
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


        public static bool HasAppointmentAlready(enTestType testType,  int LocalLicenseApplicationID, int TestTypeID)
        {
            bool Result = false;
            try
            {
                connection.Open();
               Result=  ImplementQuery(enTestType.VisionTest, LocalLicenseApplicationID, TestTypeID);
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
