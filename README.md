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

### Import Project Database

If necessary, reference [this lesson on LearnHowToProgram.com](https://old.learnhowtoprogram.com/fidgetech-3-c-and-net/3-3-database-basics/3-3-0-08-creating-a-test-database-exporting-and-importing-databases-with-mysql-workbench) for instructions on how to import a database.

1. From GitHub, select the green button that says `Code`, and clone this repository to your desktop.
2. Open MySQL Workbench and go to the *Navigator > Administration* window on the left.
3. In *Import Options*, select *Import from Self-Contained File*.
4. Navigate to the file `brian.scherner.sql`. Depending on your machine and folder setup, this may look slightly different for you.
    * Example: *C:\Users\[YOUR-USER-NAME]\Desktop\hair-salon-solution\brian_scherner.sql*
5. Under *Default Schema To Be Imported To*, select the *New* button.
6. Enter the name of your database. Use your first and last name, as in `firstname_lastname`.
7. Select *Ok*.
8. Select *Start Import* at the bottom right corner of the window.
9. Reopen the *Navigator > Schemas* tab. Right click and select *Refresh All*. The new database will now appear.

### Setup and Run Project

1. Open your terminal and navigate to this project's production directory called `HairSalon`.
2. In the production directory `HairSalon`, create a new file called `appsettings.json`.
3. In `appsettings.json`, put in the following code. If you are using the default userID and password from the LearnHowToProgram.com lessons, `uid` will be `root` and `pwd` will be `epicodus`. **Note: the database name must always match the name of the database you created in the "Import Project Database" instructions above**. If you used your own userID and password, see the example below for how to format this:

```json
{
    "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=firstname_lastname;uid=[YOUR-USERNAME-HERE];pwd=[YOUR-PASSWORD-HERE];"
    }
}
```

4. In the production directory `HairSalon`, run the command `dotnet watch run` to launch the project in development mode with a watcher.
5. Your browser should open to [https://localhost:5001](https://localhost:5001). If you can't access localhost:5001, it is likely because you have not configured a .NET developer security certificate for HTTPS. To learn about this, read this LearnHowToProgram.com lesson [Redirecting to HTTPS and Issuing a Security Certificate](https://old.learnhowtoprogram.com/fidgetech-3-c-and-net/3-2-basic-web-applications/3-2-0-17-redirecting-to-https-and-issuing-a-security-certificate).

## Known Bugs

Application is fully functional.

## License

MIT

Copyright(c) 2023 Brian Scherner