using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer
{
    public static class clsIsPersonHasRegisteredBeforeInApplication
    {
        private static string Query = @"Select LApplicationID
From LocalDrivingLicenseApplications as Local
Inner Join Applications  as app
On app.ApplicationID = local.LApplicationID
where
App.ApplicationStatus = 1 -- New (check on db)
and 
App.ApplicantPersonID =@PersonID  -- related to the same person 
and 
Local.LLicenseClassID = @LicenseClassID ;";

        public static int IsPersonHasRegisteredBefore(int PersonID, int LicenseClassID  )
        {
            SqlConnection connection = dbSettings.DbConnection();
            int Result = -1;
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(Query, connection);
                cmd.Parameters.AddWithValue("@PersonID", PersonID);
                cmd.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);

                object queryResult = cmd.ExecuteScalar();

                if(int.TryParse(queryResult?.ToString() , out int ID ) )
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
