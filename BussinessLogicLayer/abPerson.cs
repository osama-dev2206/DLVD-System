using System;
using System.Collections.Generic;
using System.Text;

namespace BussinessLogicLayer
{
    public class abPerson // from people table 
    {
     public  enum enMode { Update = 1, Add = 2 }
        public int PersonID { get; protected set; }
        public string NationalNumber { get; set; }  
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string LastName { get; set; }
        public DateOnly DateOfBirth { get; set; }
        public int  Gender { get; set; } 

        public string Address { get; set; }

        public string Phone { get; set; }
        public string ? Email { get; set; }
        public  string ? ImagePath { get; set; }

        public string NationalityCountry { get; set; }
        public int NationalityCountryID { get; set; }
    }
}
