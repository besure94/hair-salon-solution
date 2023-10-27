## Eau Claire's Salon

#### A web application that allows a user (Claire) to manage her stylists and their clients.

#### By Brian Scherner

## Technologies Used

* C#
* .NET
* ASP.NET MVC
* EF Core
* MySQL Workbench

## Description

This application presents Claire with a home page where she is presented with a link to a list of clients, and a link to a list of stylists. Claire can navigate to the list of stylists, and add new stylists to the list by their name and specialties. Each stylist will have details about their specialties, which can be viewed by selecting a specific stylist from the list.

Once a stylist has been added to the list, users can then navigate to the client list. There, they can add new clients to a specific stylist. **Note: At least one stylist must be added before a client can be added.** Claire can also select a client, and view which stylist they see. Claire also has the option to edit and delete clients and stylists.

## Setup Instructions

### Install Tools

Install the required tools that are introduced in [this series of lessons on LearnHowToProgram.com](https://old.learnhowtoprogram.com/fidgetech-3-c-and-net/3-0-lessons-1-5-getting-started-with-c/3-0-0-01-welcome-to-c).

### Setup Project Database

Follow these instructions in the LearnHowToProgram.com lesson
["Introduction to MySQL Workbench: Creating a Database"](https://old.learnhowtoprogram.com/fidgetech-3-c-and-net/3-3-database-basics/3-3-0-04-introduction-to-mysql-workbench-creating-a-database)to create a database. Use your first and last name to name your database like this: `firstname_lastname`. Click "Apply" and then "Finish".

Now, create two tables, with one named `stylists` and the other named `clients`. For the `stylists` table, create columns for "StylistId", "Name", and "Specialties". Make sure that "StylistId" has its datatype set to INT. For the boxes to the right, select PK (Primary Key), NN (Not Null), and AI (Auto Incrementing). For "Name" and "Specialties", set the datatype to VARCHAR(255) for each one. Click "Apply" to save these changes.

For the `clients` table, create columns for "StylistId", "ClientId", and "Name". Set the datatype for "StylistId" to INT, and make sure to set its Default/Expression to 0. Set the datatype for "ClientId" to INT. For the boxes to the right, select PK (Primary Key), NN (Not Null), and AI (Auto Incrementing). For "Name", set the datatype to VARCHAR(255). Click "Apply" to save these changes.

### Setup and Run Project

1. Select the green button that says `Code`, and clone this repository to your desktop.
2. Open your terminal and navigate to this project's production directory called `HairSalon`.
3. In the production directory `HairSalon`, create a new file called `appsettings.json`.
4. In `appsettings.json`, put in the following code. If you are using the default userID and password from the LearnHowToProgram.com lessons, `uid` will be `root` and `pwd` will be `epicodus`. If you used your own userID and password, see the example below for how to format this:

```json
{
    "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=firstname_lastname;uid=[YOUR-USERNAME-HERE];pwd=[YOUR-PASSWORD-HERE];"
    }
}
```

5. In the production directory `HairSalon`, run the command `dotnet watch run` to launch the project in development mode with a watcher.
6. Your browser should open to [https://localhost:5001](https://localhost:5001). If you can't access localhost:5001, it is likely because you have not configured a .NET developer security certificate for HTTPS. To learn about this, read this LearnHowToProgram.com lesson [Redirecting to HTTPS and Issuing a Security Certificate](https://old.learnhowtoprogram.com/fidgetech-3-c-and-net/3-2-basic-web-applications/3-2-0-17-redirecting-to-https-and-issuing-a-security-certificate).

## Known Bugs

Application is fully functional.

## License

MIT

Copyright(c) 2023 Brian Scherner