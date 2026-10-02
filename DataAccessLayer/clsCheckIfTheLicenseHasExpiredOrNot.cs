using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer
{
    public static class clsCheckIfTheLicenseHasExpiredOrNot
    {
        private static string Query = @"Select R = 'T'
from Licenses
where Licenses.ExpirationDate >  CAST ( GETDATE() as Date )
and Licenses.LicenseID = @LicenseID  ; ";

        public static bool CheckIfTheLicenseHasExpiredOrNot(int LicenseID)
        {
            SqlConnection connection = dbSettings.DbConnection();
            bool Res = false;
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(Query, connection);
                command.Parameters.AddWithValue("@LicenseID", LicenseID);

                object result = command.ExecuteScalar();

                if(result?.ToString() == "T")
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
