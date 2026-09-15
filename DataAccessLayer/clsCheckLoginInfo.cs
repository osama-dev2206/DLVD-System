using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer
{
    public static class clsCheckLoginInfo
    {
        static string Query = @"Select R = 'T'
from Users
where Users.Password = @Password  and  Users.UserName = @Username ;";

        public static bool IsLoginInfoValid(string Username, string Password)
        {
            if (String.IsNullOrEmpty(Username) || string.IsNullOrEmpty(Password)) return false; 
            bool res = false;

            SqlConnection connection = dbSettings.DbConnection();
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(Query, connection);
                command.Parameters.AddWithValue("@Username", Username);
                command.Parameters.AddWithValue("@Password", Password);

                object result = command.ExecuteScalar();

                if(result is not null && result.ToString() == "T")
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
