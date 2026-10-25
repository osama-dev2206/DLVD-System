# DVLD – Driving and Vehicle License Department System

---

## Quick Navigation

| Document | Contents |
| --- | --- |
| [01 – Project Overview](./docs/01-project-overview.md) | Purpose, users, capabilities, technology stack, architecture |
| [02 – Feature Documentation](./docs/02-features.md) | Every feature: workflow, frontend, BLL, DB interaction, E2E flow |
| [03 – System Architecture](./docs/03-architecture.md) | Layer diagram, component responsibilities, data-flow |
| [04 – Database Documentation](./docs/04-database.md) | Schema, every table, views, relationships, SQL operations |
| [05 – BLL Documentation](./docs/05-bll.md) | Every BLL class: methods, logic, DAL calls, design decisions |
| [06 – DAL Documentation](./docs/06-dal.md) | Every DAL class: queries, parameters, connection management |
| [07 – Frontend Documentation](./docs/07-frontend.md) | Forms, User Controls, navigation, component map |
| [08 – Cross-Layer Traceability](./docs/08-traceability.md) | Requirement to Form to BLL to DAL to Table mapping |
| [09 – Design Decisions](./docs/09-design-decisions.md) | Technical rationale, architectural trade-offs, and design patterns |
| [Requirements Specification](./docs/Requirements.md) | Original system requirements and functional specifications (Arabic) |
| [System Demo Video](#-system-demo-video) | Full HD 1080p video walkthrough demonstration |
| [System Screenshots](#-system-screenshots-in-order) | Complete 34-step sequential UI visual walkthrough |

---

## Project at a Glance

**DVLD** is a desktop Windows Forms application written in C# / .NET that automates a driving-license authority's operations. It replaces paper-based processes for managing people, system users, license applications, test scheduling, license issuance, and license lifecycle events (renew, replace, detain, release, international issuance).

All business workflows and regulatory constraints are implemented in accordance with the official functional requirements in [Requirements.md](./docs/Requirements.md), with full architectural rationale documented in [09 – Design Decisions](./docs/09-design-decisions.md).

### Core Capabilities

1. Person management (CRUD + photo upload)
2. System-user management (password encryption, active/inactive)
3. Local driving-license application lifecycle (new → test scheduling → pass → issue)
4. Three-stage test pipeline: Vision → Written → Practical
5. Retake-test workflow with a new fee application per attempt
6. License renewal (expired licenses only)
7. License replacement for damaged or lost cards
8. License detention and release with fine fees
9. International driving-license issuance
10. Driver registry and license history
11. Reference-data management (application types, test types)

---

## 🎥 System Demo Video

Watch the complete 1080p high-definition end-to-end system walkthrough demonstrating all core features:

<video src="./DVLD%201080%20(1).mp4" controls width="100%" poster="./dvld%20screenshots/02-main.png">
  Your browser does not support the video tag.
</video>

> [!TIP]
> **[▶ Download / Watch Full HD System Demo Video (DVLD 1080p)](./DVLD%201080%20(1).mp4)**

---

## 📸 System Screenshots (In Order)

Below is the complete 34-step visual walkthrough of the DVLD application in sequential operational order:

### 1. Authentication & Main Interface

| 01 – Login Screen | 02 – Main System Dashboard |
|:---:|:---:|
| ![01 - Login](./dvld%20screenshots/01-login.png) | ![02 - Main Dashboard](./dvld%20screenshots/02-main.png) |

### 2. Applications & Driving Services Menus

| 03 – Applications Menu | 04 – Driving Licenses Services Menu |
|:---:|:---:|
| ![03 - Applications Menu](./dvld%20screenshots/03-applications.png) | ![04 - Driving Services Menu](./dvld%20screenshots/04-driving-services.png) |

### 3. Local Driving License Application Creation

| 05 – New Driving License Service Selection | 06 – New Local Driving License Application Form |
|:---:|:---:|
| ![05 - New License Options](./dvld%20screenshots/05-new-license-options.png) | ![06 - New Local License Form](./dvld%20screenshots/06-new-local-license.png) |

### 4. Manage Local Driving License Applications

| 07 – Manage Applications Grid | 08 – Local Applications List & Status |
|:---:|:---:|
| ![07 - Manage Applications](./dvld%20screenshots/07-manage-applications.png) | ![08 - Local Applications List](./dvld%20screenshots/08-local-applications-list.png) |

### 5. Application Context Actions & Filter Controls

| 09 – Application Row Context Menu | 10 – Multi-Criteria Search & Filter Options |
|:---:|:---:|
| ![09 - Application Context Menu](./dvld%20screenshots/09-local-context-menu.png) | ![10 - Local List Filters](./dvld%20screenshots/10-local-list-filters.png) |

### 6. People Management & Demographic Records

| 11 – People Management Directory | 12 – Person Context Menu & Operations |
|:---:|:---:|
| ![11 - People Management](./dvld%20screenshots/11-people-management.png) | ![12 - People Context Menu](./dvld%20screenshots/12-people-context-menu.png) |

### 7. Citizen Registration & Driver Registry

| 13 – Add / Edit Person Profile Form | 14 – Registered Drivers List Grid |
|:---:|:---:|
| ![13 - Add Person](./dvld%20screenshots/13-add-person.png) | ![14 - Drivers List](./dvld%20screenshots/14-drivers-list.png) |

### 8. Driver Search & User Administration

| 15 – Driver Search Filters | 16 – Manage System Users Grid |
|:---:|:---:|
| ![15 - Driver Filters](./dvld%20screenshots/15-driver-filters.png) | ![16 - Manage Users](./dvld%20screenshots/16-manage-users.png) |

### 9. User Filtering & Operator Account Management

| 17 – User Status & Role Filters | 18 – Operator Account Settings Menu |
|:---:|:---:|
| ![17 - User Filters](./dvld%20screenshots/17-user-filters.png) | ![18 - My Account Menu](./dvld%20screenshots/18-my-account-menu.png) |

### 10. Operator Profile & Credential Security

| 19 – Current User Profile Card | 20 – Change Operator Password Form |
|:---:|:---:|
| ![19 - Current User Info](./dvld%20screenshots/19-current-user-info.png) | ![20 - Change Password](./dvld%20screenshots/20-change-password-form.png) |

### 11. License Detention Management

| 21 – Detain / Release License Menu Options | 22 – Manage Detained Licenses Grid |
|:---:|:---:|
| ![21 - Detention Options](./dvld%20screenshots/21-detention-options.png) | ![22 - Manage Detained Licenses](./dvld%20screenshots/22-manage-detained-licenses.png) |

### 12. Reference Data Management (Statutory Fees)

| 23 – Manage Application Types & Fees Catalog | 24 – Manage Test Types & Fees Configuration |
|:---:|:---:|
| ![23 - Application Types](./dvld%20screenshots/23-application-types.png) | ![24 - Test Types](./dvld%20screenshots/24-test-types.png) |

### 13. International Driving Licenses

| 25 – International License Applications List | 26 – International License Context Menu |
|:---:|:---:|
| ![25 - International Applications](./dvld%20screenshots/25-international-applications.png) | ![26 - International Context Menu](./dvld%20screenshots/26-international-context-menu.png) |

### 14. License Lifecycle: Renewal

| 27 – Driving License Services Navigation | 28 – Renew Expired License Form |
|:---:|:---:|
| ![27 - Driving Services Menu](./dvld%20screenshots/27-driving-services-menu.png) | ![28 - Renew License](./dvld%20screenshots/28-renew-license.png) |

### 15. License Replacement (Damaged & Lost Cards)

| 29 – Replacement for Damaged License Form | 30 – Replacement for Lost License Option |
|:---:|:---:|
| ![29 - Replacement Damaged](./dvld%20screenshots/29-replacement-license.png) | ![30 - Replacement Lost](./dvld%20screenshots/30-replacement-lost-option.png) |

### 16. License Release & Impoundment Processing

| 31 – Release Detained Driving License Form | 32 – Detain Driving License Form |
|:---:|:---:|
| ![31 - Release Detained License](./dvld%20screenshots/31-release-detained-license.png) | ![32 - Detain License Form](./dvld%20screenshots/32-detain-license.png) |

### 17. International Issuance & Application Gate Actions

| 33 – Issue International Driving License (1-Year) | 34 – Application Actions & Test Scheduling Menu |
|:---:|:---:|
| ![33 - New International License](./dvld%20screenshots/33-new-international-license.png) | ![34 - Actions Menu](./dvld%20screenshots/34-local-application-actions-menu.png) |

---

### Technology Stack

| Concern | Technology |
| --- | --- |
| Language | C# (.NET) |
| UI Framework | Windows Forms |
| Database | Microsoft SQL Server |
| SQL client | Microsoft.Data.SqlClient |
| Serialization | System.Text.Json (login persistence) |
| Encryption | AES-256 symmetric (System.Security.Cryptography) |

### Three-Layer Architecture

```
+----------------------------------------------+
|              FrontEnd (WinForms)             |  namespace FrontEnd
|  Forms, User Controls, Events                |
+------------------+---------------------------+
                   | calls (direct reference)
+------------------v---------------------------+
|          BussinessLogicLayer (BLL)           |  namespace BussinessLogicLayer
|  Domain objects, Validations, Workflows      |
+------------------+---------------------------+
                   | calls (direct reference)
+------------------v---------------------------+
|          DataAccessLayer (DAL)               |  namespace DataAccessLayer
|  SQL queries, SqlCommand, SqlConnection      |
+------------------+---------------------------+
                   | ADO.NET
+------------------v---------------------------+
|        SQL Server - Database "MyDVLD"        |
|  Tables, Views, T-SQL transactions           |
+----------------------------------------------+
```

### Database Diagrams

The original ERD and Relational Schema diagrams are located in:

- [`Db Design/ERD.drawio`](./Db%20Design/ERD.drawio)
- [`Db Design/Relational Schema.drawio`](./Db%20Design/Relational%20Schema.drawio)

Open these files with [draw.io](https://app.diagrams.net/) to view them.

---
