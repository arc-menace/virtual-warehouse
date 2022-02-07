using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using VirtualWarehouse.API.Interfaces;
using VirtualWarehouse.DataAccess;
using VirtualWarehouse.Models.Errors;
using VirtualWarehouse.Models.Models;

namespace VirtualWarehouse.API.Services
{
    public class SavedImageService : ISavedImageService
    {
        private readonly VirtualWarehouseDbContext _dbContext;
        private readonly IConfiguration _config;

        public SavedImageService(VirtualWarehouseDbContext dbContext,
            IConfiguration config)
        {
            _dbContext = dbContext;
            _config = config;
        }

        public Stream GetImageStream(Guid AccessKey)
        {
            SavedImage savedImage = GetSavedImageByAccessKey(AccessKey);
            if(savedImage is null)
            {
                throw new VWException(ExceptionCode.FileDoesNotExist);
            }

            string filePath = _config["ImageDirectory"];
            string fileName = savedImage.SafeFileName;
            string extension = savedImage.GetFileExtension();
            StringBuilder pathBuilder = new();
            pathBuilder.Append(filePath);
            pathBuilder.Append(Path.DirectorySeparatorChar);
            pathBuilder.Append(savedImage.Folder);
            pathBuilder.Append(Path.DirectorySeparatorChar);
            pathBuilder.Append(fileName);
            pathBuilder.Append(extension);

            return File.OpenRead(pathBuilder.ToString());
        }

        public async Task<SavedImage> CreateSavedImage(IFormFile formFile, 
            string basePath, 
            string folder, 
            int userId, 
            string overrideFileName = null)
        {
            SavedImage newImage = new()
            {
                OriginalFileName = formFile.FileName,
                SafeFileName = Guid.NewGuid().ToString(),
                AccessKey = Guid.NewGuid(),
                Hash = HashImage(formFile),
                Folder = folder,
                CreatedByUserId = userId,
                CreationDate = DateTime.Now,
                Status = Status.ACTIVE,
            };

            StringBuilder pathBuilder = new();
            pathBuilder.Append(basePath);
            pathBuilder.Append(Path.DirectorySeparatorChar);
            pathBuilder.Append(folder);

            Directory.CreateDirectory(pathBuilder.ToString());

            pathBuilder.Append(Path.DirectorySeparatorChar);
            pathBuilder.Append(newImage.SafeFileName);
            pathBuilder.Append(newImage.GetFileExtension());
            //Example Windows Path: basePath//folder//fileName.fileExtension 

            using FileStream fileStream = new(pathBuilder.ToString(), FileMode.Create);
            await formFile.CopyToAsync(fileStream);

            _dbContext.SavedImages.Add(newImage);
            await _dbContext.SaveChangesAsync();

            newImage.ExternalUrl = GenerateUrl(newImage);

            return newImage;
        }

        public SavedImage GetSavedImageByAccessKey(Guid AccessKey)
        {
            SavedImage savedImage = _dbContext.SavedImages
                .Where(x => x.AccessKey == AccessKey)
                .FirstOrDefault();

            if(savedImage is null)
            {
                throw new VWException(ExceptionCode.FileDoesNotExist);
            }

            return savedImage;
        }
        
        //Iterates through the hashes looking for inconsistencies.
        //If either or both hashes are empty, function returns false
        public bool HashesMatch(byte[] hash1, byte[] hash2)
        {
            //Check that hashes are not empty
            if((hash1 is not null && hash1.Length > 0) && (hash2 is not null && hash2.Length > 0))
            {
                if(hash1.Length == hash2.Length)
                {
                    for(int i = 0; i < hash1.Length; i++)
                    {
                        if(hash1[i] != hash2[i])
                        {
                            return false;
                        }
                    }
                    return true;
                }
            }
            return false;
        }

        public byte[] HashImage(byte[] imageBytes)
        {
            using var sha1 = SHA1.Create();
            var hash = sha1.ComputeHash(imageBytes);
            return sha1.ComputeHash(imageBytes);
        }

        //Returns the an SHA1 hash of the submitted file 
        //or null if the file is empty
        public byte[] HashImage(IFormFile formFile)
        {
            if (formFile.Length > 0)
            {
                using var ms = new MemoryStream();
                formFile.CopyTo(ms);
                var fileBytes = ms.ToArray();
                return HashImage(fileBytes);
            }
            return null;
        }

        public bool ImagesMatch(SavedImage image1, SavedImage image2)
        {
            return HashesMatch(image1.Hash, image2.Hash);
        }

        public string GenerateUrl(SavedImage image)
        {
            StringBuilder stringBuilder = new();
            stringBuilder.Append(_config["ApiUrl"]);
            stringBuilder.Append("/Image/GetImage?AccessKey=");
            stringBuilder.Append(image.AccessKey);

            return stringBuilder.ToString();
        }
    }
}
