# EShopCsv

EShopCSV is an MVC web application with the following features:
- importing a CSV file with product data using the web interface
- storing the product data in a SQL Server database
- updating existing product data when importing a CSV file 
- an overview page with all the products from the imported CSV(s) files.

## Prerequirements

* Visual Studio 2017 
* .NET Core 2.1 SDK 

## Frameworks Used

* .NET Core 2.1
* Entity Framework Core 2.1

## Libraries Used

* LumenWorksCsvReader - used to parse and read the CSV file
* EntityFrameworkCore Bulk Extensions - used to perform bulk insert or update (merge) 
* MediatR - mediator implementation in .NET used to support queries and commands
* AutoMapper - used for object-to-object mapping

## How to create the database

* Open solution in Visual Studio 2017
* Open the **appsettings.json**  file from **EShop.Infrastructure**
* Add the **connectionstring** for the SQL Server where the database will be created
```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=.\\;Database=EShopDb;Trusted_Connection=True;MultipleActiveResultSets=true"
  }
}
```
* From cmd run:
```sh
EShop\EShop.Infrastructure> dotnet run
```

## Architecture overview

The architecture patterns used for this application are based on DDD (Domain-Driven Design) and Command and Query Responsability Segregation (CQRS) approaches using the Mediator pattern.

## Solution overview

### EShop.Domain
- POCO entity classes
- Domain entity models
- Repository interfaces

### EShop.Infrastructure
- data persistance infrastructure: repository implementation
- ORM: Entity Framework Core

### EShop.Presentation
- ASP.NET MVC
- Queries and queries handlers 
- Commands and commands handlers
- Application contracts and implementation.

## ToDos
- add unit tests
- add integration tests
- improve the logical data model.
