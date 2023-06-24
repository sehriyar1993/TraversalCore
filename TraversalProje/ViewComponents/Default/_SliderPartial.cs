using Microsoft.AspNetCore.Mvc;
namespace TraversalProje.ViewComponents.Default
{
    public class _SliderPartial : ViewComponent
    {
        public IViewComponentResult Invoke() 
        {
            return View();  
        }
    }
}
