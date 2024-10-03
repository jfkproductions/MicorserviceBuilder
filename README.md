# Azure Functions CRUD Generator for MSSQL

This is a C# Windows desktop application that generates full Create, Read, Update, and Delete (CRUD) Azure Functions based on the tables of a selected Microsoft SQL Server (MSSQL) database. It automatically scaffolds model files, builds a Data Access Layer (DAL), and generates the corresponding Azure Functions for each table in the database.

## Features

- **Connect to MSSQL Database**: Easily connect to a Microsoft SQL Server database to fetch table structures.
- **Automatic Model Scaffolding**: Uses Entity Framework Core to scaffold model classes from the connected database.
- **Full CRUD Generation**: Automatically generate Create, Read, Update, and Delete (CRUD) operations for each table in the database.
- **Data Access Layer (DAL)**: Builds a Data Access Layer using repository patterns for the generated CRUD operations.
- **Azure Functions**: Uses templates to generate Azure Functions that encapsulate the CRUD logic for each table.
- **.NET CLI Integration**: Leverages the .NET CLI to build and scaffold files for models, DAL, and Azure Functions.

## Requirements

Before running this application, ensure the following prerequisites are installed:

- [.NET SDK](https://dotnet.microsoft.com/download)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)
- [Entity Framework Core](https://docs.microsoft.com/en-us/ef/core/)
- Azure account for hosting Azure Functions (Optional)

## Usage

### Step 1: Connect to the MSSQL Database

- Launch the application.
- On the home screen, input your MSSQL database connection string.
- Click on the **Connect** button to connect to the database. The application will automatically scaffold the model files from the database tables.

### Step 2: Generate Data Access Layer (DAL)

- After connecting to the database, the application will generate a Data Access Layer (DAL) for the tables in the database.
- The DAL uses repository patterns to handle data operations and is structured to work with the generated Azure Functions.

### Step 3: Generate Azure Functions

- After the DAL is created, the application will use pre-defined templates to generate the following Azure Functions for each table:
  - **Create**: Insert new records into the table.
  - **Read**: Retrieve records from the table.
  - **Update**: Modify existing records.
  - **Delete**: Remove records from the table.
  
- The generated Azure Functions are stored in the output folder selecected.

### Step 4: Build and Deploy Azure Functions

- To build the Azure Functions, the application uses the `.NET CLI`. You can either deploy these functions locally or push them to your Azure account.
- To deploy to Azure, use the following command:
  ```bash
  func azure functionapp publish <YourFunctionAppName>
