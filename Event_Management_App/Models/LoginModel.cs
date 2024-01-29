namespace Event_Management_App.Models
{
    public class LoginModel
    {
        public int GetRole { get; set; }
        public int GetId { get; set; }
        public string ExistingPassword { get; set; }
        public string GetPassword { get; set; }
        public bool EmailExist { get; set; }
    }
}
