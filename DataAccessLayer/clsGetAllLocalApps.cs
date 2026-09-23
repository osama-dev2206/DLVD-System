using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection.PortableExecutable;
using System.Text;

namespace DataAccessLayer
{
    public static class clsGetAllLocalApps
    {
        private static string Query = @" select * from LocalDrivingLicenseApplicationsView;";


        public static DataTable GetAllLocalDrivingLicenseApplications()
        {
            var connection = dbSettings.DbConnection();   
            DataTable dt = new DataTable();
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(Query, connection);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if(reader is not null && reader.HasRows)
                    {
                        dt.Load(reader);
                    }
                }

            }
            catch { }
            finally
            {
                connection?.Close();
            }
            return dt;
        }

    }
}
