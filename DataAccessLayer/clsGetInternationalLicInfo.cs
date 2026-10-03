using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DataAccessLayer
{
    public static class clsGetInternationalLicInfo
    {
        private static string Query = @"select * from ShowInternationalLicensesInfo
where LicenseID = @LicenseID  ;";

        public static DataTable GetInternationalLicenseInfoByLicenseID(int LicenseID)
        {
             SqlConnection connection = dbSettings.DbConnection();
            DataTable dt = new DataTable();

            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(Query, connection);
                cmd.Parameters.AddWithValue("@LicenseID", LicenseID);

                using(SqlDataReader R = cmd.ExecuteReader())
                {
                    if(R is not null && R.HasRows)
                    dt.Load(R);
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
