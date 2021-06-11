# _Cat Kingdom API_

### _Building an API with Swagger Documentation_

##### By:
#####  _**Jamie Knutsen**_ _©2021_


## Technologies Used

* _Visual Studio Code_
* _.NET_
* _C#_
* _Entity Framework Core (EF Core)_
* _ASP.NET Core MVC_
* _MySQL_
* _Swagger_
* _Postman (Optional)_


## Description: 
This project was designed as practice for building a basic Web API from scratch using C# and .NET with the implementation of Swagger documentation.


## Setup/Installation Requirements
_You can view this webpage by checking out the url:_
<!-- enter url here -->

### Prerequisites
* [C# & .NET] Install at (https://dotnet.microsoft.com/download/dotnet/thank-you/sdk-5.0.100-macos-x64-installer) (If Mac) OR https://dotnet.microsoft.com/download/dotnet/thank-you/sdk-5.0.102-windows-x64-installer (If Windows)
* [dotnet script] After installing C# and .NET, run the command 'dotnet tool install -g dotnet-script' in your computer's terminal or text editors terminal. 
* A text editor such as [VS Code] (https://code.visualstudio.com/)
* For the database, you'll need to install MySQL (https://dev.mysql.com/downloads/file/?id=484914). I also suggest using MySQL workbench as a GUI for viewing databases to check that they're up to date. 

### Installation
1. Open terminal
2. Input these commands into terminal's command line `cd desktop`
<!-- 3. Clone repo link from github -->
4. Run the command `code .` in your computer's terminal
5. Open VS Code or other preffered text editor terminal within the project file
6. To install and make sure all needed packages are up-to-date, navigate into the CatKingdom folder from root directory by entering `cd CatKingdom` in terminal.
    * Type the command `dotnet restore` to update and restore all needed packages and dependencies to run application.
7. In order to use the database you must make an appsettings.json file. Run the command `touch appsettings.json` in the `CatKingdom` directory of the project. 
    * Then, enter in your own approppriate username (or enter 'root' in the YOUR-USERNAME-HERE field), and whichever password you used to open, use, and create the imported database in MySQL Workbench- use it and enter it as follows in this line 'database=cat_kingdom;uid=[YOUR-USERNAME-HERE];pwd=[YOUR-PASSWORD-HERE]' *do NOT actually put []- this is just for visual purposes to see where to change the information*
    * Finally, paste it exactly like in this example, 
    {
        "Logging": {
            "LogLevel": {
            "Default": "Information",
            "Microsoft": "Warning",
            "Microsoft.Hosting.Lifetime": "Information"
            }
        },
        "AllowedHosts": "*",
        "ConnectionStrings": {
            "DefaultConnection": "Server=localhost;Port=3306;database=cat_kingdom;uid=[YOUR-USERNAME-HERE];pwd=[YOUR-PASSWORD-HERE];"
        }
    }
    and paste it into the appsettings.json to use the database. *WARNING: This file should automatically be ignored AS LONG AS it is in the CatKingdom directory and NOT the root directory (as it is listed in the .gitignore). However, Be aware of what you are committing and pushing to avoid pushing your personal username and password- as it is sensitive data* Your database should now be connected. 
8. To create and run the database, navigate back to the root directory `cd Practice1.Solution` and enter the command `dotnet tool install --global dotnet-ef` in the terminal to enable EF Core migrations if not already enabled.
    * Then, if you plan on changing the controller files at all or the models and do make changes, be sure to navigate back into the project folder `cd CatKingdom`, and run the command `dotnet ef migrations add [NAME OF YOUR MIGRATION]` to add an updated migration so that the database updates correctly. Naming conventions for migrations work like a git commit- so be sure to be verbose. 
    * After you add migrations, or if you don't add any at all and just want to use the projects exsisting migrations, navigate into the `CatKingdom` directory again if not there already, and run the command `dotnet ef database update`. You should now be able to open MySQL workbench and see a database named `cat_kingdom` that includes all of the projects correct tables and be able to use the database for this API.  
10. Finally, navigate into root directory folder in terminal `cd CatKingdom.Solution` and  enter command `dotnet run` or `dotnet watch run` to run the program. 

### Full API Documentation
1. If interested in viewing CatKingdoms endpoints, you can use Postman like so:
    * Start by running the command `dotnet run` in the `CatKingdom` project folder if you haven't already to get a server up and running. 
    * Then, navigate to https://www.postman.com and make an account if you haven't already. Once signed in,press "Launch Postman". On the left-hand side, look for the "Workspaces" tab, and select it. Once inside, select "My Workspace". 
    * Once you are inside of your workspace, look almost directly under the search bar on the top- there will be an "Overview" and a "+" Tab. Navigate over to the "+" Tab. 
    * For GET requests: to get all the cats in this API, enter http://localhost:5000/api/Cats into the "GET" search bar and select send. Then, the correct response should appear in the "Pretty" Tab as a JSON response exactly like this:
    [
    {
        "catId": 1,
        "name": "Peppermint",
        "breed": "Tuxedo/American Shorthair",
        "description": "The most chill cat you will ever meet. Peppermint loves snuggles, catnip, and his favorite mouse toy that has a bell inside of it.",
        "age": 7,
        "gender": "Male"
    },
    {
        "catId": 2,
        "name": "Mocha",
        "breed": "Calico/American Shorthair",
        "description": "A little fiesty at times, Mocha loves to love on HER terms- but when she does, she can be a real sweetheart. Her favorite things include wet food, and her ball toy that makes crinkle sounds.",
        "age": 3,
        "gender": "Female"
    },
    {
        "catId": 3,
        "name": "Lola",
        "breed": "Bombay",
        "description": "Talkative af. Will always want to loudly chat it up with you and make her presence known. Lola loves to rub against your legs, say hi, and play with crinkled up pieces of paper.",
        "age": 5,
        "gender": "Female"
    },
    {
        "catId": 4,
        "name": "Charles",
        "breed": "Tabby/American Shorthair",
        "description": "A sweet, patient old gentleman, Charles loves to nap and sit on your lap. He will play a little from time to time with his bird toy.",
        "age": 16,
        "gender": "Male"
    }
    ]
    * To GET by querying the ID: simply enter http://localhost:5000/api/Cats?CatID=[ENTER-ID-NUMBER-HERE] into that same GET search bar and simpy replace the [ENTER-ID-NUMBER-HERE] with an Id number of choice you would like to see. For Example, http://localhost:5000/api/Cats?CatID=1 will return a response exaclty like so:
    {
    "catId": 1,
    "name": "Peppermint",
    "breed": "Tuxedo/American Shorthair",
    "description": "The most chill cat you will ever meet. Peppermint loves snuggles, catnip, and his favorite mouse toy that has a bell inside of it.",
    "age": 7,
    "gender": "Male"
    }
    * Note: You can also GET responses by querying by Breed (such as http://localhost:5000/api/Cats/?breed=Bombay), by Gender (such as http://localhost:5000/api/Cats/?gender=Male), by Name (http://localhost:5000/api/Cats/?name=Mocha), and lastly, by Description (Note: This would probably be a pain so I'd suggest doing the other ones instead for brevity) which would be (http://localhost:5000/api/Cats/?description=A little fiesty at times, Mocha loves to love on HER terms- but when she does, she can be a real sweetheart. Her favorite things include wet food, and her ball toy that makes crinkle sounds.). Finally, simply switch out the specific parameters to retrieve whichever specific data you want (i.e. - switching [?name=Mocha] into [?name=Charles] and so forth.)
    * For POST requests: If you would like to add some cats to this API, Switch the request in the dropdown to the left from GET to POST. Next, deselect the "Params" tab underneath and switch to the "Body" tab. Then, select the radio button that says "Raw" and paste this into the body- replacing all values with the values you want:
    {
    "catId": 0,
    "name": "string",
    "breed": "string",
    "description": "string",
    "age": "int",
    "gender": "string"
    }
    * Finally, after filling out your preferred values, enter in http://localhost5000/api/Cats into the search bar and press "Send".
    * For PUT requests: To edit an exsisting entry with a PUT request, select the dropdown from GET or POST to PUT instead. Again, select the "Body" tab, and select the "raw" radio button. Post the following into the body and replace the values as you would like just as you would in the POST request:
    {
    "catId": 0,
    "name": "string",
    "breed": "string",
    "description": "string",
    "age": "int",
    "gender": "string"
    }
    * Finally, after filling out your preffered values, enter in http://localhost5000/api/Cats/[THE-ID-NUMBER-YOU-WANT-TO-EDIT/REPLACE] Ex: If you wanted to replace Peppermint (who has the id of one), you'd put http://localhost5000/api/Cats/1.
    * For DELETE requests: To delete one of the cats from this API, select GET in the searchbar drop down and select DELETE instead. Then, paste in http://localhost5000/api/Cats/[THE-ID-NUMBER-YOU-WANT-TO-DELETE] Ex: If you wanted to delete Mocha (who has the id of two), you'd put http://localhost5000/api/Cats/2. 
    * Finally, hit Send to delete the specific entry.
2. To view Swagger Documentation: Run `dotnet run` in the CatKingdom project folder to open up a local server, then paste the address http://localhost:5000/swagger in your URL bar to see the swagger documentation for CatKingdom API. Once the swagger UI is accessed, you can play around with the "Try out" and "Execute" buttons to see how each of the endpoints work!


## Licensing

Licensed under the [MIT License](license).

## Contact Information

_Jamie Knutsen (knutsenjamie@yahoo.com)_
