# ASP.NET-WebApp-iStock



# Build full stack web app with ASP.NET Core, Entity Framework Core , HTML, CSS, JavaScript, and C#  in a Real-Word Example 
This article explains aspnetrun basic realworld repository of github. This series of articles continues as per difficulty levels. This article intended for the beginners of asp.net core. You can follow the other articles at the end of the page.

# Introduction
In this article we will show how to build web application on ASP.NET Core Web application using Entity Framework and Razor Pages.

By the end of the article, we will have an web application which implemented mini e-commerce pages over Product,Category and Contact entities.

Take a look at the final application.


# You’ll learn how to:

Create an ASP.NET Core Web Application Project
Work with a Database using Entity Framework Core
Bootstrap 4 Theme Implementation
ASP.NET Core Identity Scaffolding and Identity Configuration
Authorization for Pages
ASP.NET Core Razor Tools — View Components, partial Views, Tag Helpers, Model Bindings and Validations, Razor Sections etc..
At the end, you’ll have a working web application running on your local machine.
Source Code
Get the Source Code from AspnetRunBasic RealWorld Github — Clone or fork this repository, if you like don’t forget the star :) If you find or ask anything you can directly open issue on repository.

# Prerequisites
Install the .NET Core 3.x or above SDK
Install Visual Studio 2019 v16.x or above
Microsoft Sql Server Express (its comes with Visual Studio)
Background
You can follow the previous article which base application of this implementation of this Basic repository in a real-world example.

Check for the previous article which explained base of this repository.

Based on that we were created a basic infrastructure of crud operations on asp.net core web application from previous post. Over this repository, we are going to create a basic real-world web application with using ASP.Net Core best practices.


# Project Structure
Examine the project files
Here’s an overview of the main project folders and files that you will work with in our operations.

Entities folder
This folder include model classes which we use all layers and manage this entities when Entity Framework Core persist on database and other database operations. We will use this folder for the new Entity definitions.

Data folder
This folder represent our Data Layer and includes Entity Framework Core implementation. Also include Seed class in order to load data when application start-up. We will add our Entities as a DBSet into DBContext object.

Migrations folder
This folder generated from Entity Framework Core in order to perform Migrations to the database. We will not modify this folder.

Repositories folder
This folder represent our Business Layer and includes Repository classes which wrappers of Entity Framework Core DbContext object. Since this is the one solution, we decided to named folder as Repository due to implement both wrapping EF.Core and implement business related logic's in one class.

Pages folder
This folder represent our Presentation Layer and includes Razor pages and supporting files. We will extend existing pages and add new Areas to implement e-commerce web application.

Starting Our Project
This project will be basic implementation of e-commerce web application. So we should define our basic use case analysis. In this post we will create Product — Category — Contact entities and create its relation. Our main use cases;

Listing Products and Categories
Login the system as a user
Authorize the Product page only see the logon users
Contact page which send Message to company, include post operations
Subscribe e-mail list
Set Entities
Go to Entities folder into your project. This will be the tables of your project. In this post, we will use the Code First Approach of the Entity Framework Core. That’s why we write the entity classes at first.
Add or Edit Product, Category and Contact class into Entities folder.

Its not meaningfully when e-commerce application authorize Product page but we will use an example of authorization. You can change your authorized page as per your design.

# Adapt UI Pages with Bootstrap 4
Since here we developed Product Data and Business Layer and also apply ASP.NET Identity module in our project. So in presentation layer we should apply some theme and layouts for listing this categories and its products on the page.
So the next steps should cover below parts;

# Bootstrap 4 Theme Implementation
ASP.NET Core Razor Tools — View Components, partial Views, Tag Helpers, Model Bindings and Validations, Razor Sections etc..
For the rest of the application, I recommend to follow aspnetrun e-books in order to develop step by step a real-world application in every level of asp.net core.

# Conclusion
This article demonstrate that how to build a basic e-commerce web application in a one solution and one project with ASP.NET Core & Entity Framework Core which used main components; razor pages, middlewares, dependency injection, configuration, logging. Provided that to create websites with minimum implementation of asp.net core based on HTML5, CSS, and JavaScript. We created a sample basic e-commerce product record management system and performed post operations on it.
For the rest of the application, I recommend to follow aspnetrun e-books in order to develop step by step a real-world application in every level of asp.net core.
