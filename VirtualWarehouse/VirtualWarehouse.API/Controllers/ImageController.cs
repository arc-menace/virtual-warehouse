using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using VirtualWarehouse.API.Interfaces;
using VirtualWarehouse.Models.Errors;
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
        private readonly ILogger<ImageController> _logger;

        public ImageController(ISavedImageService savedImageService,
            IConfiguration configuration,
            ILogger<ImageController> logger)
        {
            _savedImageService = savedImageService;
            _configuration = configuration;
            _logger = logger;
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
        public IActionResult GetImage(Guid AccessKey)
        {
            try
            {
                Stream stream = _savedImageService.GetImageStream(AccessKey);
                return File(stream, "application/octet-stream");
            }
            catch(VWException _ex)
            {
                _logger.LogError(_ex.ExceptionCode.Message);

                ApiErrorResponse apiErrorResponse = new()
                {
                    ExceptionCode = _ex.ExceptionCode
                };

                return StatusCode(_ex.ExceptionCode.SuggestedHttpResponse, apiErrorResponse);
            }
            catch(Exception _ex)
            {
                _logger.LogError(_ex.Message);

                ApiErrorResponse apiErrorResponse = new()
                { 
                    ExceptionCode = ExceptionCode.UnknownError
                };

                return StatusCode(500, apiErrorResponse);
            }
        }
    }
}
