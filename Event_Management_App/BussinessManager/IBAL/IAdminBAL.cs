using Event_Management_App.Models;

namespace Event_Management_App.BussinessManager.IBAL
{
    public interface IAdminBAL
    {
        public List<AdminModel> GetAdminList();
        public string AddAdmin(AdminModel sign);
        public AdminModel PopulateAdminData(int ID);
        public string UpdateAdminData(AdminModel adminmodel, int ID);
        public void DeleteAdminData(int ID);
    }
}
