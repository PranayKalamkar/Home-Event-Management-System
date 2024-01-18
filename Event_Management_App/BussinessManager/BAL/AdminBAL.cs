using Event_Management_App.BussinessManager.IBAL;
using Event_Management_App.DataManager.DAL;
using Event_Management_App.DataManager.IDAL;
using Event_Management_App.Models;

namespace Event_Management_App.BussinessManager.BAL
{
    public class AdminBAL : IAdminBAL
    {
        IAdminDAL _IAdminDAL;

        public AdminBAL(IDBManager dBManager)
        {
            _IAdminDAL = new AdminDAL(dBManager);
        }

        public List<AdminModel> GetAdminList()
        {
            return _IAdminDAL.GetAdminList();
        }

        public string AddAdmin(AdminModel sign)
        {
            sign.Role = 1;

            bool emailExist = _IAdminDAL.CheckEmailExist(sign.Email, sign.Id);

            if (emailExist)
            {
                return "Exist";
            }

            _IAdminDAL.AddAdmin(sign);

            return "Success";
        }

        public AdminModel PopulateAdminData(int ID)
        {
            return _IAdminDAL.PopulateAdminData(ID);
        }

        public string UpdateAdminData(AdminModel adminmodel, int ID)
        {

            bool emailExist = _IAdminDAL.CheckEmailExist(adminmodel.Email, ID);

            if (emailExist)
            {
                return "Exist";
            }

            _IAdminDAL.UpdateAdminData(adminmodel, ID);

            return "Success";
        }

        public void DeleteAdminData(int ID)
        {
            _IAdminDAL.DeleteAdminData(ID);
        }
    }
}
