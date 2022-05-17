using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlanoTestAPI.Exception
{
    public class BaseException : System.Exception 
     
    {
        public int StatusCode { get; set; }
        public ErrorCode ErrorCode { get; set; }
        public BaseException(string message, ErrorCode errorCode, int statusCode) : base(message)
        {
            StatusCode = statusCode;
            ErrorCode = errorCode;
        }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(new { StatusCode, ErrorCode = ErrorCode.ToString(), Message });
        }
    }
}
