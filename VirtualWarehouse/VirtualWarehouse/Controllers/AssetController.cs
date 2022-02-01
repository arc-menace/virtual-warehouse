using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VirtualWarehouse.Models.Models;
using VirtualWarehouse.Models.Requests;
using VirtualWarehouse.Models.ViewModels;
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

        [HttpPost]
        public async Task<IActionResult> AddTextAttribute(TextAttribute textAttribute)
        {
            TextAttribute newAttribute = await _assetService.AddTextAttribute(HttpContext, textAttribute);
            return Ok(newAttribute);
        }

        [HttpGet]
        public async Task<IActionResult> ViewAssets()
        {
            GetAssetsRequest getAssetsRequest = new()
            {
                Search = "",
                MinCreationDate = DateTime.MinValue,
                MaxCreationDate = DateTime.MaxValue,
                Status = Status.ACTIVE,
                Take = 10,
                Page = 1,
                PageSize = 25
            };

            List<Asset> Assets = await _assetService.GetAssets(HttpContext, getAssetsRequest);

            ViewAssetsViewModel viewModel = new()
            {
                Assets = Assets
            };

            return View(viewModel);
        }

        [HttpGet]
        public IActionResult CreateAsset()
        {
            return View(new Asset());
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsset(Asset asset)
        {
            asset = await _assetService.CreateAsset(HttpContext, asset);

            return RedirectToAction("AssetDetails", new { id = asset.Id });
        }
    }
}
