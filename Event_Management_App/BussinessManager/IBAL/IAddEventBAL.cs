using Event_Management_App.Models;

namespace Event_Management_App.BussinessManager.IBAL
{
    public interface IAddEventBAL
    {
        public List<AddEventModel> AddEventList();

        public AddEventModel AddEvent(AddEventModel addeventmodel, IFormFile ImageFile);
    }
}
