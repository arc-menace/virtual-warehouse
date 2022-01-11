using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VirtualWarehouse.Models;

namespace VirtualWarehouse.API.Controllers
{
    public class AssetController : Controller
    {
        [HttpGet]
        public async Task<IActionResult> GetAsset(int id)
        {
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsset(Asset asset)
        {
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> UpdateAsset(int assetId, Asset updatedAsset)
        {
            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteAsset(int assetId)
        {
            return Ok();
        }
    }
}
