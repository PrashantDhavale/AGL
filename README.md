# AGL
A temporary repo for AGL challenge

# Prerequisites on Windows
- .Net Core 2.1.2 SDK (Download from https://www.microsoft.com/net/download/windows)
- Node 8.6.0 
- npm 5.3.0

# GITHUB
  Open command prompt and clone the AGL repo at any drive/folder of your choice
  
  git clone https://github.com/PrashantDhavale/AGL.git

# Folder structure 

  The clone will create a new folder AGL -> (Root folder)

    PeopleWithPets.DataAccess
    PeopleWithPets.Domain
    PeopleWithPets.WebAPI
    PeopleWithPets.WebUI
    Tests
    PeopleWithPets.sln
    README.md
    
# Build assemblies
    On the command prompt inside the root folder
    dotnet build
    
# Executing the application

  Execution is 2 parts
  
  (a) WebAPI
  
       a.1) Command prompt -> browse to PeopleWithPets.WebAPI
       
       a.2) dotnet run
       
  (b) WebUI
  
       b.1) Command prompt -> browse to PeopleWithPets.WebUI
  
       b.2) npm install (required only once & this will take some time for downloading assemblies)
       
       b.3) ng build -prod
       
       b.4) ng serve -open      
