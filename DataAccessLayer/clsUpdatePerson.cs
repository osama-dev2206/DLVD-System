using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer
{
    public static class clsUpdatePerson
    {

        static string query = @"UPDATE People
SET 
    NationalNumber       = @NationalNumber,
    FirstName            = @FirstName,
    SecondName           = @SecondName,
    ThirdName            = @ThirdName,
    LastName             = @LastName,
    DateOfBirth          = @DateOfBirth,
    Gender               = @Gender,
    Address              = @Address,
    Phone                = @Phone,
    Email                = @Email,
    ImagePath            = @ImagePath,
    NationalityCountryID = @NationalityCountryID
WHERE PersonID = @PersonID;";


        public static bool UpdatePerson(int personID,
    string nationalNumber, string firstName, string secondName, string thirdName, string lastName,
    DateOnly dateOfBirth, int gender, string address, string phone, string ?email, string? imagePath, int nationalityCountryID)
        {

            SqlConnection connection = dbSettings.DbConnection();
            bool res = false;

            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@PersonID", personID);
                command.Parameters.AddWithValue("@NationalNumber", nationalNumber);
                command.Parameters.AddWithValue("@FirstName", firstName);
                command.Parameters.AddWithValue("@SecondName", secondName);
                command.Parameters.AddWithValue("@ThirdName", thirdName);
                command.Parameters.AddWithValue("@LastName", lastName);
                command.Parameters.AddWithValue("@DateOfBirth", dateOfBirth);
                command.Parameters.AddWithValue("@Gender", gender);
                command.Parameters.AddWithValue("@Address", address);
                command.Parameters.AddWithValue("@Phone", phone);
                if (String.IsNullOrEmpty(email))
                {
                    command.Parameters.AddWithValue("@Email", DBNull.Value);
                }
                else
                {
                    command.Parameters.AddWithValue("@Email", email);
                }
                command.Parameters.AddWithValue("@ImagePath", imagePath);
                command.Parameters.AddWithValue("@NationalityCountryID", nationalityCountryID);

               int ?NumOfAffectedRows= command.ExecuteNonQuery();

                if(NumOfAffectedRows is not null && NumOfAffectedRows>0)
                    res = true;

            }
            catch { }
            finally
            {
                connection.Close();
            }
            return res;
        }


    }
}
