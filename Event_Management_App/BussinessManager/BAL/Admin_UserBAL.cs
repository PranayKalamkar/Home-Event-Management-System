using Event_Management_App.BussinessManager.IBAL;
using Event_Management_App.DataManager.DAL;
using Event_Management_App.DataManager.IDAL;
using Event_Management_App.Models;

namespace Event_Management_App.BussinessManager.BAL
{
    public class Admin_UserBAL : IAdmin_UserBAL
    {
        IAdmin_UserDAL _IAdmin_UserDAL;

        public Admin_UserBAL(IDBManager dBManager)
        {
            _IAdmin_UserDAL = new Admin_UserDAL(dBManager);
        }

        public List<Admin_UserModel> GetAdmin_UserList()
        {
            return _IAdmin_UserDAL.GetAdmin_UserList();
        }

        public string AddAdmin_User(Admin_UserModel sign)
        {
            sign.Role = "User";

            bool emailExist = _IAdmin_UserDAL.CheckEmailExist(sign.Email);

            if (emailExist)
            {
                return "Exist";
            }

            _IAdmin_UserDAL.AddAdmin_User(sign);

            return "Success";
        }
    }
}
