using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualWarehouse.Models.Errors
{
    public class VWException : Exception
    {
        public ErrorCode ErrorCode { get; set; }

        public VWException(ErrorCode errorCode)
        {
            ErrorCode = errorCode;
        }

        public override string ToString()
        {
            return ErrorCode.Message;
        }
    }
}
