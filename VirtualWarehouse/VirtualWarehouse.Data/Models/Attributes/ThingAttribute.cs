using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace VirtualWarehouse.Data.Models.Attributes
{
    public class ThingAttribute
    {
        //used to identify partial view for thing details page
        [NotMapped]
        public string AttributeType { get; set; } 
        public int ThingAttributeId { get; set; }
        public string AttributeName { get; set; }

        public int ThingId { get; set; }
        public Thing Thing { get; set; }
    }
}
