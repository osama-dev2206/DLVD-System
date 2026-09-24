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


------------- Users 
Create View DetailsUserInfo As  
Select DetailedPersonInfo.* , Users.UserID , Users.UserName ,
Users.Password , Users.IsActive 
from DetailedPersonInfo
Inner Join Users
On Users.UserPersonID = DetailedPersonInfo.PersonID ;


create view BasicUserInfo As 
SELECT UserID , UserPersonID ,
CONCAT(People.FirstName , ' ' , People.SecondName , ' ' , People.ThirdName , ' ' , People.LastName) As FullName
, UserName , IsActive 
FROM Users
Inner Join People On People.PersonID = Users.UserPersonID;

-----------------

-- Local

Create View LocalDrivingLicenseApplicationsView As 
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

 -----
 Create View DetailedApplicationInfo 
 as 
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

-------------------------------

Create View ShowBasicInfoLocalDrivingLicense
AS
Select LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID,
LocalDrivingLicenseApplications.LApplicationID ,
LicenseClasses.ClassName
from LocalDrivingLicenseApplications
Inner Join LicenseClasses on 
LicenseClasses.LicenseClassID = 
LocalDrivingLicenseApplications.LLicenseClassID;