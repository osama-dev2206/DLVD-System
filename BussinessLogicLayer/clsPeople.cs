using System;
using System.Data;
using DataAccessLayer;
namespace BussinessLogicLayer
{
    public class clsPeople : abPerson
    {

        public static DataTable GetPeople()
        {
            return clsGetBPersonInfo.GetPeopleDataTable();
        }


    }
}
