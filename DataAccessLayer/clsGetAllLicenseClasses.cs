using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DataAccessLayer
{
    public static class clsGetAllLicenseClasses
    {
        private static string Query = @"Select * from LicenseClasses;";

        public static DataTable GetAllLicenseClasses()
        {
            SqlConnection connection = dbSettings.DbConnection();
            DataTable dt = new DataTable();

            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(Query, connection);
                SqlDataReader reader = cmd.ExecuteReader();

                if(reader is not null && reader.HasRows )
                    dt.Load(reader);

                reader?.Close();
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
