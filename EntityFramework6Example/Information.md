This project uses a SQL-Server database, Entity Framework 6 code first from an existing database. 

Prior to running this project:

- From Solution Explorer, right click, select restore NuGet packages
- Create a database named NorthWindAzureForInserts
- Run the supplied data script in NorthWindAzureForInserts database to generate tables with data.
- In app.config locate the connection string (see below), change data source to the name of an existing SQL-Server e.g. .\SQLEXPRESS.

```xml
  <connectionStrings>
    <add name="NorthWindAzureContext" 
         connectionString="data source=KARENS-PC;initial catalog=NorthWindAzureForInserts;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework" 
         providerName="System.Data.SqlClient" />
  </connectionStrings>
```
**Notes**
Usually when working with Entity Framework created by adding the model the classes are placed in the project's root folder while in this project those classes have been moved to a folder to keep the project structure clean.

Under Classes folder resides two classes, one class for returning data to the form to populate the DataGridView while the other class is for performing a single read operation.

Contact type would had been a DataGridViewComboBox if the intent was to manipulate data although this is not the intent of this code sample which is to show how sort columns in a DataGridView.