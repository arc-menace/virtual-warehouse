using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VirtualWarehouse.Data.Models;
using VirtualWarehouse.Data.Services;

namespace VirtualWarehouse.Web.Models
{
    public class ThingDetailsViewModel
    {
        public Thing Thing { get; set; }
        public ThingDetailsViewModel(Thing thing)
        {
            Thing = thing;
        }
    }
}
