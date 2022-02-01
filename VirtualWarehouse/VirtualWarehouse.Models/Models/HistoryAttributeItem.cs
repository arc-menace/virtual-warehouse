using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtualWarehouse.Models.Interfaces;

namespace VirtualWarehouse.Models.Models
{
    public class HistoryAttributeItem : IDbItem
    {
        public int Id { get; set; }
        public HistoryAttribute HistoryAttribute { get; set; }
        public int? HistoryAttributeId { get; set; }
        public string Text { get; set; }
        public string Notes { get; set; }
        public double? Number { get; set; }
        public DateTime? DateTime { get; set; }
        public Status Status { get; set; }
        public DateTime CreationDate { get; set; }
        public int CreatedByUserId { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public int? LastUpdatedByUserId { get; set; }
    }
}
