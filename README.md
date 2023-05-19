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
5. Within the production directory "Template", run `dotnet watch run` in the command line to start the project in development mode with a watcher.
4. Open the browser to _https://localhost:5001_.

```json
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=[YOUR DATABASE NAHE HERE];uid=[YOUR USERNAME HERE];pwd=[YOUR PASSWORD HERE];"
  }
}
```

## Below is a rendering of the table relationships
![photo of SQL designer](./HairSalon/wwwroot/imgs/SQLDesigner.png)

## Known Bugs
* _None_

## License 

MIT License

Copyright (c) 2023 Sarah Reimann

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.



