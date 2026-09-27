using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DataAccessLayer
{
    public static class clsGetReatakeTestInfo
    {
        private static string Query = @" -- Get Retake Application ID By Local Driving License Application 
 Select TestAppointments.RetakeApplicationID , 
 ApplicationTypes.ApplicationFees as [Retake Application Fees] , 
 [Total Application Fees] = ApplicationFees + TestTypeFees
 from TestAppointments 
 Inner Join LocalDrivingLicenseApplications on TestAppointments.TestAppointmentForLocalDrivingLicenseAppID = LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID
 Inner Join TestTypes On TestTypes.TestTypeID = TestAppointments.AppointmentTestTypeID
 Inner Join Applications On Applications.ApplicationID = RetakeApplicationID
 Inner Join ApplicationTypes On Applications.ApplicationTypeID = ApplicationTypes.ApplicationTypeID

 Where RetakeApplicationID is not null and TestAppointments.AppointmentTestTypeID = @TestTypeID -- vision(ex)
 and TestAppointments.TestAppointmentForLocalDrivingLicenseAppID  =  @LocalDrivingLicenseAppID ;";

        public static DataTable GetRetakeTestInfoByLocalDrivingLicenseApplicationID(int LocalDrivingLicenseApplicationID, int TestTypeID)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = dbSettings.DbConnection();

            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(Query, connection); 
                cmd.Parameters.AddWithValue("@LocalDrivingLicenseAppID", LocalDrivingLicenseApplicationID);
                cmd.Parameters.AddWithValue("@TestTypeID", TestTypeID);
              
                using (SqlDataReader r = cmd.ExecuteReader())
                {
                    if(r is not null  && r.HasRows)
                    dt.Load(r);
                }
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
