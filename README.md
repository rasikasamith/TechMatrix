# Blazor and Asp.NET Web API CRUD

This is a project that demonstrate CRUD operations with Blazor and ASP.NET Web API.  It is to manage freelancer information. 

# Components

It consists of two main components:
1) Web API 
    -GetUsers: Retrieve a list of freelancers.
    -CreateUser: Add a new freelancer.
    -DeleteUser: Remove a freelancer from the database.
    -UpdateUser: Modify freelancer details.
2) User Interface (UI):
    -Accesses the above API endpoints.
    -Demonstrates CRUD (Create, Read, Update, Delete) operations.

## Technologies

-API: Developed using .NET Core Web API and hosted on Azure App Services. Utilizes dependency injection and follows the Entity Framework Code-First approach.
-UI: Built using Blazor Server and hosted on Azure App Services.
-Database: Powered by Microsoft SQL Server and hosted in Azure.

## Architecture:

This project follows a Service-Based Architecture where a service layer is used to interact with the database. Services provide a structured and modular way to handle data operations, enhancing the maintainability and scalability of the application.

## Usage

-UI: Access the UI at [TechMatrix UI](https://techmatrixui.azurewebsites.net/).
-Web API:Interact with the API at [TechMatrix Web API](https://techmetrixapi.azurewebsites.net/api/user/getusers).
-Database: The database is hosted in Azure at freelancerapidbserver.database.windows.net.

## Features

-Retrieve a list of all freelancers.
-Add new freelancers to the database.
-Delete existing freelancers.
-Edit freelancer details.




