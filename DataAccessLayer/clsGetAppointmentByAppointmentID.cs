using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DataAccessLayer
{
    public class clsGetAppointmentByAppointmentID
    {
        private static string Query = @"
Select TestAppointments.* from TestAppointments  where TestAppointments.TestAppointmentID =  @TestAppointmentID ;";

        public static DataTable GetAppointmentByAppointmentID(int TestAppointmentID)
        {
            SqlConnection connection = dbSettings.DbConnection();
            DataTable  dt = new DataTable();
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(Query, connection);
                cmd.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);

                SqlDataReader  R = cmd.ExecuteReader();
                if(R is not null && R.HasRows)
                {
                    dt.Load(R);
                }
                R?.Close();

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
