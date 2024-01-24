using Event_Management_App.CommonCode;
using Event_Management_App.DataManager.IDAL;
using Event_Management_App.Models;
using System.Data;

namespace Event_Management_App.DataManager.DAL
{
    public class CustomerBookingDAL : ICustomerBookingDAL
    {
        readonly IDBManager _dBManager;

        public CustomerBookingDAL(IDBManager dBManager)
        {
            _dBManager = dBManager;
        }

        public List<AddEventModel> AddEventList()
        {
            List<AddEventModel> eventList = new List<AddEventModel>();

            _dBManager.InitDbCommand("GetAllEvent", CommandType.StoredProcedure);

            DataSet ds = _dBManager.ExecuteDataSet();
            foreach (DataRow item in ds.Tables[0].Rows)
            {
                AddEventModel addeventmodel = new AddEventModel();

                addeventmodel.Id = item["Id"].ConvertDBNullToInt();
                addeventmodel.Category = item["Category"].ConvertDBNullToString();
                addeventmodel.Location = item["Location"].ConvertDBNullToString();
                addeventmodel.Capacity = item["Capacity"].ConvertDBNullToString();
                addeventmodel.Amount = item["Amount"].ConvertDBNullToString();
                addeventmodel.Description = item["Description"].ConvertDBNullToString();
                addeventmodel.Status = item["Status"].ConvertDBNullToString();
                addeventmodel.Address = item["Address"].ConvertDBNullToString();
                addeventmodel.Contact = item["Contact"].ConvertDBNullToString();
                addeventmodel.ImagePath = item["ImagePath"].ConvertDBNullToString();

                eventList.Add(addeventmodel);
            }
            return eventList;
        }

        public string GetDBImagebyID(int ID)
        {
            string existingImage = null;

            _dBManager.InitDbCommand("GetDBImagebyID", CommandType.StoredProcedure);

            _dBManager.AddCMDParam("@ID", ID);

            DataSet ds = _dBManager.ExecuteDataSet();

            foreach (DataRow item in ds.Tables[0].Rows)
            {
                existingImage = item["ImagePath"].ConvertJSONNullToString();
            }

            return existingImage;
        }
    }
}
