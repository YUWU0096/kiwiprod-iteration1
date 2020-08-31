HopeMe
A Refugee Employment Seeking Solution
Version 1.0

Prerequisites:
    Visual Studio 2019 or later
    IIS 10.0 EXPRESS
    SQL server 2019

Installing:
    Simply run kiwiprod-iteration1.sln with Visual Studio 2019, than click on "Build" in the menu, then select "Build Solution". When the build complete, click on IIS EXPRESS on the tool bar, or press "Ctrl" and "F5" at the same time.
    
Delplyment:
   Since our webs is deployed based on ASP.NET, so I use azure APP service to publish our website. We also change our local datase to SQL server database by configuring the Azure SQL database.Besides, we set firwall for the web and change model to web model. Moreover, adding custom domains to use our own domain with SSL file.
Built With:
    C# .NET MVC

Authors:
    Anzhela Matveenko, 
    Can Liang, 
    Vaishnavi Bulbule,
    Yu Wu
    
License:
    This project is licensed under the Academic Free License v3.0 (AFL-3.0).
