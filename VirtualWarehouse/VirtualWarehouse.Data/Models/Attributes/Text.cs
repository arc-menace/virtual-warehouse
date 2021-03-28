using System;
using System.Collections.Generic;
using System.Text;
using VirtualWarehouse.Data.Services;

namespace VirtualWarehouse.Data.Models.Attributes
{
    public class Text : ThingAttribute
    {
        public string TextContent { get; set; }


        public Text()
        {
            AttributeType = "Text"; 
        }
    }
}
