using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer
{
    public static class clsDeleteApplication
    {
        private static string Query = @"Delete Applications
where Applications.ApplicationID =@AppID ;";


        public static bool DeleteApplication(int ApplicationID)
        {
            SqlConnection connection = dbSettings.DbConnection();
            bool result = false;
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(Query, connection);
                command.Parameters.AddWithValue("@AppID", ApplicationID);
                int ? NoOFRowsAffected = command.ExecuteNonQuery();

                if(NoOFRowsAffected  is not null && NoOFRowsAffected > 0)
                {
                    result = true;
                }
            }
            catch{ }

            finally
            {
                connection.Close();
            }

            return result;
        }

    }
}
