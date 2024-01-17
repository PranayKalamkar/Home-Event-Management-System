using Microsoft.AspNetCore.Mvc;

namespace Event_Management_App.Controllers
{
    public class TeamController : Controller
    {
        public IActionResult Team()
        {
            return View();
        }
    }
}
