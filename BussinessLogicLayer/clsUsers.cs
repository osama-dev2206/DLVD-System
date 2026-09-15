using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace BussinessLogicLayer
{
    public class clsUsers : abPerson
    {
        public string ?Username { get; set; }
        public string ?Password { get; set; }


        public static bool IsUserNameExist(string Username)
        {
            if (Username is null) return false;
            return DataAccessLayer.clsCheckUserExistence.IsUserNameExist(Username.Trim());
        }


        public static bool IsLoginValid(string Username, string Password)
        {
            if (Username is null || Password is null)
                 return false;
            if (clsCheckLoginInfo.IsLoginInfoValid(Username.Trim(), Password.Trim()) )
            {
                clsCurrentLoggedInUser.User = null;/// temp
                return true;
            }
            return false;
        }

    }


}
