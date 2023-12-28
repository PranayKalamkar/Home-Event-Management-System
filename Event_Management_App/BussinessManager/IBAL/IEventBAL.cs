using Event_Management_App.Models;

namespace Event_Management_App.BussinessManager.IBAL
{
    public interface IEventBAL
    {
        public List<SignUpModel> GetUserList();
        public SignUpModel AddUser(SignUpModel user);

        public string LoginUser(string email, string pass);
    }
}
