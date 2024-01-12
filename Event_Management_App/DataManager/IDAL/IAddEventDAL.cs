using Event_Management_App.Models;

namespace Event_Management_App.DataManager.IDAL
{
    public interface IAddEventDAL
    {
        public List<AddEventModel> AddEventList();

        public AddEventModel AddEvent(AddEventModel addeventmodel);

        public AddEventModel PopulateEventData(string ID);

        public AddEventModel UpdateEventData(AddEventModel addeventmodel);

        public string GetDBImagebyID(string ID);

        public void DeleteEventData(string ID);
    }
}
