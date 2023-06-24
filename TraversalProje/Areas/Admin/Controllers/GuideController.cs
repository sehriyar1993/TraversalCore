using BisnessLayer.Abstarct;
using BisnessLayer.ValidutionRole;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace TraversalProje.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class GuideController : Controller
    {
        private readonly iGuideServices _guideServices;

        public GuideController(iGuideServices guideServices)
        {
            _guideServices = guideServices;
        }

        public IActionResult Index()
        {
            var values = _guideServices.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddGuide()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddGuide(Guide guide)
        {
            GuideValidator validationRules = new GuideValidator();
            ValidationResult validationResult = validationRules.Validate(guide);
            if (validationResult.IsValid)
            {
                _guideServices.TAdd(guide);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in validationResult.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
           
        }
        [HttpGet]
        public IActionResult EditGuide(int id)
        {
            var values = _guideServices.TGetByID(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult EditGuide(Guide guide)
        {
            _guideServices.TUpdate(guide);
            return RedirectToAction("Index");

        }
        public IActionResult ChangeToTrue(int id)
        {
            _guideServices.TChangeToTrueGuide(id);
            return RedirectToAction("Index");
        }
        public IActionResult ChangeToFalse(int id)
        {
            _guideServices.TChangeToFalseGuide(id);
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            var values = _guideServices.TGetByID(id);
            _guideServices.TDelete(values);
            return RedirectToAction("Index");
        }

    }
}
