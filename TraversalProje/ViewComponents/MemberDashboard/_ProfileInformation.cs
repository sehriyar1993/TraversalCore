using BisnessLayer.Concrete;
using DataAcsesslayer.Entityframework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace TraversalProje.ViewComponents.MemberDashboard
{
    public class _ProfileInformation:ViewComponent
    {
        private readonly UserManager<AppUser> _userManager;

        public _ProfileInformation(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.userName1 = values.Name + " " + values.Surname;
            ViewBag.mail1 = values.Email;
            ViewBag.tel = values.PhoneNumber;
            return View();
        }
    }
}
