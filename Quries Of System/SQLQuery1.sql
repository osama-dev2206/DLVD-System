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

Delete People
Where People.PersonID = 1; 

select * from People; 

Insert Into People 
values ('N2','Samia','Mohamoud','Abd-elrhamaan','Elgohry','1/1/2002', 2 , '1st main', '012562252','samia12313@gamil.com','empty',1);

-- People Main Table 
insert Into People ( NationalNumber , FirstName , SecondName , ThirdName , LastName , 
DateOfBirth,Gender , Address , Phone ,Email  , ImagePath , NationalityCountryID)
values ('@NationalNumber','@FirstName',
'@SecondName','@ThirdName','@LastName', '@DateOfBirth' ,
'@Gender','@Address' , '@Phone' ,'@Email' , 
'@ImagePath' , '@NationalityCountryID' );


Select Countries.CountryID 
From Countries
where Countries.CountryName = '@Name';

select SCOPE_IDENTITY()

select R='T'
from People
where People.NationalNumber = '@NationalNum';


select People.ImagePath
from People
where People.PersonID = '@PersonID'


------ Users 
select * from Users; 
insert into Users 
values(12,'osama.2006',121,1);

Select R = 'T'
from Users
where Users.Password = 121 and Users.UserName = 'osama.2006' ;

Select * from DetailedPersonInfo;

Select * from Users;

update Users set 
Password = '94rQO8MpdbNKmxjSxo7NEw==' ;

Select * from DetailsUserInfo
where Password = 121 and UserName = 'osama.2006' ;

Select R = 'T'
from Users
where Users.IsActive = 1
and UserID =1 ; 


Select Users.* 
From Users
Where Users.UserName = 'osama.2006';

Update Users 
Set 
UserName = '@UserName' , Password='@Pass' , IsActive ='@IsActive'
where UserID = 1 


SELECT UserID , UserPersonID ,
CONCAT(People.FirstName , ' ' , People.SecondName , ' ' , People.ThirdName , ' ' , People.LastName) As FullName
, UserName , IsActive 
FROM Users
Inner Join People On People.PersonID = Users.UserPersonID
 ;

 select * from BasicUserInfo 
 where IsActive = 1; -- Active 

 delete from Users 
 where UserID = '@'


 Select BasicUserInfo.*  From BasicUserInfo Where  UserID = 1

Select *  From BasicUserInfo Where  UserPersonID = 12;

 select * from BasicUserInfo  where IsActive = 1 ;


 select * from DetailedPersonInfo;

SELECT 'T' AS R
FROM   Users
WHERE  UserPersonID = 12;

Select * from DetailsUserInfo;

Select * from Users;

Insert Into Users (UserPersonID,UserName,Password,IsActive)
values 
( '@PersonID','@UserName' , '@Password' , '@IsActive' );

Select SCOPE_IDENTITY();