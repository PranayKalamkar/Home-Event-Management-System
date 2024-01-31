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

        public GetAllBookedDetails AddbookEventData(GetAllBookedDetails bookmodel, BookedEventsModel oData)
        {
            //string amount = bookmodel.AddEventModel.Amount.ToString();

            //string deposit = bookmodel.BookedEventsModel.Deposit.ToString();

            //double balance = double.Parse(amount) - double.Parse(deposit);

            //bookmodel.BookedEventsModel.Balance = balance.ToString();

            string amount = bookmodel.AddEventModel?.Amount;

            string deposit = bookmodel.BookedEventsModel?.Deposit;

            double balance = double.Parse(amount) - double.Parse(deposit);

            bookmodel.BookedEventsModel.Balance = balance.ToString();

            bookmodel.BookedEventsModel.Status = "Booked";

            //if (amount != null && deposit != null)
            //{
            //    double balance = double.Parse(amount) - double.Parse(deposit);

            //    bookmodel.BookedEventsModel.Balance = balance.ToString();

            //    bookmodel.BookedEventsModel.Status = "Booked";
            //}

            return _ICustomerBookingDAL.AddbookEventData(bookmodel, oData);
        }
    }
}
