using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VirtualWarehouse.API.Interfaces;
using VirtualWarehouse.Models.Models;
using VirtualWarehouse.Models.ViewModels;

namespace VirtualWarehouse.API.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class ImageController : Controller
    {
        private readonly ISavedImageService _savedImageService;
        private readonly IConfiguration _configuration;

        public ImageController(ISavedImageService savedImageService,
            IConfiguration configuration)
        {
            _savedImageService = savedImageService;
            _configuration = configuration;
        }

        [HttpPost]
        public async Task<IActionResult> SaveImage([FromForm] IFormFile formFile)
        {
            SavedImage savedImage = await _savedImageService.CreateSavedImage(
                formFile,
                _configuration["ImageDirectory"],
                "virtualWarehouse",
                0);

            SavedImageViewModel viewModel = new()
            {
                Id = savedImage.Id,
                externalUrl = savedImage.ExternalUrl,
                fileName = savedImage.OriginalFileName
            };

            return Ok(viewModel);
        }

        [HttpGet]
        public async Task<IActionResult> GetFile(Guid AccessKey)
        {
            return Ok();
        }
    }
}
