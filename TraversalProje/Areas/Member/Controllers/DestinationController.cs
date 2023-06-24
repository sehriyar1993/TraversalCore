using BisnessLayer.Concrete;
using DataAcsesslayer.Entityframework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TraversalProje.Areas.Member.Controllers
{
    [Area("Member")]
    public class DestinationController : Controller
    {
        DestinotionManager destinotionManager = new DestinotionManager(new EFDestinationDal());
        public IActionResult Index()
        {
            var values = destinotionManager.TGetList();
            return View(values);
        }
        public IActionResult GetCitiesSearchByName(string searchString)
        {
            ViewData["CurrentFilter"] = searchString;
            var values = from x in destinotionManager.TGetList() select x;
            if (!string.IsNullOrEmpty(searchString))
            {
                values = values.Where(y => y.City.Contains(searchString));
            }
            return View(values.ToList());
        }
    }
}
