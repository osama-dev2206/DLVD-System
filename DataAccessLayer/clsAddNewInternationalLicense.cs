using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer
{
    public static class clsAddNewInternationalLicense
    {
        private static string Query = @"Insert Into InternationalLicenses
(
 IssueDateTime ,
 ExpirationDate ,
 IsActive , 
 UserID , 
 DriverID , 
 LicenseID , 
 ApplicationID
)
values
(
 @IssueDateTime , @ExpirationDate , 
 @IsActive , @UserID , @DriverID , @LicenseID , @ApplicationID
);
Select SCOPE_IDENTITY()  ; "; 

        public static int AddNewInternationalLicense(DateTime IssueDateTime, DateOnly ExpirationDate, bool IsActive, int UserID, int DriverID, int LicenseID, int ApplicationID)
        {
            SqlConnection connection = dbSettings.DbConnection();
            int NewID = -1;
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(Query, connection);
                 cmd.Parameters.AddWithValue("@IssueDateTime", IssueDateTime);
                cmd.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
                cmd.Parameters.AddWithValue("@IsActive", IsActive);
                cmd.Parameters.AddWithValue("@UserID", UserID);
                cmd.Parameters.AddWithValue("@DriverID", DriverID);
                cmd.Parameters.AddWithValue("@LicenseID", LicenseID);
                cmd.Parameters.AddWithValue("@ApplicationID", ApplicationID);

                object R = cmd.ExecuteScalar();
                if(R!=null && int.TryParse(R.ToString(), out int ID))
                {
                    NewID = ID;
                }
            }
            catch {   }
            finally
            {
                connection.Close();
            }
            return NewID;
        }


    }
}
