using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer
{
    public static class clsCheckLicenseExistense
    {
        private static string Query = @"Select R = 'T'
from Licenses
Inner join Applications on Applications.ApplicationID = Licenses.LicApplicationID
where Applications.ApplicantPersonID = @PersonID
and Licenses.IsActive = 1 
and ClassOfLicenseID = @LicenseClassID    ;";

        public static bool CheckIfPersonHasActiveLicenseOfClass(int PersonID, int LicenseClassID)
        {
           bool result = false;
            SqlConnection connection = dbSettings.DbConnection();
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(Query, connection);
                cmd.Parameters.AddWithValue("@PersonID", PersonID);
                cmd.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);

                object R = cmd.ExecuteScalar();

                if(R is not null && R.ToString() == "T")
                {
                    result = true;
                }

            }
            catch 
            { }
            finally
            {
                connection.Close();
            }
            return result;
        }


    }
}
