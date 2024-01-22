using Microsoft.AspNetCore.Mvc;

namespace Event_Management_App.Controllers
{
    public class BookedEventsController : Controller
    {
        public IActionResult BookedEvents()
        {
            return View();
        }
    }
}
