using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DataAccessLayer
{
    public static class clsGetBasicLocalLicenseApplicationInfo
    {
        private static string Query = @"Select * from ShowBasicInfoLocalDrivingLicense
where LocalDrivingLicenseApplicationID =@LocalDrivingLicenseApplicationID;";

        public static DataTable GetInfo(int LocalDrivingLicenseApplicationID)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = dbSettings.DbConnection();
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(Query, connection);
                command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
                using (SqlDataReader R = command.ExecuteReader())
                {
                    if (R is not null && R.HasRows)
                        dt.Load(R);
                }

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
