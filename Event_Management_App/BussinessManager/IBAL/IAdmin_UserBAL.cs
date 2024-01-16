using Event_Management_App.Models;

namespace Event_Management_App.BussinessManager.IBAL
{
    public interface IAdmin_UserBAL
    {
        public List<Admin_UserModel> GetAdmin_UserList();

        public string AddAdmin_User(Admin_UserModel sign);
    }
}
