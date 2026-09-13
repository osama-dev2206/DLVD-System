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

        // Get The DataTable Filtered by PersonID
        public static DataTable GetPersonByPersonID(int PersonID )
        {
            if(!int.TryParse(PersonID.ToString(), out int result) )
            {
                return null; 
            }

            return clsSearchPersonBy.GetPersonRecordBy(PersonID,clsSearchPersonBy.enSearchPersonBy.PersonID); 
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



    }
}
