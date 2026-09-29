using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer
{
    public static class clsCheckIfThereIsLicenseOrNot
    {
        private static string Query = @"Select Licenses.LicenseID
From Licenses 
where Licenses.LicApplicationID = @ApplicationID  ";

        public static bool CheckIfThereIsLicenseOrNot(int LocalDrivingLicenseApplication)
        {
            bool Result = false;
            SqlConnection connection = dbSettings.DbConnection();
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(Query, connection);
                cmd.Parameters.AddWithValue("@ApplicationID", LocalDrivingLicenseApplication);

                object obj = cmd.ExecuteScalar();
                if(obj != null)
                {
                    Result = true;
                }

            }
            catch { }
            finally
            {
                connection.Close();
            }

            return Result;
        }

    }
}
