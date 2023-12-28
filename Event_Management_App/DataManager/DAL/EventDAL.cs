using Event_Management_App.CommonCode;
using Event_Management_App.DataManager.IDAL;
using Event_Management_App.Models;
using System.Data;

namespace Event_Management_App.DataManager.DAL
{
    public class EventDAL : IEventDAL
    {
        readonly IDBManager _dBManager;

        public EventDAL(IDBManager dbManager)
        {
            _dBManager = dbManager;
        }

        public List<SignUpModel> GetUserList()
        {
            List<SignUpModel> userList = new List<SignUpModel>();

            _dBManager.InitDbCommandText("select * from SignUp;");

            DataSet ds = _dBManager.ExecuteDataSet();

            foreach(DataRow item in ds.Tables[0].Rows)
            {
                SignUpModel model = new SignUpModel();

                model.Id = item["Id"].ConvertDBNullToInt();
                model.Username = item["Username"].ConvertDBNullToString();
                model.Email = item["Email"].ConvertDBNullToString();
                model.SPassword = item["SPassword"].ConvertDBNullToString();

                userList.Add(model);

            }

            return userList;

        }

        public SignUpModel AddUser(SignUpModel sign)
        {
            _dBManager.InitDbCommandText("Insert into SignUp(Username,Email,SPassword) values (@Username,@Email,@SPassword);");

            _dBManager.AddCMDParam("@Username", sign.Username);
            _dBManager.AddCMDParam("@Email", sign.Email);
            _dBManager.AddCMDParam("@SPassword", sign.SPassword);

            _dBManager.ExecuteNonQuery();

            return sign;
        }

        public string LoginUser(string email)
        {
            string existingPassword = null;
            
            _dBManager.InitDbCommandText("select SPassword from SignUp where Email=@Email;");

            _dBManager.AddCMDParam("@Email", email);


            DataSet ds = _dBManager.ExecuteDataSet();

            foreach(DataRow item in ds.Tables[0].Rows)
            { 
                existingPassword = item["SPassword"].ConvertDBNullToString();
            }

            return existingPassword;
        }
    }
}
