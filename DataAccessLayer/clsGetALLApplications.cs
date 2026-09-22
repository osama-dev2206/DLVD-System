using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer
{
    public static class clsGetALLApplications
    {
        private static string Query = @"select * from Applications
where ApplicationID = @ApplicationID;";
    }
}
