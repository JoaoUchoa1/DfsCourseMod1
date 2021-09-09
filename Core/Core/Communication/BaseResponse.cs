using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Communication
{
    public abstract class BaseResponse
    {
        public bool Sucess { get; set; }
        public String Message { get; set; }

        public BaseResponse(bool sucess, string message) 
        {
            Sucess = sucess;
            Message = message;
        }
    }
}
