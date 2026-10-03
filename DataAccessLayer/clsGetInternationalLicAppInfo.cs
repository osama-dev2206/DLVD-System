using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DataAccessLayer
{
    public static class clsGetInternationalLicAppInfo
    {
        private static string Query = @"Select * 
From InternationalAppInfo
where LicenseID =  @LicenseID";

        public static DataTable GetInfo(int LicenseID)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = dbSettings.DbConnection();
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(Query, connection);
                cmd.Parameters.AddWithValue("@LicenseID", LicenseID);

                using(SqlDataReader reader = cmd.ExecuteReader())
                {
                    if(reader is not null && reader.HasRows)
                    dt.Load(reader);
                }
            }
            catch
            {
            }
            finally
            {
                connection.Close();

            }
            return dt;
        }

    }
}
