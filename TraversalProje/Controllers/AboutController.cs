using BisnessLayer.Concrete;
using DataAcsesslayer.Concrete;
using DataAcsesslayer.Entityframework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;



namespace TraversalProje.Controllers
{
    [AllowAnonymous]
    public class AboutController : Controller
    {
        AboutManager aboutManager = new AboutManager(new EFAboutDal());
        
        public IActionResult Index()
        {
            var degerler = aboutManager.TGetList(); 
            var filtered = degerler.Where(d => d.Status  == true); 
            return View(filtered);
        }
    }
}
