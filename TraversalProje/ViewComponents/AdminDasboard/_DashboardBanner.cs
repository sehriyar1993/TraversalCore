using Microsoft.AspNetCore.Mvc;

namespace TraversalProje.ViewComponents.AdminDasboard
{
    public class _DashboardBanner:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }

    }
}
