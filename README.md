# "Biblioteka" app for library management ![AppIcon-4](https://user-images.githubusercontent.com/110130588/212317785-e0d8c0f2-8d79-436f-bf45-1dd765bd9cdb.png)

This is a simple library management system i created using C# language and ADO.NET technology for the purpose of my bachelor's dissertation.

The app functionalities are majorly based on its MS SQL database connection, in which many function-specific query procedures are stored.

It allows the user to:

* manage book inventory

* library staff

* handle reader services

* monitor the book stock


### A few select screenshots of the main menu UI:

Book function panel:
![image](https://user-images.githubusercontent.com/110130588/212320162-8a979db7-7bd6-4cb4-bc90-8565f3562045.png)

Reader function panel:
![image](https://user-images.githubusercontent.com/110130588/212320260-9d376695-dabc-4813-b36b-555a04292342.png)

Staff function panel:
![image](https://user-images.githubusercontent.com/110130588/212320344-ab5e48e1-75ee-4eff-a8fa-b718a4912203.png)

Book inventory view:
![image](https://user-images.githubusercontent.com/110130588/212415058-ff47d7a9-bccb-48a6-ac76-eee393f19406.png)

Book adding function:
![image](https://user-images.githubusercontent.com/110130588/212415133-eebddf34-8c53-40fa-8ad3-0aa4fd01f3e6.png)

#### DISCLAIMER: 

##### During development and testing, the database for this app was hosted with free trial of Google Cloud SQL Server Plan, therefore for testing, it is advised to recreate a database using provided ".sql" and ".bak" files within project's "/Database" directory, and replace connection strings within the code in files:

* App.config

* Settings.settings

* Settings.Designer.cs
