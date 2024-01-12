using Event_Management_App.CommonCode;
using Event_Management_App.DataManager.IDAL;
using Event_Management_App.Models;
using System.Data;

namespace Event_Management_App.DataManager.DAL
{
    public class AddEventDAL : IAddEventDAL
    {
        readonly IDBManager _dBManager;

        public AddEventDAL(IDBManager dBManager)
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

                addeventmodel.Id = item["Id"].ConvertDBNullToString();
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

        public AddEventModel AddEvent(AddEventModel addeventmodel)
        {
            _dBManager.InitDbCommand("AddEventInsert", CommandType.StoredProcedure);

            _dBManager.AddCMDParam("@Id",addeventmodel.Id);
            _dBManager.AddCMDParam("@Category",addeventmodel.Category);
            _dBManager.AddCMDParam("@Location",addeventmodel.Location);
            _dBManager.AddCMDParam("@Capacity",addeventmodel.Capacity);
            _dBManager.AddCMDParam("@Amount",addeventmodel.Amount);
            _dBManager.AddCMDParam("@Description", addeventmodel.Description);
            _dBManager.AddCMDParam("@Status",addeventmodel.Status);
            _dBManager.AddCMDParam("@Address",addeventmodel.Address);
            _dBManager.AddCMDParam("@Contact", addeventmodel.Contact);
            _dBManager.AddCMDParam("@ImagePath", addeventmodel.ImagePath);


            _dBManager.ExecuteNonQuery();

            return addeventmodel;
        }

        public string GetDBImagebyID(string ID)
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

        public AddEventModel PopulateEventData(string ID)
        {
            _dBManager.InitDbCommand("GetAddEventbyId", CommandType.StoredProcedure);

            AddEventModel addeventmodel = null;

            _dBManager.AddCMDParam("@id", ID);

            DataSet ds = _dBManager.ExecuteDataSet();

            foreach(DataRow item in ds.Tables[0].Rows)
            {
                addeventmodel = new AddEventModel();

                addeventmodel.Id = item["Id"].ConvertDBNullToString();
                addeventmodel.Category = item["Category"].ConvertDBNullToString();
                addeventmodel.Location = item["Location"].ConvertDBNullToString();
                addeventmodel.Capacity = item["Capacity"].ConvertDBNullToString();
                addeventmodel.Amount = item["Amount"].ConvertDBNullToString();
                addeventmodel.Description = item["Description"].ConvertDBNullToString();
                addeventmodel.Status = item["Status"].ConvertDBNullToString();
                addeventmodel.Address = item["Address"].ConvertDBNullToString();
                addeventmodel.Contact = item["Contact"].ConvertDBNullToString();
                addeventmodel.ImagePath = item["ImagePath"].ConvertDBNullToString();
            }
            return addeventmodel;
        }

        public AddEventModel UpdateEventData(AddEventModel addeventmodel)
        {
            _dBManager.InitDbCommand("UpdateaddEventById", CommandType.StoredProcedure);

            _dBManager.AddCMDParam("Id", addeventmodel.Id);
            _dBManager.AddCMDParam("Category", addeventmodel.Category);
            _dBManager.AddCMDParam("Location", addeventmodel.Location);
            _dBManager.AddCMDParam("Capacity", addeventmodel.Capacity);
            _dBManager.AddCMDParam("Amount", addeventmodel.Amount);
            _dBManager.AddCMDParam("Description", addeventmodel.Description);
            _dBManager.AddCMDParam("Status", addeventmodel.Status);
            _dBManager.AddCMDParam("Address", addeventmodel.Address);
            _dBManager.AddCMDParam("Contact", addeventmodel.Contact);
            _dBManager.AddCMDParam("ImagePath", addeventmodel.ImagePath);

            _dBManager.ExecuteNonQuery();

            return addeventmodel;
        }

        public void DeleteEventData(string ID)
        {
            _dBManager.InitDbCommand("DeleteAddEventById", CommandType.StoredProcedure);

            _dBManager.AddCMDParam("@Id", ID);

            _dBManager.ExecuteNonQuery();
        }
    }
}
