using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DataAccessLayer
{
    public static class clsGetDetainedLicenseByDetainID
    {
        private static string Query = @"
select * from DetainedLicenses
where DetainID = @DetainID;";

       public static DataTable GetDetainedLicenseByDetainID(int detainID)
        {
            SqlConnection connection = dbSettings.DbConnection();
            DataTable dt = new DataTable();
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(Query, connection);
                cmd.Parameters.AddWithValue("@DetainID", detainID);
                using (SqlDataReader R = cmd.ExecuteReader())
                {
                    if(R.HasRows)
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
