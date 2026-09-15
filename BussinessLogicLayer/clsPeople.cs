using DataAccessLayer;
using Microsoft.VisualBasic.FileIO;
using System;
using System.Data;
using System.IO;
using System.Xml.Linq;

namespace BussinessLogicLayer
{
    public class clsPeople : abPerson // data view not main table 
    {
        enMode Mode;
        public static DataTable GetPeople()
        {
            return clsGetBPersonInfo.GetPeopleDataTable();
        }

        // These Methods `Use ShowBasicPersonInfo` Data View ! ///////////
        // Get The DataTable Filtered by PersonID
        public static DataTable GetPersonByPersonID(int PersonID )
        {
            if(!int.TryParse(PersonID.ToString(), out int result) )
            {
                return null; 
            }

            return clsSearchPersonBy.GetPersonRecordBy(PersonID,clsSearchPersonBy.enSearchPersonBy.PersonID);  // data view 
        }

        public static DataTable GetPersonByNationalNo(string NationalNo)
        {
            return clsSearchPersonBy.GetPersonRecordBy(NationalNo, clsSearchPersonBy.enSearchPersonBy.NationalNumber);
        }

        public static DataTable GetPersonByFirstName(string FirstName)
        {
            return clsSearchPersonBy.GetPersonRecordBy(FirstName.ToLower(), clsSearchPersonBy.enSearchPersonBy.FirstName);
        }

        public static DataTable GetPersonBySecondName(string SecondName)
        {
            return clsSearchPersonBy.GetPersonRecordBy(SecondName.ToLower(), clsSearchPersonBy.enSearchPersonBy.SecondName);
        }

        public static DataTable GetPersonByThirdName(string ThirdName)
        {
            return clsSearchPersonBy.GetPersonRecordBy(ThirdName.ToLower(), clsSearchPersonBy.enSearchPersonBy.ThirdName);
        }

        public static DataTable GetPersonByLastName(string LastName)
        {
            return clsSearchPersonBy.GetPersonRecordBy(LastName.ToLower(), clsSearchPersonBy.enSearchPersonBy.LastName);
        }

        public static DataTable GetPersonByNationality(string Nationality)
        {
             return clsSearchPersonBy.GetPersonRecordBy(Nationality.ToLower(), clsSearchPersonBy.enSearchPersonBy.Nationality);
        }

        public static DataTable GetPersonByGender(string Gender)
        {
            Gender = Gender.ToLower(); 
            if(  Gender == "male" || Gender =="m"  )
            {
                return clsSearchPersonBy.GetPersonRecordBy("m", clsSearchPersonBy.enSearchPersonBy.Gender);
            } 
            else if(Gender == "female" || Gender == "f")
            {
                return clsSearchPersonBy.GetPersonRecordBy("f", clsSearchPersonBy.enSearchPersonBy.Gender);
            }

            return null; 
        }


        public static DataTable GetPersonByPhone(string Phone)
        {
            return clsSearchPersonBy.GetPersonRecordBy(Phone, clsSearchPersonBy.enSearchPersonBy.Phone);
        }

