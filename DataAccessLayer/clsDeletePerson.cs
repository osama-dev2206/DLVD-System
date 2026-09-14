using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer
{
    public static class clsDeletePerson
    {
        static string query = @"Delete People
Where People.PersonID = @PersonID; ";

        public static bool DeletePerson(int PersonID)
        {
            SqlConnection connection = dbSettings.DbConnection();
            bool result = false;
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@PersonID",PersonID);
                int ? NumOfAffectedRows = cmd.ExecuteNonQuery();

               if(NumOfAffectedRows>0)
                    result = true;
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
