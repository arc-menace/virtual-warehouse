using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualWarehouse.Models.Errors
{
    public class ExceptionCode
    {
        public int SuggestedHttpResponse { get; private set; }
        public string Message { get; private set; }
        
        private ExceptionCode(int suggestedHttpResponse, 
            string message)
        {
            SuggestedHttpResponse = suggestedHttpResponse;
            Message = message;
        }

        public static ExceptionCode UnknownError { get { return new ExceptionCode(500, "An unknown error occured."); } }
    }
}
