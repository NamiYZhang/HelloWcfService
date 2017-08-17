using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace HelloWcfService
{
    [DataContract]
    public class ErrorData
    {
        [DataMember]
        public string ErrorCode { get; set; }

        [DataMember]
        public string ErrorDescription { get; set; }
    }
}