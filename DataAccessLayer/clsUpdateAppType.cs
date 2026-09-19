using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer
{
    public static class clsUpdateAppType
    {
        static string Query = @"
Update ApplicationTypes 
Set ApplicationTypeTitle = @ApplicationTitle  , 
ApplicationFees= @ApplicationFees ,
where ApplicationTypeID =@AppID ;";


        public static bool UpdateAppType(int AppID, string ApplicationTitle, decimal ApplicationFees)
        {
            SqlConnection connection = dbSettings.DbConnection();
            bool result = false;
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(Query, connection);
                cmd.Parameters.AddWithValue("@AppID", AppID);
                cmd.Parameters.AddWithValue("@ApplicationTitle", ApplicationTitle);
                cmd.Parameters.AddWithValue("@ApplicationFees", ApplicationFees);

                int ? rowsAffected = cmd.ExecuteNonQuery();
                if(rowsAffected is not null && rowsAffected >0)
                {
                    result = true;
                }

            }
            catch { }
            finally
            {
                connection.Close();
            }
            return result;
        }



    }
}
