using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VirtualWarehouse.Models.ViewModels;

namespace VirtualWarehouse.Website.Interfaces
{
    public interface IImageService
    {
        Task<SavedImageViewModel> UploadImage(IFormFile formFile);
    }
}
