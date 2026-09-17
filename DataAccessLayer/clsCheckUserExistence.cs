using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer
{
    public static class clsCheckUserExistence
    {
        enum enCheckType : SByte
        {
            Username, PersonID 
        }

        static string CheckQuery(enCheckType checkType)
        {
            switch(checkType)
            {
                case enCheckType.Username:
                    return @"
               Select R = 'T'
            from Users
             where Users.UserName = @Username ;";

                    case enCheckType.PersonID:
                    return @"
               Select R = 'T'
            from Users
             where UserPersonID = @PersonID ;";

            }

            return string.Empty;
        }


        public static bool IsUserNameExist(string Username)
        {
            SqlConnection connection = dbSettings.DbConnection();
            bool res = false;
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(CheckQuery(enCheckType.Username), connection);
                command.Parameters.AddWithValue("@Username", Username);
                object result = command.ExecuteScalar();    

                if(result is not null && result.ToString() == "T")
                {
                    res = true;
                }

            }
            catch 
            {
            }
            finally
            {
                connection.Close();
            }

            return res;
        }

        public static bool IsPersonIsAUser(int PersonID)
        {
            SqlConnection connection = dbSettings.DbConnection();
            bool res = false;
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(CheckQuery(enCheckType.PersonID), connection);
                command.Parameters.AddWithValue("@PersonID", PersonID);
                object result = command.ExecuteScalar();

                if (result is not null && result.ToString() == "T")
                {
                    res = true;
                }
            }
            catch
            {
            }
            finally
            {
                connection.Close();
            }
            return res;
        }


    }
}
