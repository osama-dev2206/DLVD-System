using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer
{
    public static class clsAddNewPerson
    {
        static string Query = @"-- People Main Table 
INSERT INTO People (NationalNumber, FirstName, SecondName, ThirdName, LastName, 
DateOfBirth, Gender, Address, Phone, Email, ImagePath, NationalityCountryID)

VALUES (@NationalNumber, @FirstName, @SecondName, @ThirdName, @LastName,
@DateOfBirth, @Gender, @Address, @Phone, @Email, @ImagePath, @NationalityCountryID);
Select SCOPE_IDENTITY(); ";

        public static int AddNewPerson(string NationalNumber, string FirstName, string SecondName, string ThirdName, string LastName,
            DateOnly DateOfBirth, int Gender, string Address, string Phone, string ? Email, string ImagePath, int ? NationalityCountryID)
        {
            int TheLastInsertedPersonID = -1;
            SqlConnection connection = dbSettings.DbConnection();
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(Query,connection);
                command.Parameters.AddWithValue("@NationalNumber", NationalNumber);
                command.Parameters.AddWithValue("@FirstName", FirstName);
                command.Parameters.AddWithValue("@SecondName", SecondName);
                command.Parameters.AddWithValue("@ThirdName", ThirdName);
                command.Parameters.AddWithValue("@LastName", LastName);
                command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
                command.Parameters.AddWithValue("@Gender", Gender);
                command.Parameters.AddWithValue("@Address", Address);
                command.Parameters.AddWithValue("@Phone", Phone);
                if (Email is not null) // Email is optional, so we need to check if it's null before adding it as a parameter
                {
                    command.Parameters.AddWithValue("@Email", Email);
                }
                else
                {
                    command.Parameters.AddWithValue("@Email", DBNull.Value);
                }

                command.Parameters.AddWithValue("@ImagePath", ImagePath);

                command.Parameters.AddWithValue("@NationalityCountryID", NationalityCountryID);

               object reader =  command.ExecuteScalar(); // Execute the query and get the last inserted ID

                if(reader is not null && int.TryParse(reader.ToString(), out int lastInsertedID))
                {
                    TheLastInsertedPersonID = lastInsertedID;
                }
                
            }
            catch { }
            finally
            {
                connection.Close();
            }
            return TheLastInsertedPersonID;
        }


    }
}
