using DTB.Core.Contracts;
using DTB.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DTB.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ICategoryService _categoryService;
        private readonly ILocationService _locationService;

        public HomeController(
            ILogger<HomeController> logger,
            ICategoryService categoryService,
            ILocationService locationService)
        {
            _logger = logger;
            _categoryService = categoryService;
            _locationService = locationService;
        }

        public async Task<IActionResult> Index()
        {
            var vm = new HomePageViewModel();

            vm.Categories = await _categoryService.GetAllCategoriesAsync();
            vm.Locations = await _locationService.GetAllLocationsAsync();

            return View(vm);
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

        public IActionResult AboutUs()
        {
            return View();
        }

        public IActionResult ContactUs()
        {
            return View();
        }
    }
}
