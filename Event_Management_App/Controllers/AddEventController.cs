using Event_Management_App.BussinessManager.IBAL;
using Event_Management_App.Models;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using System.Text.Json;

namespace Event_Management_App.Controllers
{
    public class AddEventController : Controller
    {
        IConfiguration _configuration;
        string connectionString;
        IAddEventBAL _IAddEventBAL;

        public AddEventController(IConfiguration configuration, IAddEventBAL addeventBAL)
        {
            _configuration = configuration;
            connectionString = configuration.GetConnectionString("DefaultConnection");
            _IAddEventBAL = addeventBAL;
        }

        public IActionResult AddEvent()
        {
            return View();
        }

        public IActionResult ListEvent()
        {
            return Json(_IAddEventBAL.AddEventList());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(string model, IFormFile file)
        {

            AddEventModel addevntmodel = JsonSerializer.Deserialize<AddEventModel>(model)!;

            _IAddEventBAL.AddEvent(addevntmodel, file);

            return Json("AddEvent");
        }

        public IActionResult Populate(int Id)
        {
            return Json(_IAddEventBAL.PopulateEventData(Id));
        }


        public IActionResult Update(int ID,string model, IFormFile file)
        {
            AddEventModel addeventmodel = JsonSerializer.Deserialize<AddEventModel>(model)!;

            _IAddEventBAL.UpdateEventData(addeventmodel, ID, file);

            return Json("Index");
        }

        public IActionResult Delete(int ID)
        {
            _IAddEventBAL.DeleteEventData(ID);

            return Json("Index");
        }
    }
}
