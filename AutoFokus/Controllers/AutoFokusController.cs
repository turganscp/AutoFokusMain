using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AutoFokus.Models;
using AutoFokus.Services;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AutoFokus.Controllers
{
    public class AutoFokusController : Controller
    {
        private readonly ICarService _carService;

        public AutoFokusController(ICarService carService)
        {
            _carService = carService;
        }


        // GET: /<controller>/
        public async Task<IActionResult> Index()
        {
            var cars = await _carService.GetIncompleteItemsAsync();

            var model = new CarViewModel()
            {
                Cars = cars
            };
            return View(model);


            //var cars = await carService.GetIncompleteItemsAsync();
            //var model = new CarViewModel()
            //{
            //    Cars = cars
            //};
            //return View(model);
        }
    }
}
