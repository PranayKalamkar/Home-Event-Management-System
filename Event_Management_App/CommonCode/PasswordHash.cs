using System.Security.Cryptography;
using System.Text;

namespace Event_Management_App.CommonCode
{
    public class PasswordHash
    {
        public static string ComputeMD5(string s)
        {
            StringBuilder sb = new StringBuilder();

            using(MD5  md5 = MD5.Create())
            {
                byte[] hashValue = md5.ComputeHash(Encoding.ASCII.GetBytes(s));

                foreach(byte b in hashValue)
                {
                    sb.Append($"{b:X2}");
                }
            }
            return sb.ToString();
        }

        public static bool DecryptMD5(string password, string s)
        {
            string existingPassword = ComputeMD5(s);
            return existingPassword == password;
        }
    }
}
