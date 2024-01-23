using Event_Management_App.Models;

namespace Event_Management_App.DataManager.IDAL
{
    public interface IBookedEventsDAL
    {
        public List<BookedEventsModel> GetBookedEvents();

        public string GetDBImagebyID(int ID);
    }
}
