using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DataAccessLayer
{
    public static class clsFindDriverByPersonID
    {
        private static string Query = @"Select *
from Drivers
Where Drivers.DriverPersonID = @DriverPersonID ;";

        public static DataTable FindDriverByPersonID(int DriverPersonID)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = dbSettings.DbConnection();
            try 
            { 
                connection.Open();
                SqlCommand cmd = new SqlCommand(Query, connection);
                cmd.Parameters.AddWithValue("@DriverPersonID", DriverPersonID);

                using (SqlDataReader r = cmd.ExecuteReader())
                {
                    if(r is not null && r.HasRows)
                    {
                        dt.Load(r);
                    }
                }

            }
            catch
            {

            }
            finally
            {
                connection.Close();
            }
            return dt;
        }

    }
}
