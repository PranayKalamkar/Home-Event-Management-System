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

        public SignUpModel AddUser(SignUpModel sign)
        {
            sign.SPassword = PasswordHash.ComputeMD5(sign.SPassword);
            return _IEventDAL.AddUser(sign);
        }

        public string LoginUser(string email, string pass)
        {
            string existingPassword = _IEventDAL.LoginUser(email);

            Console.WriteLine(existingPassword);

            bool result = PasswordHash.DecryptMD5(existingPassword, pass);

            if(result)
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

