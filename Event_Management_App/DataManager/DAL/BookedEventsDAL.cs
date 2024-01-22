using Event_Management_App.DataManager.IDAL;
using Event_Management_App.Models;
using System.Data;

namespace Event_Management_App.DataManager.DAL
{
    public class BookedEventsDAL : IBookedEventsDAL
    {
        readonly IDBManager _dBManager;

        public BookedEventsDAL(IDBManager dBManager)
        {
            _dBManager = dBManager;
        }

        public List<BookedEventsModel> GetBookedEvents() 
        {
            List<BookedEventsModel> bookedList = new List<BookedEventsModel>();

            //_dBManager

            return bookedList;
        }

        //public List<BookedEventsModel> AddEventList()
        //{
        //    List<AddEventModel> eventList = new List<AddEventModel>();

        //    _dBManager.InitDbCommand("GetAllEvent", CommandType.StoredProcedure);

        //    DataSet ds = _dBManager.ExecuteDataSet();
        //    foreach (DataRow item in ds.Tables[0].Rows)
        //    {
        //        AddEventModel addeventmodel = new AddEventModel();

        //        addeventmodel.Id = item["Id"].ConvertDBNullToInt();
        //        addeventmodel.Category = item["Category"].ConvertDBNullToString();
        //        addeventmodel.Location = item["Location"].ConvertDBNullToString();
        //        addeventmodel.Capacity = item["Capacity"].ConvertDBNullToString();
        //        addeventmodel.Amount = item["Amount"].ConvertDBNullToString();
        //        addeventmodel.Description = item["Description"].ConvertDBNullToString();
        //        addeventmodel.Status = item["Status"].ConvertDBNullToString();
        //        addeventmodel.Address = item["Address"].ConvertDBNullToString();
        //        addeventmodel.Contact = item["Contact"].ConvertDBNullToString();
        //        addeventmodel.ImagePath = item["ImagePath"].ConvertDBNullToString();

        //        eventList.Add(addeventmodel);
        //    }
        //    return eventList;
        //}

        //public AddEventModel AddEvent(AddEventModel addeventmodel)
        //{
        //    _dBManager.InitDbCommand("AddEventInsert", CommandType.StoredProcedure);

        //    _dBManager.AddCMDParam("@Category", addeventmodel.Category);
        //    _dBManager.AddCMDParam("@Location", addeventmodel.Location);
        //    _dBManager.AddCMDParam("@Capacity", addeventmodel.Capacity);
        //    _dBManager.AddCMDParam("@Amount", addeventmodel.Amount);
        //    _dBManager.AddCMDParam("@Description", addeventmodel.Description);
        //    _dBManager.AddCMDParam("@Status", addeventmodel.Status);
        //    _dBManager.AddCMDParam("@Address", addeventmodel.Address);
        //    _dBManager.AddCMDParam("@Contact", addeventmodel.Contact);
        //    _dBManager.AddCMDParam("@ImagePath", addeventmodel.ImagePath);


        //    _dBManager.ExecuteNonQuery();

        //    return addeventmodel;
        //}

        //public string GetDBImagebyID(int ID)
        //{
        //    string existingImage = null;

        //    _dBManager.InitDbCommand("GetDBImagebyID", CommandType.StoredProcedure);

        //    _dBManager.AddCMDParam("@ID", ID);

        //    DataSet ds = _dBManager.ExecuteDataSet();

        //    foreach (DataRow item in ds.Tables[0].Rows)
        //    {
        //        existingImage = item["ImagePath"].ConvertJSONNullToString();
        //    }

        //    return existingImage;
        //}

       
    }
}
