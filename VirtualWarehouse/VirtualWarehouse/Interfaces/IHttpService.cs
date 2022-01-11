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
        Task<HttpResponseMessage> GetAsync(HttpContext httpContext, int id, string controller, string action);
        Task<HttpResponseMessage> PostAsync(HttpContext httpContext, object request, string controller, string action);
        Task<HttpResponseMessage> PutAsync(HttpContext httpContext, int id, object request, string controller, string action);
        Task<HttpResponseMessage> DeleteAsync(HttpContext httpContext, int id, string controller, string action);
    }
}
