using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DataAccessLayer
{
    public static class clsGetAllDetainedILic
    {
        private static string Query = @"select * from DetailedDetainInfo;";

        public static DataTable GetAllDetainedLicenses()
        {
            SqlConnection connection = dbSettings.DbConnection();
            DataTable dt = new DataTable();
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(Query, connection);
                using (SqlDataReader R = command.ExecuteReader())
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
