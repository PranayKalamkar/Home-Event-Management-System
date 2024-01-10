using Microsoft.AspNetCore.Mvc;

namespace Event_Management_App.Controllers
{
    public class UserPageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult UserView()
        {
            return View();
        }
    }
}
