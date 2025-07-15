# AgricultureEMS

AgricultureEMS is an ASP.NET Core MVC (7.0) application for managing:
- Crops
- Fields
- Equipment
- Pest/Disease Reports
- User authentication (farmer/admin)
- Dashboard

## Getting Started

1. Set up your SQL Server and update `appsettings.json` with your connection string.
2. Run migrations to create the database:
   ```
   dotnet ef migrations add InitialCreate
   dotnet ef database update
   ```
3. Run the project:
   ```
   dotnet run
   ```
4. Open `https://localhost:5001` in your browser.

## Project Structure

- Models: Data models for the EMS
- Controllers: MVC controllers for each entity
- Views: Razor views for UI
- wwwroot: Static files

## Dependencies

- .NET 7
- Entity Framework Core 7
- ASP.NET Core Identity

---

Contributions welcome!