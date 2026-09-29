using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer
{
    public static class clsAddNewLicense
    {
        private static string Query = @"

Insert Into Licenses
(
    LicApplicationID,
    LicDriverID,
    ClassOfLicenseID,
    IssueDate,
    ExpirationDate,
    Notes,
    PaidFees,
    IsActive,
    IssueReason,
    CreatedByUserID
)
values 
( @LicApplicationID , @LicDriverID , 
@ClassOfLicenseID ,  @IssueDate , 
 @ExpirationDate  ,  @Notes  ,  @PaidFees  , 
 @IsActive  ,   @IssueReason , @CreatedByUserID );
Select SCOPE_IDENTITY(); " ;

        public static int AddNewLicense(int ApplicationID, int DriverID, int LicenseClassID, DateOnly IssueDate, DateOnly ExpirationDate
            , string? Notes, decimal PaidFees, bool IsActive, byte IssueReason, int CreatedByUserID)
        {
            SqlConnection connection = dbSettings.DbConnection();
            int newLicenseID = -1;

            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(Query, connection);
                cmd.Parameters.AddWithValue("@LicApplicationID", ApplicationID);
                cmd.Parameters.AddWithValue("@LicDriverID", DriverID);
                cmd.Parameters.AddWithValue("@ClassOfLicenseID", LicenseClassID);
                cmd.Parameters.AddWithValue("@IssueDate", IssueDate);
                cmd.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
                
                if(String.IsNullOrEmpty(Notes))
                {
                    cmd.Parameters.AddWithValue("@Notes", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Notes", Notes);
                }

                cmd.Parameters.AddWithValue("@PaidFees", PaidFees);
                cmd.Parameters.AddWithValue("@IsActive", IsActive);
                cmd.Parameters.AddWithValue("@IssueReason", IssueReason);
                cmd.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

                object R = cmd.ExecuteScalar();
                if(R is not null && int.TryParse(R.ToString() , out int ID))
                {
                    newLicenseID = ID;
                }

            }
            catch { }
            finally
            {
                connection.Close();
            }
            return newLicenseID;
        }


    }
}
