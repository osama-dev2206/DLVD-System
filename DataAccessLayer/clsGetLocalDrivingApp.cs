using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Security.Cryptography.Pkcs;
using System.Text;

namespace DataAccessLayer
{
    public static class clsGetLocalDrivingApp
    {
        private static readonly string Query = @"Select * from LocalDrivingLicenseApplications where LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID";

        public static DataTable GetLocalDrivingApplicationByLocalDrivingLicenseApplication(int LocalDrivingLicenseApplicationID)
        {
            SqlConnection connection  = dbSettings.DbConnection();
            DataTable dt = new DataTable();
            try
            {
                using (connection)
                {
                    connection.Open();
                   using(SqlCommand command = new SqlCommand(Query, connection))
                    {
                        command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
                        SqlDataReader reader = command.ExecuteReader();
                        if(reader is not null && reader.HasRows)
                        {
                            dt.Load(reader);
                        }
                        reader?.Close();
                    }

                }


            }
            catch { }

            return dt;
        }

    }
}
