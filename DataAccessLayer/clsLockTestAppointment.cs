using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer
{
    public static class clsLockTestAppointment
    {
        private static string query = @"Update TestAppointments
set IsLocked = 1
where TestAppointments.TestAppointmentID = @TestAppointmentID
and TestAppointments.AppointmentTestTypeID = @TestTypeID ;";


        public static bool LockTestAppointment(int TestAppointmentID , int TestTypeID)
        {
            SqlConnection connection = dbSettings.DbConnection();
            bool res = false;
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
                command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
                int numberOfRowsAffected = command.ExecuteNonQuery();
                if(numberOfRowsAffected>0) res = true;
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
