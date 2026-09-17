using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer
{
    public static class clsDeleteUser
    {
        static string Query = @"DELETE FROM Users WHERE UserID = @UserID and UserID <> 1 ;";

        public static bool DeleteUserByUserID(int UserID)
        {
            if (!int.TryParse(UserID.ToString(), out _)) return false;
            SqlConnection connection = dbSettings.DbConnection();
            bool isDeleted = false;
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(Query, connection);
                cmd.Parameters.AddWithValue("@UserID", UserID);

               int ? numOfAffectedRows =  cmd.ExecuteNonQuery();

                isDeleted = ( numOfAffectedRows > 0 && numOfAffectedRows is not null );

            }
            catch
            {
            
            }
            finally
            {
                connection.Close();
            }
            return isDeleted;
        }

    }
}
