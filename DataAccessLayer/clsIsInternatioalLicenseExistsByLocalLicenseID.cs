using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.Pkcs;
using System.Text;

namespace DataAccessLayer
{
    public static class clsIsInternatioalLicenseExistsByLocalLicenseID
    {
        private static string Query = @"Select R = 'T'     
from InternationalLicenses
where LicenseID = @LicenseID ;";

        public static bool IsExists(int LocalLicenseID)
        {
            bool exists = false;
            SqlConnection connection = dbSettings.DbConnection();
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(Query, connection);
                cmd.Parameters.AddWithValue("@LicenseID", LocalLicenseID);

                object R = cmd.ExecuteScalar();
                if(R is not null && R.ToString() == "T")
                {
                    exists = true;
                }
            }
            catch { }
            finally
            {
                connection.Close();
            }
            return exists;
        }

    }
}
