using BisnessLayer.Abstarct;
using Microsoft.AspNetCore.Mvc;

namespace TraversalProje.ViewComponents.Destination
{
    public class _GuideDetails : ViewComponent
    {
        private readonly iGuideServices _guideService;

        public _GuideDetails(iGuideServices guideService)
        {
            _guideService = guideService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _guideService.TGetByID(1);
            return View(values);
        }
    }
}
