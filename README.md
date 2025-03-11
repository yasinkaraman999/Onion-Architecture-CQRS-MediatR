# Product App - Onion Architecture

This project is a .NET Core Web API application built using Clean Architecture (Onion Architecture) principles. It provides a robust foundation for building scalable and maintainable product management systems.

##  Architecture

The solution follows the Onion Architecture pattern with the following layers:

### Core Layer
- **ProductApp.Domain**: Contains enterprise logic and entities
  - Entities
  - Common abstractions
  - Domain models

- **ProductApp.Application**: Contains business logic and interfaces
  - DTOs
  - Interfaces
  - Application Services
  - Mappings
  - CQRS Features
  - Exception Handling
  - Wrappers

### Infrastructure Layer
- **ProductApp.Persistence**: Implementation of Core interfaces
  - Database Context
  - Repositories
  - Database Configurations
  - Migrations

### Presentation Layer
- **ProductApp.WebApi**: API endpoints and configurations
  - Controllers
  - Middleware
  - API Configurations

##  Technologies

- .NET Core
- Entity Framework Core
- AutoMapper
- CQRS Pattern
- Fluent Validation
- Clean Architecture
- RESTful API

##  Prerequisites

- .NET Core SDK
- SQL Server
- Visual Studio 2022 or VS Code

##  Installation

1. Clone the repository
```bash
git clone https://github.com/yourusername/ProductApp_OnionArchitecture.git
```

2. Navigate to the project directory
```bash
cd ProductApp_OnionArchitecture
```

3. Restore dependencies
```bash
dotnet restore
```

4. Update the database
```bash
dotnet ef database update
```

5. Run the application
```bash
dotnet run --project src/WebApi/ProductApp.WebApi
```

##  Project Structure

```
├── src/
│   ├── Core/
│   │   ├── ProductApp.Domain/
│   │   └── ProductApp.Application/
│   ├── Infrastructure/
│   │   └── ProductApp.Persistence/
│   └── WebApi/
│       └── ProductApp.WebApi/
```

##  Features

- Clean Architecture implementation
- CQRS pattern with MediatR
- Entity Framework Core with SQL Server
- AutoMapper for object mapping
- Fluent Validation for request validation
- Exception handling middleware
- API versioning
- Swagger documentation


##

Thank you [Salih Cantekin](https://github.com/salihcantekin)