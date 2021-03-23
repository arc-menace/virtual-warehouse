using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VirtualWarehouse.Data.Models;

namespace VirtualWarehouse.Web.Models
{
    public class DashboardViewModel
    {
        public List<Thing> Things { get; set; }

        public DashboardViewModel()
        {
            Things = new List<Thing>();
        }
    }
}
