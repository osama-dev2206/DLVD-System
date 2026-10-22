# 01 – Project Overview

[← Back to Index](../README.md)

---

## 1. Project Name and Purpose

**DVLD** (Driving and Vehicle License Department) is a three-tier desktop application that digitises the complete workflow of a vehicle-licensing authority. It tracks every person who interacts with the authority, the license applications they submit, the tests they sit, the licenses issued to them, and all subsequent lifecycle events such as renewal, replacement, detention, and international-license issuance.

---

## 2. Problem Solved

A manual, paper-based licensing authority faces:

- No single source of truth for applicant history.
- No enforcement of sequential business rules (e.g., vision test before written test before practical test).
- No link between a person record, their driver record, and their license record.
- No audit trail showing which staff member processed each transaction.
- Duplicate applications and licence issuances for the same class.

DVLD solves each of these by maintaining a relational database with enforced constraints and a layered application that applies business rules before any database write.

---

## 3. Target Users and Roles

The application has a single user role: **System User** (an authority staff member). All users share the same capabilities; there is no separate admin role modelled in the database. However, a `IsActive` flag on every user account lets an operator deactivate any account.

The **currently logged-in user** is tracked via the static `clsCurrentLoggedInUser.User` property (BLL), which is set on successful login and used to stamp `CreatedByUserID` on every record written to the database.

---

## 4. Main System Capabilities

| # | Capability | Key Forms |
|---|---|---|
| 1 | Person CRUD | `FrmPeopleManagement`, `frmAddEditPerson`, `ctrlAddEditPerson` |
| 2 | User management | `frmManageUsers`, `frmAddEditUser`, `frmChangePassword` |
| 3 | Local driving-license application | `frmManageLocalDrivingLicenseApplications`, `frmAddEditLocalDrivingLicense` |
| 4 | Vision test scheduling and execution | `frmTestVisionAppointments`, `frmTakeTest` |
| 5 | Written test scheduling and execution | `frmManageWrittenTestAppointments`, `frmTakeTest` |
| 6 | Practical test scheduling and execution | `frmManagePracticalTestAppointments`, `frmTakeTest` |
| 7 | Retake test (automatic within test scheduling) | handled inside test-appointment forms |
| 8 | License issuance | `frmAddNewLicense` |
| 9 | License renewal | `frmRenewLicense` |
| 10 | License replacement (damaged / lost) | `frmReplacementForDamagedLic` |
| 11 | License detention | `frmDetainLicense` |
| 12 | License release | `frmReleaseLicense`, `frmManageDetainedLicenses` |
| 13 | International driving license | `frmNewInternationalLicense`, `frnManageInternationalLicensesApps` |
| 14 | Driver list and history | `frmListDrivers`, `frmLicenseHistory` |
| 15 | Reference data (application types, test types) | `frmApplicationTypes`, `frmManageTestTypes` |
| 16 | Login / authentication | `frmLogin` |

---

## 5. Technologies and Libraries

| Concern | Detail |
|---|---|
| Language | C# (target framework inferred from project files as .NET) |
| UI | Windows Forms (`System.Windows.Forms`) |
| Database access | ADO.NET via `Microsoft.Data.SqlClient` |
| Database server | Microsoft SQL Server (database name `MyDVLD`) |
| Encryption | AES-256 with fixed key/IV in `clsEncryptDecrypt` (used for passwords) |
| JSON persistence | `System.Text.Json` – persists login credentials to `C:\DVLDSavedLoginInfo\SavedLogin.json` |
| Image storage | Files stored on disk under `C:\DVLDPeopleImages\`; path stored in DB |

---

## 6. High-Level Architecture

The solution consists of three Visual Studio projects:

```
My Solution/
  BussinessLogicLayer/    --> Class library (BLL)
  DataAccessLayer/        --> Class library (DAL)
  FrontEnd/               --> Windows Forms executable
```

### Layer Responsibilities

| Layer | Responsibility |
|---|---|
| **FrontEnd** | Display, data collection, input validation feedback, event wiring. Never talks directly to the database. |
| **BussinessLogicLayer** | Domain objects (classes representing real-world entities), business rules, state machines (Add/Edit mode), orchestration of multi-step workflows. |
| **DataAccessLayer** | Raw SQL execution. Each DAL class is a small, focused static class that performs exactly one operation (insert, select, update, delete, check). |
| **SQL Server** | Persists data, enforces relational constraints, provides views for reporting. |

### Dependency Direction

```
FrontEnd --> BussinessLogicLayer --> DataAccessLayer --> SQL Server
```

The FrontEnd project references only the BLL; the BLL references only the DAL; the DAL uses `Microsoft.Data.SqlClient` directly. There are no circular references.

---

## 7. General Application Workflow

```
1. User launches the application.
2. frmLogin is shown.
   - Saved credentials loaded from JSON file if "remember me" was checked before.
   - User enters username and password.
   - BLL: encrypts password (AES-256), checks username exists and is active,
     verifies credentials against database.
   - On success: clsCurrentLoggedInUser.User is populated; frmMain is shown.

3. From frmMain's menu bar the user selects a workflow:
   - People Management
   - User Management
   - Local Driving License Applications (new, edit, cancel, delete, schedule tests, issue)
   - International Licenses
   - Renew License
   - Replacement License
   - Detain / Release License
   - Drivers list
   - Reference data (Application Types, Test Types)

4. Each workflow opens a dedicated form (modal dialog).
   The form instantiates BLL objects, calls their Save() or query methods,
   and the BLL delegates to DAL classes which execute parameterised SQL.

5. After every operation the calling form refreshes its DataGridView
   to reflect current database state.
```

---

## 8. Requirements & Design Decisions References

- **Functional Requirements:** The system's complete business rules, workflow specifications, and service fees are derived from the official requirements document in [Requirements Specification (Arabic)](./Requirements.md).
- **Architecture & Design Decisions:** Comprehensive technical rationale, patterns, and trade-offs for all design choices (layering, supertype inheritance, retake test composite billing, state machine, etc.) are documented in [09 – Design Decisions](./09-design-decisions.md).

