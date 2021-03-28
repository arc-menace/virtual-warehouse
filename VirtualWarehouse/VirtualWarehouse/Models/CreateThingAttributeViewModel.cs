using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VirtualWarehouse.Data.Models.Attributes;

namespace VirtualWarehouse.Web.Models
{
    public class CreateThingAttributeViewModel
    {
        public string Type { get; set; }
        public ThingAttribute ThingAttribute { get; set; }

        public CreateThingAttributeViewModel()
        {
            ThingAttribute = new ThingAttribute();
        }
    }
}