        public static DataTable GetPersonByEmail(string Email)
        {
            return clsSearchPersonBy.GetPersonRecordBy(Email, clsSearchPersonBy.enSearchPersonBy.Email);
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        // it is like the og table except gender is string and nationality is string not int
        private clsPeople(int personID, string nationalNumber, string firstName, string secondName, string thirdName, string lastName, string gender, string nationalityCountry, string phone, string email,
            DateTime dateOfBirth, string address, string imagePath)  // Data View 
        {
            this.PersonID = personID;
            this.NationalNumber = nationalNumber;
            this.FirstName = firstName;
            this.SecondName = secondName;
            this.ThirdName = thirdName;
            this.LastName = lastName;
            this.DateOfBirth= DateOnly.FromDateTime(dateOfBirth);
            this.Gender = (gender.ToUpper() == "M")? 1 : 2;
            this.Address = address;
            this.Phone = phone;
            this.Email = email; 
            this.ImagePath  = imagePath;
            this.NationalityCountry = nationalityCountry;

            this.Mode = enMode.Update;
        }

        // retrurns object of clsPeople with all properties filled from the database by PersonID
        public static clsPeople ? GetPersonObjectByPersonID(int PersonID)
        {
            DataTable dt = clsGetDetailsPersonInfoByPersonID.GetFullPersonByPersonID(PersonID);
            if (dt is not null) 
            {
                clsPeople? people = null; 
                foreach (DataRow R in dt.Rows) 
                {
                  
                    people = new clsPeople
                        (
                         Convert.ToInt32(R["PersonID"]) ,
                         R["NationalNumber"].ToString() ,
                         R["FirstName"].ToString(),
                         R["SecondName"].ToString(),
                         R["ThirdName"].ToString(),
                         R["LastName"].ToString(),
                         R["Gender"].ToString(), // string from data view
                         R["Nationality"].ToString(), 
                         R["Phone"].ToString(),
                         R["Email"].ToString() ,
                        Convert.ToDateTime((R["DateOfBirth"]))  ,
                        R["Address"].ToString(),
                        R["ImagePath"].ToString()
                        );
                }

                return people;

            }

            else 
                return null;
        }


        public static bool DeletePersonByPersonID(int PersonID)
        {
            string Path = ImagePathFromDB(PersonID);
         
            return (DeleteImageFromDir(Path) && clsDeletePerson.DeletePerson(PersonID) );
        }

        public static DataTable GetAllCountries()
        {
            return clsListOfCountrires.GetAllCountries();
        }

        private int ? GetCountryIDByItsName()
        {
            return clsGetCountryIDByCountryName.GetCountryID(this.NationalityCountry);
        }

        public static int ? GetCountryIDByItsName(string CountryName)
        {
            return clsGetCountryIDByCountryName.GetCountryID(CountryName);
        }

        public static bool IsNationalNumberExists(string NationalNumber)
        {
            return clsCheckNationalNumExistence.IsNationalNumExist(NationalNumber);
        }


        public clsPeople() // for adding new person
        {
            this.Mode = enMode.Add;
        }

        private bool AddNewPerson()
        {
            
            int ID =   (
               clsAddNewPerson.AddNewPerson
                (
                NationalNumber: this.NationalNumber, FirstName: this.FirstName, SecondName: this.SecondName, ThirdName: this.ThirdName, LastName: this.LastName,
                DateOfBirth: this.DateOfBirth, Gender: this.Gender , Address: this.Address, Phone: this.Phone, Email: this.Email, ImagePath: this.ImagePath, NationalityCountryID: GetCountryIDByItsName()
                )
                )  ;

            this.PersonID = ID;

            return (ID != -1);

        }

        public string? OldPath { get; set; }
        private bool Update() // the old pfp will be deleted and the new one will be added to the new path
        {
            return clsUpdatePerson.UpdatePerson(personID:this.PersonID, nationalNumber: this.NationalNumber ,
                firstName : this.FirstName ,  secondName: this.SecondName ,  thirdName: this.ThirdName,
                lastName:this.LastName , dateOfBirth:this.DateOfBirth , gender:this.Gender , address: this.Address ,
                phone:this.Phone , email:this?.Email , imagePath:this?.ImagePath , nationalityCountryID: this.NationalityCountryID); 
        }

        private string ? ImagePathFromDB()
        {
            return clsGetPersonImagePathOnly.GetPersonImagePath(this.PersonID);
        }

        private static string? ImagePathFromDB(int personID)
        {
            return clsGetPersonImagePathOnly.GetPersonImagePath(personID);
        }

        public bool Save()
        {
            switch(this.Mode)
            {
                case enMode.Add:
                    {
                        if (ImageMoveToNewDir() && AddNewPerson())
                        {
                            Mode = enMode.Update;
                            return true;
                        }
                        return false;
                    }

                case enMode.Update:
                    {
                        string ?OldPath = ImagePathFromDB(); // store the old image path before updating
                        if (ImageMoveToNewDir() && Update()  ) 
                        {
                      
                            return DeleteOldImage(OldPath);
                            
                        }
                        return false;
                    }

            }

            return false;
        }


        // Image Handling 
        // Path To Move C:\
        private DirectoryInfo DI;  // class 
        string PathToMove = @"C:\DVLDPeopleImages\";

        // Create New Directory If Not Exist 
        private bool  CheckDir()
        {
            if (Directory.Exists(PathToMove)) return true; // if the directory already exists return true
            try { DI = Directory.CreateDirectory(PathToMove); } // create new directory if not exist
            catch { return false; }
            
             return  true; 
        }

        private void CopyTheFileToNewDestination()
        {
            string ?FileName = Path.GetFileName(this?.ImagePath); // get the file name from the original path
            string? CopyPath = Path.Combine(PathToMove, Guid.NewGuid().ToString() + Path.GetExtension(ImagePath)); // the new path 

            File.Copy(this.ImagePath, CopyPath); // copy 

            ImagePath = CopyPath; // change the path to the new path
   

        }

        private bool  ImageMoveToNewDir()
        {
            if(CheckDir() && File.Exists(this.ImagePath) )
            {
                CopyTheFileToNewDestination();
                return File.Exists(this.ImagePath); // check if the new path exists and return true if it does, false otherwise
            }
            return false;
        }

        private bool DeleteOldImage(string ?OldPath)
        {
            if (File.Exists(OldPath))
            {
                try
                {
                    File.Delete(OldPath);
                    return true;
                }
                catch
                {
                    return false;
                }
            }
            return true; // if the file does not exist, consider it deleted
        }

        private static bool DeleteImageFromDir(string Path)
        {
            clsPeople p = new clsPeople();
            return p.DeleteOldImage(Path);
        }

    }
}
