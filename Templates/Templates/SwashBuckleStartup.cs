using System;
using System.Reflection;
using AzureFunctions.Extensions.Swashbuckle;
using AzureFunctions.Extensions.Swashbuckle.Settings;
using @@ProjectName;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Swashbuckle.AspNetCore.SwaggerGen;
using Microsoft.OpenApi;



[assembly: FunctionsStartup(typeof(@@ProjectName.SwashBuckleStartup))]
namespace @@ProjectName
{
    internal class SwashBuckleStartup : IWebJobsStartup
    {
        public void Configure(IWebJobsBuilder builder)
        {
            //Register the extension
            builder.AddSwashBuckle(Assembly.GetExecutingAssembly(), opts =>
            {
                var AditionalText = @"Get Functions : use single object " + System.Environment.NewLine +
                             "Post Functions: uses the Array object []. The Primarykey id must be null or -1,as well as the primary key values for new subsequent data." + System.Environment.NewLine +
                             "Put Functions: uses the Array object []. The Primarykey must not be null or -1,as well as the primary key values for new subsequent data." + System.Environment.NewLine +
                             "Delete Functions No Object required. "+
							 "You can Query and object by setting the Mode=Where (Query) , the query is linb based eg Normal Query Where c.Fielname == 'Value' or  Complex Query Where c.TblPersonRegistration.First().TblIdentityCard.First().IdentityNumber == '58xxxxxxxx'";

                opts.SpecVersion = OpenApiSpecVersion.OpenApi2_0;
                opts.AddCodeParameter = true;
                opts.PrependOperationWithRoutePrefix = true;
                opts.Documents = new[]
                {
                    new SwaggerDocument
                    {
                        Name = "v1",
                        Title = "@@ProjectName",
                        Description = AditionalText,
                        Version = "v2"
                    }
                };
                opts.Title = "@@ProjectName";
                opts.ConfigureSwaggerGen = (x =>
                {
                    x.CustomOperationIds(apiDesc =>
                    {
                        return apiDesc.TryGetMethodInfo(out MethodInfo methodInfo)
                            ? methodInfo.Name
                            : new Guid().ToString();
                    });
                });
            });

        }
    }
}
