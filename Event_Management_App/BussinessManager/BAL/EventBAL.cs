using Event_Management_App.BussinessManager.IBAL;
using Event_Management_App.CommonCode;
using Event_Management_App.DataManager.DAL;
using Event_Management_App.DataManager.IDAL;
using Event_Management_App.Models;

namespace Event_Management_App.BussinessManager.BAL
{
    public class EventBAL : IEventBAL
    {
        IEventDAL _IEventDAL;

        public EventBAL(IDBManager dBManager)
        {
            _IEventDAL = new EventDAL(dBManager);
        }

        public List<SignUpModel> GetUserList()
        {
            return _IEventDAL.GetUserList();
        }

        public string SignUp(SignUpModel sign)
        {
            // sign.SPassword = PasswordHash.ComputeMD5(sign.SPassword);

            bool emailExist = _IEventDAL.CheckEmailExist(sign.Email);

            if (emailExist)
            {
                return "Exist";
            }

            _IEventDAL.AddUser(sign);
            return "Success";

        }

        public bool CheckEmailExist(string emailId)
        {
            return _IEventDAL.CheckEmailExist(emailId);
        }

        public string LoginUser(string email, string pass)
        {
            bool emailExist = _IEventDAL.CheckEmailExist(email);

            string getPassword = _IEventDAL.GetPassword(pass);

            string existingPassword = _IEventDAL.LoginUser(email);

            //bool emailExist = _IEventDAL.CheckEmailExist(sign.Email);

            if (!emailExist)
            {
                return "Exist";
            }
            else if (getPassword != existingPassword)
            {
                return "Invalid Password";
            }
            else
            {
                return "Valid Passowrd";
            }

        }
    }
}

