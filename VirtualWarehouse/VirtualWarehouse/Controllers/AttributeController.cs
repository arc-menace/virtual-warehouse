using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VirtualWarehouse.Website.Controllers
{
    public class AttributeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
