using BisnessLayer.Concrete;
using DataAcsesslayer.Entityframework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace TraversalProje.Controllers
{
    [AllowAnonymous]
    public class DestinationController : Controller
    {

        DestinotionManager destinotionManager = new DestinotionManager(new EFDestinationDal());
        private readonly UserManager<AppUser> _userManager;

        public DestinationController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        public IActionResult Index()
        {
            var values = destinotionManager.TGetList();
            return View(values);
        }
		
		public async Task<IActionResult> DestinationDetas(int id)
        {
            ViewBag.i = id;
            ViewBag.destID = id;

            if (User.Identity.IsAuthenticated)
            {
                var value = await _userManager.FindByNameAsync(User.Identity.Name);
                ViewBag.userID = value.Id;
            }
            else
            {
            }
            //var value = await _userManager.FindByNameAsync(User.Identity.Name);
            //ViewBag.userID = value.Id;
            var values = destinotionManager.TGetDestinationWithGuide(id);
            return View(values);
        }
        // public IActionResult Index()
        // {
        //     var value = destinotionManager.TGetList();
        //     return View(value);
        // }
        //// [HttpGet]
        // public async Task<IActionResult> DestinationDetas(int id) 
        // {

        //     ViewBag.i = id;
        //     ViewBag.destID = id;
        //     if (User.Identity.IsAuthenticated)
        //     {
        //         var value = await _userManager.FindByNameAsync(User.Identity.Name);
        //         ViewBag.userID = value.Id;
        //     }
        //     else
        //     {
        //     }
        //     var values = destinotionManager.TGetDestinationWithGuide(id);


        //     return View(values);

        // }
        //[HttpPost]
        //public IActionResult DestinationDetas(Destination p) 
        //{
        //     return View();
        //}

    }
}
