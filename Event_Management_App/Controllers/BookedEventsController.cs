using Event_Management_App.BussinessManager.BAL;
using Event_Management_App.BussinessManager.IBAL;
using Microsoft.AspNetCore.Mvc;

namespace Event_Management_App.Controllers
{
    public class BookedEventsController : Controller
    {
        IConfiguration _configuration;
        string connectionString;
        IBookedEventsBAL _IBookedEventsBAL;

        public BookedEventsController(IConfiguration configuration, IBookedEventsBAL bookedeventsBAL)
        {
            _configuration = configuration;
            connectionString = configuration.GetConnectionString("DefaultConnection");
            _IBookedEventsBAL = bookedeventsBAL;
        }

        public IActionResult BookedEvents()
        {
            return View();
        }

        public IActionResult BookedEventsList()
        {
            return Json(_IBookedEventsBAL.GetBookedEvents());
        }
    }
}
