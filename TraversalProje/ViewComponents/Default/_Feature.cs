using BisnessLayer.Concrete;
using DataAcsesslayer.Entityframework;
using Microsoft.AspNetCore.Mvc;

namespace TraversalProje.ViewComponents.Default
{
    public class _Feature:ViewComponent
    {
        FeatureManager featureManager = new FeatureManager(new EFFeatureDal());
        public IViewComponentResult Invoke() 
        {
            var values = featureManager.TGetList();
           // ViewBag.f1 = featureManager.
            return View(values); 
        }
    }
}
