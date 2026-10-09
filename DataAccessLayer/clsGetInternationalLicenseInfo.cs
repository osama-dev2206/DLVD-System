using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DataAccessLayer
{
    public static class clsGetInternationalLicenseInfo
    {
        private static string Query = @"Select InternationalLicenses.InternationalLicenseID ,
InternationalLicenses.ApplicationID ,
InternationalLicenses.LicenseID, 
LicenseClasses.ClassName ,
InternationalLicenses.IssueDateTime,
InternationalLicenses.ExpirationDate ,
InternationalLicenses.IsActive 
from InternationalLicenses
Inner Join Licenses On Licenses.LicenseID = InternationalLicenses.LicenseID
Inner Join LicenseClasses On LicenseClasses.LicenseClassID = Licenses.ClassOfLicenseID
Inner Join Applications On Applications.ApplicationID = Licenses.LicApplicationID
where ApplicantPersonID=@PersonID ;";

        public static DataTable GetTable(int PersonID)
        {
            SqlConnection connection = dbSettings.DbConnection();
            DataTable dt = new DataTable();
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(Query, connection);
                cmd.Parameters.AddWithValue("@PersonID", PersonID);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if(reader.HasRows)
                    dt.Load(reader);
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
