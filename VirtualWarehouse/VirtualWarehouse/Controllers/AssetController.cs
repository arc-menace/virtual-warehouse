using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VirtualWarehouse.Models.Models;
using VirtualWarehouse.Website.Interfaces;

namespace VirtualWarehouse.Website.Controllers
{
    public class AssetController : Controller
    {
        private readonly IAssetService _assetService;

        public AssetController(IAssetService assetService)
        {
            _assetService = assetService;
        }

        [HttpGet]
        public async Task<IActionResult> AssetDetails(int id)
        {
            Asset asset = await _assetService.GetAsset(HttpContext, id);
            return View(asset);
        }
    }
}
