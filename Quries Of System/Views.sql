Create View ShowBasicPersonInfo
As 

Select People.PersonID , People.NationalNumber , People.FirstName , People.SecondName, People.ThirdName  ,People.LastName , 
 Gender =
 Case
 When  People.Gender = 1 Then 'M'
 When People.Gender = 2 Then 'F'
 End 
 , Countries.CountryName As Nationality , People.Phone , People.Email 
from People
Inner Join Countries On Countries.CountryID = People.NationalityCountryID;

Select * from ShowBasicPersonInfo;
Select * from People ;

Create View DetailedPersonInfo AS
Select ShowBasicPersonInfo.* , People.Address , People.DateOfBirth , People.ImagePath , People.NationalityCountryID 

from ShowBasicPersonInfo
Inner Join People 
On People.PersonID = ShowBasicPersonInfo.PersonID;