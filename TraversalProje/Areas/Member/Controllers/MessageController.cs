﻿using Microsoft.AspNetCore.Mvc;

namespace TraversalProje.Areas.Member.Controllers
{
    public class MessageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
