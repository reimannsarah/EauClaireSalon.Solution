# Eau Claire's Salon

#### An application for the owner of Eau Claire's salon to keep track of stylists and clients.

#### By Sarah Reimann

## Technologies Used

* _HTML_
* _CSS_
* _C#_
* _.NET 6.0_
* _Razor_
* _MySQL_
* _Entity FrameWork Core_

## Description

An application that allows the user to add stylists and clients. Each stylist can have several clients but each client can only be assigned to one stylist. Stylists come with specialties as well. They either do Cut, Color, or both. 


## How To Run This Project


### Set up the Databases

Using the `sarah_reimann.sql` file located at the top level of this repo, export and import the database to create new database in MySQL WorkBench with your first and last name.

### Set Up and Run Project

1. Clone this repo.
2. Open the terminal and navigate to this project's production directory called "HairSalon".
3. Within the production directory "HairSalon", create a new file called `appsettings.json`.
4. Within `appsettings.json`, put in the following code, replacing the `uid`, `pwd`,an `database` values with your own username and password for MySQL and database name. 

```json
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=[YOUR DATABASE NAHE HERE];uid=[YOUR USERNAME HERE];pwd=[YOUR PASSWORD HERE];"
  }
}
```
![alt text](wwwroot/imgs/SQLDesigner.png)

## Below is a rendering of the table relationships


5. Within the production directory "Template", run `dotnet watch run` in the command line to start the project in development mode with a watcher.
4. Open the browser to _https://localhost:5001_.
