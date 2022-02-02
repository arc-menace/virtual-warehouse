using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VirtualWarehouse.Models.Errors;
using VirtualWarehouse.Models.ViewModels;
using VirtualWarehouse.Website.Interfaces;

namespace VirtualWarehouse.Website.Controllers
{
    public class ImageController : Controller
    {
        private readonly IImageService _imageService;
        private readonly ILogger<ImageController> _logger;

        public ImageController(IImageService imageService,
            ILogger<ImageController> logger)
        {
            _imageService = imageService;
            _logger = logger;
        }

        [HttpPost]
        public async Task<IActionResult> Upload(IFormFile image)
        {
            try
            {
                SavedImageViewModel viewModel = await _imageService.UploadImage(image);
                return Ok(viewModel);
            }
            catch(VWException _ex)
            {
                _logger.LogError(_ex.ExceptionCode.Message);
                return StatusCode(_ex.ExceptionCode.SuggestedHttpResponse, _ex.ExceptionCode.Message);
            }
            catch (Exception _ex)
            {
                _logger.LogError(_ex.Message);
                return StatusCode(500, ExceptionCode.UnknownError.Message);
            }
        }
    }
}
