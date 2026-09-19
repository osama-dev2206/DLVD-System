using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DataAccessLayer
{
    public static class clsGetAllAppTypes
    {
        private static string Query = @"select * from ApplicationTypes;";

        public static DataTable GetAllAppTypes()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = dbSettings.DbConnection();
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(Query, connection);
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
