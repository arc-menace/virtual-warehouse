using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtualWarehouse.Models.Models;

namespace VirtualWarehouse.Models.Requests
{
    public class GetAssetsRequest
    {
        public string Search { get; set; }
        public DateTime MinCreationDate { get; set; }
        public DateTime MaxCreationDate { get; set; }
        public Status Status { get; set; }
        public int Take { get; set; }
        public int Page { get; set; }
        public int PageSize { get; set; }
    }
}
