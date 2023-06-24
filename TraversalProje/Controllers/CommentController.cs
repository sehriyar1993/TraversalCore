using BisnessLayer.Concrete;
using DataAcsesslayer.Entityframework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace TraversalProje.Controllers
{
    [AllowAnonymous]

    public class CommentController : Controller
    {
        CommentManager commentManager = new CommentManager(new EFCommentDal());
        private readonly UserManager<AppUser> _userManager;

        public CommentController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public PartialViewResult AddComment()
        {
            
            return PartialView();
        }
        [HttpPost]
        public IActionResult AddComment(Commentler p, AppUser appUser)
        {
            p.CommentDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            p.CommentState = true;
            commentManager.TAdd(p);
            return RedirectToAction("Index", "Destination");
        }
    }
}
