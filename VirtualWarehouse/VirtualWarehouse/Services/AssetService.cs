using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using VirtualWarehouse.Models.Models;
using VirtualWarehouse.Website.Interfaces;

namespace VirtualWarehouse.Website.Services
{
    public class AssetService : IAssetService
    {
        private readonly IHttpService _httpService;

        public AssetService(IHttpService httpService)
        {
            _httpService = httpService;
        }

        public async Task<TextAttribute> AddTextAttribute(HttpContext httpContext, TextAttribute textAttribute)
        {
            HttpResponseMessage response = await _httpService.PostAsync(
                httpContext, 
                textAttribute, 
                "Asset", 
                "AddTextAttribute");

            if(response.IsSuccessStatusCode)
            {
                string responseContent = await response.Content.ReadAsStringAsync();

                return JsonConvert.DeserializeObject<TextAttribute>(responseContent);
            }

            throw new Exception();
        }

        public async Task<Asset> GetAsset(HttpContext httpContext, int id)
        {
            HttpResponseMessage response = await _httpService.GetAsync(
                httpContext, 
                id, 
                "Asset", 
                "GetAsset");
            
            if(response.IsSuccessStatusCode)
            {
                string responseContent = await response.Content.ReadAsStringAsync();

                return JsonConvert.DeserializeObject<Asset>(responseContent);
            }

            throw new Exception();
        }
    }
}
