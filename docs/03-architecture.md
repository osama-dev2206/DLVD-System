# 03 – System Architecture

[← Back to Index](./README.md)

---

## 1. Architectural Overview

DVLD follows a classic **three-tier client-server architecture** implemented as a single-machine desktop application:

```
+--------------------------------------------------------+
|                   Presentation Tier                    |
|  FrontEnd project (Windows Forms)                      |
|  Namespace: FrontEnd                                   |
|  - Forms (frmXxx) and User Controls (ctrlXxx)         |
|  - Input collection, inline validation, UI events      |
+---------------------------|----------------------------+
                            | uses objects from
+---------------------------|----------------------------+
|                   Business Logic Tier                  |
|  BussinessLogicLayer project (Class Library)           |
|  Namespace: BussinessLogicLayer                        |
|  - Domain classes (clsXxx)                             |
|  - Business rules, state machines, workflow orchestration|
+---------------------------|----------------------------+
                            | calls static methods from
+---------------------------|----------------------------+
|                    Data Access Tier                    |
|  DataAccessLayer project (Class Library)               |
|  Namespace: DataAccessLayer                            |
|  - One static class per database operation             |
|  - Parameterised SQL queries, ADO.NET                  |
+---------------------------|----------------------------+
                            | via SqlConnection/SqlCommand
+---------------------------|----------------------------+
|                      Database Tier                     |
|  Microsoft SQL Server – Database: MyDVLD               |
|  - 14 tables, 8 views, FK/unique constraints           |
+--------------------------------------------------------+
```

---

## 2. Project Structure

```
My Solution/
  BussinessLogicLayer/          C# Class Library
    abPerson.cs                 Abstract base – person properties
    clsAbTestAppointments.cs    Abstract base – test appointment behaviour
    clsApplications.cs          Application entity; internal ctor
    clsApplicationTypes.cs      Reference data – application type lookup
    clsCheckExistence.cs        Static helpers for test completion checks
    clsCurrentLoggedInUser.cs   Static session holder
    clsDetainReleaseLicense.cs  Detain + Release workflow
    clsDrivers.cs               Driver entity + registry
    clsEncryptDecrypt.cs        AES-256 encryption utility
    clsInternationalLicense.cs  International license workflow
    clsLicenseClasses.cs        License class lookup
    clsLicenses.cs              License issuance, disable, validity checks
    clsLocalDrivingLicenseApplication.cs   LDLA workflow
    clsPeople.cs                Person CRUD + image management
    clsPracticalTest.cs         Practical test appointment
    clsRetakeTest.cs            Retake appointment creation (internal)
    clsRenewLicense.cs          License renewal workflow
    clsReplacementLicense.cs    License replacement workflow
    clsTestTypes.cs             Reference data – test type lookup
    clsTest.cs                  Test result recording
    clsUsers.cs                 User authentication + session
    clsPUsersManagement.cs      User CRUD (partial class of clsUsers)
    clsVisionTests.cs           Vision test appointment
    clsWrittenTest.cs           Written test appointment

  DataAccessLayer/              C# Class Library
    dbSettings.cs               Connection string factory
    clsAddNewPerson.cs, clsUpdatePerson.cs, clsDeletePerson.cs, clsFindPersonBy.cs ...
    clsAddNewUser.cs, clsUpdateUser.cs, clsDeleteUser.cs, clsFindUser.cs ...
    clsAddNewApplicationToApplicationTable.cs, clsUpdateApplication.cs ...
    clsAddNewLocalDrivingLicense.cs, clsDeleteLocalDrivingLicense.cs ...
    clsAddNewTestAppointment.cs, clsLockTestAppointment.cs ...
    clsAddNewTest.cs, clsGetTestResultByTestAppointmentID.cs ...
    clsAddNewLicense.cs, clsDisableLicenseByLicID.cs ...
    clsAddNewDriver.cs, clsFindDriver.cs ...
    clsAddNewDetainedLicense.cs, clsReleaseLicnese.cs ...
    clsAddNewInternationalLicense.cs, clsDeactivateInternationalLicense.cs ...
    [~70+ focused DAL classes total]

  FrontEnd/                     Windows Forms Application
    Program.cs                  Entry point; wires Login → Main
    frmLogin.cs                 Authentication form
    FrmMain.cs                  Main menu/shell
    FrmPeopleManagement.cs      Person list
    frmAddEditPerson.cs         Person add/edit wrapper
    ctrlAddEditPerson.cs        Person add/edit user control
    ctrlPersonInfo.cs           Person info display control
    ctrlFilterFindBy.cs         Search-by-PersonID/NationalNo control
    frmManageUsers.cs           User list
    frmAddEditUser.cs           User add/edit
    frmManageLocalDrivingLicenseApplications.cs
    frmAddEditLocalDrivingLicense.cs
    frmShowLocalDrivingLicApplicationDetails.cs
    frmTestVisionAppointments.cs
    frmManageWrittenTestAppointments.cs
    frmManagePracticalTestAppointments.cs
    frmTakeTest.cs
    frmAddNewLicense.cs
    frmShowLicense.cs
    frmLicenseHistory.cs
    frmRenewLicense.cs
    frmReplacementForDamagedLic.cs
    frmDetainLicense.cs
    frmReleaseLicense.cs
    frmManageDetainedLicenses.cs
    frmNewInternationalLicense.cs
    frnManageInternationalLicensesApps.cs
    frmListDrivers.cs
    frmApplicationTypes.cs
    frmManageTestTypes.cs
    frmChangePassword.cs
    frmShowCurrentUserInfo.cs
    [+ several ctrlXxx User Controls and helper forms]

  Initial Db Design/            Reference documents
    DDL.sql                     Database creation script
    ERD.drawio                  Entity-Relationship Diagram
    Relational Schema.drawio    Relational schema diagram

  Quries Of System/             Reference SQL
    SQLQuery1.sql               Ad-hoc queries used during development
    Views.sql                   All database view definitions
```

