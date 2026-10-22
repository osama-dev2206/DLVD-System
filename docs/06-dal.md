# 06 – Data Access Layer (DAL) Documentation

[← Back to Index](./README.md)

---

## 1. Architectural Pattern and Design Principles

The **Data Access Layer (DAL)** (`DataAccessLayer.dll`, namespace `DataAccessLayer`) is responsible exclusively for database communication with Microsoft SQL Server.

### 1.1 Single Responsibility Principle (SRP) via Micro-Classes
Unlike traditional architectures that group all CRUD methods for a table into a single large class (e.g., `PersonDAL`), the DVLD project implements a **micro-class command pattern**. 

There are **93 specialized static classes** in the DAL. Each class typically encapsulates:
1. Exactly one SQL query or stored script (declared as a `private static string Query`).
2. Exactly one static method (with overloaded parameters if necessary).
3. The complete lifecycle of connection opening, parameter binding, command execution, and deterministic connection closure.

### 1.2 Connection & Command Management
All DAL classes obtain connections from the internal helper class [dbSettings.cs](file:///m:/Temp%20Comparison/My%20Solution/DataAccessLayer/dbSettings.cs):

```csharp
namespace DataAccessLayer
{
    internal static class dbSettings
    {
        static string ConnectionString =
            @"Server=OSAMA-PC;Database=MyDVLD;Integrated Security=True;TrustServerCertificate=True;";

        public static SqlConnection DbConnection()
        {
            return new SqlConnection(ConnectionString);
        }
    }
}
```

### 1.3 Execution Templates
Every DAL method adheres strictly to one of three ADO.NET execution templates:

#### Template A: Scalar Insert / Query Execution (`ExecuteScalar`)
Used for operations returning an auto-generated identity (`SCOPE_IDENTITY()`), an aggregate count (`COUNT(*)`), or an existence flag:
```csharp
public static int AddNewRecord(...)
{
    SqlConnection connection = dbSettings.DbConnection();
    int newID = -1;
    try
    {
        connection.Open();
        SqlCommand cmd = new SqlCommand(Query, connection);
        cmd.Parameters.AddWithValue("@Param1", val1);
        object result = cmd.ExecuteScalar();
        if (result != null && int.TryParse(result.ToString(), out int id))
        {
            newID = id;
        }
    }
    catch { /* Log or suppress */ }
    finally { connection.Close(); }
    return newID;
}
```

#### Template B: Modification / Command Execution (`ExecuteNonQuery`)
Used for `UPDATE` and `DELETE` commands, returning `true` if `cmd.ExecuteNonQuery() > 0`:
```csharp
public static bool UpdateRecord(...)
{
    SqlConnection connection = dbSettings.DbConnection();
    bool isSuccess = false;
    try
    {
        connection.Open();
        SqlCommand cmd = new SqlCommand(Query, connection);
        cmd.Parameters.AddWithValue("@Param1", val1);
        if (cmd.ExecuteNonQuery() > 0) isSuccess = true;
    }
    catch { }
    finally { connection.Close(); }
    return isSuccess;
}
```

#### Template C: Tabular / Dataset Retrieval (`SqlDataReader` into `DataTable`)
Used for grid binding and record retrieval:
```csharp
public static DataTable GetData(...)
{
    DataTable dt = new DataTable();
    SqlConnection connection = dbSettings.DbConnection();
    try
    {
        connection.Open();
        SqlCommand cmd = new SqlCommand(Query, connection);
        using (SqlDataReader reader = cmd.ExecuteReader())
        {
            if (reader.HasRows) dt.Load(reader);
        }
    }
    catch { }
    finally { connection.Close(); }
    return dt;
}
```

---

## 2. Category Grouping of DAL Classes

The 93 DAL classes are categorized below by business domain, detailing their queries, parameters, return types, and consuming BLL classes.

---

### 2.1 Person Data Access Classes

| Class Name | Primary Query / Table Accessed | Parameters | Return Type | Consuming BLL Class |
|---|---|---|---|---|
| `clsAddNewPerson` | `INSERT INTO People (...) VALUES (...); SELECT SCOPE_IDENTITY();` | `@NationalNumber`, `@FirstName`, `@SecondName`, `@ThirdName`, `@LastName`, `@DateOfBirth`, `@Gender`, `@Address`, `@Phone`, `@Email`, `@ImagePath`, `@NationalityCountryID` | `int` (New PersonID) | `clsPeople.Save()` |
| `clsUpdatePerson` | `UPDATE People SET NationalNumber=@NationalNumber, FirstName=@FirstName, ... WHERE PersonID=@PersonID;` | All person demographic parameters + `@PersonID` | `bool` | `clsPeople.Save()` |
| `clsDeletePerson` | `DELETE FROM People WHERE PersonID = @PersonID;` | `@PersonID` | `bool` | `clsPeople.Delete()` |
| `clsFindPersonBy` | Dynamic parameterized `SELECT * FROM ShowBasicPersonInfo WHERE [Column] = @Val` | Search criteria enum (PersonID, NationalNumber, Name, Phone, Email, etc.) + value | `DataTable` | `clsPeople.GetPersonBy...` |
| `clsCheckNationalNumExistence` | `SELECT R='T' FROM People WHERE NationalNumber = @NationalNumber;` | `@NationalNumber` | `bool` | `clsPeople.Save()` validation |
| `clsGetBPersonInfo` | `SELECT * FROM ShowBasicPersonInfo;` | None | `DataTable` | `clsPeople.GetPeople()` |
| `clsGetDetailsPersonInfoByPersonID` | `SELECT * FROM DetailedPersonInfo WHERE PersonID = @PersonID;` | `@PersonID` | `DataTable` | `clsPeople.FindPersonByID()` |
| `clsGetPersonImagePathOnly` | `SELECT ImagePath FROM People WHERE PersonID = @PersonID;` | `@PersonID` | `string` | Person photo viewing controls |

---

### 2.2 System User Data Access Classes

| Class Name | Primary Query / Table Accessed | Parameters | Return Type | Consuming BLL Class |
|---|---|---|---|---|
| `clsAddNewUser` | `INSERT INTO Users (UserPersonID, UserName, Password, IsActive) VALUES (@PersonID, @UserName, @Password, @IsActive); SELECT SCOPE_IDENTITY();` | `@PersonID`, `@UserName`, `@Password` (encrypted), `@IsActive` | `int` (New UserID) | `clsUsers.Save()` |
| `clsUpdateUser` | `UPDATE Users SET UserName=@UserName, Password=@Password, IsActive=@IsActive WHERE UserID=@UserID;` | `@UserID`, `@UserName`, `@Password`, `@IsActive` | `bool` | `clsUsers.Save()` |
| `clsDeleteUser` | `DELETE FROM Users WHERE UserID = @UserID;` | `@UserID` | `bool` | `clsUsers.DeleteUserByUserID()` |
| `clsFindUser` | `SELECT * FROM DetailsUserInfo WHERE ...` / `BasicUserInfo` | By UserID, UserName, PersonID, FullName, IsActive | `DataTable` | `clsUsers.FindUserBy...` |
| `clsGetAllUsers` | `SELECT * FROM BasicUserInfo;` | None | `DataTable` | `clsUsers.GetAllUsers()` |
| `clsCheckLoginInfo` | `SELECT R='T' FROM Users WHERE UserName=@UserName AND Password=@Password;` | `@UserName`, `@Password` (encrypted) | `bool` | `clsUsers.IsLoginValid()` |
| `clsCheckUserExistence` | `SELECT R='T' FROM Users WHERE UserName=@UserName;` / `WHERE UserPersonID=@PersonID;` | `@UserName` / `@PersonID` | `bool` | `clsUsers.IsUserNameExist()`, `IsUserISAPerson()` |
| `clsIsUserActive` | `SELECT R='T' FROM Users WHERE IsActive=1 AND (UserID=@ID / UserName=@Name / UserPersonID=@PID);` | Identifier + enum check mode | `bool` | `clsUsers.IsUserActiveBy...` |
| `clsGetUserByUserName` | `SELECT UserID, UserPersonID, UserName, Password, IsActive FROM Users WHERE UserName=@UserName AND Password=@Password;` | `@UserName`, `@Password` | `DataTable` | `clsUsers.GetUserObjByUsernameAndPassword()` |

---

### 2.3 Base Application Data Access Classes

| Class Name | Primary Query / Table Accessed | Parameters | Return Type | Consuming BLL Class |
|---|---|---|---|---|
| `clsAddNewApplicationToApplicationTable` | `INSERT INTO Applications (ApplicantPersonID, ApplicationDateTime, ApplicationTypeID, ApplicationStatus, LastStatusDateTime, PaiedFees, CreatedByUserID) VALUES (...); SELECT SCOPE_IDENTITY();` | `@ApplicantPersonID`, `@ApplicationDateTime`, `@ApplicationTypeID`, `@ApplicationStatus`, `@LastStatusDateTime`, `@PaidFees`, `@CreatedByUserID` | `int` (New ApplicationID) | `clsApplications.SaveApplication()` |
| `clsUpdateApplication` | `UPDATE Applications SET ApplicationStatus=@ApplicationStatus, LastStatusDateTime=@LastStatusDateTime WHERE ApplicationID=@ApplicationID;` | `@ApplicationID`, `@ApplicationStatus`, `@LastStatusDateTime` | `bool` | `clsApplications.UpdateApplicationStatus()` |
| `clsDeleteApplication` / `clsDeleteApplicationByApplicationID` | `DELETE FROM Applications WHERE ApplicationID = @ApplicationID;` | `@ApplicationID` | `bool` | `clsApplications.DeleteApplication()` |
| `clsGetApplicationByAppID` | `SELECT * FROM Applications WHERE ApplicationID = @ApplicationID;` | `@ApplicationID` | `DataTable` | `clsApplications.GetApplicationObjByAppID()` |
| `clsGetDetailedAppInfoByApplicationID` | `SELECT * FROM DetailedApplicationInfo WHERE ApplicationID = @ApplicationID;` | `@ApplicationID` | `DataTable` | `clsApplications.GetApplicationDetailsByApplicationID()` |

---

### 2.4 Local Driving License Application Data Access Classes

| Class Name | Primary Query / Table Accessed | Parameters | Return Type | Consuming BLL Class |
|---|---|---|---|---|
| `clsAddNewLocalDrivingLicense` | `INSERT INTO LocalDrivingLicenseApplications (LApplicationID, LLicenseClassID) VALUES (@ApplicationID, @LicenseClassID); SELECT SCOPE_IDENTITY();` | `@ApplicationID`, `@LicenseClassID` | `int` (New LDLAppID) | `clsLocalDrivingLicenseApplications.SaveLocalDrivingLicenseApplication()` |
| `clsUpdateLocalDrivingLic` | `UPDATE LocalDrivingLicenseApplications SET LLicenseClassID=@LicenseClassID WHERE LocalDrivingLicenseApplicationID=@LocalAppID;` | `@LocalAppID`, `@LicenseClassID` | `bool` | `clsLocalDrivingLicenseApplications.SaveLocalDrivingLicenseApplication()` |
| `clsDeleteLocalDrivingLicense` | **Explicit T-SQL Transaction:** `BEGIN TRANSACTION; SELECT @AppID = LApplicationID ...; DELETE LocalDrivingLicenseApplications ...; DELETE Applications ...; COMMIT TRANSACTION;` | `@LocalAppID` | `bool` | `clsLocalDrivingLicenseApplications.Delete()` |
| `clsGetAllLocalApps` | `SELECT * FROM LocalDrivingLicenseApplicationsView;` | None | `DataTable` | `clsLocalDrivingLicenseApplications.GetAllLocalApps()` |
| `clsFindLocalAppUsing` | Parameterized search on `LocalDrivingLicenseApplicationsView` by LDLAppID, NationalNo, FullName, Status | Search criteria + search value | `DataTable` | Filtered search methods on `clsLocalDrivingLicenseApplications` |
| `clsGetLocalDrivingApp` | `SELECT * FROM LocalDrivingLicenseApplications WHERE LocalDrivingLicenseApplicationID = @ID;` | `@ID` | `DataTable` | `clsLocalDrivingLicenseApplications.FindLocalDrivingLicenseApplicationByLocalID()` |
| `clsIsPersonHasRegisteredBefore` | `SELECT A.ApplicationID FROM Applications A INNER JOIN LocalDrivingLicenseApplications L ON A.ApplicationID=L.LApplicationID WHERE A.ApplicantPersonID=@PersonID AND L.LLicenseClassID=@LicenseClassID AND A.ApplicationStatus=1;` | `@PersonID`, `@LicenseClassID` | `int` (Existing AppID or -1) | Pre-save validation in `clsLocalDrivingLicenseApplications` |
| `clsUpdateApplicationStatusUsingLocalDriving` | `UPDATE Applications SET ApplicationStatus=@ApplicationStatus, LastStatusDateTime=@LastStatusDateTime WHERE ApplicationID = (SELECT LApplicationID FROM LocalDrivingLicenseApplications WHERE LocalDrivingLicenseApplicationID=@LocalAppID);` | `@LocalAppID`, `@ApplicationStatus`, `@LastStatusDateTime` | `bool` | Application cancellation / status update |
| `clsGetNumOfPassedTestsByLDLAppID` | `SELECT COUNT(*) FROM Test T INNER JOIN TestAppointments A ON T.AppointmentOfTestID=A.TestAppointmentID WHERE T.TestResult=1 AND A.TestAppointmentForLocalDrivingLicenseAppID=@LocalAppID;` | `@LocalAppID` | `int` (0 to 3) | Testing stage evaluation |
| `clsGetBasicLocalLicenseApplicationInfo` | `SELECT * FROM ShowBasicInfoLocalDrivingLicense WHERE LocalDrivingLicenseApplicationID = @LocalAppID;` | `@LocalAppID` | `DataTable` | UI header info |
| `clsGetApplicantPersonIDByLDLAPPID` | `SELECT ApplicantPersonID FROM Applications INNER JOIN LocalDrivingLicenseApplications ON Applications.ApplicationID=LocalDrivingLicenseApplications.LApplicationID WHERE LocalDrivingLicenseApplicationID=@LocalAppID;` | `@LocalAppID` | `int` (Applicant PersonID) | Applicant resolution |

---

### 2.5 Test Appointment and Examination Data Access Classes

| Class Name | Primary Query / Table Accessed | Parameters | Return Type | Consuming BLL Class |
|---|---|---|---|---|
| `clsAddNewTestAppointment` | `INSERT INTO TestAppointments (AppointmentTestTypeID, TestAppointmentForLocalDrivingLicenseAppID, AppointmentDateTime, PaidFees, CreatedByUserID, IsLocked, RetakeApplicationID) VALUES (...); SELECT SCOPE_IDENTITY();` | TestTypeID, LocalAppID, AppointmentDateTime, PaidFees, UserID, IsLocked, RetakeApplicationID | `int` (New TestAppointmentID) | `clsAbTestAppointments.AddNewTestAppointment()` |
| `clsUpdateTestAppointment` | `UPDATE TestAppointments SET AppointmentDateTime=@DateTime WHERE TestAppointmentID=@AppointmentID;` | `@AppointmentID`, `@DateTime` | `bool` | Rescheduling appointment |
| `clsLockTestAppointment` | `UPDATE TestAppointments SET IsLocked=1 WHERE TestAppointmentID=@AppointmentID;` | `@AppointmentID` | `bool` | `clsTest.Save()` appointment lock |
| `clsIsTestAppointmentLocked` | `SELECT IsLocked FROM TestAppointments WHERE TestAppointmentID=@AppointmentID;` | `@AppointmentID` | `bool` | Appointment edit validation |
| `clsGetAllTestAppointments` | `SELECT TestAppointmentID, AppointmentDateTime, PaidFees, IsLocked FROM TestAppointments WHERE TestAppointmentForLocalDrivingLicenseAppID=@LocalAppID AND AppointmentTestTypeID=@TestTypeID;` | `@LocalAppID`, `@TestTypeID` | `DataTable` | Appointment management grids |
| `clsGetAppointmentByAppointmentID` | `SELECT * FROM TestAppointments WHERE TestAppointmentID=@AppointmentID;` | `@AppointmentID` | `DataTable` | `clsVisionTests`, `clsWrittenTest`, `clsPracticalTest` |
| `clsCheckIfThereIsOpenAppointmentBefore` | `SELECT R='T' FROM TestAppointments WHERE TestAppointmentForLocalDrivingLicenseAppID=@LocalAppID AND AppointmentTestTypeID=@TestTypeID AND IsLocked=0;` | `@LocalAppID`, `@TestTypeID` | `bool` | Prevents booking duplicate open appointments |
| `clsAddNewTest` | `INSERT INTO Test (AppointmentOfTestID, TestResult, Notes, CreatedByUserID) VALUES (@AppointmentID, @TestResult, @Notes, @UserID); SELECT SCOPE_IDENTITY();` | `@AppointmentID`, `@TestResult`, `@Notes`, `@UserID` | `int` (New TestID) | `clsTest.Save()` |
| `clsGetTestResultByTestAppointmentID` | `SELECT TOP 1 TestResult FROM Test INNER JOIN TestAppointments ON Test.AppointmentOfTestID=TestAppointments.TestAppointmentID WHERE TestAppointments.TestAppointmentForLocalDrivingLicenseAppID=@LocalAppID AND TestAppointments.AppointmentTestTypeID=@TestTypeID ORDER BY TestID DESC;` | `@LocalAppID`, `@TestTypeID` | `bool?` (`true`=Passed, `false`=Failed, `null`=Not taken) | Pipeline gate validation |
| `clsCheckIfTestHasFinishedOrNot` | `SELECT R='T' FROM Test INNER JOIN TestAppointments ON Test.AppointmentOfTestID=TestAppointments.TestAppointmentID WHERE TestAppointments.TestAppointmentForLocalDrivingLicenseAppID=@LocalAppID AND TestAppointments.AppointmentTestTypeID=@TestTypeID AND Test.TestResult=1;` | `@TestTypeID`, `@LocalAppID` | `bool` | Prerequisite gatekeeper for next test stage |
| `clsCheckIfTheTestHasTakenAndFailedOrNot` | Checks if applicant has an existing failed test record for the specified test type. | `@LocalAppID`, `@TestTypeID` | `bool` | Determines whether appointment is a regular or retake test |
| `clsGetNumOfTrialsOfTest` | `SELECT COUNT(*) FROM Test INNER JOIN TestAppointments ON Test.AppointmentOfTestID=TestAppointments.TestAppointmentID WHERE TestAppointments.TestAppointmentForLocalDrivingLicenseAppID=@LocalAppID AND TestAppointments.AppointmentTestTypeID=@TestTypeID;` | `@LocalAppID`, `@TestTypeID` | `int` | Trial counter displayed on test cards |

---

### 2.6 Driver and License Data Access Classes

| Class Name | Primary Query / Table Accessed | Parameters | Return Type | Consuming BLL Class |
|---|---|---|---|---|
| `clsAddNewDriver` | `INSERT INTO Drivers (DriverPersonID, CretatedByUserID, CreateDate) VALUES (@PersonID, @UserID, @CreateDate); SELECT SCOPE_IDENTITY();` | `@PersonID`, `@UserID`, `@CreateDate` | `int` (New DriverID) | `clsDrivers.AddNewDriver()` |
| `clsFindDriver` / `clsFindDriverByPersonID` | `SELECT * FROM Drivers WHERE ...` | DriverID, PersonID, NationalNumber, FullName | `DataTable` | `clsDrivers.FindDriverObjByPersonID()` |
| `clsCheckIfThePersonIsDriverOrNot` | `SELECT R='T' FROM Drivers WHERE DriverPersonID=@PersonID;` | `@PersonID` | `bool` | `clsDrivers.IsDriverExists()` |
| `clsListDrivers` | `SELECT * FROM ListDrivers;` | None | `DataTable` | Driver management grid |
| `clsAddNewLicense` | `INSERT INTO Licenses (LicApplicationID, LicDriverID, ClassOfLicenseID, IssueDate, ExpirationDate, Notes, PaidFees, IsActive, IssueReason, CreatedByUserID) VALUES (...); SELECT SCOPE_IDENTITY();` | Full license parameters | `int` (New LicenseID) | `clsLicenses.Save()` |
| `clsDisableLicenseByLicID` | `UPDATE Licenses SET IsActive=0 WHERE LicenseID=@LicenseID;` | `@LicenseID` | `bool` | Deactivation on renew/replace |
| `clsCheckIfTheLicenseHasExpiredOrNot` | `SELECT R='T' FROM Licenses WHERE LicenseID=@LicenseID AND ExpirationDate < CAST(GETDATE() AS Date);` | `@LicenseID` | `bool` | Renewal validation |
| `clsCheckLicenseExistense` | `SELECT R='T' FROM Licenses INNER JOIN Applications ON Licenses.LicApplicationID=Applications.ApplicationID WHERE Applications.ApplicantPersonID=@PersonID AND Licenses.ClassOfLicenseID=@ClassID AND Licenses.IsActive=1;` | `@PersonID`, `@ClassID` | `bool` | Duplicate active license check |
| `clsCheckIfThereIsLicenseOrNot` | `SELECT R='T' FROM Licenses WHERE LicApplicationID=@ApplicationID;` | `@ApplicationID` | `bool` | `clsCheckExistence.CheckIfTheLicenseHasBeenIssuedOrNot()` |
| `clsGetLicenseInfoByID` | `SELECT * FROM Licenses WHERE LicenseID=@LicenseID;` | `@LicenseID` | `DataTable` | `clsLicenses.GetLicenseObjByLicenseID()` |
| `clsGetLicenseByPersonID` | `SELECT Licenses.* FROM Licenses INNER JOIN Applications ON Licenses.LicApplicationID=Applications.ApplicationID WHERE Applications.ApplicantPersonID=@PersonID AND Licenses.ClassOfLicenseID=@ClassID;` | `@PersonID`, `@ClassID` | `DataTable` | Finding license by person |
| `clsGetDriverLicenseInfo` | `SELECT * FROM DriverLicenseInfo WHERE LicenseID=@LicenseID;` | `@LicenseID` / `@ApplicationID` | `DataTable` | License display card control |
| `clsLicenseHistory` | `SELECT Licenses.LicenseID, Applications.ApplicationID, LicenseClasses.ClassName, Licenses.IssueDate, Licenses.ExpirationDate, Licenses.IsActive FROM Licenses ... WHERE Applications.ApplicantPersonID=@PersonID;` | `@PersonID` | `DataTable` | Local license history grid |
| `clsGetSummaryInfoForRenewLicense` | Joins license and application data to present renewal summary. | `@LicenseID` | `DataTable` | Renewal form review card |

---

### 2.7 Detained and Released License Data Access Classes

| Class Name | Primary Query / Table Accessed | Parameters | Return Type | Consuming BLL Class |
|---|---|---|---|---|
| `clsAddNewDetainedLicense` | `INSERT INTO DetainedLicenses (DetainedLicenseID, DetainDateTime, FineFees, CreatedByUserID, ISReleased) VALUES (@LicenseID, @DetainDT, @FineFees, @UserID, @IsReleased); SELECT SCOPE_IDENTITY();` | `@LicenseID`, `@DetainDT`, `@FineFees`, `@UserID`, `@IsReleased` | `int` (New DetainID) | `clsDetainReleaseLicense.Add()` |
| `clsReleaseLicnese` | `UPDATE DetainedLicenses SET ISReleased=1, ReleasedDateTime=@ReleasedDT, ReleasedByUserID=@ReleasedUserID, ReleaseApplicationID=@ReleaseAppID WHERE DetainID=@DetainID;` | `@DetainID`, `@ReleasedDT`, `@ReleasedUserID`, `@ReleaseAppID` | `bool` | `clsDetainReleaseLicense.ReleaseLicense()` |
| `clsIsLicenseDetained` | `SELECT R='T' FROM DetainedLicenses WHERE DetainedLicenseID=@LicenseID AND ISReleased=0;` | `@LicenseID` | `bool` | `clsDetainReleaseLicense.IsLicenseDetained()` |
| `clsFindDetainedLicenseByLicneseID` | `SELECT * FROM DetainedLicenses WHERE DetainedLicenseID=@LicenseID AND ISReleased=0;` | `@LicenseID` | `DataTable` | Loading active detention record |
| `clsGetDetainedLicenseByDetainID` | `SELECT * FROM DetainedLicenses WHERE DetainID=@DetainID;` | `@DetainID` | `DataTable` | Detention details viewer |
| `clsGetAllDetainedILic` | `SELECT * FROM DetailedDetainInfo;` | None | `DataTable` | Detained license grid |

---

### 2.8 International Driving License Data Access Classes

| Class Name | Primary Query / Table Accessed | Parameters | Return Type | Consuming BLL Class |
|---|---|---|---|---|
| `clsAddNewInternationalLicense` | `INSERT INTO InternationalLicenses (IssueDate, ExpirationDate, IsActive, UserID, DriverID, LicenseID, ApplicationID) VALUES (...); SELECT SCOPE_IDENTITY();` | IssueDate, ExpirationDate, IsActive, UserID, DriverID, LicenseID, ApplicationID | `int` (New InternationalLicenseID) | `clsInternationalLicense.Save()` |
| `clsDeactivateInternationalLicense` | `UPDATE InternationalLicenses SET IsActive=0 WHERE LicenseID=@LicenseID;` | `@LicenseID` | `bool` | Deactivation when underlying local license is renewed/replaced |
| `clsCheckIfThePersonHasInternationalLicenseOrNot` | Checks if person already has an active international permit. | `@PersonID` | `bool` | Issuance validation |
| `clsIsInternatioalLicenseExistsByLocalLicenseID` | Checks active international permit by local license ID. | `@LicenseID` | `bool` | Issuance validation |
| `clsFindInternationalLicenseBy` | Search queries across `ShowInternationalLicensesInfo` view. | Search criteria + value | `DataTable` | International search & filter |
| `clsGetInternationalLicenseInfo` | `SELECT * FROM ShowInternationalLicensesInfo WHERE InternationalLicenseID=@ID;` | `@ID` | `DataTable` | International license card control |
| `clsGetInternationalLicAppInfo` | `SELECT * FROM InternationalAppInfo WHERE ApplicationID=@AppID;` | `@AppID` | `DataTable` | International application card control |
| `clsInternationalLicensesAppsView` | `SELECT * FROM InernationalLicenseApplications;` | None | `DataTable` | International licenses grid |

---

### 2.9 Lookup and Reference Data Access Classes

| Class Name | Primary Query / Table Accessed | Parameters | Return Type | Consuming BLL Class |
|---|---|---|---|---|
| `clsGetAllAppTypes` | `SELECT * FROM ApplicationTypes;` | None | `DataTable` | `clsApplicationTypes.GetAllAppTypes()` |
| `clsFindAppTypeByAppID` | `SELECT * FROM ApplicationTypes WHERE ApplicationTypeID=@AppID;` | `@AppID` | `DataTable` | `clsApplicationTypes.FindAppObjByAppID()` |
| `clsUpdateAppType` | `UPDATE ApplicationTypes SET ApplicationTypeTitle=@Title, ApplicationFees=@Fees WHERE ApplicationTypeID=@AppID;` | `@AppID`, `@Title`, `@Fees` | `bool` | `clsApplicationTypes.Save()` |
| `clsGetAllLicenseClasses` | `SELECT * FROM LicenseClasses;` | None | `DataTable` | `clsLicenseClasses.GetAll_LicenseClassses()` |
| `clsFindLicenseClasssByClassID` | `SELECT * FROM LicenseClasses WHERE LicenseClassID=@ClassID;` | `@ClassID` | `DataTable` | `clsLicenseClasses.FindLicenseClassByID()` |
| `clsGetLicenseClassIDByItsName` | `SELECT LicenseClassID FROM LicenseClasses WHERE ClassName=@ClassName;` | `@ClassName` | `int` | `clsLicenseClasses.GetLicenseClassIDByClassName()` |
| `clsGetAllTestTypes` | `SELECT * FROM TestTypes;` | None | `DataTable` | `clsTestTypes.GetAllTestTypes()` |
| `clsFindTestType` | `SELECT * FROM TestTypes WHERE TestTypeID=@TestTypeID;` | `@TestTypeID` | `DataTable` | `clsTestTypes.FindTestType()` |
| `clsUpdateTestType` | `UPDATE TestTypes SET TestTypeTitle=@Title, TestTypeDescription=@Description, TestTypeFees=@Fees WHERE TestTypeID=@TestTypeID;` | `@TestTypeID`, `@Title`, `@Description`, `@Fees` | `bool` | `clsTestTypes.Save()` |
| `clsListOfCountrires` | `SELECT * FROM Countries;` | None | `DataTable` | Country combobox population |
| `clsGetCountryIDByCountryName` | `SELECT CountryID FROM Countries WHERE CountryName=@CountryName;` | `@CountryName` | `int` | Country resolution |
