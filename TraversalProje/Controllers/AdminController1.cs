using Microsoft.AspNetCore.Mvc;

namespace TraversalProje.Controllers
{
    public class AdminController1 : Controller
    {
        public PartialViewResult PartialHeader()
        {
            return PartialView();
        }
        public PartialViewResult PartialAppBrendDemo()
        {
            return PartialView();
        }
        public PartialViewResult PartialSideBar()
        {
            return PartialView();
        }
        public PartialViewResult PartialNavBar()
        {
            return PartialView();
        }
        public PartialViewResult PartialFooter()
        {
            return PartialView();
        }
    }
}
