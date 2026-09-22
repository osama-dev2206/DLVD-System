using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer
{
    public static class clsIsPersonHasRegisteredBefore
    {
        private static string Query = @"Select R = 'T' 
From Applications
where
Applications.ApplicationTypeID = @AppTypeID
and
Applications.ApplicationStatus = 1 -- New (check on db)
and 
Applications.ApplicantPersonID = @PersonID ;";

        public static bool IsPersonHasRegisteredBefore(int PersonID, byte AppTypeID)
        {
            SqlConnection connection = dbSettings.DbConnection();
            bool Result = false;
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(Query, connection);
                cmd.Parameters.AddWithValue("@PersonID", PersonID);
                cmd.Parameters.AddWithValue("@AppTypeID", AppTypeID);

                object queryResult = cmd.ExecuteScalar();

                if(queryResult != null && queryResult.ToString() == "T")
                {
                    Result = true;
                }

            }
            catch { }
            finally
            {
                connection.Close();
            }

            return Result;
        }
        

    }
}
