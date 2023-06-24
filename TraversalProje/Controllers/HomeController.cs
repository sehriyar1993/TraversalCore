using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TraversalProje.Models;

namespace TraversalProje.Controllers
{
    [AllowAnonymous]

    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            DateTime d = Convert.ToDateTime(DateTime.Now.ToLongTimeString());
            _logger.LogInformation(d + "İndex səhifəsi çağırıldı");
            return View();
        }

        public IActionResult Privacy()
        {
            _logger.LogInformation("Privacy səhifəsi çağırıldı");
            return View();
        }
        public IActionResult Test() 
        {
            _logger.LogInformation("Test səhifəsi çağırıldı");
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}