using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer
{
    public static class clsCheckIfThereIsOpenAppointmentBefore // if the pervious is locked you can add new 
    {
        private static string Query = @"
Select top 1  R = 'T'
from TestAppointments 
where TestAppointments.TestAppointmentForLocalDrivingLicenseAppID = @LocalDrivingLicenseApplicationID
and TestAppointments.AppointmentTestTypeID = @TestTypeID
and TestAppointments.IsLocked = 1 -- Test Finished
order by TestAppointmentID DESC ;
;";

        public static bool CheckIfThereIsRetakeApplicationBefore(int LocalDrivingLicenseApplicationID, int TestTypeID)
        {
            SqlConnection connection = dbSettings.DbConnection();
            bool result = false;
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(Query, connection);
                cmd.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
                cmd.Parameters.AddWithValue("@TestTypeID", TestTypeID);

                object retakeApplicationID = cmd.ExecuteScalar();
                if(retakeApplicationID != null && retakeApplicationID != DBNull.Value)
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
