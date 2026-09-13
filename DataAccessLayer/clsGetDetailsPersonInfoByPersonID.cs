using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DataAccessLayer
{
    public static class clsGetDetailsPersonInfoByPersonID
    {
        static string Query = @"Select * from DetailedPersonInfo where PersonID = @PersonID ; ";

        public static DataTable GetFullPersonByPersonID(int personID)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = dbSettings.DbConnection();
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(Query, connection);
                command.Parameters.AddWithValue("@PersonID", personID);
                SqlDataReader reader = command.ExecuteReader();
                
                if(reader.HasRows)
                {
                    dt.Load(reader);
                }

                reader.Close();
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
