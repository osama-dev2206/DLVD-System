using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DataAccessLayer
{
    public static class clsGetAllUsers
    {
        static string Query = @"SELECT UserID , UserPersonID ,
CONCAT(People.FirstName , ' ' , People.SecondName , ' ' , People.ThirdName , ' ' , People.LastName) As FullName
, UserName , IsActive 
FROM Users
Inner Join People On People.PersonID = Users.UserPersonID;";

        public static DataTable GetAllUsers()
        {
            SqlConnection connection = dbSettings.DbConnection();
            DataTable dt = new DataTable();

            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(Query, connection);
                
                SqlDataReader r = cmd.ExecuteReader();
                
                if(r is not null && r.HasRows)
                {
                    dt.Load(r);
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