---

## 3. Component Responsibilities

### 3.1 Presentation Layer (FrontEnd)

**Responsibility**: Collect user input, display data, provide navigation, show errors.

**Does NOT**:
- Apply business rules
- Write SQL
- Manage connections

**How it interacts with BLL**:
- Instantiates BLL domain objects (e.g., `new clsLocalDrivingLicenseApplications(personID)`).
- Sets properties on those objects.
- Calls `Save()` or static query methods.
- Subscribes to `Action<T>` delegates (callback pattern) to receive results (e.g., `OnSaveGetDetainInfo`, `OnSaveGetInterLicID`).
- Binds returned `DataTable` objects directly to `DataGridView.DataSource`.

**Key patterns used**:
- **Event / Action callbacks** – instead of returning values from `Save()` that would require multiple returns, BLL classes expose `public Action<T>` fields (e.g., `OnTestSaveGetTestID`, `OnSaveGetError`). The form subscribes before calling `Save()`.
- **Inline validation** – `errorProvider1.SetError()` on each field's TextChanged/Validating events.
- **Context menus** – `frmManageLocalDrivingLicenseApplications` uses a context menu whose items are dynamically enabled/disabled based on LDLA state (computed by calling BLL/DAL from `CheckScheduleTestForSelectedApplication()`).

### 3.2 Business Logic Layer

**Responsibility**: Domain model, business rules, multi-step workflow orchestration.

**Design patterns observed**:

| Pattern | Where used |
|---|---|
| State Machine (Add/Edit mode enum) | All domain classes (clsPeople, clsUsers, clsLicenses, clsLocalDrivingLicenseApplications, etc.) |
| Template Method | clsAbTestAppointments (abstract base) → clsVisionTests / clsWrittenTest / clsPracticalTest |
| Composition | clsLocalDrivingLicenseApplications holds clsApplications; clsRenewLicense holds clsApplications + clsLicenses |
| Action callbacks | clsVisionTests.OnSaveGetTheRetakeID, clsTest.OnTestSaveGetTestID, etc. |
| Singleton-like session | clsCurrentLoggedInUser (static class) |
| Partial class | clsUsers split into clsUsers.cs (login/session) + clsPUsersManagement.cs (CRUD) |

**Add/Edit mode pattern**:
Every domain class that supports both insert and update uses a private `enum enMode { Add, Update }`. The constructor used determines the mode. `Save()` switches on mode and calls `Add()` or `Update()`. After a successful `Add()`, mode is switched to `Update` so subsequent `Save()` calls become updates. This is a common pattern that prevents double-inserts.

**Composition for Applications**:
Several workflows require creating a parent Application first. Rather than duplicating application creation logic, these classes compose a `clsApplications` object:
- `clsLocalDrivingLicenseApplications` → has `Application` property
- `clsRenewLicense` → has `RenewApplication`
- `clsReplacementLicense` → has `ApplicationForReplacement`
- `clsInternationalLicense` → has `InternationalNewApplication`
- `clsDetainReleaseLicense` → has `ReleaseApplication` (on release path)
- `clsRetakeTest` → has `RetakeTestApplication`

`clsApplications` is internal/sealed – only BLL classes can instantiate it, preventing the frontend from writing applications directly.

### 3.3 Data Access Layer

**Responsibility**: Execute exactly one SQL operation; open and close connection; return result.

**Design pattern**: One `static` class per operation. Each class contains:
- A `private static string Query` field holding the SQL.
- One `public static` method accepting the query parameters and returning `int`, `bool`, `DataTable`, etc.
- A `try/finally` block ensuring the connection is always closed.
- Empty `catch {}` blocks (exception swallowed; failed operations return sentinel values like -1 or false).

