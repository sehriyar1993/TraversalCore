using BisnessLayer.Abstarct;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace TraversalProje.Areas.Admin.Controllers
{
    [Area("Admin")]

    public class SubAboutController : Controller
    {
        private readonly ISubAbutServices _subAbut;

        public SubAboutController(ISubAbutServices subAbut)
        {
            _subAbut = subAbut;
        }

        public IActionResult Index()
        {
            var degerler = _subAbut.TGetList();
            return View(degerler);
        }
        [HttpGet]
        public IActionResult AddSubAbout()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddSubAbout(SubAbout about)
        {
            _subAbut.TAdd(about);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteSubAbout(int id)
        {
            var values = _subAbut.TGetByID(id);
            _subAbut.TDelete(values);
            return RedirectToAction("Index");

        }
        [HttpGet]
        public IActionResult UpdateSubAbout(int id)
        {
            var values = _subAbut.TGetByID(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateSubAbout(SubAbout about)
        {
            _subAbut.TUpdate(about);
            return RedirectToAction("Index");
        }
    }
}
