# CityTransport-API

ASP.NET Core Web API project for managing Montreal Transit Authority bus routes and schedules.

## Features

- **Public API** - Read-only endpoints for commuters to view bus routes
- **Admin API** - Management endpoints for adding/removing routes
- **Repository Pattern** - Abstracted data access layer
- **Entity Framework Core** - SQL Server database integration
- **Swagger/OpenAPI** - Interactive API documentation

## Tech Stack

- ASP.NET Core Web API
- Entity Framework Core
- SQL Server LocalDB
- Swagger/OpenAPI

## Project Structure

```
CityTransport.API/
├── Areas/
│   ├── Public/Controllers/     # Public-facing endpoints
│   └── Admin/Controllers/      # Admin management endpoints
├── Program.cs
└── appsettings.json

CityTransport.Data/
├── Models/                     # BusRoute, BusStop entities
├── Interfaces/                 # IRouteRepository
├── Repositories/               # In-memory and database implementations
├── Migrations/                 # EF Core migrations
└── CityTransportContext.cs     # DbContext
```

## API Endpoints

### Public Area
- `GET /public/api/routes` - Get all bus routes
- `GET /public/api/routes/{id}` - Get specific route

### Admin Area
- `POST /admin/api/routes` - Add new route
- `DELETE /admin/api/routes/{id}` - Remove route

## Setup

1. Clone the repository
2. Open solution in Visual Studio
3. Update connection string in `appsettings.json` if needed
4. Run migrations in Package Manager Console:
   ```powershell
   Add-Migration InitialCreate
   Update-Database
   ```
5. Run the project (F5)
6. Navigate to `/swagger` for API documentation

## Database

SQL Server LocalDB with seeded Montreal STM bus routes including:
- Route 24 (Sherbrooke)
- Route 80 (Du Parc)
- Route 165 (Côte-des-Neiges)
- Route 10 (De Lorimier)
- Route 45 (Papineau)
- And more...

## Academic Project

Built for college web development assignment demonstrating ASP.NET Core Areas, Repository Pattern, and EF Core integration.

## License

Academic project - All rights reserved
