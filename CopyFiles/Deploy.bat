cd "@@Path"
mkdir "@@ProjectName"
cd "@@ProjectName"
dotnet new -i Microsoft.Azure.WebJobs.ProjectTemplates::3.1.1582
dotnet new func --AzureFunctionsVersion v3 --name @@ProjectName --StorageConnectionStringValue "UseDevelopmentStorage=true" 
dotnet add package  Microsoft.NET.Sdk.Functions -v 3.0.7
dotnet add package  AzureExtensions.Swashbuckle -v 3.2.2
dotnet add package  Microsoft.EntityFrameworkCore.Proxies -v 3.1.8

cd "@@Path"
dotnet new sln --name @@ProjectName  --force
dotnet sln @@ProjectName.sln add @@ProjectName/@@ProjectName.csproj --in-root


cd "@@Path"
dotnet new classlib -f netcoreapp3.1 --name Dal@@ProjectName

cd "@@Path/Dal@@ProjectName"
dotnet add package Microsoft.EntityFrameworkCore.Design 
dotnet add package Microsoft.EntityFrameworkCore.SqlServer

 
 echo "EF scafolding"
 dotnet tool update --global dotnet-ef --version 3.1.4
 dotnet ef dbcontext scaffold "Server=@@Server;Database=@@DB;User ID=@@User;Password=@@Password" Microsoft.EntityFrameworkCore.SqlServer -o Models -f
 cd "@@Path"
 dotnet sln @@ProjectName.sln add Dal@@ProjectName\Dal@@ProjectName.csproj --in-root
 dotnet add "@@Path/@@ProjectName/@@ProjectName.csproj" reference "@@Path/Dal@@ProjectName/Dal@@ProjectName.csproj"
 del "@@Path\Dal\models\sysdiagrams.cs"
 echo "File Created by Microservice maker. " > "@@Path/Readme.txt
exit