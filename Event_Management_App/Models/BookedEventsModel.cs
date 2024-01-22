using System.ComponentModel.DataAnnotations;

namespace Event_Management_App.Models
{
    public class BookedEventsModel
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        [RegularExpression(@"^[0-9]+$", ErrorMessage = "Deposit must contain only numbers.")]
        public string? Deposit { get; set; }

        [Required]
        [StringLength(50)]
        [RegularExpression(@"^[0-9]+$", ErrorMessage = "Balance must contain only numbers.")]
        public string? Balance { get; set; }

        [Required]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:YYYY/MM/DD}")]
        public string? Date { get; set; }

        [Required]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{HH:mm}")]     
        public string? Time { get; set; }

        [Required]
        [StringLength(50)]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Status must contain only letters.")]
        public string? Status { get; set; }

        public int Addevent_id { get; set; }

        public int Signup_id { get; set; }
    }
}
