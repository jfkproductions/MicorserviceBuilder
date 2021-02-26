using System;
using System.Collections.Generic;
using System.Text;

namespace @@ProjectName.Classes
{
    public class ReqObject
    {
        public string requestBody { get; set; }
        public string Mode { get; set; }
        public string PrimaryKeyvalue { get; set; }
        public CrudMethod Method { get; set; }
        public dynamic InformationObject { get; set; }
    }


}
