using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection.PortableExecutable;
using System.Text;

namespace DataAccessLayer
{
    public static class clsGetAllLocalApps
    {
        private static string Query = @" Select LocalDrivingLicenseApplications.LApplicationID as 'L.D.LAppID' ,
 LicenseClasses.ClassName as 'Driving Class' ,
 People.NationalNumber as 'National No' ,
CONCAT( People.FirstName , ' ' , People.SecondName , ' ' , People.ThirdName ,' ' ,People.LastName) As [Full Name] ,
Applications.ApplicationDateTime ,
(
Select Count(*) 
from Test 
Inner Join TestAppointments On TestAppointments.TestAppointmentForLocalDrivingLicenseAppID = LocalDrivingLicenseApplicationID
where Test.TestResult=1 
and 
TestAppointments.TestAppointmentForLocalDrivingLicenseAppID = LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID

) as [Passed Tests] ,
Status =
Case
When Applications.ApplicationStatus =1 then 'New' 
When Applications.ApplicationStatus =2 then 'Cancelled'
When Applications.ApplicationStatus =3 then 'Completed'
End

from LocalDrivingLicenseApplications
 Inner Join LicenseClasses On LocalDrivingLicenseApplications.LLicenseClassID = LicenseClasses.LicenseClassID
 Inner Join Applications On Applications.ApplicationID = LocalDrivingLicenseApplications.LApplicationID
 Inner Join People On People.PersonID = Applications.ApplicantPersonID ;";


        public static DataTable GetAllLocalDrivingLicenseApplications()
        {
            var connection = dbSettings.DbConnection();   
            DataTable dt = new DataTable();
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(Query, connection);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if(reader is not null && reader.HasRows)
                    {
                        dt.Load(reader);
                    }
                }

            }
            catch { }
            finally
            {
                connection?.Close();
            }
            return dt;
        }

    }
}
