using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer
{
    public static class clsIsLicenseDetained
    {
        private static string Query = @"Select R = 'T'
from DetainedLicenses
where DetainedLicenses.DLicenseID = @LicenseID
and 
DetainedLicenses.ISReleased = 0;";

        public static bool IsLicenseDetained(int LicenseID)
        {
            SqlConnection connection = dbSettings.DbConnection();
            bool Res = false;
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(Query, connection);
                cmd.Parameters.AddWithValue("@LicenseID", LicenseID);

                object R = cmd.ExecuteScalar();
                if(R?.ToString() == "T")
                {
                    Res = true;
                }
            }
            catch { }
            finally
            {
                connection.Close();
            }
            return Res;
        }

    }
}
