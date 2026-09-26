using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer
{
    public static class clsIsTestAppointmentLocked
    {
        private static string Query = @"Select R= 'T' 
from TestAppointments
inner Join LocalDrivingLicenseApplications on
LocalDrivingLicenseApplicationID = TestAppointments.TestAppointmentForLocalDrivingLicenseAppID
where TestAppointments.TestAppointmentID = @TestAppointmentID
and TestAppointments.IsLocked =1 -- Test Finished
and TestAppointments.AppointmentTestTypeID = @TestTypeID  -- Vision  ;";

        public static bool IsAppointmentLocked(int TestAppointmentID, int TestTypeID)
        {
            SqlConnection connection = dbSettings.DbConnection();
            bool res = false;
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(Query, connection);
                cmd.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
                cmd.Parameters.AddWithValue("@TestTypeID", TestTypeID);
                 
                object result = cmd.ExecuteScalar();
                if(result?.ToString() == "T")
                {
                    res = true;
                }
            }
            catch { }
            finally
            {
                connection.Close();
            }
            return res;
        }

    }
}
