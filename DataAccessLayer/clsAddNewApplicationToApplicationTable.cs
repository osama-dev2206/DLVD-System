using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer
{
    public static class clsAddNewApplicationToApplicationTable
    {
        private static string Query = @"INSERT INTO Applications
(
    ApplicantPersonID,
    ApplicationDateTime,
    ApplicationTypeID,
    ApplicationStatus,
    LastStatusDateTime,
    PaidFees,
    CreatedByUserID
)
VALUES
(
    @ApplicantPersonID,
    @ApplicationDateTime,
    @ApplicationTypeID,
    @ApplicationStatus,
    @LastStatusDateTime,
    @PaidFees,
    @CreatedByUserID
);
Select SCOPE_IDENTITY(); ";


        public static int AddNewApplication(int ApplicantPersonID, DateTime ApplicationDateTime, int ApplicationTypeID, byte ApplicationStatus, DateTime LastStatusDateTime, decimal PaidFees, int CreatedByUserID)
        {
            SqlConnection connection = dbSettings.DbConnection();
            int newApplicationID = -1;
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(Query, connection);
                command.Parameters.AddWithValue("@ApplicantPersonID", ApplicantPersonID);
                command.Parameters.AddWithValue("@ApplicationDateTime", ApplicationDateTime);
                command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
                command.Parameters.AddWithValue("@ApplicationStatus", ApplicationStatus);
                command.Parameters.AddWithValue("@LastStatusDateTime", LastStatusDateTime);
                command.Parameters.AddWithValue("@PaidFees", PaidFees);
                command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

                object  res = command.ExecuteScalar();
                if(res != null && int.TryParse(res.ToString(), out int id))
                {
                    newApplicationID = id;
                }
            }
            catch { }
            finally
            {
                connection.Close();
            }
            return newApplicationID;
        }


    }
}
