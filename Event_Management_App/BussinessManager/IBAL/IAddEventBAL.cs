using Event_Management_App.Models;

namespace Event_Management_App.BussinessManager.IBAL
{
    public interface IAddEventBAL
    {
        public List<AddEventModel> AddEventList();

        public AddEventModel AddEvent(AddEventModel addeventmodel, IFormFile ImageFile);

        public AddEventModel PopulateEventData(string ID);

        public AddEventModel UpdateEventData(AddEventModel addeventmodel, string ID, IFormFile file);

        public void DeleteEventData(string ID);

        public string UploadImage(IFormFile imageFile);
    }
}
