using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualWarehouse.Models.ViewModels
{
    public class SavedImageViewModel
    {
        public int Id { get; set; }
        public string externalUrl { get; set; }
        public string fileName { get; set; }
    }
}
