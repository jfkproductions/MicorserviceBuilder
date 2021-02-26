using System;
using System.Net.Http;
using System.Threading.Tasks;
using AzureFunctions.Extensions.Swashbuckle;
using AzureFunctions.Extensions.Swashbuckle.Attribute;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;

namespace @@ProjectName.Functions
{
    public static class SwaggerFunctions
    {
        [SwaggerIgnore]
        [FunctionName("Swagger")]
        public static Task<HttpResponseMessage> Swagger(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "swagger/json")]
            HttpRequestMessage req,
            [SwashBuckleClient] ISwashBuckleClient swashBuckleClient)
        {
            return Task.FromResult(swashBuckleClient.CreateSwaggerDocumentResponse(req));
        }

        [SwaggerIgnore]
        [FunctionName("SwaggerUi")]
        public static Task<HttpResponseMessage> SwaggerUi(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "swagger/ui")]
            HttpRequestMessage req, ILogger log,
            [SwashBuckleClient] ISwashBuckleClient swashBuckleClient)
        {
            string _errLog = "Function V1.3";

            try
            {
                _errLog += "SwaggerUi";
                log.LogInformation(_errLog);
                return Task.FromResult(swashBuckleClient.CreateSwaggerUIResponse(req, "swagger/json"));
            }
            catch (Exception ex)
            {
                log.LogInformation(_errLog + ex.Message + ":" + ex.StackTrace);
                return Task.FromResult(new HttpResponseMessage
                {
                    Content = new StringContent(_errLog + ex.Message + ":" + ex.StackTrace)

                });
            }

        }
    }
}
