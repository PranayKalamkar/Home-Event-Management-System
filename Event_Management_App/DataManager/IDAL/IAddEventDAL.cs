using Event_Management_App.Models;

namespace Event_Management_App.DataManager.IDAL
{
    public interface IAddEventDAL
    {
        public List<AddEventModel> AddEventList();

        public AddEventModel AddEvent(AddEventModel addeventmodel);

        public AddEventModel PopulateEventData(int ID);

        public AddEventModel UpdateEventData(AddEventModel addeventmodel);

        public string GetDBImagebyID(int ID);

        public void DeleteEventData(int ID);
    }
}
