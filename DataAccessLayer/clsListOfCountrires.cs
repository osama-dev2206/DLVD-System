using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DataAccessLayer
{
    public static class clsListOfCountrires
    {
        static string Query = @"Select Countries.CountryName 
            From Countries;";

        public static DataTable GetAllCountries()
        {
            DataTable dt = new DataTable();
            SqlConnection connection  = dbSettings.DbConnection();
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(Query, connection);
            SqlDataReader reader =  cmd.ExecuteReader();
                if(reader.HasRows && reader is not null )
                {
                    dt.Load(reader);
                }
                reader?.Close();
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
