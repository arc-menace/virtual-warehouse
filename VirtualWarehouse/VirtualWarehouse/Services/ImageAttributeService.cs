using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using VirtualWarehouse.Models.Errors;
using VirtualWarehouse.Models.Interfaces;
using VirtualWarehouse.Models.Models;
using VirtualWarehouse.Website.Interfaces;

namespace VirtualWarehouse.Website.Services
{
    public class ImageAttributeService : IAttributeService<ImageAttribute>
    {
        private readonly IHttpService _httpService;

        public ImageAttributeService(IHttpService httpService)
        {
            _httpService = httpService;
        }

        public async Task<ImageAttribute> CreateAttribute(ImageAttribute attribute)
        {
            HttpResponseMessage response = await _httpService.PostAsync(attribute, "Attribute", "CreateImageAttribute");

            if(response is not null)
            {
                string responseContent = await response.Content.ReadAsStringAsync();
                if (response.IsSuccessStatusCode)
                {
                    return JsonConvert.DeserializeObject<ImageAttribute>(responseContent);
                }
                else
                {
                    ApiErrorResponse errorResponse = JsonConvert.DeserializeObject<ApiErrorResponse>(responseContent);
                    throw new VWException(errorResponse.ErrorCode);
                }
            }

            throw new VWException(ErrorCode.UnknownError);
        }

        public async Task<ImageAttribute> GetAttribute(int id)
        {
            throw new NotImplementedException();
        }
    }
}
