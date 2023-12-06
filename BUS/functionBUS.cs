using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using DAO;
namespace BUS
{
    public class functionBUS
    {
        public ELibEntities db = new ELibEntities();
        public bool ValidateUserName(string username)
        {
            return true;
        }
        public bool ValidatePhoneNumber(string phoneNumber)
        {

            if (phoneNumber.Length != 10)
            {
                return false;
            }
            for (int i = 0; i < phoneNumber.Length; i++)
            {
                if (!Char.IsDigit(phoneNumber[i]))
                {
                    return false;
                }
            }
            return true;
        }

        public string ConvertMD5(string input)
        {
            using (var md5 = MD5.Create())
            {
                var bytes = Encoding.UTF8.GetBytes(input);
                var hash = md5.ComputeHash(bytes);
                return BitConverter.ToString(hash).Replace("-", string.Empty);
            }
        }
    }




    public class HardCodeHelper
    {
        // Tạo một biến để lưu trữ các hard code
        private static Dictionary<string, string> hardCodes = new Dictionary<string, string>();


        // Hàm để thêm một hard code
        public static void Add(string key, string value)
        {
            hardCodes.Add(key, value);
        }

        // Hàm để lấy giá trị của một hard code
        public static string Get(string key)
        {
            return hardCodes[key];
        }

        // Hàm để thay thế các hard code trong một chuỗi
        public static string Replace(string text)
        {
            // Tạo một biến để lưu trữ kết quả
            string result = text;

            // Duyệt qua các hard code
            foreach (var pair in hardCodes)
            {
                // Thay thế các hard code trong chuỗi
                result = result.Replace(pair.Key, pair.Value);
            }

            return result;
        }
    }
}
