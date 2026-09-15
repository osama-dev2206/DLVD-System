using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DataAccessLayer
{
    public static class clsGetUserByUserName
    {
        static string Query = @"
Select * from Users
where Password = @Password   and  UserName =   @Username  ; ";      


        public static DataTable GetUserOnlyInfo(string UserName , string Password) // it doesn't cover the user personal info 
        {
            SqlConnection connection = dbSettings.DbConnection();
            DataTable dt = new DataTable();
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(Query, connection);
                command.Parameters.AddWithValue("@Username", UserName);
                command.Parameters.AddWithValue("@Password", Password);


                SqlDataReader reader = command.ExecuteReader();

                if(reader is not null && reader.HasRows)
                {
                    dt.Load(reader);
                }

            }
            catch { }
            finally
            {
                connection.Close();
            }

                return dt;
            }




    }
}
