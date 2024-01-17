using Event_Management_App.CommonCode;
using Event_Management_App.DataManager.IDAL;
using Event_Management_App.Models;
using System.Data;

namespace Event_Management_App.DataManager.DAL
{
    public class AdminDAL : IAdminDAL
    {
        readonly IDBManager _dBManager;

        public AdminDAL(IDBManager dbManager)
        {
            _dBManager = dbManager;
        }

        public List<AdminModel> GetAdminList()
        {
            List<AdminModel> userList = new List<AdminModel>();

            _dBManager.InitDbCommand("GetAllAdmin", CommandType.StoredProcedure);

            DataSet ds = _dBManager.ExecuteDataSet();

            foreach (DataRow item in ds.Tables[0].Rows)
            {
                AdminModel model = new AdminModel();

                model.Id = item["Id"].ConvertDBNullToInt();
                model.Username = item["Username"].ConvertDBNullToString();
                model.Email = item["Email"].ConvertDBNullToString();

                userList.Add(model);

            }

            return userList;

        }

        public AdminModel AddAdmin(AdminModel sign)
        {
            sign.SPassword = sign.SPassword + _dBManager.getSalt();

            _dBManager.InitDbCommand("InsertAdmin", CommandType.StoredProcedure);

            _dBManager.AddCMDParam("@Username", sign.Username);
            _dBManager.AddCMDParam("@Email", sign.Email);
            _dBManager.AddCMDParam("@SPassword", sign.SPassword);
            _dBManager.AddCMDParam("@u_RoleId", sign.Role);


            _dBManager.ExecuteNonQuery();

            return sign;
        }

        public bool CheckEmailExist(string emailId)
        {
            _dBManager.InitDbCommand("CheckEmailExist", CommandType.StoredProcedure);

            _dBManager.AddCMDParam("@newEmail", emailId);

            var result = _dBManager.ExecuteScalar();

            bool emailExist = Convert.ToBoolean(result);

            return emailExist;
        }

        public AdminModel PopulateAdminData(int ID)
        {
            _dBManager.InitDbCommand("GetAdminbyId", CommandType.StoredProcedure);

            AdminModel adminmodel = null;

            _dBManager.AddCMDParam("@p_id", ID);

            DataSet ds = _dBManager.ExecuteDataSet();

            foreach (DataRow item in ds.Tables[0].Rows)
            {
                adminmodel = new AdminModel();

                adminmodel.Id = item["Id"].ConvertDBNullToInt();
                adminmodel.Username = item["Username"].ConvertDBNullToString();
                adminmodel.Email = item["Email"].ConvertDBNullToString();
            }
            return adminmodel;
        }

        public AdminModel UpdateAdminData(AdminModel adminmodel, int ID)
        {
            _dBManager.InitDbCommand("UpdateadminById", CommandType.StoredProcedure);

            _dBManager.AddCMDParam("u_Id", ID);
            _dBManager.AddCMDParam("Username", adminmodel.Username);
            _dBManager.AddCMDParam("Email", adminmodel.Email);

            _dBManager.ExecuteNonQuery();

            return adminmodel;
        }

        public void DeleteAdminData(int ID)
        {
            _dBManager.InitDbCommand("DeleteadminById", CommandType.StoredProcedure);

            _dBManager.AddCMDParam("@deleteId", ID);

            _dBManager.ExecuteNonQuery();
        }
    }
}
