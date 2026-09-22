using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer
{
    public static class clsGetLicenseClassIDByItsName
    {
        static string Query = @"Select * from LicenseClasses
where ClassName =  @ClassName  ";

        public static int GetLicenseClassIDByItsName(string ClassName)
        {
            SqlConnection connection = dbSettings.DbConnection();
            int LicenseClassID = -1;
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(Query, connection);
                command.Parameters.AddWithValue("@ClassName", ClassName);
                
                object result = command.ExecuteScalar();
                if(result is not null && int .TryParse(result.ToString(), out int id))
                {
                    LicenseClassID = id;
                }
            }
            catch { }
            finally
            {
                connection.Close();
            }

            return LicenseClassID;
        }

    }
}
