using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer
{
    public static class clsGetPersonImagePathOnly
    {
        static string query = @"select People.ImagePath
from People
where People.PersonID = @PersonID ";

        public static string ? GetPersonImagePath(int PersonID)
        {
            SqlConnection connection = dbSettings.DbConnection();
            string ?res= null;
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@PersonID", PersonID);
                object reader = cmd.ExecuteScalar();
                res = reader.ToString();
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
