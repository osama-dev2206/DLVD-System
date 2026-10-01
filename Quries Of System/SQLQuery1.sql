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

 Select Applications.ApplicationStatus 
 from Applications
 Inner Join LocalDrivingLicenseApplications On
 LocalDrivingLicenseApplications.LApplicationID = Applications.ApplicationID
 where LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = 11;
 

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


select * from LocalDrivingLicenseApplicationsView where [Full Name] Like ('%' + 'm' + '%');


select * from LocalDrivingLicenseApplicationsView where Lower([Full Name]) Like Lower('%M%');

-- Get PersonID From LDLAPP
Select Applications.ApplicantPersonID
from Applications 
Inner Join LocalDrivingLicenseApplications On 
LocalDrivingLicenseApplications.LApplicationID = Applications.ApplicationID
where LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID =9;

Select * , LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID , 
LocalDrivingLicenseApplications.LLicenseClassID
from DetailedApplicationInfo
Inner Join LocalDrivingLicenseApplications On LocalDrivingLicenseApplications.LApplicationID
= DetailedApplicationInfo.ApplicationID;


Select * from DetailedApplicationInfo
where DetailedApplicationInfo.LocalDrivingLicenseApplicationID = 11;

select * from LocalDrivingLicenseApplicationsView;

select * from ShowBasicInfoLocalDrivingLicense;

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




Select Count(*) as NumOfPassedTests 
from Test
Inner Join TestAppointments on Test.AppointmentOfTestID = TestAppointments.TestAppointmentID
Inner Join LocalDrivingLicenseApplications On LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID
= TestAppointments.TestAppointmentForLocalDrivingLicenseAppID
Inner Join Applications On Applications.ApplicationID = LocalDrivingLicenseApplications.LApplicationID
where Test.TestResult = 1 and
Applications.ApplicantPersonID = 11;


Select * from TestAppointments ;

Insert Into TestAppointments(AppointmentTestTypeID,
TestAppointmentForLocalDrivingLicenseAppID,
AppointmentDateTime,
PaidFees
,CreatedByUserID
,IsLocked,
RetakeApplicationID)
values
(   
'@TestTypeID', '@LocalDrivingLicenseApplicationID', '@AppointmentDateTime',
'@PaidFees', '@CreatedByUserID', '@IsLocked', '@RetakeApplicationID'
);

Select SCOPE_IDENTITY();

Select * from TestTypes
where TestTypeID =1 ;

Select * from TestAppointments
where TestAppointments.TestAppointmentID = 1 ; -- Vision Test Appointment


Select TestAppointments.TestAppointmentID , TestAppointments.AppointmentDateTime ,
TestAppointments.PaidFees , TestAppointments.IsLocked 
from TestAppointments
where TestAppointments.TestAppointmentID = 1 ;

Select * from LocalDrivingLicenseApplications

Select R='T'
from TestAppointments
Inner Join TestTypes On TestTypes.TestTypeID = TestAppointments.AppointmentTestTypeID
Inner Join LocalDrivingLicenseApplications on
LocalDrivingLicenseApplicationID = TestAppointments.TestAppointmentForLocalDrivingLicenseAppID
Where LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID =11
and TestTypes.TestTypeID = 1 ;-- if has appointment (vision Test)

-- Get Num Of Trials For Vision Test ---------
Select Count(*) as NumOfTrials
From Test
Inner Join TestAppointments On TestAppointments.TestAppointmentID = Test.AppointmentOfTestID
Inner Join LocalDrivingLicenseApplications On 
LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = 
TestAppointments.TestAppointmentForLocalDrivingLicenseAppID

where LocalDrivingLicenseApplicationID =11 -- Local Driving License Application ID
and TestAppointments.AppointmentTestTypeID = 1 ; -- Vision Test ID


Select * from TestTypes;
Select * from TestAppointments;

Insert Into Test(AppointmentOfTestID,TestResult,Notes,CreatedByUserID)
values (
'@TestAppointmentID', '@TestResult', '@Notes', '@CreatedByUserID');

Select * from Test;

Select * from TestAppointments;

Update TestAppointments
set IsLocked = 1
where TestAppointments.TestAppointmentID = '@TestAppointmentID'
and TestAppointments.AppointmentTestTypeID =1;


