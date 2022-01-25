﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtualWarehouse.Models.Models;

namespace VirtualWarehouse.Models.Interfaces
{
    public interface IAttribute
    {
        public int Id { get; set; }
        public int AssetId { get; set; }
        public string Name { get; set; }
        public Status Status { get; set; }
        public int CreatedByUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int LastUpdatedByUserId { get; set; }
        public DateTime LastUpdatedDate { get; set; }
    }
}
