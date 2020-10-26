# ASP.NET_Core
## Migrations
### Data
#### Create migration
```
dotnet ef migrations add InitialModel --context InfrastructureContext -p ../ASP.NET_Core.Infrastructure/ASP.NET_Core.Infrastructure.csproj -s ASP.NET_Core.MvcWebApp.csproj -o Data/Migrations
```
#### Remove the last migration
```
dotnet ef migrations remove --context InfrastructureContext -p ../ASP.NET_Core.Infrastructure/ASP.NET_Core.Infrastructure.csproj -s ASP.NET_Core.MvcWebApp.csproj
```
### Identity
#### Create migration
```
dotnet ef migrations add InitialIdentityModel --context AppIdentityDbContext -p ../ASP.NET_Core.Infrastructure/ASP.NET_Core.Infrastructure.csproj -s ASP.NET_Core.MvcWebApp.csproj -o Identity/Migrations
```
#### Remove the last migration
```
dotnet ef migrations remove --context AppIdentityDbContext -p ../ASP.NET_Core.Infrastructure/ASP.NET_Core.Infrastructure.csproj -s ASP.NET_Core.MvcWebApp.csproj
```
## Database
### Data
```
dotnet ef database update -c InfrastructureContext -p ../ASP.NET_Core.Infrastructure/ASP.NET_Core.Infrastructure.csproj -s ASP.NET_Core.MvcWebApp.csproj
```
### Identity
```
dotnet ef database update -c AppIdentityDbContext -p ../ASP.NET_Core.Infrastructure/ASP.NET_Core.Infrastructure.csproj -s ASP.NET_Core.MvcWebApp.csproj
```
