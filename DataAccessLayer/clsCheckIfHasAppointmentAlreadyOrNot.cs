using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace DataAccessLayer
{
    public static class clsCheckIfHasAppointmentAlreadyOrNot // if the pervious appointment is not locked then the user cannot add new appointment for the same test type and local driving license application ID
    {
        private static SqlConnection connection;

        static clsCheckIfHasAppointmentAlreadyOrNot()
        {
            connection = dbSettings.DbConnection();
        }


        private static bool ImplementQuery(int  testTypeID, int LocalLicenseApplicationID)
        {

                    return @SqlCmd(@"
SELECT TOP 1 TestAppointmentID
FROM TestAppointments
WHERE TestAppointmentForLocalDrivingLicenseAppID = @LocalDrivingLicenseApplicationID
  AND AppointmentTestTypeID = @TestTypeID
  AND IsLocked = 0
ORDER BY TestAppointmentID DESC ;", Paramter1: "@LocalDrivingLicenseApplicationID", value1:LocalLicenseApplicationID, 
Paramter2: "@TestTypeID",  value2 : testTypeID);




        }

        private static bool @SqlCmd(string Query, string Paramter1,int value1 , string Paramter2 , int value2)
        {
            SqlCommand cmd = new SqlCommand(Query, connection);
            cmd.Parameters.AddWithValue(Paramter1, value1);
            cmd.Parameters.AddWithValue(Paramter2, value2);
            object R = cmd.ExecuteScalar();
            if (R is not null )
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public static bool HasAppointmentIsNotLocked(int testTypeID,  int LocalLicenseApplicationID)
        {
            bool Result = false;
            try
            {
                connection.Open();
               Result=  ImplementQuery(testTypeID, LocalLicenseApplicationID);
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
