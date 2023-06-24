using AutoMapper;
using BisnessLayer.Abstarct;
using DTOLayer.DTOs.ContactDTOs;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace TraversalProje.Areas.Member.Controllers
{
    [Area("Member")]
   // [Route("Member/[controller]/[action]")]
    public class ContactUsController : Controller
    {
        private readonly IContactUsServices _contactUsService;
        private readonly IMapper _mapper;

        public ContactUsController(IContactUsServices contactUsService, IMapper mapper)
        {
            _contactUsService = contactUsService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(SendMessageDto model)
        {
            if (ModelState.IsValid)
            {
                _contactUsService.TAdd(new ContactUs()
                {
                    MessageBody = model.MessageBody,
                    Mail = model.Mail,
                    MessageStatus = true,
                    Name = model.Name,
                    Subject = model.Subject,
                    MessageDate = Convert.ToDateTime(DateTime.Now.ToShortDateString())
                });

                return RedirectToAction("Index", "ContactUs");
            }
            return View(model);
        }
    }
}
