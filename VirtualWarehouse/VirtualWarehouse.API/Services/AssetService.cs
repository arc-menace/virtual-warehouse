using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtualWarehouse.API.Interfaces;
using VirtualWarehouse.DataAccess;
using VirtualWarehouse.Models.Errors;
using VirtualWarehouse.Models.Models;
using VirtualWarehouse.Models.Requests;

namespace VirtualWarehouse.API.Services
{
    public class AssetService : IAssetService
    {
        private readonly VirtualWarehouseDbContext _dbContext;
        private readonly ILogger _logger;

        public AssetService(VirtualWarehouseDbContext dbContext,
            ILogger logger)
        {
            _dbContext = dbContext;
            _logger = logger;
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

        public List<Asset> GetAllAssets(
            int take,
            int page,
            int pageSize,
            string search = "",
            DateTime? minCreationDate = null,
            DateTime? maxCreationDate = null,
            Status status = Status.ACTIVE)
        {
            var assetsQuery = _dbContext.Assets.Include(x => x.HistoryAttributes)
                .ThenInclude(x => x.HistoryAttributeItems)
                .Include(x => x.ImageAttributes)
                .ThenInclude(x => x.SavedImage)
                .Include(x => x.TextAttributes)
                .Where(x => x.Status == status);

            if(minCreationDate is not null)
            {
                assetsQuery = assetsQuery.Where(x => x.CreationDate > minCreationDate);
            }

            if(maxCreationDate is not null)
            {
                assetsQuery = assetsQuery.Where(x => x.CreationDate < maxCreationDate);
            }

            return assetsQuery.Skip((page - 1) * pageSize)
                .Take(take)
                .ToList();
        }

        public List<Asset> GetAllAssets(GetAssetsRequest getAssetsRequest)
        {
            return GetAllAssets(
                getAssetsRequest.Take, 
                getAssetsRequest.Page, 
                getAssetsRequest.PageSize, 
                getAssetsRequest.Search, 
                getAssetsRequest.MinCreationDate, 
                getAssetsRequest.MaxCreationDate, 
                getAssetsRequest.Status);  
        }

        private bool AssetContainsSearch(Asset asset, string search)
        {
            Stopwatch stopwatch = new();
            stopwatch.Start();

            StringBuilder stringToSearchBuilder = new(asset.Name);

            //separator helps prevent strings blurring together
            //Ex: "this" + "pot" = "thispot" contains the words "this", "pot" and "spot"
            //but "this" + "pot" is not relevant in a search for "spot"
            char separator = '|';
            stringToSearchBuilder.Append(separator);

            //search all history attributes
            foreach(HistoryAttribute historyAttribute in asset.HistoryAttributes)
            {
                stringToSearchBuilder.Append(historyAttribute.Name);
                stringToSearchBuilder.Append(separator);

                //search all items of each history attribute
                foreach(HistoryAttributeItem historyAttributeItem in historyAttribute.HistoryAttributeItems)
                {
                    stringToSearchBuilder.Append(historyAttributeItem.Text);
                    stringToSearchBuilder.Append(separator);
                    stringToSearchBuilder.Append(historyAttributeItem.Notes);
                    stringToSearchBuilder.Append(separator);
                    stringToSearchBuilder.Append(historyAttributeItem.Number);
                    stringToSearchBuilder.Append(separator);
                }
            }

            //search all image attributes
            foreach(ImageAttribute imageAttribute in asset.ImageAttributes)
            {
                stringToSearchBuilder.Append(imageAttribute.Name);
                stringToSearchBuilder.Append(separator);
                stringToSearchBuilder.Append(imageAttribute.SavedImage.OriginalFileName);
                stringToSearchBuilder.Append(separator);
            }

            //search all text attributes
            foreach (TextAttribute textAttribute in asset.TextAttributes)
            {
                stringToSearchBuilder.Append(textAttribute.Name);
                stringToSearchBuilder.Append(separator);
                stringToSearchBuilder.Append(textAttribute.Contents);
                stringToSearchBuilder.Append(separator);
            }

            string stringToSearch = stringToSearchBuilder.ToString();
            stopwatch.Stop();
            _logger.LogInformation("Built search string for asset {Id} in {Milliseconds}ms", 
                asset.Id, 
                stopwatch.ElapsedMilliseconds);

            stopwatch.Restart();

            bool containsSearch = stringToSearch.Contains(search);

            stopwatch.Stop();

            if(stopwatch.ElapsedMilliseconds > 1000)
            {
                _logger.LogWarning("Searching asset {Id} for \"{Search}\" took {Milliseconds}ms to complete",
                   asset.Id,
                   search,
                   stopwatch.ElapsedMilliseconds);
            }
            else
            {
                _logger.LogInformation("Searching asset {Id} for \"{Search}\" took {Milliseconds}ms to complete",
                   asset.Id,
                   search,
                   stopwatch.ElapsedMilliseconds);
            }

            return containsSearch;
        }

        public Asset GetAssetById(int id)
        {
            Asset asset = _dbContext.Assets.Single(x => x.Id == id);

            if(asset is not null)
            {
                return asset;
            }

            throw new VWException(ErrorCode.ObjectNotFound);
        }

        public Task<Asset> UpdateAsset(int id, Asset asset)
        {
            throw new NotImplementedException();
        }
    }
}
