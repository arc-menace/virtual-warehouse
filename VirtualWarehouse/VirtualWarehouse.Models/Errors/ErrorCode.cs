using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualWarehouse.Models.Errors
{
    public class ErrorCode
    {
        public int SuggestedHttpResponse { get; private set; }
        public string Message { get; private set; }
        
        private ErrorCode(int suggestedHttpResponse, 
            string publicMessage)
        {
            SuggestedHttpResponse = suggestedHttpResponse;
            Message = publicMessage;
        }

        //Server Errors
        public static ErrorCode UnknownError { get { return new ErrorCode(500, "An unknown error occured"); } }
        public static ErrorCode InvalidApiResponse { get { return new ErrorCode(500, UnknownError.Message); } }

        //Client Errors
        public static ErrorCode EmptyFile { get { return new ErrorCode(400, "File cannot be empty"); } }
        public static ErrorCode FileDoesNotExist { get { return new ErrorCode(404, "Requested file does not exist"); } }
        public static ErrorCode ObjectNotFound { get { return new ErrorCode(404, "Requested object does not exist"); } }
    }
}
