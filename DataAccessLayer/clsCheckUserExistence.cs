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
            Username,
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




    }
}
