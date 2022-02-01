using System;
using System.Collections.Generic;
using VirtualWarehouse.Models.Interfaces;

namespace VirtualWarehouse.Models.Models
{
    public class Asset : IDbItem
    {
        public int Id { get; set; }
        public Asset ParentAsset { get; set; }
        public int? ParentAssetId { get; set; }
        public string Name { get; set; }
        public Status Status { get; set; }
        public int CreatedByUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int? LastUpdatedByUserId { get; set; }
        public DateTime? LastUpdatedDate { get; set; }

        public List<TextAttribute> TextAttributes { get; set; }
        public List<ImageAttribute> ImageAttributes { get; set; }
        public List<Asset> ChildAssets { get; set; }
    }
}
