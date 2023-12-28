using Event_Management_App.BussinessManager.IBAL;
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

        public SignUpModel AddUser(SignUpModel sign)
        {
            return _IEventDAL.AddUser(sign);
        }

        public string LoginUser(string email, string pass)
        {
            string existingPassword = _IEventDAL.LoginUser(email);

            if(existingPassword == pass)
            {
                return "Valid";
            }
            else
            {
                return "Invalid Pasword!";
            }
        }
    }
}

