# ASP.NET_Core
## Create migrations
```
dotnet ef migrations add InitialModel --context InfrastructureContext -p ../ASP.NET_Core.Infrastructure/ASP.NET_Core.Infrastructure.csproj -s ASP.NET_Core.MvcWebApp.csproj -o Data/Migrations
```
## Create database
```
dotnet ef database update -c InfrastructureContext -p ../ASP.NET_Core.Infrastructure/ASP.NET_Core.Infrastructure.csproj -s ASP.NET_Core.MvcWebApp.csproj
```
