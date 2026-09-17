using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DataAccessLayer
{
    public static class clsFindUser
    {
        static clsFindUser()
        {
            DelfindUserBy += @SqlCmd;

        }

        public enum enFindUserBy { UserName,   UserID, ByUserIDGetBasic,  PersonID , FullName , IsActive , IsNOTActive }
        static private SqlConnection connection = dbSettings.DbConnection();
        // static DataTable dt; // using the same dt will cause NullReferenceException 
        private delegate DataTable DelFindBy(string Query, string @What, dynamic valueToPath, out DataTable dt);
        private static DelFindBy DelfindUserBy;


        private static DataTable ImplementQuery(enFindUserBy enFind , dynamic valueToPath)
        {
            DataTable dt = new DataTable(); // local dt to avoid NullReferenceException when using the same dt in multiple calls
            switch (enFind)
            {
                case enFindUserBy.UserID:
                    DelfindUserBy?.Invoke(@"Select Users.*  From Users  Where UserID =  @UserID ;", "@UserID", valueToPath, out dt);
                    return dt;
                 

                case enFindUserBy.ByUserIDGetBasic:
                   DelfindUserBy?.Invoke(@"Select *  From BasicUserInfo Where  UserID = @UserID  ; ", "@UserID", valueToPath, out dt);
                    return dt;

                case enFindUserBy.PersonID:
                    DelfindUserBy?.Invoke(@"Select *  From BasicUserInfo Where  UserPersonID = @PersonID  ; ", "@PersonID", valueToPath, out dt);
                    return dt;

                case enFindUserBy.UserName:
                  DelfindUserBy?.Invoke(@"Select BasicUserInfo.*  From BasicUserInfo  Where UserName = @UserName ; ", "@UserName", valueToPath, out dt);
                    return dt;

                case enFindUserBy.FullName:
                   DelfindUserBy?.Invoke(@"  select * from BasicUserInfo 
                     where FullName like '%' + @FullName + '%'  ; -- contains ", "@FullName", valueToPath, out dt);
                    return dt;

                case enFindUserBy.IsActive:
              DelfindUserBy?.Invoke(@" select * from BasicUserInfo  where IsActive = @IsActive ; ", "@IsActive", 1, out dt);
                    return dt;

                case enFindUserBy.IsNOTActive:
                      DelfindUserBy?.Invoke(@" select * from BasicUserInfo  where IsActive = @IsActive ;  -- IsNot Active  ; ", "@IsActive", 0, out dt);
                    return dt;

                default:
                    return dt;

            }
        }

        private static DataTable @SqlCmd(string Query , string @What , dynamic valueToPath , out DataTable dt)
        {
             dt = new DataTable();
            using (SqlCommand cmd = new SqlCommand(Query, connection))
            {
                cmd.Parameters.AddWithValue(@What, valueToPath);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader is not null && reader.HasRows)
                {
                    dt.Load(reader);
                }
                else
                {
                    dt = null;
                }
                reader.Close();
            }

            return dt; 
        }


        public static DataTable FindUserBy(enFindUserBy enFind, dynamic valueToPath)
        {
            DataTable dt = new DataTable();
            try
            {
                connection.Open();
               dt= ImplementQuery(enFind, valueToPath);

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
