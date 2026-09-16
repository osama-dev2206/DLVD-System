using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.IO.Enumeration;
using System.Text;

namespace DataAccessLayer
{
    public static  class clsIsUserActive
    {

        static  clsIsUserActive() // static constructor to initialize the delegate
        {
            InvokeQueryAccordingToCheckBySelection += @SqlCommand;
        }

       public  enum enCheckBy { ByUserName,   ByUserID , ByPersonID  }
        static SqlConnection connection = dbSettings.DbConnection();
        delegate void InvokeQuery(string Query, string ColumnNameToPass, dynamic value, SqlConnection connection);
        private static InvokeQuery InvokeQueryAccordingToCheckBySelection;  // instance of delegate to invoke the query according to the check by selection

        static   void ImplementQuery(dynamic Value , enCheckBy enCheck)
        {
            switch(enCheck)
            {
                case enCheckBy.ByUserName:
                    InvokeQueryAccordingToCheckBySelection?.Invoke(@"Select R = 'T'  from Users where UserName =  @Username  and Users.IsActive = 1  ; ", 
                        "UserName", Value, connection);
                    break;

                case enCheckBy.ByUserID:
                    InvokeQueryAccordingToCheckBySelection?.Invoke(@"Select R = 'T' from Users  where  UserID = @UserID  and   Users.IsActive = 1 ; ", "UserID", Value, connection);
                    break;

                case enCheckBy.ByPersonID:
                    InvokeQueryAccordingToCheckBySelection?.Invoke(@"Select R = 'T' from Users  where  PersonID = @PersonID  and   Users.IsActive = 1 ; ", "PersonID", Value, connection);
                    break;

            }
        }

        static bool  Res = false;
        static void @SqlCommand(string Query , string ColumnNameToPass ,dynamic value , SqlConnection connection)
        {
            ColumnNameToPass = "@" + ColumnNameToPass;
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue(ColumnNameToPass, value);
            object result = command.ExecuteScalar();

            if(result != null && result.ToString() == "T")
            {
                Res = true;
            }
        }

        public static bool  IsUserActive(dynamic Value , enCheckBy checkBy)
        {
  
            bool  IsActive= false;
            try
            {
                connection.Open();
                ImplementQuery(Value, checkBy);
                IsActive = Res;
        
            }
            catch { }
            finally
            {
                connection.Close();
            }
            return IsActive; 
        }

    }
}
