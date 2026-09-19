using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DataAccessLayer
{
    public static class clsFindAppTypeByAppID
    {
        static string Query = @"select * from ApplicationTypes
where ApplicationTypeID = @AppID ;";

        public static DataTable GetAppByAppID(int AppID)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = dbSettings.DbConnection();
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(Query, connection);
                cmd.Parameters.AddWithValue("@AppID", AppID);

                var res = cmd.ExecuteReader();
                if(res is not null && res.HasRows)
                {
                    dt.Load(res);
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
