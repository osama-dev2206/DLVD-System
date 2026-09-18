using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Security;
using System.Text;

namespace BussinessLogicLayer
{
    // this class is used to manage the users in the system and it is a partial class that is used to separate the user management functionality from the user information functionality
    public partial class clsUsers 
    {

        // Find By Returns DataTable ///
        public static DataTable FindUserByUserID(int UserID)
        {
            if (!int.TryParse(UserID.ToString(), out _)) return null; 
            return clsFindUser.FindUserBy(clsFindUser.enFindUserBy.UserID, UserID);
        }
        
        public static DataTable FindBasicUserByUserID(int UserID)
        {
            if (!int.TryParse(UserID.ToString(), out _)) return null;
            return clsFindUser.FindUserBy(clsFindUser.enFindUserBy.ByUserIDGetBasic, UserID);
        }

        public static DataTable FindUserByUserName(string UserName)
        {
            if (string.IsNullOrEmpty(UserName)) return null;
            return clsFindUser.FindUserBy(clsFindUser.enFindUserBy.UserName, UserName);
        }

        public static DataTable FindUserByPersonID(int PersonID)
        {
            if (!int.TryParse(PersonID.ToString(), out _)) return null;
            return clsFindUser.FindUserBy(clsFindUser.enFindUserBy.PersonID, PersonID);
        }
        
        public static DataTable GetUsersByPersonFullName(string FullName)
        {
            if (string.IsNullOrEmpty(FullName)) return null;
            return clsFindUser.FindUserBy(clsFindUser.enFindUserBy.FullName, FullName);
        }

        public static DataTable GetAllActiveUsers()
        {
            return clsFindUser.FindUserBy(clsFindUser.enFindUserBy.IsActive, 1);
        }

        public static DataTable GetAllNONActiveUsers()
        {
            return clsFindUser.FindUserBy(clsFindUser.enFindUserBy.IsNOTActive, 0);
        }

      public static  bool IsUserISAPerson(int PersonID)
        {
            if(!int.TryParse(PersonID.ToString(), out _)) return false;
            return clsCheckUserExistence.IsPersonIsAUser(PersonID);
        }

        //////////////////////////////////////////////

        public static DataTable GetAllUsers()
        {
            return clsGetAllUsers.GetAllUsers();
        }

        public static clsUsers FindUserByUserIDAsObj(int UserID)
        {
            if (!int.TryParse(UserID.ToString(), out _)) return null;
            clsUsers user = null;

            DataTable dt = FindUserByUserID(UserID);

            foreach (DataRow R in dt.Rows)
            {
                user = new clsUsers
                    (
                    UserID: Convert.ToInt32(R["UserID"]) ,
                    UserPersonID: Convert.ToInt32(R["UserPersonID"]),
                    UserName: R["UserName"].ToString(),
                    Password: R["Password"].ToString(),
                    IsActive: Convert.ToBoolean(R["IsActive"])
                    );
            }


            return user;
        }

        public static bool DeleteUserByUserID(int UserID)
        {
            if (!int.TryParse(UserID.ToString(), out _) || clsCurrentLoggedInUser.User.IsActive) return false; // you cannot delete a user if the user is currently logged in and active
            return clsDeleteUser.DeleteUserByUserID(UserID);
        }

       private bool Update()
        {
            this.Password = clsEncryptDecrypt.Encrypt(Password); // encrypt the password before updating it in the database
            return clsUpdateUser.UpdateUser(UserID: this.UserID,UserName:this.Username, Password:this.Password , this.IsActive) ;
        }

        private bool Add()
        {
            return true;

        }

        public bool Save()
        {
            switch(this.Mode)
            {
                     case enMode.Update:
                    {
                        if(Update())
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }

                    case enMode.Add:
                    {
                        if (Add())
                        {
                            this.Mode = enMode.Update;
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }


            }


            return false;
        }



    }
}
