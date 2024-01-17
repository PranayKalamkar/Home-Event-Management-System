using Microsoft.AspNetCore.Mvc;

namespace Event_Management_App.Controllers
{
    public class AnalyticsReportsController : Controller
    {
        public IActionResult AnalyticsReports()
        {
            return View();
        }
    }
}
