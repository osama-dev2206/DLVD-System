using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DataAccessLayer
{
    public static class clsFindDriver
    {
        static SqlConnection connection;
         static clsFindDriver()
        {
            connection = dbSettings.DbConnection();
        }

     public   enum enFindDriverBy { DriverID = 1, PersonID = 2 , NationalNo =3 , FullName =4  }

        private static DataTable ImplementQuery (enFindDriverBy FindBy , dynamic ValueToSearchWith )
        {
            DataTable dt = new DataTable();
            switch (FindBy)
            {
                case enFindDriverBy.DriverID:
                    return @SqlCmd(Query: @"Select * from ListDrivers where DriverID = @DriverID ;", Column: "@DriverID",  Paramter: ValueToSearchWith);

                case enFindDriverBy.PersonID:
                    return @SqlCmd(Query: @"Select * from ListDrivers where PersonID = @PersonID ;", Column: "@PersonID", Paramter: ValueToSearchWith);

                case enFindDriverBy.NationalNo:
                    return @SqlCmd(Query: @"Select * from ListDrivers  where NationalNumber =  @NationalNo ;", Column: "@NationalNo", Paramter: ValueToSearchWith);

                    case enFindDriverBy.FullName:
                    return @SqlCmd(Query: @"Select * from ListDrivers where [Full Name] like '%' + @FullName + '%';", Column: "@FullName", Paramter: ValueToSearchWith);


            }
            return dt;
        }

        private static DataTable @SqlCmd(string Query , string Column , dynamic Paramter)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand(Query, connection);
            cmd.Parameters.AddWithValue(Column, Paramter);
            using (SqlDataReader R = cmd.ExecuteReader())
            {
                if( R is not null && R.HasRows)
                dt.Load(R);
            }
            return dt;
        }


        public static DataTable FindDriver(enFindDriverBy FindBy, dynamic ValueToSearchWith)
        {
            DataTable dt = new DataTable();
            try
            {
                connection.Open();
                dt= ImplementQuery(FindBy, ValueToSearchWith);
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
