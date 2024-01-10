namespace Event_Management_App.Models
{
    public class LoginModel
    {
        public string GetRole { get; set; }
        public string ExistingPassword { get; set; }
        public string GetPassword { get; set; }
        public bool EmailExist { get; set; }
    }
}
