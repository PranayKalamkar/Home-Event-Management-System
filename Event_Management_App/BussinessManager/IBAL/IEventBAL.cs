using Event_Management_App.Models;

namespace Event_Management_App.BussinessManager.IBAL
{
    public interface IEventBAL
    {
        public List<SignUpModel> GetUserList();
        public string SignUp(SignUpModel user);
        public LoginModel LoginUser(string email, string pass);

        // public bool CheckEmailExist(string emailId);
    }
}
