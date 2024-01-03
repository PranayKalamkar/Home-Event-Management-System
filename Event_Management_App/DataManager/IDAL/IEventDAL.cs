using Event_Management_App.Models;

namespace Event_Management_App.DataManager.IDAL
{
    public interface IEventDAL
    {
        public List<SignUpModel> GetUserList();
        public SignUpModel AddUser(SignUpModel sign);
        public string LoginUser(string email, string pass);
        public bool CheckEmailExist(string emailId);
    }
}
