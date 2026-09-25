using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DataAccessLayer
{
    public static class clsGetAllVisionTestAppointments
    {
        private static string Query = @"Select TestAppointments.TestAppointmentID , TestAppointments.AppointmentDateTime ,
TestAppointments.PaidFees , TestAppointments.IsLocked 
from TestAppointments
where TestAppointments.TestAppointmentID = 1 ;"; // -- Vision Test Appointment

        public static DataTable GetAllVisionTestAppointments()
        {
            SqlConnection connection = dbSettings.DbConnection();
            DataTable dt = new DataTable();
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(Query, connection);
               
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
