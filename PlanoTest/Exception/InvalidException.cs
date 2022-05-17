using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace PlanoTestAPI.Exception
{
    public class InvalidModelException : BaseException
    {

        public InvalidModelException(ModelStateDictionary modelState) : base(
             modelState != null ? string.Join(". ", modelState.Select(x => $"{x.Key} is invalid")) : string.Empty,
             ErrorCode.INVALID_MODEL,
            (int)HttpStatusCode.BadRequest
            )
        {
        }
    }
}
