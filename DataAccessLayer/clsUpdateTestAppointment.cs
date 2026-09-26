using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer
{
    public static class clsUpdateTestAppointment
    {
        private static string Query = @"
Update TestAppointments Set AppointmentDateTime
= @AppointmentDateTime 
where TestAppointments.TestAppointmentID = @TestAppointmentID ;";

      public static bool UpdateTestAppointmentDateTime(int TestAppointmentID, DateTime AppointmentDateTime)
        {
            SqlConnection connection = dbSettings.DbConnection();
            bool result = false;
            try
            {
                SqlCommand command = new SqlCommand(Query, connection);
                command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
                command.Parameters.AddWithValue("@AppointmentDateTime", AppointmentDateTime);

                int ? rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected is not null && rowsAffected > 0)
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
