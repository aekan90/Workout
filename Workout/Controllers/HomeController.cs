using ClassLibraryLayer.LinQ;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Workout.Models;

namespace Workout.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            LazyEagerLoading lazyEagerLoading = new LazyEagerLoading();
            Category getCategoryLazy = lazyEagerLoading.GetKategoriWithLazyLoading(1);
            Category getCategoryEager = lazyEagerLoading.GetKategoriWithEagerLoading(1);
            return View();
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