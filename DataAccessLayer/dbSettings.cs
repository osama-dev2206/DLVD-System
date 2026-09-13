using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer
{
    internal static class dbSettings
    {

        static string ConnectionString =
            @"Server=OSAMA-PC;Database=MyDVLD;Integrated Security=True;TrustServerCertificate=True;";

        public static SqlConnection DbConnection()
        {
            return new SqlConnection(ConnectionString);
        }


    }
}
