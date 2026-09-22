using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer
{
    public static class clsIsPersonHasRegisteredBeforeInApplication
    {
        private static string Query = @"Select ApplicationID
From Applications
where
Applications.ApplicationTypeID = @AppTypeID
and
Applications.ApplicationStatus = 1 -- New (check on db)
and 
Applications.ApplicantPersonID = @PersonID ;";

        public static int IsPersonHasRegisteredBefore(int PersonID, int AppTypeID)
        {
            SqlConnection connection = dbSettings.DbConnection();
            int Result = -1;
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(Query, connection);
                cmd.Parameters.AddWithValue("@PersonID", PersonID);
                cmd.Parameters.AddWithValue("@AppTypeID", AppTypeID);

                object queryResult = cmd.ExecuteScalar();

                if(queryResult != null && int.TryParse(queryResult.ToString() , out int ID) )
                {
                    Result = ID;
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
