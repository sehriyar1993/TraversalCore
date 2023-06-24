using BisnessLayer.Abstarct;
using BisnessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace TraversalProje.Areas.Admin.Controllers
{
    [Area("Admin")]

    public class AboutController : Controller
    {
        private readonly IAboutServices _about;

        public AboutController(IAboutServices about)
        {
            _about = about;
        }

        public IActionResult Index()
        {
            var degerler = _about.TGetList();
            return View(degerler);
        }
        [HttpGet]
        public IActionResult AddAbout()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddAbout(About about)
        {
            _about.TAdd(about);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteAbout(int id)
        {
            var values = _about.TGetByID(id);
            _about.TDelete(values);
            return RedirectToAction("Index");

        }
        [HttpGet]
        public IActionResult UpdateAbout(int id)
        {
            var values = _about.TGetByID(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateAbout(About about)
        {
            _about.TUpdate(about);
            return RedirectToAction("Index");
        }
        public IActionResult ChangeToFalse(int id)
        {
            _about.TChangeToFalseGuide(id);
            return RedirectToAction("Index");
        }
        public IActionResult ChangeToTrue(int id)
        {
            _about.TChangeToTrueGuide(id);
            return RedirectToAction("Index");
        }
    }
}
