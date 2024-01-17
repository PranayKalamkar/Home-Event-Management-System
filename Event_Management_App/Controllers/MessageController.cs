using Microsoft.AspNetCore.Mvc;

namespace Event_Management_App.Controllers
{
    public class MessageController : Controller
    {
        public IActionResult Message()
        {
            return View();
        }
    }
}
