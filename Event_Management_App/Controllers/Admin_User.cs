using Microsoft.AspNetCore.Mvc;

namespace Event_Management_App.Controllers
{
    public class Admin_User : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
