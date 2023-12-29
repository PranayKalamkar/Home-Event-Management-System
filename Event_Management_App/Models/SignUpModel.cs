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
        [EmailAddress]
        public string? Email { get; set; }

        [Required]
        [StringLength(50)]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,50}$", ErrorMessage = "Password must meet complexity requirements.")]
        public string? SPassword { get; set; }
    }
}
