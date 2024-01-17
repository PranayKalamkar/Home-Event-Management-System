using Event_Management_App.Models;

namespace Event_Management_App.DataManager.IDAL
{
    public interface IEventDAL
    {
        public List<SignUpModel> GetUserList();
        public SignUpModel AddUser(SignUpModel sign);
        public string GetPassword(string pass);
        public int GetRole(string email);
        public string LoginUser(string email);
        public bool CheckEmailExist(string emailId);
    }
}
