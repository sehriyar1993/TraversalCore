using Microsoft.AspNetCore.Mvc;

namespace TraversalProje.Controllers
{
    public class ErrorPageController : Controller
    {
        public IActionResult Error404(int code)
        {
            return View();
        }
    }
}
