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

        public AddEventController(IConfiguration configuration)
        {
            _configuration = configuration;
            connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        public IActionResult Index()
        {
            List<AddEventModel> eventList = new List<AddEventModel>();
            const string storedProcedure = "";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            using (MySqlCommand command = new MySqlCommand(storedProcedure, connection))
            {
                command.CommandType = System.Data.CommandType.StoredProcedure;
                connection.Open();

                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    AddEventModel eventmodel = new AddEventModel();

                    eventmodel.Id = reader["Id"].ToString();
                    eventmodel.Id = reader["Category"].ToString();
                    eventmodel.Id = reader["Location"].ToString();
                    eventmodel.Id = reader["Capacity"].ToString();
                    eventmodel.Id = reader["Amount"].ToString();
                    eventmodel.Id = reader["Desciption"].ToString();
                    eventmodel.Id = reader["Status"].ToString();
                    eventmodel.Id = reader["ImagePath"].ToString();

                    eventList.Add(eventmodel);
                }
            }
            return View(eventList);
        }

        public IActionResult AddEvent()
        {
            return View();
            //return Json();
        }

        public IActionResult Create()
        {
            return View();
        }
        public IActionResult Create(string model, IFormFile file)
        {

            AddEventModel addevntmodel = JsonSerializer.Deserialize<AddEventModel>(model)!;

            

            return View();
        }

    }
}
