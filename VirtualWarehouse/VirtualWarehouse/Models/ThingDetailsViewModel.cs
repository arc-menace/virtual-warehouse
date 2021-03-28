using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VirtualWarehouse.Data.Models;
using VirtualWarehouse.Data.Services;
using System.Reflection;
using VirtualWarehouse.Data.Models.Attributes;

namespace VirtualWarehouse.Web.Models
{
    public class ThingDetailsViewModel
    {
        public Thing Thing { get; set; }
        //When the user wants to create an attribute, 
        //this list populates a dropdown for them to 
        //select the attribute type from
        public List<string> AttributeTypes { get; set; }
        public ThingDetailsViewModel(Thing thing)
        {
            AttributeTypes = new List<string>();
            //https://stackoverflow.com/questions/79693/getting-all-types-in-a-namespace-via-reflection
            string nspace = "VirtualWarehouse.Data.Models.Attributes";
            AttributeTypes = AppDomain.CurrentDomain
                                      .GetAssemblies()
                                      .SelectMany(t => t.GetTypes())
                                      .Where(t => t.IsClass && 
                                                  t.Namespace == nspace && 
                                                  t.Name != "ThingAttribute")
                                      .Select(t => t.Name)
                                      .ToList();
            
            Thing = thing;
        }
    }
}
