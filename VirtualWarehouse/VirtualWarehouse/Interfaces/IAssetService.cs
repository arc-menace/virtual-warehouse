using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VirtualWarehouse.Models.Models;

namespace VirtualWarehouse.Website.Interfaces
{
    public interface IAssetService
    {
        Task<Asset> GetAsset(HttpContext httpContext, int id);
        Task<TextAttribute> AddTextAttribute(HttpContext httpContext, TextAttribute textAttribute);
    }
}
