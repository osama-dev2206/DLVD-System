using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer
{
    public static class clsAddNewDriver
    {
        private static string Query = @"Insert Into Drivers(DriverPersonID,CreatedByUserID,CreateDate)
values (   @PersonID   ,   @CreatedByUserID  ,  @CreateDate );
Select SCOPE_IDENTITY(); ";

        public static int AddNewDriver(int PersonID, int CreatedByUserID, DateOnly CreateDate)
        {
          SqlConnection connection = dbSettings.DbConnection();  
            int newDriverID = 0;
            try
            {
                connection.Open();  
                SqlCommand  cmd = new SqlCommand(Query, connection);
                cmd.Parameters.AddWithValue("@PersonID", PersonID);
                cmd.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
                cmd.Parameters.AddWithValue("@CreateDate", CreateDate);

                object ExecuteScalarResult = cmd.ExecuteScalar();
                if(ExecuteScalarResult is not null && int.TryParse(ExecuteScalarResult.ToString() , out int ID))
                {
                    newDriverID = ID;
                }

            }
            catch { }
            finally
            {
                    connection.Close();
            }
            return newDriverID;
        }

    }
}
