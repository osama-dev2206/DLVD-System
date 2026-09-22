using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DataAccessLayer
{
    public static class clsGetApplicationByAppID
    {
        private static string Query = @"select * from Applications
where ApplicationID = @ApplicationID ;";

        public static DataTable GetApplication(int ApplicationID)
        { 
            SqlConnection connection = dbSettings.DbConnection();
            DataTable dt = new DataTable();

            try
            {
                using (connection)
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(Query, connection);
                    using (cmd)
                    {
                        cmd.Parameters.AddWithValue("@ApplicationID", ApplicationID);
                        SqlDataReader reader = cmd.ExecuteReader();
                        if(reader is not null && reader.HasRows)
                        {
                            dt.Load(reader);
                        }

                        reader?.Close();

                    }
                }
            }
            catch { }
 
            return dt;
        }

    }
}
