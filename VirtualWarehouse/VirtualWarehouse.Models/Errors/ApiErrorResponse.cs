using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualWarehouse.Models.Errors
{
    public class ApiErrorResponse
    {
        public ApiErrorResponse() { }
        public ApiErrorResponse(ErrorCode errorCode)
        {
            ErrorCode = errorCode;
        }

        public ErrorCode ErrorCode { get; set; }
    }
}
