using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using VirtualWarehouse.Data.Models;
using VirtualWarehouse.Data.Services;
using VirtualWarehouse.Models;
using VirtualWarehouse.Web.Models;

namespace VirtualWarehouse.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private DatabaseContext _context { get; set; } 

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _context = new DatabaseContext(new DbContextOptions<DatabaseContext>());
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Dashboard()
        {
            var viewModel = new DashboardViewModel();

            //Select all things in database and place into viewmodel list
            viewModel.Things = _context.Things.Select(n => n).ToList();

            return View(viewModel);
        }

        [HttpGet]
        public IActionResult ThingDetails(int id)
        {
            /*
             * This page displays information about a specific "thing"
             * It also displays all of the associated attributes
             */

            //Get the selected thing from database
            Thing thing = _context.Things.Where(n => n.ThingId == id).FirstOrDefault();
            thing.Attributes = _context.ThingAttributes.Where(n => n.ThingId == thing.ThingId).ToList();
            var viewModel = new ThingDetailsViewModel(thing);

            return View(viewModel);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
