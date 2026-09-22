using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DataAccessLayer
{
    public static  class clsFindLicenseClasssByClassID
    {
        private static string Query = @"Select * from LicenseClasses 
where LicenseClassID =@ClassID ; ";

        public static DataTable FindLicenseClassByClassID(int ClassID)
        {
            SqlConnection connection = dbSettings.DbConnection();
            DataTable dataTable = new DataTable();

            try 
            { 
                connection.Open();
                SqlCommand cmd = new SqlCommand(Query, connection);
                cmd.Parameters.AddWithValue("@ClassID", ClassID);

                SqlDataReader reader = cmd.ExecuteReader();
                if(reader is not null && reader.HasRows)
                {
                    dataTable.Load(reader);
                }

                reader?.Close();
            }
            catch { }
            finally
            {
                connection.Close();
            }


            return dataTable;
        }
    }
}
