using BisnessLayer.Abstarct;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using TraversalProje.Models;

namespace TraversalProje.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CityController : Controller
    {
        private readonly IdestinationServices _destinationServices;
        public CityController(IdestinationServices destinationServices)
        {
            _destinationServices = destinationServices;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CityList()
        {
            var jasoncity = JsonConvert.SerializeObject(_destinationServices.TGetList);
            return Content(jasoncity, "application/json");
        }


        [HttpPost]
        public IActionResult AddCityDestination(Destination destination)
        {
            destination.Status = true;
            _destinationServices.TAdd(destination);
            var values = JsonConvert.SerializeObject(destination);
            return Json(destination);
        }
        public IActionResult GetById(int DestinationID)
        {
            var values = _destinationServices.TGetByID(DestinationID);
            var jsonValues = JsonConvert.SerializeObject(values);
            return Json(jsonValues);
        }

        public IActionResult DeleteCity(int id)
        {
            var values = _destinationServices.TGetByID(id);
            _destinationServices.TDelete(values);
            return NoContent();
        }

        public IActionResult UpdateCity(Destination destination)
        {
            _destinationServices.TUpdate(destination);
            var v = JsonConvert.SerializeObject(destination);
            return Json(v);
        }
    }
}
