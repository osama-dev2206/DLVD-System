Create Database DLVD;
use DlVD; 

-- People And Contries 
create Table Countries
(
CountryID int not null Primary Key Identity(1,1) , 
CountryName nvarchar(50) 
);

Create Table People
(
PersonID int not null Primary Key Identity(1,1) ,
NationalNumber nvarchar(20) not null Unique , 
FirstName nvarchar(20) not null ,
SecondName nvarchar(20) not null , 
LastName nvarchar(20) not null ,
DateOfBirth date not null ,
Gender tinyint not null , 
Address nvarchar(500) not null ,
Phone nvarchar(20) not null , 
Email nvarchar(50) not null ,
ImagePath nvarchar(250) null ,
NationalityCountryID int not null Foreign Key References Countries(CountryID) 
);

alter table People 
Add Constraint UQ_Phone 
Unique(Phone);

alter table People 
Add Constraint UQ_Email 
Unique(Email);

alter table People 
Add Constraint UQ_NationalNumber
Unique(NationalNumber);


-- Users (admin of the system) 
Create Table Users
(
UserID int not null Primary Key Identity(1,1) , 
UserPersonID int not null Foreign Key References People(PersonID) ,
UserName nvarchar(20) not null UNIQUE,
Password nvarchar(20) not null , 
IsActive bit not null 
);

-- Drivers 
Create Table Drivers
(
DriverID int not null Primary Key Identity(1,1) , 
DriverPersonID int not null Foreign Key References People(PersonID) ,
CretatedByUserID int not null Foreign Key References Users(UserID) , 
CreateDate date not null default ( CAST(GETDATE() As Date) ) 
);

-- Applications (Generliazed Table)

Create Table ApplicationTypes
(
ApplicationTypeID Int not null Primary Key Identity(1,1) , 
ApplicationTypeTitle nvarchar(150) not null  Unique  ,
ApplicationFees smallmoney null 
);

Insert Into ApplicationTypes(ApplicationTypeTitle,ApplicationFees)
values( 'New Local Driving License Service',15);
Insert Into ApplicationTypes(ApplicationTypeTitle,ApplicationFees)
values( 'Renew Driving License Service',5);
Insert Into ApplicationTypes(ApplicationTypeTitle,ApplicationFees)
values( 'Replacemnet for Lost Driving License',10);
Insert Into ApplicationTypes(ApplicationTypeTitle,ApplicationFees)
values( 'Replacemnet for A Damaged Driving License',5);
Insert Into ApplicationTypes(ApplicationTypeTitle,ApplicationFees)
values( 'Release Detained Driving License',15);
Insert Into ApplicationTypes(ApplicationTypeTitle,ApplicationFees)
values( 'New International Driving License',50);
Insert Into ApplicationTypes(ApplicationTypeTitle,ApplicationFees)
values( 'Retake Test',5);

select * from ApplicationTypes; -- lookup table 

Create Table Applications
(
ApplicationID int not null  Primary Key  Identity(1,1)  ,
ApplicantPersonID int not null Foreign Key References People(PersonID) ,
ApplicationDateTime datetime not null  ,
ApplicationTypeID int not null Foreign Key References ApplicationTypes(ApplicationTypeID) ,
ApplicationStatus tinyint not null , 
LastStatusDateTime datetime null ,
PaiedFees SmallMoney not null , 
CreatedByUserID int not null Foreign Key References  Users(UserID) 
);

alter table Applications 
Add Constraint DefaultAppDateTime
Default GetDate() for ApplicationDate ; 

-- 1 new , 2 cancelled  , 3 completed  
alter table Applications
Add Constraint CHK_AppStatus 
Check(ApplicationStatus in (1,2,3) ) ;

alter table Applications 
Add Constraint Default_ApplicationStatus 
Default 1 for ApplicationStatus ;

-- Local Driving License 
Create Table LicenseClasses -- lookup table 
(
LicenseClassID int not null primary key identity(1,1) , 
ClassName nvarchar(50) not null ,
ClassDescription nvarchar(50) null , 
MinimumAllowedAge tinyint not null ,
DefaultValidityLength tinyint not null ,
ClassFees smallmoney not null 
);

