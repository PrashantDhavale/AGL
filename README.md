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
    
# Test assemblies
    On the command prompt inside the root folder
    dotnet test
    
# Executing the application

  Execution is 2 parts
  
  (a) WebAPI
  
       a.1) Command prompt -> browse to PeopleWithPets.WebAPI
       
       a.2) dotnet run
            This will run the WebAPI and the prompt will display the localhost address where it is listening
            http://localhost:5000/api/PeopleWithPets
       
       a.3) On a web browser browse to http://localhost:5000/api/PeopleWithPets and check if the API is running. 
            It should return the response as JSON.
       
  (b) WebUI
  
       b.1) Command prompt -> browse to PeopleWithPets.WebUI
  
       b.2) npm install (required only once & this will take some time for downloading packages)
       
       b.3) ng build -prod
       
       b.4) ng serve -open
            This will pop up a new browser and display the default page with a Information button.
       
       b.5) Click the Blue information button
       
       
