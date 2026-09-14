using System;
using System.Data;
using DataAccessLayer;
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
            this.Gender = gender;
            this.Address = address;
            this.Phone = phone;
            this.Email = email; 
            this.ImagePath  = imagePath;
            this.NationalityCountry = nationalityCountry;

            this.Mode = enMode.Update;
        }


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
                         R["Gender"].ToString() ,
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
            return clsDeletePerson.DeletePerson(PersonID);
        }

        public static DataTable GetAllCountries()
        {
            return clsListOfCountrires.GetAllCountries();
        }

        private int ? GetCountryIDByItsName()
        {
            return clsGetCountryIDByCountryName.GetCountryID(this.NationalityCountry);
        }

        public clsPeople() // for adding new person
        {
            this.Mode = enMode.Add;
        }

        private bool AddNewPerson()
        {
            return
               (
               clsAddNewPerson.AddNewPerson
                (
                NationalNumber: this.NationalNumber, FirstName: this.FirstName, SecondName: this.SecondName, ThirdName: this.ThirdName, LastName: this.LastName,
                DateOfBirth: this.DateOfBirth, Gender: this.Gender == "m" ? 1 : 2, Address: this.Address, Phone: this.Phone, Email: this.Email, ImagePath: this.ImagePath, NationalityCountryID: GetCountryIDByItsName()
                )
                ) != -1 ;

        }

        public bool Save()
        {
            switch(this.Mode)
            {
                case enMode.Add:
                  if (AddNewPerson())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                  return false;


            }

            return false;
        }

        }
}
