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
            return null;

            //return _IEventDAL.LoginUser();
        }
        //{
        //    //string existingPassword = _IEventDAL.LoginUser(email);

        //    //Console.WriteLine(existingPassword);

        //    //bool result = PasswordHash.DecryptMD5(existingPassword, pass);

        //    bool result = null;

        //    if(result)
        //    {
        //        return "Valid";
        //    }
        //    else
        //    {
        //        return "Invalid Pasword!";
        //    }
        //}
    }
}

