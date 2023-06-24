using Microsoft.AspNetCore.Mvc;

namespace TraversalProje.ViewComponents.AdminDasboard
{
    public class _TotalRevanue: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            //ViewBag.c2 = c.Users.Count();
            //ViewBag.c1 = c.Destinations.Count();
            return View();
        }
    }
}
