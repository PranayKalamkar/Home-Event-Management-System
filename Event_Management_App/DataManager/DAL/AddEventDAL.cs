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

            _dBManager.InitDbCommand("",CommandType.StoredProcedure);

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
                addeventmodel.ImagePath = item["ImagePath"].ConvertDBNullToString();

                eventList.Add(addeventmodel);
            }
            return eventList;
        }

        public AddEventModel AddEvent(AddEventModel addeventmodel)
        {
            _dBManager.InitDbCommand("", CommandType.StoredProcedure);

            _dBManager.AddCMDParam("@Id",addeventmodel.Id);
            _dBManager.AddCMDParam("@Category",addeventmodel.Category);
            _dBManager.AddCMDParam("@Location",addeventmodel.Location);
            _dBManager.AddCMDParam("@Capacity",addeventmodel.Category);
            _dBManager.AddCMDParam("@Amount",addeventmodel.Amount);
            _dBManager.AddCMDParam("@Description",addeventmodel.Description);
            _dBManager.AddCMDParam("@Status",addeventmodel.Status);
            _dBManager.AddCMDParam("@ImagePath",addeventmodel.ImagePath);

            _dBManager.ExecuteNonQuery();

            return addeventmodel;
        }
    }
}
