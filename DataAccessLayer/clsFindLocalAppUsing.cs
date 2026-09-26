using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DataAccessLayer
{
    public static class clsFindLocalAppUsing
    {
         static clsFindLocalAppUsing()
        {
            DelsqlCmd += @SqlCmd;
            connection = dbSettings.DbConnection();
        }

       public enum enSearchBy { LdLAppID = 1, NationalNo = 2, FullName = 3, NewStatus = 4 , CancelledStatus=5 , CompletedStatus=6 }
        private static SqlConnection connection;


        delegate void delSqlCmd(string Query, string Paramter, dynamic ValueForParamter, out DataTable dtRes);
        private static delSqlCmd DelsqlCmd;

        private static DataTable ImplementQuey(enSearchBy searchBy , dynamic ValueForParamter)
        {
            DataTable dt = new DataTable();
            switch(searchBy)
            {
                case enSearchBy.LdLAppID:
                    DelsqlCmd?.Invoke(@"select * from LocalDrivingLicenseApplicationsView  where [L.D.LAppID] = @AppID ;", "@AppID", ValueForParamter, out dt);

                    return dt;
                  
                case enSearchBy.NationalNo:
                    
                    DelsqlCmd?.Invoke(@" select* from LocalDrivingLicenseApplicationsView where [National No] = @NationalNo;", "@NationalNo", ValueForParamter, out dt);
                    return dt;

                case enSearchBy.FullName:
                    DelsqlCmd?.Invoke(@"select * from LocalDrivingLicenseApplicationsView where [Full Name] Like '%' + @FullName + '%'   ; " , 
                        "@FullName", ValueForParamter, out dt);
                    return dt;

                case enSearchBy.NewStatus:
                    DelsqlCmd?.Invoke(@"select * from LocalDrivingLicenseApplicationsView where Status = @Status ;", "@Status", "New", out dt);
                    return dt;

                    case enSearchBy.CancelledStatus:
                    DelsqlCmd?.Invoke(@"select * from LocalDrivingLicenseApplicationsView where Status = @Status ;", "@Status", "Cancelled", out dt);
                    return dt;

                case enSearchBy.CompletedStatus:
                    DelsqlCmd?.Invoke(@"select * from LocalDrivingLicenseApplicationsView where Status = @Status ;", "@Status", "Completed", out dt);
                    return dt;

            }
            return dt;
        }

        private static void @SqlCmd(string Query , string Paramter , dynamic ValueForParamter , out DataTable dtRes)
        {
            dtRes = new DataTable();
            SqlCommand cmd = new SqlCommand(Query,connection);
            cmd.Parameters.AddWithValue(Paramter, ValueForParamter);

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if(reader is not null && reader.HasRows)
                {
                    dtRes.Load(reader);
                }
            }

        }


        public static  DataTable FindBy(dynamic Value ,enSearchBy searchBy)
        {
         
            DataTable dt = new DataTable();

            try
            { 
                connection.Open();
                dt = ImplementQuey(searchBy, Value);

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
