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

        public enum enFindUserBy { UserName,   UserID,  PersonID }
        static private SqlConnection connection = dbSettings.DbConnection();
        static DataTable dt = new DataTable();
        private   delegate void  DelFindBy(string Query, string @What, dynamic valueToPath);
        private static DelFindBy DelfindUserBy;


        private static void ImplementQuery(enFindUserBy enFind , dynamic valueToPath)
        {
            switch(enFind)
            {
                case enFindUserBy.UserID:
                    DelfindUserBy?.Invoke(@"Select Users.*  From Users  Where Users.UserID =  @UserID ;", "@UserID", valueToPath);
                    break;

                case enFindUserBy.PersonID:
                    DelfindUserBy?.Invoke(@"Select Users.*  From Users Where Users.UserPersonID = @PersonID  ; ", "@PersonID", valueToPath);
                    break;
   
                    case enFindUserBy.UserName:
                    DelfindUserBy?.Invoke(@"Select Users.*  From Users Where Users.UserName = @UserName ; ", "@UserName", valueToPath);
                    break;


            }
        }

        private static void @SqlCmd(string Query , string @What , dynamic valueToPath)
        {

            SqlCommand cmd = new SqlCommand(Query,connection);
            cmd.Parameters.AddWithValue(@What, valueToPath);
            SqlDataReader reader = cmd.ExecuteReader();
            if(reader is not null && reader.HasRows)
            {
                dt.Load(reader);
            }
            reader.Close();
        }


        public static DataTable FindUserBy(enFindUserBy enFind, dynamic valueToPath)
        {
            try
            {
                connection.Open();
                ImplementQuery(enFind, valueToPath);

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
