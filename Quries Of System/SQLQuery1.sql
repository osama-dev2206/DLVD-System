-- People 
Select People.PersonID , People.NationalNumber , People.FirstName , People.SecondName, People.ThirdName  ,People.LastName , 
 Gender =
 Case
 When  People.Gender = 1 Then 'M'
 When People.Gender = 2 Then 'F'
 End 
 , Countries.CountryName As Nationality , People.Phone , People.Email 
from People
Inner Join Countries On Countries.CountryID = People.NationalityCountryID;

select * from ShowBasicPersonInfo;

-- Insert record 
Insert Into People 
values ('N1','Sama','Mohammed','Abd-allah','Elgohry','1/1/2001', 2 , '12st main', '0121212122','sama12313@gamil.com','empty',1);

select * from People;
select * from ShowBasicPersonInfo where PersonID =1 ;


Select * from DetailedPersonInfo;
