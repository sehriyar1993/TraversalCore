using Microsoft.AspNetCore.Mvc;

namespace TraversalProje.Controllers
{
    public class InformationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
