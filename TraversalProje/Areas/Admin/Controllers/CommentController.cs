using BisnessLayer.Abstarct;
using BisnessLayer.Concrete;
using DataAcsesslayer.Entityframework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MimeKit.Encodings;

namespace TraversalProje.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CommentController : Controller
    {
        private readonly IcommentServices _commentServices;

        public CommentController(IcommentServices commentServices)
        {
            _commentServices = commentServices;
        }
        [HttpGet]
        public IActionResult Index(Destination x)
        {
            
            var values = _commentServices.TGetListCommentsWithDestination();
            return View(values);
        }
       
        

        public IActionResult DeleteComment(int id)
        {
            var values = _commentServices.TGetByID(id);
            _commentServices.TDelete(values);
            return RedirectToAction("Index");
        }

    }
}
