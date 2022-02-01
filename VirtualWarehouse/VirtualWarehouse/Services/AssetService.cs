using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using VirtualWarehouse.Models.Models;
using VirtualWarehouse.Models.Requests;
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

        public async Task<Asset> CreateAsset(HttpContext httpContext, Asset asset)
        {
            HttpResponseMessage response = await _httpService.PostAsync(
                asset, 
                "Asset", 
                "CreateAsset");

            if(response.IsSuccessStatusCode)
            {
                string responseContent = await response.Content.ReadAsStringAsync();

                return JsonConvert.DeserializeObject<Asset>(responseContent);
            }

            throw new Exception();
        }

        public async Task<Asset> GetAsset(HttpContext httpContext, int id)
        {
            HttpResponseMessage response = await _httpService.GetAsync(
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

        public async Task<List<Asset>> GetAssets(HttpContext httpContext, GetAssetsRequest getAssetsRequest)
        {
            HttpResponseMessage response = await _httpService.PostAsync(
                getAssetsRequest,
                "Asset",
                "GetAssets");

            if(response.IsSuccessStatusCode)
            {
                string responseContent = await response.Content.ReadAsStringAsync();

                return JsonConvert.DeserializeObject<List<Asset>>(responseContent);
            }

            throw new NotImplementedException();
        }

    }
}
