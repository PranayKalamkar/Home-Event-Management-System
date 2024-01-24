using Event_Management_App.Models;

namespace Event_Management_App.DataManager.IDAL
{
    public interface ICustomerBookingDAL
    {
        public List<AddEventModel> AddEventList();

        public string GetDBImagebyID(int ID);
    }
}
