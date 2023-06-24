using BisnessLayer.Concrete;
using DataAcsesslayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace TraversalProje.ViewComponents.Default
{
    public class _Statistics:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            using var c = new Context();
            ViewBag.v1 = c.Destinations.Count();
            ViewBag.v2 = c.Guides.Count();
            ViewBag.v3 = "200";

            return View();
        }
    }
}
