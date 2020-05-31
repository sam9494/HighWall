using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using HighWall.Core.Model;
using HighWall.Core.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using HighWall.Models;

namespace HighWall.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ICapitalismService _capitalismService;

        public HomeController(ILogger<HomeController> logger, ICapitalismService capitalismService)
        {
            _logger = logger;
            _capitalismService = capitalismService;
        }

        public IActionResult Index()
        {
            var viewModel = _capitalismService.GetHomeViewModel();


            _logger.LogInformation("This is Info log");
            _logger.LogInformation("This is debug log");
            _logger.LogError("This is error log");

            return View(viewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
