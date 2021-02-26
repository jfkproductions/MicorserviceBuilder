cd "@@Path"
mkdir "@@ProjectName"
cd "@@ProjectName"
dotnet new -i Microsoft.Azure.WebJobs.ProjectTemplates::3.1.1582
dotnet new func --AzureFunctionsVersion v3 --name @@ProjectName --StorageConnectionStringValue "UseDevelopmentStorage=true" 
dotnet add package  Microsoft.NET.Sdk.Functions -v 3.0.7
dotnet add package  AzureExtensions.Swashbuckle -v 3.2.2
dotnet add package  Microsoft.EntityFrameworkCore.Proxies -v 3.1.8
dotnet add package  Z.Expressions.Eval -v 4.0.23
dotnet add package  Azure.Security.KeyVault.Secrets -v 4.1.0

cd "@@Path"
dotnet new sln --name @@ProjectName  --force
dotnet sln @@ProjectName.sln add @@ProjectName/@@ProjectName.csproj --in-root


cd "@@Path"
dotnet new classlib -f netcoreapp3.1 --name Dal

cd "@@Path/Dal"
dotnet add package Microsoft.EntityFrameworkCore.Design -v 3.1.7
dotnet add package Microsoft.EntityFrameworkCore.SqlServer -v 3.1.7

 
 echo "EF scafolding"
 dotnet tool update --global dotnet-ef --version 3.1.4
 dotnet ef dbcontext scaffold "Server=@@Server;Database=@@DB;User ID=@@User;Password=@@Password" Microsoft.EntityFrameworkCore.SqlServer -o Models -f
 cd "@@Path"
 dotnet sln @@ProjectName.sln add Dal\Dal.csproj --in-root
 dotnet add "@@Path/@@ProjectName/@@ProjectName.csproj" reference "@@Path/Dal/Dal.csproj"
 del "@@Path\Dal\models\sysdiagrams.cs"
 echo "File Created by Microservice maker. " > "@@Path/Readme.txt
exit