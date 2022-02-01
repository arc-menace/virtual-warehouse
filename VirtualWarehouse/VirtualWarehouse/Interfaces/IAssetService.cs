using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VirtualWarehouse.Models.Models;
using VirtualWarehouse.Models.Requests;

namespace VirtualWarehouse.Website.Interfaces
{
    public interface IAssetService
    {
        Task<Asset> GetAsset(HttpContext httpContext, int id);
        Task<List<Asset>> GetAssets(HttpContext httpContext, GetAssetsRequest getAssetsRequest);
        Task<TextAttribute> AddTextAttribute(HttpContext httpContext, TextAttribute textAttribute);
        Task<Asset> CreateAsset(HttpContext httpContext, Asset asset);
    }
}
