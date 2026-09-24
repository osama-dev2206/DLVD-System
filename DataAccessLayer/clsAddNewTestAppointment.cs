using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer
{
    public static class clsAddNewTestAppointment
    {
        private static string Query = @"Insert Into TestAppointments(AppointmentTestTypeID,
TestAppointmentForLocalDrivingLicenseAppID,
AppointmentDateTime,
PaidFees
,CreatedByUserID
,IsLocked )
values
(   
@TestTypeID , @LocalDrivingLicenseApplicationID, @AppointmentDateTime   ,
@PaidFees , @CreatedByUserID , @IsLocked 
);
Select SCOPE_IDENTITY();  ";


        public static int AddNewTestAppointment(int TestTypeID, int LocalDrivingLicenseApplicationID, DateTime AppointmentDateTime, decimal PaidFees, int CreatedByUserID, 
            bool IsLocked)
        {
            SqlConnection connection = dbSettings.DbConnection();
            int NewTestAppointmentID = -1;
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(Query,connection);
                cmd.Parameters.AddWithValue("@TestTypeID", TestTypeID);
                cmd.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
                cmd.Parameters.AddWithValue("@AppointmentDateTime", AppointmentDateTime);
                cmd.Parameters.AddWithValue("@PaidFees", PaidFees);
                cmd.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
                cmd.Parameters.AddWithValue("@IsLocked", IsLocked);

             object r = cmd.ExecuteScalar();
                if(r is not null && int.TryParse(r.ToString(), out int result))
                {
                    NewTestAppointmentID = result;
                }

            }
            catch { }
            finally
            {
                connection.Close();
            }
            return NewTestAppointmentID;
        }

    }
}
