# ASP.NET_Core
## Create migrations
### Data
```
dotnet ef migrations add InitialModel --context InfrastructureContext -p ../ASP.NET_Core.Infrastructure/ASP.NET_Core.Infrastructure.csproj -s ASP.NET_Core.MvcWebApp.csproj -o Data/Migrations
```
### Identity
```
dotnet ef migrations add InitialIdentityModel --context AppIdentityDbContext -p ../ASP.NET_Core.Infrastructure/ASP.NET_Core.Infrastructure.csproj -s ASP.NET_Core.MvcWebApp.csproj -o Identity/Migrations
```
## Create database
### Data
```
dotnet ef database update -c InfrastructureContext -p ../ASP.NET_Core.Infrastructure/ASP.NET_Core.Infrastructure.csproj -s ASP.NET_Core.MvcWebApp.csproj
```
### Identity
```
dotnet ef database update -c AppIdentityDbContext -p ../ASP.NET_Core.Infrastructure/ASP.NET_Core.Infrastructure.csproj -s ASP.NET_Core.MvcWebApp.csproj
```
