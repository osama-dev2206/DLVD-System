using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DataAccessLayer
{
    public static class clsGetDetailedAppInfoByApplicationID
    {

        private static string Query = @"Select * from DetailedApplicationInfo Where ApplicationID = @ApplicationID ";


        public static DataTable GetInfo(int ApplicationID)
        {
            SqlConnection connection = dbSettings.DbConnection();
            DataTable dt = new DataTable();
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(Query, connection);
                cmd.Parameters.AddWithValue("@ApplicationID", ApplicationID);

                using (SqlDataReader R = cmd.ExecuteReader())
                {
                    if (R is not null && R.HasRows)
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
