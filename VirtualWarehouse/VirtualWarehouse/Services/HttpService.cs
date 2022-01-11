using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using VirtualWarehouse.Website.Interfaces;

namespace VirtualWarehouse.Website.Services
{
    public class HttpService : IHttpService
    {
        private readonly HttpClient _client;
        private readonly IConfiguration _configuration;

        public HttpService(IConfiguration configuration)
        {
            _client = new();
            _configuration = configuration;
        }

        public Task<HttpResponseMessage> DeleteAsync(HttpContext httpContext, int id, string controller, string action)
        {
            throw new NotImplementedException();
        }

        public async Task<HttpResponseMessage> GetAsync(HttpContext httpContext, int id, string controller, string action)
        {
            return await _client.GetAsync(_configuration["ApiUrl"] + "/" + controller + "/" + action + "?id=" + id.ToString());
        }

        public Task<HttpResponseMessage> PostAsync(HttpContext httpContext, object request, string controller, string action)
        {
            throw new NotImplementedException();
        }

        public Task<HttpResponseMessage> PutAsync(HttpContext httpContext, int id, object request, string controller, string action)
        {
            throw new NotImplementedException();
        }
    }
}
