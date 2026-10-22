# DVLD – Driving and Vehicle License Department System
---

## Quick Navigation

| Document | Contents |
|---|---|
| [01 – Project Overview](./docs/01-project-overview.md) | Purpose, users, capabilities, technology stack, architecture |
| [02 – Feature Documentation](./docs/02-features.md) | Every feature: workflow, frontend, BLL, DB interaction, E2E flow |
| [03 – System Architecture](./docs/03-architecture.md) | Layer diagram, component responsibilities, data-flow |
| [04 – Database Documentation](./docs/04-database.md) | Schema, every table, views, relationships, SQL operations |
| [05 – BLL Documentation](./docs/05-bll.md) | Every BLL class: methods, logic, DAL calls, design decisions |
| [06 – DAL Documentation](./docs/06-dal.md) | Every DAL class: queries, parameters, connection management |
| [07 – Frontend Documentation](./docs/07-frontend.md) | Forms, User Controls, navigation, component map |
| [08 – Cross-Layer Traceability](./docs/08-traceability.md) | Requirement to Form to BLL to DAL to Table mapping |

---

## Project at a Glance

**DVLD** is a desktop Windows Forms application written in C# / .NET that automates a driving-license authority's operations. It replaces paper-based processes for managing people, system users, license applications, test scheduling, license issuance, and license lifecycle events (renew, replace, detain, release, international issuance).

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

### Technology Stack

| Concern | Technology |
|---|---|
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

