# Cinema Ticket Sales System

Client-server desktop application for cinema ticket sales, built as a
university software engineering project. Demonstrates layered architecture,
a custom network protocol and design-pattern-driven system operations.

Class and database names are in Serbian; this document describes the
architecture in English.

## Architecture
- **Server** — multithreaded TCP server handling each connected client on its own thread
- **Klijent** — WinForms client application
- **Zajednicki** — shared domain model and transfer objects used by both sides
- **SistemskeOperacije** — 15 system operations built on the Template Method
  pattern, each wrapped in a transaction with automatic rollback on failure
- **DBBroker** — generic data-access layer with CRUD operations over SQL Server

## Highlights
- Custom request/response protocol over TCP sockets with object serialization
- Relational database of 8 tables and 7 foreign keys, modeled from a use-case analysis
- Consistent transaction handling: commit on success, rollback on any error
- Generic data-access layer: all domain classes implement a common `IEntity`
  interface exposing table name, columns and value mapping, so a single broker
  performs CRUD over any entity without entity-specific SQL
- Singleton pattern for the server-side controller and the client-side
  coordinator and communication classes, ensuring a single point of access
  to system operations and to the socket connection

## Tech stack
C# · .NET · WinForms · SQL Server · TCP Sockets