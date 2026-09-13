using System;
using System.Collections.Generic;
using System.Text;

namespace BussinessLogicLayer
{
    public class abPerson
    {
        public int PersonID { get; protected set; }
        public string NationalNumber { get; set; }  
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string LastName { get; set; }
        public DateOnly DateOfBirth { get; set; }
        public string Gender { get; set; }

        public string Address { get; set; }

        public string Phone { get; set; }
        public string Email { get; set; }
        public  string ImagePath { get; set; }

        public int NationalityCountryID { get; set; }

    }
}
