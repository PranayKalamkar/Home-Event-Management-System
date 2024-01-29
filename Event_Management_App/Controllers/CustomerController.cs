using Microsoft.AspNetCore.Mvc;

namespace Event_Management_App.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Customer()
        {
            Console.WriteLine(HttpContext.Session.GetInt32("Id"));

            return View();
        }
    }
}
