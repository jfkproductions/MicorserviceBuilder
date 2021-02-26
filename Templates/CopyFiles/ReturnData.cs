using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace @@ProjectName.Classes
{
    public static   class ReturnData
    {
        public static HttpResponseMessage ReturnCleanData(object ObjectToConvert, string mode = null)
        {
            bool returnRaw = false;
            if (!string.IsNullOrWhiteSpace(mode))
            {
                if (mode.ToUpper().Trim() == "RAW")
                    returnRaw = true;
            }

            if (returnRaw)
            {
                var resp = new HttpResponseMessage()
                {
                    Content = new StringContent(JsonConvert.SerializeObject(ObjectToConvert, Formatting.Indented,
                           new JsonSerializerSettings
                           {
                               ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                               PreserveReferencesHandling = PreserveReferencesHandling.Objects,
                               NullValueHandling = NullValueHandling.Ignore,
                               MissingMemberHandling = MissingMemberHandling.Ignore,
                        
                           }))
                };
                resp.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                return resp;
            }
            else
            {
                var resp = new HttpResponseMessage()
                {
                    Content = new StringContent(JsonConvert.SerializeObject(ObjectToConvert, Formatting.Indented))

                };
                resp.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                return resp;

            }


        }
    }
}
