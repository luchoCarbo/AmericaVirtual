using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AmericaVirtual.Models;
using AmericaVirtual.Utilities.Interfaces;
using AmericaVirtual.Utilities;
using System.Net.Http;
using AmericaVirtual.Dtos;
using AmericaVirtual.Models.ViewModels.Interfaces;

namespace AmericaVirtual.Controllers
{
    public class HomeController : Controller
    {
        
        private readonly ILogger<HomeController> _logger;
        private readonly ITemperatureViewModel _temperatureViewModel;


        public HomeController(ILogger<HomeController> logger, ITemperatureViewModel temperatureViewModel)
        {
            _logger = logger;
            _temperatureViewModel = temperatureViewModel;
        }

        public async Task<IActionResult> Index()
        {
            var temperatureList = await ApiCommunication.getTemperatureList();

            _temperatureViewModel.AddTemperatureDtoList(temperatureList);
            return View(_temperatureViewModel);
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
