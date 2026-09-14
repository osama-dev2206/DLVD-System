using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer
{
    public static class clsCheckNationalNumExistence
    {
        static string query = @"select R='T'
from People
where People.NationalNumber = @NationalNum;";

        public static bool IsNationalNumExist(string nationalNum)
        {
            SqlConnection connection = dbSettings.DbConnection();
            bool res = false;
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@NationalNum", nationalNum);
                object result = cmd.ExecuteScalar();
                if (result is not null && result?.ToString() == "T") 
                {
                    res = true; 
                }
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
