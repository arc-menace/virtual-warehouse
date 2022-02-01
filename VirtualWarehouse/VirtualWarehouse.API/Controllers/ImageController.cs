using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VirtualWarehouse.API.Interfaces;
using VirtualWarehouse.Models.Models;

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
        public async Task<IActionResult> SaveImage(IFormFile formFile)
        {
            SavedImage savedImage = await _savedImageService.CreateSavedImage(
                formFile,
                _configuration["ImageDirectory"],
                "virtualWarehouse",
                0);

            return Ok(savedImage);
        }

        [HttpGet]
        public async Task<IActionResult> GetFile(Guid AccessKey)
        {
            return Ok();
        }
    }
}
