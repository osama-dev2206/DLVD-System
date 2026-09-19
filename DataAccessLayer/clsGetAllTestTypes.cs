using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DataAccessLayer
{
    public class clsGetAllTestTypes
    {
        static string Query = @"SELECT * FROM TestTypes";

        public static DataTable GetAllTestTypes()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = dbSettings.DbConnection();
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(Query, connection);
                SqlDataReader reader = cmd.ExecuteReader();

                if(reader is not null && reader.HasRows)
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
