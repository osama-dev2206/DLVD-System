using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DataAccessLayer
{
    public static class clsGetApplicationInfoByLocalLicenseAppID
    {
        private static string Query = @"Select * from DetailedApplicationInfo
where DetailedApplicationInfo.LocalDrivingLicenseApplicationID = @LocalLicenseApplicationID ;";


        public static DataTable GetInfo(int LocalLicenseApplicationID)
        {
            SqlConnection connection = dbSettings.DbConnection();
            DataTable dt = new DataTable();
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(Query, connection);
                cmd.Parameters.AddWithValue("@LocalLicenseApplicationID", LocalLicenseApplicationID);

                using (SqlDataReader r = cmd.ExecuteReader())
                {
                    if (r is not null && r.HasRows)
                        dt.Load(r);
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
