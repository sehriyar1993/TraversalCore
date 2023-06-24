using AutoMapper;
using BisnessLayer.Abstarct;
using DTOLayer.DTOs.AnnouncementDTOs;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using TraversalProje.Areas.Admin.Models;

namespace TraversalProje.Areas.Admin.Controllers
{
    [Area("Admin")]

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
        public IActionResult DeleteAnnouncement(int id)
        {
            var values = _announcementServices.TGetByID(id);
            _announcementServices.TDelete(values);
            return RedirectToAction("Index");

        }
        [HttpGet]
        public IActionResult AddAnnouncement()
        {
           
            return View();
        }
        [HttpPost]
        public IActionResult AddAnnouncement(AnnouncementAddDTOs x)
        {
           
            
                _announcementServices.TAdd(new Announcement()
                {
                    AnnouncementID = x.AnnouncementID,
                    Content = x.Content,
                    Title = x.Title,
                    Status= true,
                    Date= x.Date
                });
                return RedirectToAction("Index");
            
        }
        [HttpGet]
        public IActionResult Update (int id)
        {
            var values = _mapper.Map<AnnouncementUpdateDTO>(_announcementServices.TGetByID(id));
            return View(values);
        }
        [HttpPost]
        public IActionResult Update(AnnouncementUpdateDTO p)
        {
            
            
                _announcementServices.TUpdate(new Announcement()
                {
                    AnnouncementID = p.AnnouncementID,
                    Content = p.Content,
                    Title = p.Title,
                    Status = true,
                    Date = Convert.ToDateTime(DateTime.Now.ToShortDateString())
                });
                return RedirectToAction("Index");
           
        }
        
    }
}
