using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer
{
    public static class clsCheckIfThereIsRetakeApplicationBefore
    {
        private static string Query = @"Select top 1 TestAppointments.RetakeApplicationID
from TestAppointments 
where TestAppointmentForLocalDrivingLicenseAppID = @LocalDrivingLicenseApplicationID
and AppointmentTestTypeID =@TestTypeID -- Vision 
and TestAppointments.IsLocked =0 -- Hasnot Finished
order by TestAppointmentID desc; ";

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
