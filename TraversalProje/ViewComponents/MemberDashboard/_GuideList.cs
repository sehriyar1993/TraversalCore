using BisnessLayer.Concrete;
using DataAcsesslayer.Entityframework;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace TraversalProje.ViewComponents.MemberDashboard
{
    public class _GuideList: ViewComponent
    {
        GuideManager guideManager = new GuideManager(new EFGuideDal());

        public IViewComponentResult Invoke()
        {
            var values = guideManager.TGetList();
            return View(values);
        }
    }
      
    
}