Insert Into LicenseClasses
values('Class 1-Small Motorcycle License','it allows the driver to drive small motorcycles',18,5,15);
Insert Into LicenseClasses
values('Class 2-Heavy Motocycle License','it allows the driver to drive heavy motorcycles',21,5,30);
Insert Into LicenseClasses
values('Class 3-Ordinary Driving License','it allows the driver to drive normal cars',18,10,20);
Insert Into LicenseClasses
values('Class 4-Commercial Driving License','it allows the driver to drive taxi/limosine cars',21,10,200);
Insert Into LicenseClasses
values('Class 5-Agricultural Driving License','it allows the driver to drive Agricultural and work vehicles used in farms',21,10,50);
Insert Into LicenseClasses
values('Class 6-Small And Medium Bus License','it allows the driver to drive bus',21,10,300);
Insert Into LicenseClasses
values('Class 7-Truck And Heavy Vechicle License','it allows the driver to drive truck and heavy vehicles',21,10,300);


-- LocalDrivingLicenseApplications IS-A Application 
Create Table LocalDrivingLicenseApplications
(
LocalDrivingLicenseApplicationID int not null Primary Key identity(1,1) ,
LApplicationID int not null Foreign Key References Applications(ApplicationID) ,
LLicenseClassID int not null Foreign Key References LicenseClasses(LicenseClassID) 
);


-- Test Types && Test Appointment  

Create Table TestTypes -- lookup table 
(
TestTypeID int not null Identity(1,1) primary key , 
TestTypeTitle nvarchar(100) not null , 
TestTypeDescription nvarchar(500) null ,
TestTypeFees smallmoney not null 
);
Insert Into TestTypes
values('Vision Test','This assesses the aplicant`s visual acuity to ensure have suffiecent vision to drive',10);
Insert Into TestTypes 
values('Written Test','Written test for driving license',20);
Insert Into TestTypes
values ('Practical Test','Practical test (stress test) for driving license',30);

Create Table TestAppointments
(
TestAppointmentID int not null Primary Key Identity(1,1) ,
AppointmentTestTypeID int not null Foreign Key References  TestTypes(TestTypeID) ,
TestAppointmentForLocalDrivingLicenseAppID int not null 
Foreign Key References LocalDrivingLicenseApplications(LocalDrivingLicenseApplicationID),
AppointmentDateTime smalldatetime not null , 
PaidFees smallmoney not null , 
CreatedByUserID int not null Foreign Key References  Users(UserID) ,
IsLocked bit not null 
);

alter Table TestAppointments
Add RetakeApplicationID int null Foreign Key References Applications(ApplicationID) 

--  Tests
Create Table Test 
(
TestID int not null Primary Key Identity(1,1) , 
AppointmentOfTestID int not null Foreign Key References TestAppointments(TestAppointmentID) ,
TestResult bit null , 
Notes nvarchar(500) null ,
CreatedByUserID int not null Foreign Key References  Users(UserID) 
);

-- Licenses 
Create Table Licenses 
(
LicenseID int not null Primary Key IDentity(1,1) , 
LicApplicationID int not null Foreign Key References Applications(ApplicationID) ,
LicDriverID int not null Foreign Key References Drivers(DriverID) ,
ClassOfLicenseID int not null foreign Key References LicenseClasses(LicenseClassID) ,
IssueDate date default CAST( GETDATE() AS Date) not null ,
ExpirationDate date not null ,
Notes nvarchar(500) null ,
PaidFees smallmoney not null , 
IsActive bit not null ,
-- issue reason : 1-first time , 2-renew , 3-replacement for damage , 4-replacement for lost 
IssueReason tinyint not null Check(IssueReason in (1,2,3,4) ) ,
CreatedByUserID int not null Foreign Key References Users(UserID) 
);


--- Detain License 
Create Table DetainedLicenses
(
DetainID int not null identity(1,1) primary key , 
DetainedLicenseID int not null Foreign Key References Licenses(LicenseID), 
DetainDateTime datetime not null default GETDATE() ,
FineFees smallmoney not null , 
ISReleased bit not null , 
CreatedByUserID int not null Foreign Key References Users(UserID) , 
ReleasedDateTime datetime null , 
ReleasedByUserID int null Foreign Key References Users(UserID) ,
ReleaseApplicationID int null foreign Key References Applications(ApplicationID) 
);

alter table DetainedLicenses
add Constraint Default_ISReleased
Default 0 for ISReleased ;

alter table LicenseClasses 
Add Constraint Default_MinAge 
Default 18 for [MinimumAllowedAge];