Example structure:
```csharp
public static class clsAddNewPerson
{
    static string Query = @"INSERT INTO People (...) VALUES (...); SELECT SCOPE_IDENTITY();";

    public static int AddNewPerson(string NationalNumber, ...)
    {
        int result = -1;
        SqlConnection connection = dbSettings.DbConnection();
        try
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand(Query, connection);
            cmd.Parameters.AddWithValue("@NationalNumber", NationalNumber);
            // ...
            object r = cmd.ExecuteScalar();
            if (r != null && int.TryParse(r.ToString(), out int id))
                result = id;
        }
        catch { }
        finally { connection.Close(); }
        return result;
    }
}
```

Notably, `clsFindPersonBy` uses a delegate pattern internally for query construction, but the public interface follows the same contract.

**Connection management**: Each DAL class creates a new `SqlConnection` per call (from `dbSettings.DbConnection()`). There is no connection pooling configuration; ADO.NET handles this automatically.

---

## 4. Data Flow Diagrams

### 4.1 Save a New Person

```
frmAddEditPerson
  └─ ctrlAddEditPerson
       └─ person.Save()                        [clsPeople, BLL]
            ├─ CheckDir()                      [filesystem]
            ├─ CopyTheFileToNewDestination()   [filesystem]
            └─ clsAddNewPerson.AddNewPerson()  [DAL]
                 └─ INSERT INTO People ...     [SQL Server]
                      └─ SCOPE_IDENTITY()
                           └─ PersonID returned up the chain
```

### 4.2 Full Local License Application → Test → Issue

```
User Action                BLL Call                              DAL / DB
-----------                --------                              --------
New LDLA           →  clsLocalDrivingLicenseApplications.Save() → INSERT Applications
                                                                → INSERT LocalDrivingLicenseApplications

Schedule Vision    →  clsVisionTests.Save()                     → INSERT TestAppointments
Take Vision Test   →  clsTest.Save()                            → INSERT Test
                                                                → UPDATE TestAppointments (IsLocked=1)

Schedule Written   →  clsWrittenTest.Save()                     → INSERT TestAppointments
Take Written Test  →  clsTest.Save()                            → INSERT Test
                                                                → UPDATE TestAppointments (IsLocked=1)

Schedule Practical →  clsPracticalTest.Save()                   → INSERT TestAppointments
Take Practical     →  clsTest.Save()                            → INSERT Test
                                                                → UPDATE TestAppointments (IsLocked=1)

Issue License      →  clsLicenses.Save()                        → INSERT Drivers (if new)
                                                                → INSERT Licenses
                                                                → UPDATE Applications (status=Completed)
```

---

## 5. Security Architecture

| Concern | Implementation |
|---|---|
| Password storage | AES-256 encrypted; never plain-text in DB or JSON file |
| Session management | Static `clsCurrentLoggedInUser.User`; cleared on logout |
| SQL injection prevention | All DAL queries use `SqlCommand.Parameters.AddWithValue()`; no string concatenation |
| File access | Images stored in a fixed directory; no path traversal possible as paths are set programmatically |
| Credential persistence | Encrypted credentials stored in `C:\DVLDSavedLoginInfo\SavedLogin.json` |

**Limitations (known)**:
- The AES key and IV are hardcoded in source code (`clsEncryptDecrypt.cs`). An attacker with access to the binary could extract these.
- `catch {}` in all DAL classes silently swallows exceptions. Database errors are invisible to logs.
- The connection string is hardcoded in `dbSettings.cs` with Windows Integrated Security (no SQL credentials risk), but the server name (`OSAMA-PC`) is environment-specific.

---

## 6. Cross-Cutting Concerns

### 6.1 Audit Trail

Every Application record has `CreatedByUserID` (FK to `Users.UserID`). Every License, Test, and DetainedLicense record also has `CreatedByUserID`. This traces every write to the staff member who performed it. `clsCurrentLoggedInUser.User.UserID` is used at time of save.

### 6.2 Error Handling Strategy

- **Frontend**: uses `MessageBox.Show()` for user-facing errors; `errorProvider1.SetError()` for field-level inline errors.
- **BLL**: validates conditions before calling DAL; communicates errors via `Action<string>` callbacks (e.g., `OnSaveGetError`) or `bool` return values from `Save()`.
- **DAL**: catches all exceptions silently and returns sentinel values (`-1`, `false`, `null`). This keeps DAL methods simple but prevents detailed error diagnostics.

### 6.3 State Machine

All domain classes use the same mode pattern:
```
object created with "Add" constructor  → Mode = Add
  → Save() calls Add()
  → if successful: Mode switches to Update
object loaded with "Edit" constructor  → Mode = Update
  → Save() calls Update()
```

This guarantees idempotent save behaviour and prevents double inserts within a session.
