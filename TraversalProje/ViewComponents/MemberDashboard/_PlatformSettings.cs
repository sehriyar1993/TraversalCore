using Microsoft.AspNetCore.Mvc;

namespace TraversalProje.ViewComponents.MemberDashboard
{
    public class _PlatformSettings: ViewComponent
    {
        public IViewComponentResult Invoke() 
        {
            return View(); 
        }
    }
}
