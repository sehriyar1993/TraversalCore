using BisnessLayer.Concrete;
using DataAcsesslayer.Entityframework;
using DocumentFormat.OpenXml.Office2010.Excel;
using DocumentFormat.OpenXml.Spreadsheet;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace TraversalProje.Areas.Member.Controllers
{
    [Area("Member")]
    public class ReservationController : Controller
    {
        DestinotionManager destinotionManager = new DestinotionManager(new EFDestinationDal());
        ReservationManager reservationManager = new ReservationManager(new EFReservationDal());
        private readonly UserManager<AppUser> _userManager;

        public ReservationController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult> MyCurrentReservation()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            
            var valueslist = reservationManager.GetListWithReservationsByAccepted(values.Id);
            return View(valueslist);
        }
        public async Task<IActionResult> MyOldReservation()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            
            var valueslist = reservationManager.GetListWithReservationsByPrevious(values.Id);
            return View(valueslist); ;
        }
        public async Task<IActionResult> MyApprovelReservation()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name); 
            ViewBag.v=values.Name;
            var valueslist = reservationManager.GetListWithReservationsByWaitAproval(values.Id);
            return View(valueslist);
        }
        [HttpGet]
        public IActionResult NewReservation()
        {
            List<SelectListItem> values =(from x in destinotionManager.TGetList()
                                          select new SelectListItem
                                          {
                                              Text=x.City,
                                              Value = x.DestinationID.ToString()
                                          }).ToList();
            ViewBag.v = values;
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> NewReservationAsync(Reservation p)
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            p.AppUserId = values.Id;
            p.Status = "Təsdiq Gözləyir";
            reservationManager.TAdd(p);
            return RedirectToAction("MyCurrentReservation");
        }
    }
}
