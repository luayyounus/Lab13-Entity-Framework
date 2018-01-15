# Star Gazers University ASP.NET Core Application
**Author**: Luay Younus

## Overview
Web app that allows students to enroll into new courses at the Star Gazers university. The main purpose of this app is to practice Entity Framework with actual implementation. Sorting mechanisms are used in the App.

## Architecture
 - C# ASP.NET Core application.
 - MVC architectural design pattern.
 - Entity Framework (Object-Relational Mapper)

## Requirements to run the Application
- [Visual Studio 2017 Community with .NET Core 2.0 SDK](https://www.microsoft.com/net/core#windowscmd)
- [GitBash / Terminal](https://git-scm.com/downloads) or [GitHub Extension for Visual Studio](https://visualstudio.github.com)

## Getting Started
1. Clone the repository to your local machine.
2. Cd into the application directory where the `AppName.sln` exist.
3. Open the application using `Open/Start AppName.sln`.
4. Once Visual Studio is opened, you can Run the application by clicking on the Play button <img src="https://github.com/luayyounus/Lab02-Unit-Testing/blob/Lab02-Luay/WarCardGame/play-button.jpg" width="16">.
5. The website will run on your default web browser routing to the main home page.

# What to expect the first you run the app?
- A welcome message with a form to fill in order to enroll into a course at the Star Gazers University.
- Very simple UI with a table that enlist all students enrolled with their classes and other information.
- Not found page that shows whenever a wrong entry happen or a bad route is requested.

# Main components of the Application
 - DbContext for dependency injection
 - Two Main controllers
 - One Main Student Model
 - ASP Tag Helpers are used for routing

# Testing
##### An InMemory Context is implemented for testing purposes
```C#
DbContextOptionsBuilder<StudentDbContext> builder = new DbContextOptionsBuilder<StudentDbContext;
builder.UseInMemoryDatabase;
DbContextOptions<StudentDbContext> options = builder.Options;
_context = new StudentDbContext(options);
```

# Dependencies and Packages
- AspNetCore.All
- EntityFrameworkCore.InMemory
- EntityFrameworkCore.Tools
- Xunit
- Xunit.Runner
