using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DataAccessLayer
{
    public static class clsFindTestType
    {
        private static string Query = @"Select * from TestTypes
where TestTypeID =@ID ;";

        public static DataTable FindTestType(int TestTypeID)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = dbSettings.DbConnection();
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(Query, connection);
                cmd.Parameters.AddWithValue("@ID", TestTypeID);

                var Reader = cmd.ExecuteReader();
                if(Reader is not null && Reader.HasRows)
                dt.Load(Reader);

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
