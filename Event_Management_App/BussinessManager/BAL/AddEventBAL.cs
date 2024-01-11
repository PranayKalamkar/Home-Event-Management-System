using Event_Management_App.BussinessManager.IBAL;
using Event_Management_App.DataManager.DAL;
using Event_Management_App.DataManager.IDAL;
using Event_Management_App.Models;

namespace Event_Management_App.BussinessManager.BAL
{
    public class AddEventBAL : IAddEventBAL
    {
        IAddEventDAL _IAddEventDAL;

        public AddEventBAL(IDBManager dBManager)
        {
            _IAddEventDAL = new AddEventDAL(dBManager);
        }

        List<AddEventModel> IAddEventBAL.AddEventList()
        {
            return _IAddEventDAL.AddEventList();
        }

        public AddEventModel AddEvent(AddEventModel addeventmodel, IFormFile ImageFile)
        {
            addeventmodel.ImageFile = ImageFile;

            addeventmodel.ImagePath = UploadImage(addeventmodel.ImageFile);

            return _IAddEventDAL.AddEvent(addeventmodel);
        }

        public string UploadImage(IFormFile imageFile)
        {

            try
            {
                string uniqueFileName = null;

                if (imageFile != null)
                {
                    string uploadFolder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "addeventimages");

                    // Create the directory if it doesn't exist

                    Console.WriteLine(Directory.GetCurrentDirectory());

                    if (!Directory.Exists(uploadFolder))
                    {
                        Directory.CreateDirectory(uploadFolder);
                    }

                    uniqueFileName = Guid.NewGuid().ToString() + "_" + imageFile.FileName;
                    string filePath = Path.Combine(uploadFolder, uniqueFileName);

                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        imageFile.CopyTo(stream);
                    }

                }
                else
                {
                    Console.WriteLine("Image file path is null");
                }

                Console.WriteLine(uniqueFileName);

                return uniqueFileName;
            }
            catch (Exception ex)
            {
                return ex.StackTrace;
            }
        }
    }
}
