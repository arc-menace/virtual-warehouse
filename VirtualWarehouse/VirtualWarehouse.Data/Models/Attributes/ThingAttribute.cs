using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualWarehouse.Data.Models.Attributes
{
    public class ThingAttribute
    {
        public int ThingAttributeId { get; set; }
        public string AttributeName { get; set; }

        public int ThingId { get; set; }
        public Thing Thing { get; set; }
    }
}
