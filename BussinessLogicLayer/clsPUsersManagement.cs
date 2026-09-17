using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace BussinessLogicLayer
{
    // this class is used to manage the users in the system and it is a partial class that is used to separate the user management functionality from the user information functionality
    public partial class clsUsers 
    {

        public static DataTable FindUserByUserID(int UserID)
        {
            if (!int.TryParse(UserID.ToString(), out _)) return null; 
            return clsFindUser.FindUserBy(clsFindUser.enFindUserBy.UserID, UserID);
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

        bool Update()
        {
            return clsUpdateUser.UpdateUser(UserID: this.UserID,UserName:this.Username, Password:this.Password , this.IsActive) ;
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



            }


            return false;
        }



    }
}
