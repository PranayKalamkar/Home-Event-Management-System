using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Event_Management_App.Models
{
    [Table("SignUp")]
    public class SignUpModel
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Username must contain only letters and numbers.")]
        public string? Username { get; set; }

        [Required]
        [StringLength(50)]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string? Email { get; set; }

        [Required]
        //[StringLength(50)]
        //[Display(Name = "Password")]
        //[RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,50}$", ErrorMessage = "Password must meet complexity requirements.")]
        [RegularExpression(@"^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{8,}$", ErrorMessage = "Password must meet complexity requirements.")]
        public string? SPassword { get; set; }

        [Required]
        //[StringLength(50)]
        //[Display(Name ="Confirm Password")]
        [Compare(nameof(SPassword), ErrorMessage = "Passwords do not match")]
        //[RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,50}$", ErrorMessage = "Password must meet complexity requirements.")]
        [RegularExpression(@"^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{8,}$", ErrorMessage = "Password must meet complexity requirements.")]
        public string? ConfirmSPassword { get; set; }

        [Required]
        public string? Role { get; set; }
    }
}
