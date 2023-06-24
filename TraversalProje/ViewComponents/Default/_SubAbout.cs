using BisnessLayer.Concrete;
using DataAcsesslayer.Entityframework;
using Microsoft.AspNetCore.Mvc;

namespace TraversalProje.ViewComponents.Default
{
    public class _SubAbout: ViewComponent
    {
        SubAboutManager subAboutManager = new SubAboutManager(new EFSubAboutdal());
        public IViewComponentResult Invoke()
        {
            var values =subAboutManager.TGetList();
            return View(values); 
        }
    }
}
