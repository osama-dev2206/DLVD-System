using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer
{
    public static class clsAddNewDetainedLicense
    {
        private static string Query = @"-- Detain Only Now 
Insert Into DetainedLicenses
( DLicenseID , DetainDateTime , FineFees , ISReleased , CreatedByUserID )
values ( @DLicenseID , @DetainDateTime , @FineFees , @ISReleased , @CreatedByUserID );
Select Scope_Identity();";

        public static int AddNewLicenseToDetainedLicenses(int LicenseID, DateTime DetainDT, decimal FineFees, int CreatedByUserID,bool IsReleased = false)
        {
            SqlConnection connection = dbSettings.DbConnection();
            int NewInsertedRowID = -1;
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(Query, connection);
                cmd.Parameters.AddWithValue("@DLicenseID", LicenseID);
                cmd.Parameters.AddWithValue("@DetainDateTime", DetainDT);
                cmd.Parameters.AddWithValue("@FineFees", FineFees);
                cmd.Parameters.AddWithValue("@ISReleased", IsReleased);
                cmd.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
                object R = cmd.ExecuteScalar();

                if(int.TryParse(R?.ToString() , out int id))
                {
                    NewInsertedRowID = id; 
                }

            }
            catch { }
            finally
            {
                connection.Close();
            }
            return NewInsertedRowID;
        }


    }


}
