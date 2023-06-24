using BisnessLayer.Concrete;
using DataAcsesslayer.Concrete;
using DataAcsesslayer.Entityframework;
using Microsoft.AspNetCore.Mvc;

namespace TraversalProje.ViewComponents.Comment
{
    public class _CommentList:ViewComponent
    {
        CommentManager commentManager = new CommentManager(new EFCommentDal());
        Context contex = new Context();
        public IViewComponentResult Invoke(int id) 
        {
            ViewBag.Say = contex.Commentlers.Where(x => x.DestinationID == id).Count();
            var values = commentManager.TGetListCommentsWithDestinationAndUser(id);
            return View(values);
        }
    }
}
