using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VirtualWarehouse.Models.Models;
using VirtualWarehouse.Models.Requests;

namespace VirtualWarehouse.API.Interfaces
{
    public interface IAssetService
    {
        public Task<Asset> CreateAsset(Asset asset);
        public Task<Asset> UpdateAsset(int id, Asset asset);
        public Asset GetAssetById(int id);
        public List<Asset> GetAllAssets(GetAssetsRequest getAssetsRequest);
        public List<Asset> GetAllAssets(
            int take,
            int page,
            int pageSize,
            string search = "", 
            DateTime? minCreationDate = null, 
            DateTime? maxCreationDate = null, 
            Status status = Status.ACTIVE);
    }
}
