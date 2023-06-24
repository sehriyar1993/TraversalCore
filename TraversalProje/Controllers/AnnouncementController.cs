using AutoMapper;
using BisnessLayer.Abstarct;
using BisnessLayer.Concrete;
using DataAcsesslayer.Entityframework;
using DTOLayer.DTOs.AnnouncementDTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TraversalProje.Controllers
{
    [AllowAnonymous]
    public class AnnouncementController : Controller
    {
        private readonly IAnnouncementServices? _announcementServices;
        private readonly IMapper _mapper;

        public AnnouncementController(IAnnouncementServices? announcementServices, IMapper mapper)
        {
            _announcementServices = announcementServices;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            var values = _mapper.Map<List<AnnouncementListDTO>>(_announcementServices.TGetList());
            return View(values);
        }
    }
}
