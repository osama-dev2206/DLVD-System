using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer
{
    public static class clsAddNewTest
    {
        private static string Query = @"Insert Into Test(AppointmentOfTestID,TestResult,Notes,CreatedByUserID)
values ( @TestAppointmentID  ,  @TestResult   ,   @Notes  ,  @CreatedByUserID );
SELECT SCOPE_IDENTITY();";


        public static int AddNewTest(int AppointmentIDOfTest, int TestResult, string? Notes, int CreatedByUserID)
        {
            int newTestID = -1; // Default value indicating failure
            SqlConnection connection = dbSettings.DbConnection();
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(Query, connection);
                cmd.Parameters.AddWithValue("@TestAppointmentID", AppointmentIDOfTest);
                cmd.Parameters.AddWithValue("@TestResult", TestResult);
                if (String.IsNullOrEmpty(Notes))
                {
                    cmd.Parameters.AddWithValue("@Notes", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Notes", Notes);
                }

                cmd.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
                object Result = cmd.ExecuteScalar();
                   
                if(Result is not null && int.TryParse(Result.ToString(), out int TestID))
                {
                     newTestID=TestID;
                }
            }
            catch
            {

            }
            finally
            {
                connection.Close();
            }

            return newTestID;


        }
    }


}