Select R = 'T' 
From TestAppointments 
Inner Join TestTypes On TestTypes.TestTypeID = TestAppointments.AppointmentTestTypeID
Inner Join LocalDrivingLicenseApplications On
LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = 
TestAppointments.TestAppointmentForLocalDrivingLicenseAppID
Inner Join Applications On Applications.ApplicationID = LocalDrivingLicenseApplications.LApplicationID
Inner Join Test On Test.AppointmentOfTestID = TestAppointments.TestAppointmentID

where TestTypeID = @TestTypeID -- vision,written,practical 
And 
LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = @LocalApplicationID -- applicant person id
and
Test.TestResult =1 ;



Select TestAppointments.TestAppointmentID , TestAppointments.AppointmentDateTime ,
TestAppointments.PaidFees , TestAppointments.IsLocked 
from TestAppointments
Inner Join LocalDrivingLicenseApplications 
On LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = TestAppointments.TestAppointmentForLocalDrivingLicenseAppID
where TestAppointments.TestAppointmentID = 1 
and LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = '@LDLAppID'


select * from LocalDrivingLicenseApplicationsView;

Select Count(*) as NumOfPassedTests 
from Test
Inner Join TestAppointments on Test.AppointmentOfTestID = TestAppointments.TestAppointmentID
Inner Join LocalDrivingLicenseApplications On LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID
= TestAppointments.TestAppointmentForLocalDrivingLicenseAppID
Inner Join Applications On Applications.ApplicationID = LocalDrivingLicenseApplications.LApplicationID
where Test.TestResult = 1 and
LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = 21;


Select * from TestAppointments;
Select * from TestTypes;

Select TestAppointments.* from TestAppointments  where TestAppointments.TestAppointmentID = 1 ;

Update TestAppointments Set AppointmentDateTime
= '@AppointmentDateTime' 
where TestAppointments.TestAppointmentID = 1 ;

Select TestAppointments.* from TestAppointments  where TestAppointments.TestAppointmentID =  25;
-------------------------------

Select R= 'T' 
from TestAppointments
inner Join LocalDrivingLicenseApplications on
LocalDrivingLicenseApplicationID = TestAppointments.TestAppointmentForLocalDrivingLicenseAppID
where TestAppointments.TestAppointmentID = 1
and TestAppointments.IsLocked =1 -- Test Finished
and TestAppointments.AppointmentTestTypeID = 1 -- Vision ;




-- Has Taken Test And Failed (EX)
Select R = 'T'
from (

Select Test.TestID,Test.TestResult , Test.AppointmentOfTestID , LocalDrivingLicenseApplicationID 
, TestAppointments.IsLocked
from Test 
Inner Join TestAppointments On TestAppointments.TestAppointmentID = Test.AppointmentOfTestID
Inner Join LocalDrivingLicenseApplications On 
LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = 
TestAppointments.TestAppointmentForLocalDrivingLicenseAppID  
where TestAppointmentID = 20 -- Specific TestAppointment ID
and Test.TestResult = 0 -- Failed 
and TestAppointments.IsLocked = 1 -- Test Finished
and TestAppointments.AppointmentTestTypeID = 1 -- Vision Test ID

) R ;

-- Get Test Result For Specific Test Appointment ID
Select top 1 Test.TestResult
from Test
Inner Join TestAppointments On TestAppointments.TestAppointmentID = Test.AppointmentOfTestID
Inner Join LocalDrivingLicenseApplications On
TestAppointments.TestAppointmentForLocalDrivingLicenseAppID
= LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID
where LocalDrivingLicenseApplicationID = 20 -- Specific TestAppointment ID
and TestAppointments.AppointmentTestTypeID =1 -- Vision Test ID 
;

-- Is This Local Driving License With This Type Has Taken The exam before??

Select R = 'T'
From TestAppointments
where TestAppointments.TestAppointmentForLocalDrivingLicenseAppID =20
and TestAppointments.AppointmentTestTypeID =1 -- vision ex
;


Select  top 1 Test.TestResult
from Test
Inner Join TestAppointments On TestAppointments.TestAppointmentID = Test.AppointmentOfTestID
Inner Join LocalDrivingLicenseApplications On
TestAppointments.TestAppointmentForLocalDrivingLicenseAppID
= LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID
where LocalDrivingLicenseApplicationID = 11  -- Specific TestAppointment ID
and TestAppointments.AppointmentTestTypeID =1 



