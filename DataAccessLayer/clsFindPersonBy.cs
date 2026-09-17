using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DataAccessLayer
{

    public static  class clsFindPersonBy
    {

        public enum enSearchPersonBy {None = 0, PersonID = 1,  NationalNumber=2 , FirstName = 3 , SecondName =4 , ThirdName = 5 , LastName =6 , Nationality = 7 , Gender=8 , Phone=9 , Email =10 }
        private  delegate void cmdDelegate(string Query, string @What ,dynamic value, SqlConnection connection);
        static cmdDelegate ?@delegate =null ; // instance of delegate 
        static SqlDataReader ? reader = null;
       static SqlConnection connection = dbSettings.DbConnection();

        static clsFindPersonBy() // static constructor to initialize any static data or perform actions that need to be performed only once
        {
            @delegate += cmd; // subscribe the cmd method to the delegate
        }


        static void PrepareQuery(enSearchPersonBy enSearch , dynamic value)
        {
            switch (enSearch)
            {
                case enSearchPersonBy.PersonID:
                    @delegate?.Invoke(@"select * from ShowBasicPersonInfo where PersonID =@PersonID ;", "@PersonID" , Convert.ToInt32(value) , connection);  // invoke 
                    break;

                case enSearchPersonBy.NationalNumber:
                    @delegate?.Invoke(@"select * from ShowBasicPersonInfo where NationalNumber =@NationalNumber ;", "@NationalNumber", value, connection);
                    break;

                case enSearchPersonBy.FirstName:
                    @delegate?.Invoke(@"select * from ShowBasicPersonInfo where  LOWER(FirstName) =@FirstName ;", "@FirstName", value, connection);
                    break;

                    case enSearchPersonBy.SecondName:
                    @delegate?.Invoke(@"select * from ShowBasicPersonInfo where Lower(SecondName) =@SecondName ;", "@SecondName", value, connection);
                    break; 

                    case enSearchPersonBy.ThirdName:
                    @delegate?.Invoke(@"select * from ShowBasicPersonInfo where Lower(ThirdName) =@ThirdName ;", "@ThirdName", value, connection);
                    break;

                    case enSearchPersonBy.LastName:
                    @delegate?.Invoke(@"select * from ShowBasicPersonInfo where Lower(LastName) =@LastName ;", "@LastName", value, connection);
                    break;

                    case enSearchPersonBy.Nationality: // جنسيه 
                    @delegate?.Invoke(@"select * from ShowBasicPersonInfo where Lower(Nationality) =@Nationality ;", "@Nationality", value, connection);
                    break;

                case enSearchPersonBy.Gender:
                    @delegate?.Invoke(@"select * from ShowBasicPersonInfo where LOWER(Gender) =@Gender ;", "@Gender", value, connection);
                    break;

                    case enSearchPersonBy.Phone:
                    @delegate?.Invoke(@"select * from ShowBasicPersonInfo where Phone =@Phone ;", "@Phone", value, connection);
                    break; 
                    
                    case enSearchPersonBy.Email:
                    @delegate?.Invoke(@"select * from ShowBasicPersonInfo where Email =@Email ;", "@Email", value, connection);
                    break; 

            }
            return ;
        }

      private static  void  cmd(string Query, string @What ,dynamic value ,SqlConnection connection )
        {
            SqlCommand command = new SqlCommand(Query , connection);
            command.Parameters.AddWithValue(@What, value);
            reader = command.ExecuteReader();
        }

        public static DataTable GetPersonRecordBy(dynamic Keyword ,enSearchPersonBy searchPersonBy)
        {
            DataTable dt = new DataTable();

            try
            {
                connection.Open();
                 PrepareQuery(searchPersonBy,Keyword); // get the query based on the search criteria
                if (reader != null && reader.HasRows) 
                    dt.Load(reader); // load the data from the reader into the DataTable
            }
            catch { }
            finally 
            {
                connection.Close();
                reader?.Close();
            }

            return dt;
        }

    }
}
