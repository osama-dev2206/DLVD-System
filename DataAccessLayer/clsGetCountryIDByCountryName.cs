using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer
{
    public static class clsGetCountryIDByCountryName
    {
        static string Query = @"
Select Countries.CountryID 
From Countries
where Countries.CountryName = @Name;";

        public static int ? GetCountryID(string CountyName)
        {
            int ? CountryID = -1;
            SqlConnection connection = dbSettings.DbConnection();
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(Query, connection);
                cmd.Parameters.AddWithValue(CountyName, "@Name");

               if (int.TryParse(cmd.ExecuteScalar().ToString() , out int id))
                  CountryID = id;
            }
            catch { }
            finally
            {

            }
            return CountryID;
        }

    }
}
