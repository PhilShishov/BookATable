# Book A Table
WindowsForms & Entity Framework

 ## Technologies
 * C# .NET, SQL Server, EF, LINQ
 * Windows Messages, Winforms Controls, DataGridView, ComboBox, BindingSource 

Desktop application that implements a restaurant booking. The users can add/edit other users, restaurants and reservations.

The project adheres to the so-called three-tier architecture. Database layer, Data access layer for our repositories, and GUI - Presentation layer.
Data is stored on a relational database. Access to data is realized with Entity
Frame and Repository pattern. The presentation layer is implemented with Windows
Forms.

## Installation
When in visual studio click on rebuild solution. 
If not working there is a Nuget package, which you ca download from package manager - Entity Framework

The app needs also :
 - Microsoft SQL Server (Express Basic)
 - Microsoft SQL Server Management Studio (Recommended)
 
 
 If still not working you may need to do this : 
 
1. check SQL Server Configuration Manager and enable services SQL Server and SQL Server Browser
 - enable TCP/IP and Named Pipes in Protocols for SQLEXPRESS
 - also in TCP/IP -> properties -> IPALL -> Port -> 1433
2. In Windows Firewall Advanced Settings -> Inbound Rules -> New Rule -> UDP and Port 1434


 Migrations with Package Manager Console: 
 
 - Enable-Migrations -EnableAutomaticMigrations
 - Update-Database
 
<img src="https://image.ibb.co/mOVASp/bookatable.png">


## Using

The main form contains three forms - Users, Restaurants and Reservations each of them containing   
ToolStripMenu, DataGridView and BindingSource each for User, Restaurant and Reservation entities respectively.  

Each form of add and edit an object contains controls equal to the number of  
properties and corresponding to their types, as well as two buttons for save and cancel.

User authentification login can be used after storing an administrator and uncomment BookATable.cs
