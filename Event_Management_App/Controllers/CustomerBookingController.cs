using Event_Management_App.BussinessManager.IBAL;
using Microsoft.AspNetCore.Mvc;

namespace Event_Management_App.Controllers
{
    public class CustomerBookingController : Controller
    {
        ICustomerBookingBAL _ICustomerBookingBAL;

        public CustomerBookingController(ICustomerBookingBAL customerbookBAL)
        {
            _ICustomerBookingBAL = customerbookBAL;
        }
        public IActionResult CustomerBooking()
        {
            return View();
        }

        public IActionResult CustomerListEvent()
        {
            return Json(_ICustomerBookingBAL.AddEventList());
        }
    }
}
