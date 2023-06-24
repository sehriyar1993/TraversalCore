using BisnessLayer.Abstarct;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCoreProje.ViewComponents.MemberDashboard
{
    public class _LastDestinations : ViewComponent
    {
        private readonly IdestinationServices _destinationService;

        public _LastDestinations(IdestinationServices destinationService)
        {
            _destinationService = destinationService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _destinationService.TGetLast4Destinations();
            return View(values);
        }
    }
}