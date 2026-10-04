using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DataAccessLayer
{
    public static  class clsFindInternationalLicenseBy
    {
        public enum enFindInternationalLicenseBy {  ApplicationID = 1, DriverID = 2, LicenseID = 3, InternationalLicenseID = 4 }
     static  SqlConnection connection;

        static clsFindInternationalLicenseBy()
        {
            connection = dbSettings.DbConnection();
        }

        private static DataTable ImplementQuery(enFindInternationalLicenseBy licenseBy , int ID)
        {
            DataTable dt = new DataTable();
            switch (licenseBy)
            {
                case enFindInternationalLicenseBy.ApplicationID:
                    return @SqlCmd(Query: @"Select * From InernationalLicenseApplications where ApplicationID = @ApplicationID ;", Column: "@ApplicationID", Paramter: ID);

                    case enFindInternationalLicenseBy.DriverID:
                    return @SqlCmd(Query: @"Select * From InernationalLicenseApplications where DriverID = @DriverID ;", Column: "@DriverID", Paramter: ID);

                case enFindInternationalLicenseBy.LicenseID:
                    return @SqlCmd(Query: @"Select * From InernationalLicenseApplications where LicenseID = @LicenseID ;", Column: "@LicenseID", Paramter: ID);

                case enFindInternationalLicenseBy.InternationalLicenseID:
                    return @SqlCmd(Query: @"Select * From InernationalLicenseApplications where InternationalLicenseID = @InternationalLicenseID ;", Column: "@InternationalLicenseID", Paramter: ID);

            }

            return dt;

        }


        private static  DataTable @SqlCmd(string Query , string Column , int Paramter)
        {
            SqlCommand cmd = new SqlCommand(Query, connection);
            DataTable dt = new DataTable();
            cmd.Parameters.AddWithValue(Column, Paramter);
            using (SqlDataReader R = cmd.ExecuteReader())
            {
                if(R.HasRows )
                    dt.Load(R);
            }
            return dt;
        }

        public static DataTable GetTable(enFindInternationalLicenseBy enFindInternational , int ID)
        {
            DataTable dt = new DataTable();
            try
            {
                connection.Open();
                dt = ImplementQuery(enFindInternational, ID);
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
