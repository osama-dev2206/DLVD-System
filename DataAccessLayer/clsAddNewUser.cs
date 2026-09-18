using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer
{
    public static class clsAddNewUser
    {
        private static string Query = @"
Insert Into Users (UserPersonID,UserName,Password,IsActive)
values 
( @PersonID , @UserName , @Password ,  @IsActive );
Select  SCOPE_IDENTITY() ";

        public static int AddNewUser(int PersonID, string UserName, string Password, bool IsActive)
        {
            SqlConnection connection = dbSettings.DbConnection();
             int newUserId = 0;
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(Query, connection);
                command.Parameters.AddWithValue("@PersonID", PersonID);
                command.Parameters.AddWithValue("@UserName", UserName);
                command.Parameters.AddWithValue("@Password", Password);
                command.Parameters.AddWithValue("@IsActive", IsActive);

                object result = command.ExecuteScalar();
                if(result is not null && int.TryParse(result.ToString(),out int ID))
                {
                    newUserId = ID;
                }

            }
            catch { }
            finally
            {
                connection.Close();
            }

            return newUserId;
        }

    }
}
