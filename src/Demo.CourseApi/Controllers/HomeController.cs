﻿using Microsoft.AspNetCore.Mvc;

namespace Demo.CourseApi.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return Redirect("/swagger");
        }
    }
}