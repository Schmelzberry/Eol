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

[Epicodus Online (EOL)](epicodus-online.azurewebsites.net) is an AIM-inspired message service that allows users to communicate real-time in a public chat room, or one-on-one in a private conversation with another user. 

<img src="https://github.com/Schmelzberry/Eol/blob/main/Eol/wwwroot/img/eol-chat.png" alt="EOL chatroom.">

To be granted access to the chat functionality of the web application, a user must first register an account with the application's authentication service. In fact, upon visiting the website for the first time, a user will be greeted by a login form:

<img src="https://github.com/Schmelzberry/Eol/blob/main/Eol/wwwroot/img/login-d.png" alt="EOL account login view.">

### 🐛 Known Bugs

* If any bugs are discovered, please contact the project's authors.

### 🔨 Built With

- [Visual Studio Code](https://code.visualstudio.com/)
- [C#](https://docs.microsoft.com/en-us/dotnet/csharp/)
- [Azure](https://azure.microsoft.com/)
- [ASP.NET Core MVC 6.0.0](https://docs.microsoft.com/en-us/aspnet/core/mvc/overview?)
- [ASP.NET Core SignalR Library](https://learn.microsoft.com/en-us/aspnet/core/tutorials/signalr)
- [MySQL 8.0.34](https://dev.mysql.com/)
- [Entity Framework Core 6.0.0](https://docs.microsoft.com/en-us/ef/core/)
- [Entity Framework Core CLI Tools 6.0.0](https://learn.microsoft.com/en-us/ef/core/cli/dotnet)
- [Entity Framework Core Identity 6.0.0](https://learn.microsoft.com/en-us/aspnet/core/security/authentication/identity)
- [Miro Board](https://miro.com/)

---

## 🏁 Getting Started

### 📋 Prerequisites

#### Install .NET Core

* On macOS with Apple Chip:
  * [Click here](https://dotnet.microsoft.com/en-us/download/dotnet/thank-you/sdk-6.0.402-macos-arm64-installer) to download the .NET Core SDK from Microsoft Corp for macOS.
* On macOs with Intel Chip:
  * [Click here](https://dotnet.microsoft.com/en-us/download/dotnet/thank-you/sdk-6.0.402-macos-x64-installer) to download the .NET Core SDK from Microsoft Corp for macOS.
* On Windows:
  * [Click here](https://dotnet.microsoft.com/en-us/download/dotnet/thank-you/sdk-6.0.402-windows-x64-installer) to download the 64-bit .NET Core SDK from Microsoft Corp for Windows.

#### Install `dotnet script`

In Terminal for macOS or PowerShell for Windows, enter the following command to install the REPL dotnet-script:

 ```
 $ dotnet tool install -g dotnet-script
 ```

#### Install `dotnet-ef`

For Entity Framework Core, we'll use a tool called dotnet-ef to reference the project's migrations and update our database accordingly. To install this tool globally, run the following command in your terminal:

```
$ dotnet tool install --global dotnet-ef --version 6.0.0
```

Optionally, you can run the following command to verify that EF Core CLI tools are correctly installed:

```
$ dotnet ef
```

#### Install MySQL Workbench

This project assumes you have MySQL Server and MySQL Workbench installed on your system. If you do not have these tools installed, follow along with the installation steps for the the necessary tools introduced in the series of lessons found here on [LearnHowToProgram](https://full-time.learnhowtoprogram.com/c-and-net/getting-started-with-c/installing-and-configuring-mysql).

Or, [Download and install the appropriate version of MySQL Workbench](https://dev.mysql.com/downloads/workbench/).

#### Code Editor

To view or edit the code, you will need an code editor or text editor. The popular open-source choices for an code editor are Atom and VisualStudio Code.

1. Code Editor Download:

- [VisualStudio Code](https://code.visualstudio.com/)

2. Click the download most applicable to your OS and system.
3. Wait for download to complete, then install -- Windows will run the setup exe and macOS will drag and drop into applications.
4. Optionally, create a [GitHub Account](https://github.com)

### ⚙️ Setup and Use

#### Cloning

1. Navigate to the project directory, [project repository here,](https://github.com/Schmelzberry/Eol).
2. Click 'Clone or download' to reveal the HTTPS url ending with .git and the 'Download ZIP' option.
3. Open up your system Terminal or GitBash, navigate to your desktop with the command: `$ cd Desktop`, or whichever location suits you best.
4. Clone the repository to your desktop: `$ git clone https://github.com/Schmelzberry/Eol` and navigate to root directory of project.
5. Run the command `$ cd Eol` to enter into the project directory.
6. View or Edit:
   - Code Editor - Run the command `$ code .` to open the project in VisualStudio Code for review and editing.

#### AppSettings

1. Create a new file in the project directory named `appsettings.json`
2. Add in the following code snippet to the new appsettings.json file:

```
{
   "Logging": {
       "LogLevel": {
       "Default": "Warning"
       }
   },
   "AllowedHosts": "*",
   "ConnectionStrings": {
       "DefaultConnection": "Server=localhost;Port=3306;database=eol;uid=[USERNAME];pwd=[PASSWORD];"
   }
}
```

3. Change the server, port, and user id as necessary. Replace `[USERNAME]` and `[PASSWORD]` with your personal MySQL username and password (set at installation of MySQL).

#### Database

  1) Navigate to Eol/Eol directory using the MacOS Terminal or Windows Powershell (e.g. `cd Desktop/Eol/Eol`).
  2) Run the command `dotnet ef database update` to generate the database through Entity Framework Core.
     1) (Optional) To update the database with any changes to the code, run the command `dotnet ef migrations add <MigrationsName>` which will use Entity Framework Core's code-first principle to generate a database update. 
  3) After, run the previous command `dotnet ef database update` to create and update the project database.

#### Run the Application

1) Now that everything is in place, all that's left to do is compile and launch the application. While in the project's main directory (e.g. `cd Desktop/Eol/Eol`), run the following command in your terminal:
   
   ```
   $ dotnet watch run
   ```
  > Optionally, you can run `dotnet build` to compile this web app without running it.

2) Open your browser to https://localhost:5001 to navigate and use the web application. 
> If you cannot access localhost:5001 it is likely because you have not configured a .NET developer security certificate for HTTPS.

##### Alternatively:

1) You can access the web application directly via the following link: 
   * https://epicodus-online.azurewebsites.net/

### ⚖️ License

This project is licensed under the [MIT License](https://opensource.org/licenses/MIT).

Copyright (c) Jake Elsberry, Joey Palchak, Paul LeTourneau, Moses Atia Poston, Seth Gonzales

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

```

```
