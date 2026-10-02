using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DataAccessLayer
{
    public static class clsGetLicenseByPersonID
    {
        private static string Query = @"select * from Licenses
Inner Join Applications On Applications.ApplicationID = Licenses.LicApplicationID

Where Applications.ApplicantPersonID = @PersonID
and Licenses.ClassOfLicenseID =@LicenseClassID  ;";

        public static DataTable GetData(int PersonID, int LicenseClassID)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = dbSettings.DbConnection();
            try
            {
                connection.Open();  
                SqlCommand cmd = new SqlCommand(Query, connection); 
                cmd.Parameters.AddWithValue("@PersonID", PersonID);
                cmd.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);

                using (SqlDataReader R = cmd.ExecuteReader())
                {
                  if(R is not null && R.HasRows)  dt.Load(R);
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
