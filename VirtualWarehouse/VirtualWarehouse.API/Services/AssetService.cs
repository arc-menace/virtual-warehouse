using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VirtualWarehouse.API.Interfaces;
using VirtualWarehouse.DataAccess;
using VirtualWarehouse.Models.Models;
using VirtualWarehouse.Models.Requests;

namespace VirtualWarehouse.API.Services
{
    public class AssetService : IAssetService
    {
        private readonly VirtualWarehouseDbContext _dbContext;

        public AssetService(VirtualWarehouseDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Asset> CreateAsset(Asset asset)
        {
            //validate asset here
            asset.Status = Status.ACTIVE;
            asset.CreationDate = DateTime.Now;
            _dbContext.Assets.Add(asset);
            await _dbContext.SaveChangesAsync();

            return asset;
        }

        public List<Asset> GetAllAssets(GetAssetsRequest getAssetsRequest)
        {
            return _dbContext.Assets
                .Where(x => x.Status == getAssetsRequest.Status)
                .Where(x => x.CreationDate > getAssetsRequest.MinCreationDate)
                .Where(x => x.CreationDate < getAssetsRequest.MaxCreationDate)
                .Skip((getAssetsRequest.Page - 1) * getAssetsRequest.PageSize)
                .Take(getAssetsRequest.Take)
                .ToList();
        }

        public Asset GetAssetById(int id)
        {
            Asset asset = _dbContext.Assets.Single(x => x.Id == id);

            if(asset is not null)
            {
                return asset;
            }

            throw new Exception();
        }

        public Task<Asset> UpdateAsset(int id, Asset asset)
        {
            throw new NotImplementedException();
        }
    }
}
