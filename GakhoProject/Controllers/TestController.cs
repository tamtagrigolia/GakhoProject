﻿using Microsoft.AspNetCore.Mvc;

namespace GakhoProject.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
