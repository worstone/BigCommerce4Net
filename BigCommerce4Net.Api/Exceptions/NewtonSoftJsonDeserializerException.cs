using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RestSharp;

namespace BigCommerce4Net.Api
{
    public class NewtonSoftJsonDeserializerException : System.Exception
    {
        public IRestResponse RestResponse { get; set; }

        public NewtonSoftJsonDeserializerException(string message)
            : base(message) {
        }
    }
}
