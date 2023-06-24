using BisnessLayer.Abstarct;
using BisnessLayer.Concrete;
using DataAcsesslayer.Abstract;
using DataAcsesslayer.Entityframework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace TraversalProje.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DestinationController : Controller
    {
        private readonly IdestinationServices _destinationServices;
        GuideManager guideManager = new GuideManager(new EFGuideDal());

        public DestinationController(IdestinationServices destinationServices)
        {
            _destinationServices = destinationServices;
        }

        public IActionResult Index()
        {
            var values = _destinationServices.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddDestination()
        {
            List<SelectListItem> values = (from x in guideManager.TGetList()
                                           select new SelectListItem
                                           {
                                               Text = x.Name,
                                               Value = x.GuideID.ToString()
                                           }).ToList();
            ViewBag.v = values;
            return View();
        }
        [HttpPost]
        public IActionResult AddDestination(Destination destination)
        {
            
            _destinationServices.TAdd(destination);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteDestination(int id)
        {
            var values = _destinationServices.TGetByID(id);
            _destinationServices.TDelete(values);
            return RedirectToAction("Index");

        }
        [HttpGet]
        public IActionResult UpdateDestination(int id)
        {
            var values = _destinationServices.TGetByID(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateDestination(Destination destination)
        {
            _destinationServices.TUpdate(destination);
            return RedirectToAction("Index");
        }

    }
}