SELECT TOP 1 Test.TestResult
FROM Test
INNER JOIN TestAppointments
    ON TestAppointments.TestAppointmentID = Test.AppointmentOfTestID
INNER JOIN LocalDrivingLicenseApplications
    ON TestAppointments.TestAppointmentForLocalDrivingLicenseAppID
       = LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID
WHERE LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID
      = 44
AND TestAppointments.AppointmentTestTypeID = 1
ORDER BY TestAppointments.AppointmentDateTime DESC;


Select * from Applications;
Select * from ApplicationTypes;
Select * from LocalDrivingLicenseApplications;

Select  * from DetailedApplicationInfo;

Select
 TestAppointments.* from TestAppointments  
 order by TestAppointmentID desc ;

 Select * From ApplicationTypes;
 Select * from TestTypes;

 -- Get Retake Application ID By Local Driving License Application 
 Select TestAppointments.RetakeApplicationID , 
 ApplicationTypes.ApplicationFees as [Retake Application Fees] , 
 [Total Application Fees] = ApplicationFees + TestTypeFees
 from TestAppointments 
 Inner Join LocalDrivingLicenseApplications on TestAppointments.TestAppointmentForLocalDrivingLicenseAppID = LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID
 Inner Join TestTypes On TestTypes.TestTypeID = TestAppointments.AppointmentTestTypeID
 Inner Join Applications On Applications.ApplicationID = RetakeApplicationID
 Inner Join ApplicationTypes On Applications.ApplicationTypeID = ApplicationTypes.ApplicationTypeID

 Where RetakeApplicationID is not null and TestAppointments.AppointmentTestTypeID = 1 -- vision 
 and TestAppointments.TestAppointmentForLocalDrivingLicenseAppID  = 47 ;



Select * from TestAppointments
order by TestAppointmentID desc;

-- Get The last inserted retake application ID for a specific local driving license application and test type (Vision Test in this case)
Select top 1 TestAppointments.RetakeApplicationID
from TestAppointments 
inner Join Test on Test.TestID = TestAppointments.TestAppointmentID
where TestAppointmentForLocalDrivingLicenseAppID = 1050
and AppointmentTestTypeID =2 -- Written
and TestAppointments.IsLocked =0 -- Hasnot Finished
and Test.TestResult = 0 -- Failed
order by TestAppointmentID desc;

select * from TestTypes;
select * from ApplicationTypes;



SELECT TOP 1 Test.TestResult
FROM TestAppointments
inner Join Test on Test.TestID = TestAppointments.TestAppointmentID

WHERE TestAppointmentForLocalDrivingLicenseAppID = 1053
  AND AppointmentTestTypeID = 3
ORDER BY TestAppointmentID DESC ;

-- check if the pervious test has finished or not (for retake)

Select top 1  R = 'T'
from TestAppointments 
where TestAppointments.TestAppointmentForLocalDrivingLicenseAppID = 1053
and TestAppointments.AppointmentTestTypeID = 3
and TestAppointments.IsLocked = 1 -- Test Finished
order by TestAppointmentID DESC ;


Select top 1  Test.TestResult
from TestAppointments 
Inner Join Test on Test.TestID = TestAppointments.TestAppointmentID
where TestAppointments.TestAppointmentForLocalDrivingLicenseAppID = 1053
and TestAppointments.AppointmentTestTypeID = 3
and TestAppointments.IsLocked = 1 -- Test Finished
order by TestAppointmentID DESC


select * from TestAppointments
Inner Join Test on Test.TestID = TestAppointments.TestAppointmentID
where TestAppointments.TestAppointmentForLocalDrivingLicenseAppID = 1055

Select top 1 Test.TestResult
from TestAppointments
Inner Join Test on Test.AppointmentOfTestID = TestAppointments.TestAppointmentID

where 
Test.TestResult = 0 and TestAppointments.IsLocked = 1 -- Test Finished
and TestAppointments.TestAppointmentForLocalDrivingLicenseAppID = 1055
and AppointmentTestTypeID =1
order by TestAppointmentID DESC;

Select * from Applications;
Select * from ApplicationTypes;
Select * from TestTypes;

