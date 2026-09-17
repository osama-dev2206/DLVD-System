using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer
{
    public static class clsUpdateUser
    {
        static string Query = @"
Update Users 
Set 
UserName = @UserName , Password= @Password , IsActive = @IsActive
where UserID =  @UserID ";

        public static bool UpdateUser(int UserID , string UserName , string Password , bool IsActive)
        {
            if (!int.TryParse(UserID.ToString(), out _) || string.IsNullOrEmpty(UserName) || string.IsNullOrEmpty(Password))   return false;

            SqlConnection connection = dbSettings.DbConnection();
            bool res = false;
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(Query, connection);
                command.Parameters.AddWithValue("@UserID", UserID);
                command.Parameters.AddWithValue("@UserName", UserName);
                command.Parameters.AddWithValue("@Password", Password);
                command.Parameters.AddWithValue("@IsActive", IsActive);

                int ? rowsAffected = command.ExecuteNonQuery();
                if(rowsAffected is not null && rowsAffected > 0)
                {
                    res = true;
                }

            }
            catch { }
            finally
            {
                connection.Close();
            }
          return res;
        }

    }
}
