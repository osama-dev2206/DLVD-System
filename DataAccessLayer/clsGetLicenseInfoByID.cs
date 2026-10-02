using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DataAccessLayer
{
    public static class clsGetLicenseInfoByID
    {
        private static string Query = @"
select * from Licenses
where Licenses.LicenseID =@LicenseID ;";

        public static DataTable GetLicenseByLicenseID(int LicenseID)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = dbSettings.DbConnection();
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(Query, connection);
                cmd.Parameters.AddWithValue("@LicenseID", LicenseID);

                using (SqlDataReader R = cmd.ExecuteReader())
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
