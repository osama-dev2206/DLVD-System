using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DataAccessLayer
{
    public static class clsFindDetainedLicenseByLicneseID
    {
        private static string Query = @"-- if it isnot released yet then it is still detained you cannot add another detain for the same license
select * from DetainedLicenses
where ISReleased =0  and DLicenseID = @LicenseID;";


        public static DataTable GetDetainedLicense(int LicenseID)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = dbSettings.DbConnection();
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(Query, connection);
                cmd.Parameters.AddWithValue("@LicenseID", LicenseID);

                using(SqlDataReader R = cmd.ExecuteReader())
                {
                    if(R.HasRows)
                    {
                        dt.Load(R);
                    }
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
