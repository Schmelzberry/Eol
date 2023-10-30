<br>

 <p align="center">
    🖥️🖥️🖥️🖥️🖥️🖥️🖥️🖥️🖥️🖥️🖥️🖥️🖥️🖥️🖥️🖥️🖥️
    
</p>
  <p align="center">
  🖥️🖥️🖥️🖥️🖥️<u><big>|| <b>EOL - Epicodus Online</b> ||</big></u>🖥️🖥️🖥️🖥️🖥️
</p>
    <p align="center">
      🖥️🖥️🖥️🖥️🖥️🖥️🖥️🖥️🖥️🖥️🖥️🖥️🖥️🖥️🖥️🖥️🖥️
    </p>
    <p align="center">
  <small>Initiated October 30th, 2023</small>
  <br>
  <small>By:</small>
</p>
 <p align="center">
    <a href="https://github.com/Schmelzberry">
        <strong>Schmelzberry</strong>
    </a>
    <br>
       <a href="https://github.com/pletourneau">
        <strong>pletourneau</strong>
    </a>
    <br>
       <a href="https://github.com/sethgonzales">
        <strong>sethgonzales</strong>
    </a>
    <br>
       <a href="https://github.com/Object-ions">
        <strong>Object-ions</strong>
    </a>
    <br>
       <a href="https://github.com/jfpalchak">
        <strong>jfpalchak</strong>
    </a>
    <br>
  </p>
    
------------------------------

## 🗺️ About the Project

### 💻 Description
An AIM-inspired Message service for homies to chat and communicate on.

### 🐛 Known Bugs



### 🔨 Built With
* [Visual Studio Code](https://code.visualstudio.com/)
* [C#](https://docs.microsoft.com/en-us/dotnet/csharp/)
* [ASP.NET Core MVC 6.0.0](https://docs.microsoft.com/en-us/aspnet/core/mvc/overview?view=aspnetcore-3.1)
* [MySQL 8.0.34 for Windows](https://dev.mysql.com/)
* [Entity Framework Core 6.0.0](https://docs.microsoft.com/en-us/ef/core/)

------------------------------

## 🏁 Getting Started

### 📋 Prerequisites

#### Install .NET Core
* On Windows 10 x64 or later
  * [Click here](https://dotnet.microsoft.com/en-us/download) to download the 64-bit .NET Core SDK from Microsoft Corp for Windows. Version 6.0 is used in this project. 
* On macOS Mojave or later
  * [Click here](https://dotnet.microsoft.com/en-us/download) to download the .NET Core SDK from Microsoft Corp for macOS.  Version 6.0 is used in this project. 
#### Install ```dotnet script```
 Enter the command ``$ dotnet tool install -g dotnet-script`` in Terminal for macOS or PowerShell for Windows.

#### Install MySQL Workbench
 [Download and install the appropriate version of MySQL Workbench](https://dev.mysql.com/downloads/workbench/).



#### Code Editor

  To view or edit the code, you will need an code editor or text editor. The popular open-source choices for an code editor are Atom and VisualStudio Code.

  1) Code Editor Download:

  * [VisualStudio Code](https://code.visualstudio.com/)
  2) Click the download most applicable to your OS and system.
  3) Wait for download to complete, then install -- Windows will run the setup exe and macOS will drag and drop into applications.
  4) Optionally, create a [GitHub Account](https://github.com)

### ⚙️ Setup and Use

 #### Cloning

  1) Navigate to the project directory, [project repository here,](https://github.com/Schmelzberry/Eol).
  2) Click 'Clone or download' to reveal the HTTPS url ending with .git and the 'Download ZIP' option.
  3) Open up your system Terminal or GitBash, navigate to your desktop with the command: `$ cd Desktop`, or whichever location suits you best.
  4) Clone the repository to your desktop: `$ git clone https://github.com/Schmelzberry/Eol` and navigate to root directory of project.
  5) Run the command `$ cd Eol` to enter into the project directory.
  6) View or Edit:
      * Code Editor - Run the command `$ code .` to open the project in VisualStudio Code for review and editing.
      


  #### AppSettings

  1) Create a new file in the project directory named `appsettings.json`
  2) Add in the following code snippet to the new appsettings.json file:
  
 ```
{
    "Logging": {
        "LogLevel": {
        "Default": "Warning"
        }
    },
    "AllowedHosts": "*",
    "ConnectionStrings": {
        "DefaultConnection": "Server=localhost;Port=3306;database=national_park_api;uid=root;pwd=Password;"
    }
}
  ```
3) Change the server, port, and user id as necessary. Replace 'Password' with your own relevant MySQL password and userId. (set at installation of MySQL).


### ⚖️ License

This project is licensed under the [MIT License](https://opensource.org/licenses/MIT).

Copyright (c) Jake Elsberry, Joey Palchak, Paul LeTourneau, Moses Atia, Seth Gonzales

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
```

