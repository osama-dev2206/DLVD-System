using Microsoft.Data.SqlClient;
using System;
using System.Data;

namespace DataAccessLayer
{
    public static class clsGetBPersonInfo
    {

        static string Query = @"select * from ShowBasicPersonInfo;";

        public static DataTable GetPeopleDataTable()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = dbSettings.DbConnection();
            try
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand(Query, connection);

                var Reader = cmd.ExecuteReader();

                if (Reader.HasRows) dt.Load(Reader);

                Reader.Close();
            }
            catch
            {
            }
            finally
            {
                connection.Close();
            }

            return dt;
        }


    }
}
