# DB-recycling
3d course, Microsoft SQL Server database, Visual Studio GUI for it

This project helps to schedule the export of sity domestic waste,
control the separate garbage collection and union transport companies work and recycling companies.

### About DB
Database contains companies data, gathering places, factories, export scheduler, information about containers and employee's personal info.


![](/data_models/relational_data_model_official.png)

### About GUI
The client application can be used by transport company administrators and garbage truck drivers. 
- administrators have access to the schedule table and crew tables, 
- drivers have limited access to the schedule table. 

Users can view, edit existing notes or add new ones.

## How load DB
- load `.mdf` and `.ldf` files in MS SQL
- take code for creation DB from `script_texts\database_creating_script.txt`

#### SQL-query, code of functions
All my queries, functions and triggers are saved in `script_texts\console_query_func_trigger.txt`

## How load GUI
1. load `AppForDB_Recycling` and `OleDbConnection.udl`
2. reconstruct DB (check How load DB)
3. run this project in VS
