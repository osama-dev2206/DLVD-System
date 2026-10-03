using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer
{
    public static class clsCheckIfThePersonHasInternationalLicenseOrNot
    {
        private static string Query = @"Select R = 'T'
from InternationalLicenses
Inner Join Licenses on Licenses.LicenseID = InternationalLicenses.LicenseID
Inner Join Applications On Applications.ApplicationID = Licenses.LicApplicationID
where Applications.ApplicantPersonID =  @PersonID 
and InternationalLicenses.IsActive =1  ;";

        public static bool CheckIfThePersonHasInternationalLicenseOrNot(int PersonID)
        {
            bool Res = false;
            SqlConnection connection = dbSettings.DbConnection();
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(Query, connection);
                cmd.Parameters.AddWithValue("@PersonID", PersonID);

                object R = cmd.ExecuteScalar();
                if(R != null && R.ToString() == "T")
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
