using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer
{
    public static class clsCheckIfThePersonIsDriverOrNot
    {
        private static string Query = @"Select R = 'T'
from Drivers
Where Drivers.DriverPersonID = @PersonID;";

        public static bool CheckIfThePersonIsDriverOrNot(int PersonID)
        {
            bool Res = false;
            SqlConnection connection = dbSettings.DbConnection();
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(Query, connection);
                cmd.Parameters.AddWithValue("@PersonID", PersonID);

                object result = cmd.ExecuteScalar();
                if(result != null && result.ToString() == "T")
                {
                    Res = true;
                }

            }
            catch { }
            finally
            {
                connection.Close();
            }
            return Res;
        }

    }
}
