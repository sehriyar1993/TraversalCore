using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TraversalProje.Models;

namespace TraversalProje.Controllers
{
    [AllowAnonymous]

    public class LogInController1 : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signManager;

        public LogInController1(UserManager<AppUser> userManager, SignInManager<AppUser> signManager)
        {
            _userManager = userManager;
            _signManager = signManager;
        }

        [HttpGet]
        public IActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> SignUp(UserRegisterViewModel p)
        {   
            AppUser appUser = new AppUser() 
            {
				Name = p.Name,
				Surname = p.Surname,
                Email=p.Mail,
                UserName=p.UserName
                
            };
           if(p.Password==p.ConfirmPassword)
            {
                var result=await _userManager.CreateAsync(appUser, p.Password); 
                if(result.Succeeded)
                {
                    return RedirectToAction("SignIn");
                }
                else 
                {
                 foreach(var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }    
            }
            return View(p);
        }
        [HttpGet]
        public IActionResult SignIn()
        {
            return View();
        }
        [HttpPost]
		public async Task<IActionResult> SignIn(UserSignInViewModel p)
		{
			if (ModelState.IsValid)
			{
				var result = await _signManager.PasswordSignInAsync(p.UserName ,p.Password, false, true);
				if (result.Succeeded)
				{
					return RedirectToAction("Index", "Dashboard", new {area = "Member"}); ///Member/Dashboard/Index

                }
                else
				{
					return RedirectToAction("SignIn", "LogInController1" );
				}
			}
			return View();
		}
        public async Task<IActionResult> SignOut() 
        {
            await _signManager.SignOutAsync(); 
            return RedirectToAction("SignIn", "LogInController1"); 
        }




    }
}
