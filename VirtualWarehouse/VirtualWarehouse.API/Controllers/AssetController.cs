using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VirtualWarehouse.API.Interfaces;
using VirtualWarehouse.Models.Errors;
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
            try
            {
                _logger.LogInformation("HttpGet GetAsset for id {Id}", id);

                Asset asset = _assetService.GetAssetById(id);
                return Ok(asset);
            }
            catch(VWException ex)
            {
                _logger.LogError(ex, ex.ErrorCode.Message);
                return StatusCode(ex.ErrorCode.SuggestedHttpResponse, new ApiErrorResponse(ex.ErrorCode));
            }
            catch(Exception ex)
            {
                _logger.LogError(ex, "HttpGet GetAsset id={Id}: {ExceptionMessage}", id, ex.Message);

                return StatusCode(500, new ApiErrorResponse(ErrorCode.UnknownError));
            }
        }

        [HttpPost]
        public IActionResult GetAssets(GetAssetsRequest getAssetsRequest)
        {
            _logger.LogInformation("HttpPost GetAssets Take={Take} Page={Page} " +
                "PageSize={PageSize} MinCreationDate={MinCreationDate} " +
                "MaxCreationDate={MaxCreationDate} Status={Status}",
                getAssetsRequest.Take,
                getAssetsRequest.Page,
                getAssetsRequest.PageSize,
                getAssetsRequest.MinCreationDate,
                getAssetsRequest.MaxCreationDate,
                getAssetsRequest.Status);

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
