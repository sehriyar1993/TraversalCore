using BisnessLayer.Abstarct;
using Microsoft.AspNetCore.Mvc;

namespace TraversalProje.Areas.Admin.Controllers
{
    [Area("Admin")]

    public class ContactUsController : Controller
    {
        private readonly  IContactUsServices _contactUsServices;

        public ContactUsController(IContactUsServices contactUsServices)
        {
            _contactUsServices = contactUsServices;
        }

        public IActionResult Index()
        {
            var values = _contactUsServices.TGetListContactUsByTrue();
            return View(values);
        }
        public IActionResult Index2()
        {
            var values = _contactUsServices.TGetListContactUsByFalse();
            return View(values);
        }
        public IActionResult Index3()
        {
            var values = _contactUsServices.TGetList();
            return View(values);
        }
        public IActionResult ChangeToTrue(int id)
        {
            _contactUsServices.TContactUsChangeToTrue(id);
            return RedirectToAction("Index");
        }
        public IActionResult ChangeToFalse(int id)
        {
            _contactUsServices.TContactUsChangeToFalse(id);
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            var values = _contactUsServices.TGetByID(id);
            _contactUsServices.TDelete(values);
            return RedirectToAction("Index");
        }
    }
}
