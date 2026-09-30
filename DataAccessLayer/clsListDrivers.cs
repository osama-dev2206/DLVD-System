using DataAccessLayer;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace BussinessLogicLayer
{
    public static class clsListDrivers
    {
        private static string Query = @"Select * from Drivers";

        public static DataTable ListAllDrivers()
        {
            SqlConnection connection = dbSettings.DbConnection();
            DataTable dt = new DataTable();
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(Query, connection);

                using(SqlDataReader R = cmd.ExecuteReader())
                {
                    if(R is not null  && R.HasRows)
                        dt.Load(R);
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
