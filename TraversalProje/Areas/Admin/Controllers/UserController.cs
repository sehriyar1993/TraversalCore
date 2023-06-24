using BisnessLayer.Abstarct;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace TraversalProje.Areas.Admin.Controllers
{
    [Area("Admin")]

    public class UserController : Controller
    {
        private readonly IAppUserServices _appUserServices;
        private readonly IReservationServices _reservationServices ;

        public UserController(IAppUserServices appUserServices, IReservationServices reservationServices)
        {
            _appUserServices = appUserServices;
            _reservationServices = reservationServices;
        }

        public IActionResult Index()
        {
            var values = _appUserServices.TGetList();
            return View(values);
        }
        public IActionResult DeleteUser(int id)
        {
            var values = _appUserServices.TGetByID(id);
            _appUserServices.TDelete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateUser(int id)
        {
            var values = _appUserServices.TGetByID(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateUser(AppUser appUser)
        {
            _appUserServices.TUpdate(appUser);
            return RedirectToAction("Index");
        }
        public IActionResult CommentUser(int id)
        {
            _appUserServices.TGetList();
            return View();
        }
        public IActionResult ReservationUser(int id)
        {
           var values = _reservationServices.GetListWithReservationsByAccepted(id);
            return View(values);
        }
    }
}
