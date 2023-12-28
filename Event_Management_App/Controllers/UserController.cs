using Event_Management_App.BussinessManager.IBAL;
using Event_Management_App.Extension;
using Event_Management_App.Models;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using System.Text.Json;

namespace Event_Management_App.Controllers
{
    public class UserController : Controller
    {
        readonly IEventBAL _IEventBAL;

        public UserController(IEventBAL eventBAL)
        {
            _IEventBAL = eventBAL;
        }

        public IActionResult GetUser()
        {
            return Json(_IEventBAL.GetUserList());
        }

        public IActionResult Dashboard()
        {
            return View();
        }

        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SignUpPost(string model)
        {
            SignUpModel sign = JsonSerializer.Deserialize<SignUpModel>(model)!;

            _IEventBAL.AddUser(sign);

            return Json("Login");
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult LoginPost(string email, string pass)
        {
            var result = _IEventBAL.LoginUser(email,pass);

            if(result == "Valid")
            {
                return Json("Valid");
            }
            return Json("Invalid");
        }
    }
}
