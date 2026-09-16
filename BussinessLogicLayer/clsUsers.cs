using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using System.IO;

namespace BussinessLogicLayer
{
    public class clsUsers : abPerson
    {
        public string ?Username { get; set; }
        public string ?Password { get; set; }
        public int UserID { get; private set; }
        public bool IsActive { get; private set; }

        enMode Mode;

        private clsUsers(int UserID , int UserPersonID , string UserName , string Password ,bool  IsActive )// to get user info only
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

       public static bool  IsUserActiveByUserName(string username)
        {
            if (string.IsNullOrEmpty(username)) return false;
            return clsIsUserActive.IsUserActive(username, clsIsUserActive.enCheckBy.ByUserName);
        }

        public static bool IsUserActiveByPersonID(int PersonID)
        {
            if (!int.TryParse(PersonID.ToString() , out _ )) return false;
            return clsIsUserActive.IsUserActive(PersonID, clsIsUserActive.enCheckBy.ByPersonID);
        }

        public static bool IsUserActiveByUserID(int UserD)
        {
            if (!int.TryParse(UserD.ToString(), out _ )) return false;
            return clsIsUserActive.IsUserActive(UserD, clsIsUserActive.enCheckBy.ByUserID);
        }



        public static bool  IsLoginValid(string Username, string Password)
        {
            if (String.IsNullOrEmpty(Username ) || String.IsNullOrEmpty(Password) ) 
                return false;

            Username = Username.Trim();
            Password = Password.Trim();
            if ( IsUserActiveByUserName(Username) && clsCheckLoginInfo.IsLoginInfoValid(Username, Password) )
            {
                clsCurrentLoggedInUser.User = GetUserObjByUsernameAndPassword(Username , Password); // set the current logged in user object
                return true;
            }

            return false;
        }


        // Save Login Cardinealties Info (Remember Me) in the system
        struct stLoginInfo
        {
            public string UserName { get; set; }
            public string Password { get; set; }
            public bool RememberMe { get; set; }
            public stLoginInfo()
            {
                RememberMe = false; 
            }
        }

        static stLoginInfo SavedLoginInfo = new stLoginInfo();

        private static string SavedLoginInfoPath = Path.Combine(@"C:\DVLDSavedLoginInfo", "SavedLogin.json");
        public static void SaveLoginInfoAsJson(string username ,string password, bool RememberMe)
        {
            if (!RememberMe) // donot remeber me 
            {
                return; // if the user checked remember me we will save the info in the json file
            }

            // Fill struct with the login info
            SavedLoginInfo.UserName = username;
            SavedLoginInfo.Password = password;
            SavedLoginInfo.RememberMe = RememberMe;

            Directory.CreateDirectory(@"C:\DVLDSavedLoginInfo"); // create dir if it isn't exist

            DeleteSavedLoginInfo(); // the requirements requires to save only one login info, so if the file is exist we will delete it and create a new one
            
            string JSONString = JsonSerializer.Serialize(SavedLoginInfo); // convert the anonymous type to JSON string

            File.WriteAllText(SavedLoginInfoPath,JSONString); // write the json file to the path
        }

        public static bool GetSavedLoginInfo(out string usename , out string password)
        {
            usename = string.Empty;
            password = string.Empty;

            if (!File.Exists(SavedLoginInfoPath)) return false;  // if file doesn't exist we will return empty strings

            string JsonStringFromFile = File.ReadAllText(SavedLoginInfoPath);

            stLoginInfo temp = new stLoginInfo();
            temp= JsonSerializer.Deserialize<stLoginInfo>(JsonStringFromFile); // convert the JSON File to struct object

            if (!temp.RememberMe) return false; // if the user didn't check remember me we will return empty strings

            usename = temp.UserName;
            password = temp.Password;
            return true; 
        }


        public static void DeleteSavedLoginInfo()
        {
            if (File.Exists(SavedLoginInfoPath))
            {
                File.Delete(SavedLoginInfoPath);
            }
        }






    }


}
