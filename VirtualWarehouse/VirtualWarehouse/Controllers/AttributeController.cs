using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VirtualWarehouse.Models.Models;

namespace VirtualWarehouse.Website.Controllers
{
    public class AttributeController : Controller
    {
        [HttpGet]
        public IActionResult AddImageAttribute()
        {
            return View(new ImageAttribute());
        }
    }
}
