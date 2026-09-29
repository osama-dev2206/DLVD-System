using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DataAccessLayer
{
    public static class clsGetDriverLicenseInfo
    {
        private static string Query = @"Select * from DriverLicenseInfo
where ApplicationID = @ApplicationID ;";

        public static DataTable GetDriverLicenseInfoByApplicationID(int ApplicationID)
        {
          DataTable dt = new DataTable();
            SqlConnection connection = dbSettings.DbConnection();
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(Query, connection);
                cmd.Parameters.AddWithValue("@ApplicationID", ApplicationID);   

                using ( SqlDataReader R = cmd.ExecuteReader())
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
