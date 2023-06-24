using BisnessLayer.Concrete;
using DataAcsesslayer.Entityframework;
using Microsoft.AspNetCore.Mvc;

namespace TraversalProje.ViewComponents.Default
{
    public class _Testimonial:ViewComponent
    {
        Testimonialmanager testimonialmanager = new Testimonialmanager(new EFTestimonialDal());
        public IViewComponentResult Invoke() 
        {
            var value = testimonialmanager.TGetList();
            return View(value);
        }
    }
}
