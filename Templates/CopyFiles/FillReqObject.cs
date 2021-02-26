using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace @@ProjectName.Classes
{
    public class FillReqObject
    {
        public static ReqObject Fill(string requestBody,string Reqmethod, string mode, string PrimarykeyValue)
        {
            dynamic ObjectData = JsonConvert.DeserializeObject(requestBody);
            CrudMethod method = (CrudMethod)Enum.Parse(typeof(CrudMethod), Reqmethod, true);
            ReqObject reqObject = new ReqObject
            { Method = method,
              Mode   = mode,
              PrimaryKeyvalue = PrimarykeyValue,
              requestBody = requestBody,
              InformationObject = ObjectData
            };
            return reqObject;
        }
    }
}