Select * from TestAppointments
order by TestAppointmentID desc;


-- Driver
Select * from Drivers;

Insert Into Drivers(DriverPersonID,CreatedByUserID,CreateDate)
values ('@PersonID','@CreatedByUserID','@CreateDate');


--- License 

-- If there is lic or not 
Select Licenses.LicenseID
From Licenses 
where Licenses.LicApplicationID = 1

-- is this Driver Registered Before or not
Select *
from Drivers
Where Drivers.DriverPersonID = 11;


/*
## Issue Reason :

1-first time 

2-renew 

3-replacement for damage 

4-replacement for lost

*/

Select * from Licenses;
Select SCOPE_IDENTITY(); 

Insert Into Licenses
(
    LicApplicationID,
    LicDriverID,
    ClassOfLicenseID,
    IssueDate,
    ExpirationDate,
    Notes,
    PaidFees,
    IsActive,
    IssueReason,
    CreatedByUserID
)
values 
('@LicApplicationID', '@LicDriverID', 
'@ClassOfLicenseID', '@IssueDate', 
'@ExpirationDate', '@Notes', '@PaidFees', 
'@IsActive', '@IssueReason', '@CreatedByUserID');

Select * from Drivers;
Select * from Licenses;

Select LicenseClasses.ClassName ,
People.FirstName + ' ' + 
People.SecondName + ' ' + People.ThirdName + ' ' + People.LastName As FullName ,
Licenses.LicenseID , 
People.DateOfBirth , 
People.NationalNumber ,
Gender =
case
When People.Gender = 1 Then 'M'
When People.Gender = 2 Then 'F'
End ,
Licenses.IssueDate , Licenses.ExpirationDate , Licenses.IsActive
, Drivers.DriverID,
People.DateOfBirth , Licenses.Notes ,
IssueReason =
Case
 when Licenses.IssueReason = 1 Then 'First Time' 

when  Licenses.IssueReason = 2 then 'Renew' 

when  Licenses.IssueReason = 3 then 'Replacement For Damage' 

when  Licenses.IssueReason =  4 then 'Replacement For Lost'
End 

from Applications
Inner Join LocalDrivingLicenseApplications On 
LocalDrivingLicenseApplications.LApplicationID = Applications.ApplicationID
Inner Join Licenses On Licenses.LicApplicationID = Applications.ApplicationID
Inner Join Drivers On Drivers.DriverPersonID = Applications.ApplicantPersonID
Inner Join People On People.PersonID = Drivers.DriverPersonID
Inner Join LicenseClasses On LicenseClasses.LicenseClassID = Licenses.ClassOfLicenseID

--
Select * From LicenseClasses;
Select * from Licenses;
---
Select * from DriverLicenseInfo
where ApplicationID =1069 ;

Select * from Drivers;

-- Get The License History For Specific Person (By PersonID) (Local)
Select Licenses.LicenseID ,
Licenses.LicApplicationID  , 
LicenseClasses.ClassName ,
Licenses.IssueDate ,
Licenses.ExpirationDate 
,Licenses.IsActive
from Licenses
Inner Join LicenseClasses On LicenseClasses.LicenseClassID = Licenses.ClassOfLicenseID
Inner Join Applications On Applications.ApplicationID = Licenses.LicApplicationID
where Applications.ApplicantPersonID = 7  ;


---------------- Drivers 

-- List Drivers
Select Drivers.DriverID , People.PersonID  ,
People.NationalNumber , 
People.FirstName + ' ' + People.SecondName + ' ' + People.ThirdName + ' ' + People.LastName As [Full Name] ,
Drivers.CreateDate , 
[Active License] =
(
Select Count(*) From Licenses 
where Licenses.LicDriverID = Drivers.DriverID
)

From Drivers
Inner Join People on People.PersonID = Drivers.DriverPersonID

Select * from ListDrivers
where DriverID =1 ;

Select * from ListDrivers
where PersonID =7 ;


Select * from ListDrivers
where NationalNumber =  'n1';

Select * from ListDrivers
where [Full Name] like '%' + 'M' + '%';


Select R = 'T'
from Licenses
Inner join Applications on Applications.ApplicationID = Licenses.LicApplicationID
where Applications.ApplicantPersonID =11 
and Licenses.IsActive = 1 
and ClassOfLicenseID =1 ;