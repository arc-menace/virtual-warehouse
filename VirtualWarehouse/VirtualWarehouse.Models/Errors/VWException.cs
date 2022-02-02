using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualWarehouse.Models.Errors
{
    public class VWException : Exception
    {
        public ExceptionCode ExceptionCode { get; set; }

        public VWException(ExceptionCode exceptionCode)
        {
            ExceptionCode = exceptionCode;
        }

        public override string ToString()
        {
            return ExceptionCode.Message;
        }
    }
}
