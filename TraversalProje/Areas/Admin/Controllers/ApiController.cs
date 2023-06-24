using Microsoft.AspNetCore.Mvc;

namespace TraversalProje.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ApiController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
