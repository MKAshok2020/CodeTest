using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlanoTestAPI.Exception
{
    public enum ErrorCode
    {
        INTERNAL_SERVER_ERROR = 1,
        UNAUTHORIZED,        
        ENTITY_NOT_FOUND, 
        ENTITY_COMMAND_FAIL,
        DUPLICATE_DATA,
        CONFLICT_DATA,
        FORBIDDEN,         
        INVALID_MODEL        
    }
}
