﻿using Microsoft.AspNetCore.Mvc;

namespace Event_Management_App.Controllers
{
    public class UserPageController : Controller
    {
        public IActionResult UserPage()
        {
            return View();
        }
    }
}
