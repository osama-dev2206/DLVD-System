using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer
{
    public static class clsUpdateTestType
    {
        static string Query = @"Update TestTypes 
Set TestTypeTitle = @TestTypeTitle  ,
TestTypeDescription = @TestTypeDescription ,
TestTypeFees = @TestTypeFees
where TestTypeID = @ID ;";

        public static bool UpdateTestType(int TestTypeID, string TestTypeTitle, string TestTypeDescription, decimal TestTypeFees)
        {
            SqlConnection connection = dbSettings.DbConnection();
            bool res = false;
            try 
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(Query,connection);
                cmd.Parameters.AddWithValue("@TestTypeTitle", TestTypeTitle);
                cmd.Parameters.AddWithValue("@TestTypeDescription", TestTypeDescription);
                cmd.Parameters.AddWithValue("@TestTypeFees", TestTypeFees);
                cmd.Parameters.AddWithValue("@ID", TestTypeID);

                int ? NumOfAffectedRows = cmd.ExecuteNonQuery();
                if (NumOfAffectedRows is not null && NumOfAffectedRows > 0)
                    res = true;
            }
            catch
            { }
            finally
            {
                connection.Close();
            }
            return res; 
        }

    }
}
