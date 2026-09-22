using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer
{
    public static class clsUpdateApplication
    {
        private static string Query = @"
Update Applications
Set 
ApplicationStatus = @ApplicationStatus ,
LastStatusDateTime = @LastStatusDateTime
where Applications.ApplicationID = @ApplicationID ; ";

        public static bool UpdateApplication(int ApplicationID, byte ApplicationStatus, DateTime LastStatusDateTime)
        {
            bool result = false;        
            SqlConnection connection = dbSettings.DbConnection();
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(Query, connection);
                cmd.Parameters.AddWithValue("@ApplicationID", ApplicationID);
                cmd.Parameters.AddWithValue("@ApplicationStatus", ApplicationStatus);
                cmd.Parameters.AddWithValue("@LastStatusDateTime", LastStatusDateTime);
                
                int ? NumOfAffectedRows = cmd.ExecuteNonQuery();

                if(NumOfAffectedRows is not null && NumOfAffectedRows > 0)
                {
                    result = true;
                }

            }
            catch { }
            finally
            {
                connection.Close();
            }
            return result;
        }

    }
}
