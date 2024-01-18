using Event_Management_App.Models;

namespace Event_Management_App.DataManager.IDAL
{
    public interface IAdminDAL
    {
        public List<AdminModel> GetAdminList();

        public AdminModel AddAdmin(AdminModel sign);

        public bool CheckEmailExist(string emailId, int Id);

        public AdminModel PopulateAdminData(int ID);

        public AdminModel UpdateAdminData(AdminModel adminmodel, int ID);

        public void DeleteAdminData(int ID);
    }
}
