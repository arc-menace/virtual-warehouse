using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using VirtualWarehouse.Models.Models;

namespace VirtualWarehouse.API.Interfaces
{
    public interface ISavedImageService
    {
        public Task<SavedImage> CreateSavedImage(IFormFile formFile,
            string basePath,
            string folder,
            int userId,
            string overrideFileName = null);
        public SavedImage GetSavedImageByAccessKey(Guid AccessKey);
        public Stream GetImageStream(Guid AccessKey);
        public byte[] HashImage(byte[] imageBytes);
        public byte[] HashImage(IFormFile formFile);
        public bool HashesMatch(byte[] hash1, byte[] hash2);
        public bool ImagesMatch(SavedImage image1, SavedImage image2);
    }
}
