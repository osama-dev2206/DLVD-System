using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer
{
    public static class clsGetTestResultByTestAppointmentID
    {
        private static string Query = @"-- Get Test Result For Specific Test Appointment ID
Select top 1 Test.TestResult
from Test
Inner Join TestAppointments On TestAppointments.TestAppointmentID = Test.AppointmentOfTestID
where TestAppointments.TestAppointmentID = @TestAppointmentID -- Specific TestAppointment ID";

        public static bool? GetTestResultByTestAppointmentID(int TestAppointmentID)
        {
            SqlConnection connection = dbSettings.DbConnection();
            bool? result = null;
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(Query, connection);
                cmd.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
                object res = cmd.ExecuteScalar();
                if(res != null && int.TryParse(res.ToString() , out int TestRes))
                {
                    if (TestRes == 1) result = true; // pass
                    else if (TestRes == 0) result = false; // fail
                    else  result = null;
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
