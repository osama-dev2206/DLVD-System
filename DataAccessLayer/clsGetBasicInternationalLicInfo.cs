using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DataAccessLayer
{
    public static class clsGetBasicInternationalLicInfo
    {
        private static string Query = @"Select * from InternationalLicenses
where LicenseID = @LicenseID ;";

        public static DataTable GetInfo(int LocalLicenseID)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = dbSettings.DbConnection();
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(Query, connection);
                cmd.Parameters.AddWithValue("@LicenseID", LocalLicenseID);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader != null && reader.HasRows)
                        dt.Load(reader);
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
