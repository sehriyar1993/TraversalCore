using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TraversalProje.Areas.Member.Controllers
{
    public class CommentController : Controller
    {
        [Area("Member")]
        
        public IActionResult Index()
        {
            return View();
        }
    }
}
