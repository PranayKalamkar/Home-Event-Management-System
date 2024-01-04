using Event_Management_App.BussinessManager.IBAL;
using Event_Management_App.Extension;
using Event_Management_App.Models;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
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

           if(ModelState.IsValid)
            {
                var result = _IEventBAL.SignUp(sign);

                if(result == "Exist")
                {
                    //return Json("Email Already Exist!");
                    return Json(new { status = "warning", message = "Email Id Already Exists!" });
                }
            }

            //return Json("Login");
            return Json(new { status = "success", message = "User register successfully!" });
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult LoginPost(string Email, string SPassword)
        {
            var result = _IEventBAL.LoginUser(Email, SPassword);

            if(result == "Invalid Password")
            {
                return Json(new { status = "warning", message = "Invalid Passowrd!" });
            }
            return Json(new { status = "success", message = "User Login successfully!" });
        }
    }
}


//if (result == "exists")
//{
//    return Json(new { status = "warning", message = "Email Id Already Exists!" });
//}
//return Json(new { status = "success", message = "User register successfully!" });