using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using VirtualWarehouse.Models.Errors;
using VirtualWarehouse.Models.ViewModels;
using VirtualWarehouse.Website.Interfaces;

namespace VirtualWarehouse.Website.Services
{
    public class ImageService : IImageService
    {
        private readonly IHttpService _httpService;

        public ImageService(IHttpService httpService)
        {
            _httpService = httpService;
        }

        public async Task<SavedImageViewModel> UploadImage(IFormFile formFile)
        {
            if(formFile != null && formFile.Length > 0)
            {
                HttpResponseMessage response = await _httpService.PostFileAsync(formFile, "Image", "SaveImage");

                if(response is not null)
                {
                    string responseContent = await response.Content.ReadAsStringAsync();

                    if (response.IsSuccessStatusCode)
                    {
                        return JsonConvert.DeserializeObject<SavedImageViewModel>(responseContent);
                    }
                    else
                    {
                        ApiErrorResponse apiErrorResponse = JsonConvert.DeserializeObject<ApiErrorResponse>(responseContent);
                        throw new VWException(apiErrorResponse.ErrorCode);
                    }
                }
            }
            else
            {
                return new SavedImageViewModel();
            }

            throw new VWException(ErrorCode.UnknownError);
        }
    }
}
