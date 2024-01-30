using Event_Management_App.BussinessManager.IBAL;
using Event_Management_App.Models;
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
            return Json(_ICustomerBookingBAL.GetBookedEvents());
        }

        public IActionResult Populate(int ID)
        {
            return Json(_ICustomerBookingBAL.PopulateEventData(ID));
        }

        public IActionResult Update(GetAllBookedDetails bookmodel, int ID)
        {
            _ICustomerBookingBAL.UpdateEventData(bookmodel, ID);

            return Json("CustomerListEvent");
        }
    }
}
