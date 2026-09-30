using DataAccessLayer;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace BussinessLogicLayer
{
    public static class clsLicenseHistory
    {
        private static string Query = @"Select Licenses.LicenseID ,
Licenses.LicApplicationID  , 
LicenseClasses.ClassName ,
Licenses.IssueDate ,
Licenses.ExpirationDate 
,Licenses.IsActive
from Licenses
Inner Join LicenseClasses On LicenseClasses.LicenseClassID = Licenses.ClassOfLicenseID
Inner Join Applications On Applications.ApplicationID = Licenses.LicApplicationID
where Applications.ApplicationID =  @ApplicantID  ; ";


        public static DataTable GetLicenseHistoryByApplicantID(int ApplicantID)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = dbSettings.DbConnection();

            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(Query, connection);
                cmd.Parameters.AddWithValue("@ApplicantID", ApplicantID);

                using (SqlDataReader R = cmd.ExecuteReader())
                {
                    if(R is not null && R.HasRows)
                    dt.Load(R);
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
