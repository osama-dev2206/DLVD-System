using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace BussinessLogicLayer
{
    public static class clsAppTypes // this class is used to manage the application types in the system (update and search is the only allowed functionality)
    {
        public static DataTable GetAllAppTypes()
        {
            return DataAccessLayer.clsGetAllAppTypes.GetAllAppTypes();
        }


    }
}
