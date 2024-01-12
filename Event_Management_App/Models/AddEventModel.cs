namespace Event_Management_App.Models
{
    public class AddEventModel
    {
        public string Id { get; set; }
        public string Category { get; set; }
        public string Location { get; set; }
        public string Capacity { get; set; }
        public string Amount { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public string ImagePath { get; set; }
        public IFormFile ImageFile { get; set; }
        public string Address { get; set; }
        public string Contact { get; set; }

    }
}
