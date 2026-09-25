using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DataAccessLayer
{
    public static class clsGetAllTestAppointmentsForSpecificLocalDrivingLicenseAppID
    {
        private static string Query = @"Select TestAppointments.TestAppointmentID , TestAppointments.AppointmentDateTime ,
TestAppointments.PaidFees , TestAppointments.IsLocked 
from TestAppointments
Inner Join LocalDrivingLicenseApplications 
On LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = TestAppointments.TestAppointmentForLocalDrivingLicenseAppID
where TestAppointments.AppointmentTestTypeID = @TestTypeID
and LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = @LDLAppID ;"; // -- Vision Test Appointment

        public static DataTable GetAllVisionTestAppointments(int LocalDrivingLicenseApplicationID, int TestTypeID)
        {
            SqlConnection connection = dbSettings.DbConnection();
            DataTable dt = new DataTable();
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(Query, connection);
               cmd.Parameters.AddWithValue("@TestTypeID", TestTypeID);
                cmd.Parameters.AddWithValue("@LDLAppID", LocalDrivingLicenseApplicationID);
                SqlDataReader reader = cmd.ExecuteReader();

                if(reader is not null && reader.HasRows)
                {
                    dt.Load(reader);
                }

                reader?.Close(); 
            }
            catch { }
            finally
            {
                connection.Close();
            }
            return dt;
        }

        }

}
