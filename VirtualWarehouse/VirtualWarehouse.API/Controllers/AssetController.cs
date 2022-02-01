using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VirtualWarehouse.API.Interfaces;
using VirtualWarehouse.Models.Models;
using VirtualWarehouse.Models.Requests;

namespace VirtualWarehouse.API.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class AssetController : Controller
    {
        private readonly IAssetService _assetService;
        private readonly ILogger<AssetController> _logger;

        public AssetController(ILogger<AssetController> logger, 
            IAssetService assetService)
        {
            _logger = logger;
            _assetService = assetService;
        }

        [HttpGet]
        public IActionResult GetAsset(int id)
        {
            Asset asset = _assetService.GetAssetById(id);
            return Ok(asset);
        }

        [HttpPost]
        public IActionResult GetAssets(GetAssetsRequest getAssetsRequest)
        {
            List<Asset> assets = _assetService.GetAllAssets(getAssetsRequest);

            return Ok(assets);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsset(Asset asset)
        {
            asset = await _assetService.CreateAsset(asset);
            return Ok(asset);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateAsset(int assetId, Asset updatedAsset)
        {
            updatedAsset = await _assetService.UpdateAsset(assetId, updatedAsset);
            return Ok(updatedAsset);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteAsset(int assetId)
        {
            return Ok();
        }
    }
}
