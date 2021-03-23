using System;
using System.Collections.Generic;
using VirtualWarehouse.Data.Models.Attributes;

namespace VirtualWarehouse.Data.Models
{
    public class Thing
    {
        public int ThingId { get; set; }
        public string ThingName { get; set; }
        public List<Thing> AssociatedThings { get; set; }
        public List<ThingAttribute> Attributes { get; set; }

        public Thing()
        {
            Attributes = new List<ThingAttribute>();
            AssociatedThings = new List<Thing>();
        }
    }
}
