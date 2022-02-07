using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using VirtualWarehouse.Models.Errors;
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

        public Task<HttpResponseMessage> DeleteAsync(int id, string controller, string action)
        {
            throw new NotImplementedException();
        }

        public async Task<HttpResponseMessage> GetAsync(int id, string controller, string action)
        {
            StringBuilder urlBuilder = new();
            urlBuilder.Append(GenerateUrl(controller, action));
            urlBuilder.Append("?id=");
            urlBuilder.Append(id);

            return await _client.GetAsync(urlBuilder.ToString());
        }

        public async Task<HttpResponseMessage> PostAsync(object request, string controller, string action)
        {
            return await _client.PostAsJsonAsync(
                GenerateUrl(controller, action), 
                request);
        }

        public async Task<HttpResponseMessage> PostFileAsync(IFormFile formFile, string controller, string action)
        {
            using MultipartFormDataContent content = new();
            content.Add(
                new StreamContent(formFile.OpenReadStream())
                {
                    Headers =
                    {
                        ContentLength = formFile.Length,
                        ContentType = new MediaTypeHeaderValue(formFile.ContentType)
                    }
                },
                "formFile",
                formFile.FileName);

            HttpResponseMessage response = await _client.PostAsync(GenerateUrl(controller, action), content);

            if(response is null)
            {
                throw new VWException(ExceptionCode.InvalidApiResponse);
            }

            return response;
        }

        public Task<HttpResponseMessage> PutAsync(int id, object request, string controller, string action)
        {
            throw new NotImplementedException();
        }

        private string GenerateUrl(string controller, string action)
        {
            StringBuilder urlBuilder = new();

            urlBuilder.Append(_configuration["ApiUrl"]);
            urlBuilder.Append('/');
            urlBuilder.Append(controller);
            urlBuilder.Append('/');
            urlBuilder.Append(action);

            return urlBuilder.ToString();
        }
    }
}
