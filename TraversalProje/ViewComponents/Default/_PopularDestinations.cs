using BisnessLayer.Concrete;
using DataAcsesslayer.Entityframework;
using Microsoft.AspNetCore.Mvc;

namespace TraversalProje.ViewComponents.Default
{
    public class _PopularDestinations : ViewComponent
    {
        DestinotionManager destinotionManager = new DestinotionManager(new EFDestinationDal());
        public IViewComponentResult Invoke()
        {
            var values = destinotionManager.TGetLast6Destinations();
            return View(values);
        }
    }
}
