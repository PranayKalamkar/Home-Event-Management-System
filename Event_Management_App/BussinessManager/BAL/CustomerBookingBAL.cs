using Event_Management_App.BussinessManager.IBAL;
using Event_Management_App.DataManager.DAL;
using Event_Management_App.DataManager.IDAL;
using Event_Management_App.Models;

namespace Event_Management_App.BussinessManager.BAL
{
    public class CustomerBookingBAL : ICustomerBookingBAL
    {
        ICustomerBookingDAL _ICustomerBookingDAL;

        public CustomerBookingBAL(IDBManager dBManager)
        {
            _ICustomerBookingDAL = new CustomerBookingDAL(dBManager);
        }

        public List<GetAllBookedDetails> GetBookedEvents()
        {
            return _ICustomerBookingDAL.GetBookedEvents();
        }

        public GetAllBookedDetails PopulateEventData(int ID)
        {
            return _ICustomerBookingDAL.PopulateEventData(ID);
        }

        public GetAllBookedDetails UpdateEventData(GetAllBookedDetails bookmodel, int ID)
        {
            return _ICustomerBookingDAL.UpdateEventData(bookmodel, ID);
        }
    }
}
