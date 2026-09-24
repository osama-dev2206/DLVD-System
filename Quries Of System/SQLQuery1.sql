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
update Users
set Password ='94rQO8MpdbNKmxjSxo7NEw==' 
where UserID =1 ;

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

-- Application Types
select * from ApplicationTypes;

Update ApplicationTypes 
Set ApplicationTypeTitle = '', 
ApplicationFees= 1 
where ApplicationTypeID =1 ;

select * from ApplicationTypes
where ApplicationTypeID =1 ;

-- Test Types 
alter Table TestTypes Add Constraint 
UQ_TestTitle Unique(TestTypeTitle);

Select * from TestTypes;

Update TestTypes 
Set TestTypeTitle ='' ,
TestTypeDescription = '' ,
TestTypeFees = '' 
where TestTypeID =1 ;


--- Application - Local Driving License ----------------------
Select * from LicenseClasses
where ClassName = '';
 
 Select Applications.* 
 from Applications
 where Applications.ApplicationID =1;

 /*
 Application Status :
1. new 
2.cancelled
3.completed 
 */

INSERT INTO Applications
(
    ApplicantPersonID,
    ApplicationDateTime,
    ApplicationTypeID,
    ApplicationStatus,
    LastStatusDateTime,
    PaidFees,
    CreatedByUserID
)
VALUES
(
    @ApplicantPersonID,
    @ApplicationDateTime,
    @ApplicationTypeID,
    @ApplicationStatus,
    @LastStatusDateTime,
    @PaidFees,
    @CreatedByUserID
);
Select SCOPE_IDENTITY();

Select * from LocalDrivingLicenseApplications;

Insert Into LocalDrivingLicenseApplications
values ('@ApplicationID','@LicenseClassID');
Select SCOPE_IDENTITY();

Delete Applications
where Applications.ApplicationID =1 ;

Select * from ApplicationTypes;

 /*
 Application Status :
1. new 
2.cancelled
3.completed 
 */
Select R = 'T' 
From LocalDrivingLicenseApplications as Local
Inner Join Applications  as app
On app.ApplicationID = local.LApplicationID
where
App.ApplicationStatus = 1 -- New (check on db)
and 
App.ApplicantPersonID = 11 -- related to the same person 
and 
Local.LLicenseClassID = 3;




Delete LocalDrivingLicenseApplications 
where LocalDrivingLicenseApplicationID in (3) ;

select * from LocalDrivingLicenseApplications
where LocalDrivingLicenseApplicationID = 1 ;

select * from Applications;

delete  Applications
truncate table LocalDrivingLicenseApplications

Delete Applications
where ApplicationID =2 ;

Update LocalDrivingLicenseApplications
Set LLicenseClassID = '@LicenseClassID'
where LocalDrivingLicenseApplicationID =   1 ;


Update Applications
Set 
ApplicationStatus = '@ApplicationStatus' ,
LastStatusDateTime = '@LastStatusDateTime' 
where Applications.ApplicationID = 1;

Select * from LicenseClasses 
where LicenseClassID =1 ;

Select * from ApplicationTypes;


Delete LocalDrivingLicenseApplications
where LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = 1;



 /*
 Application Status :
1. new 
2.cancelled
3.completed 
 */
 Select LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID as 'L.D.LAppID' ,
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
 Inner Join People On People.PersonID = Applications.ApplicantPersonID ;



 select * from LocalDrivingLicenseApplicationsView
 where Status = 'New';

 Select * from 
 LocalDrivingLicenseApplications 
 where LocalDrivingLicenseApplicationID = 8;

 Select * from Applications;

 Delete Applications 
 where Applications.ApplicationID =
(
Select LocalDrivingLicenseApplications.LApplicationID
from LocalDrivingLicenseApplications
where LocalDrivingLicenseApplicationID = '1111111'
) ;

-- TSQL
Begin Transaction ;

Declare @AppID Int ; 

Select @AppID = LocalDrivingLicenseApplications.LApplicationID
from LocalDrivingLicenseApplications
where LocalDrivingLicenseApplicationID = 11

Delete LocalDrivingLicenseApplications
where LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = @LocalAppID

Delete Applications
where Applications.ApplicationID = @AppID 

Commit  Transaction ;

Select * from LocalDrivingLicenseApplications;
Select * from Applications;

Update Applications
Set ApplicationStatus = 1
where Applications.ApplicationID 
= 
(
Select LocalDrivingLicenseApplications.LApplicationID
from LocalDrivingLicenseApplications
where LocalDrivingLicenseApplicationID = '1111111'
); 


 /*
 Application Status :
1. new 
2.cancelled
3.completed 
 */


Select * from Applications;

Select Applications.ApplicationID ,
Applications.ApplicantPersonID ,
Applications.ApplicationDateTime ,
ApplicationType = ApplicationTypes.ApplicationTypeTitle , 
ApplicationStatus = 
CASE
when ApplicationStatus =1 Then 'New'
when ApplicationStatus = 2 Then 'Cancelled'
When ApplicationStatus = 3 Then 'Completed'
END 
,
Applications.LastStatusDateTime ,
Applications.PaidFees ,
CreatedByUserName =
(
Select Users.UserName from Users 
where Users.UserID = Applications.CreatedByUserID
)

from Applications
Inner Join ApplicationTypes On
Applications.ApplicationTypeID = ApplicationTypes.ApplicationTypeID;


Select * from DetailedApplicationInfo
Where ApplicationID =1 ;

Select * from LocalDrivingLicenseApplications;

Select LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID,
LocalDrivingLicenseApplications.LApplicationID ,
LicenseClasses.ClassName
from LocalDrivingLicenseApplications
Inner Join LicenseClasses on 
LicenseClasses.LicenseClassID = 
LocalDrivingLicenseApplications.LLicenseClassID;

Select * from ShowBasicInfoLocalDrivingLicense
where LocalDrivingLicenseApplicationID =11;


select * from LocalDrivingLicenseApplicationsView where Lower([Full Name]) Like Lower('%M%');

-- Get PersonID From LDLAPP
Select Applications.ApplicantPersonID
from Applications 
Inner Join LocalDrivingLicenseApplications On 
LocalDrivingLicenseApplications.LApplicationID = Applications.ApplicationID
where LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID =9;



-- Test & Test Appointments 

Select * from TestTypes;

-- Check If The Person Has Finished vision Test Or Not (EX)
-- Will return True If The Test Has Finished 
Select R = 'T' 
From TestAppointments 
Inner Join TestTypes On TestTypes.TestTypeID = TestAppointments.AppointmentTestTypeID
Inner Join LocalDrivingLicenseApplications On
LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = 
TestAppointments.TestAppointmentForLocalDrivingLicenseAppID
Inner Join Applications On Applications.ApplicationID = LocalDrivingLicenseApplications.LApplicationID
Inner Join Test On Test.AppointmentOfTestID = TestAppointments.TestAppointmentID

where TestTypeID =1 
And 
Applications.ApplicantPersonID = 11
and
Test.TestResult =2 ;


