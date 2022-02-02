using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace VirtualWarehouse.Website.Interfaces
{
    public interface IHttpService
    {
        Task<HttpResponseMessage> GetAsync(int id, string controller, string action);
        Task<HttpResponseMessage> PostAsync(object request, string controller, string action);
        Task<HttpResponseMessage> PostFileAsync(IFormFile formFile, string controller, string action);
        Task<HttpResponseMessage> PutAsync(int id, object request, string controller, string action);
        Task<HttpResponseMessage> DeleteAsync(int id, string controller, string action);
    }
}
