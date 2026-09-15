using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.CompilerServices;
using System.Text;

namespace BussinessLogicLayer
{
    public class clsUsers : abPerson
    {
        public string ?Username { get; set; }
        public string ?Password { get; set; }
        public int UserID { get; private set; }
        public bool IsActive { get; private set; }

        enMode Mode;

        private clsUsers(int UserID , int UserPersonID , string UserName , string Password ,bool  IsActive )
        {
            this.UserID = UserID;
            this.PersonID = UserPersonID;
            this.Username = UserName;
            this.Password = Password;
            this.IsActive = IsActive;

            Mode = enMode.Update;
        }

        public static bool IsUserNameExist(string Username)
        {
            if (Username is null) return false;
            return DataAccessLayer.clsCheckUserExistence.IsUserNameExist(Username.Trim());
        }

        public static clsUsers ? GetUserObjByUsernameAndPassword(string Username , string Password) //// it doesn't cover the user personal info 
            {
            if(String.IsNullOrEmpty(Username) || string.IsNullOrEmpty(Password))
                return null;

            DataTable dt = clsGetUserByUserName.GetUserOnlyInfo(Username.Trim(), Password.Trim());
            clsUsers? User = null;
            foreach(DataRow R in dt.Rows)
            {
                User = new clsUsers
                    (
                    Convert.ToInt32 (R["UserID"]) , Convert.ToInt32(R["UserPersonID"]) ,
                    R["UserName"]?.ToString(), R["Password"]?.ToString(), (R["IsActive"].ToString() == "1" )? true :false
                    );
            }

            return User;
        }

        public static bool IsLoginValid(string Username, string Password)
        {
            if (Username is null || Password is null)
                 return false;
            if (clsCheckLoginInfo.IsLoginInfoValid(Username.Trim(), Password.Trim()) )
            {
                clsCurrentLoggedInUser.User = GetUserObjByUsernameAndPassword(Username , Password);
                return true;
            }

            return false;
        }

    }


}
