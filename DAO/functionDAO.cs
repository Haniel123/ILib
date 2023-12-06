using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace DAO
{

    public class functionDAO
    {
        public ELibEntities db = new ELibEntities();
        public bool ValidateUserName(string username)
        {
            return true;
        }

        public bool ValidateTextBox(System.Windows.Forms.TextBox textBox)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                WarningMessageBox("Vui lòng không để trống !!!");
                textBox.Focus();
                return true;
            }
            return false;
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


        public bool checkEmpty(string value ) {

            if (value == "" || string.IsNullOrEmpty(value))
            {
                return false;

            }
            else
            {
                return true;
            }
            
        
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

        public string LoadPositionName(string id)
        {
            int id2 = int.Parse(id);
            var position = db.UserTypes.FirstOrDefault(p => p.id.Equals(id2));
            if (position != null)
            {
                return position.Username.ToString();
            }
            else
            {
                return "Chưa xác định !!!";
            }
        }

        public string LoadStatus(string status)
        {
            int status2 = int.Parse(status); 
            switch (status2)
            {
                case 1: return "Hoạt động";
                case 0: return "Đã xoá";
                default: return "Hoạt động";
            }
        }


        public bool CheckUserName(string username)
        {

            var userCheck = db.Userts.FirstOrDefault(p => p.Username.Equals(username) && p.Status.Equals(1));
            if (userCheck != null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void ButtonControl(Control control, bool action = false)
        {
            foreach (var button in control.Controls.OfType<Button>())
                if (button.Name == "btnDelete" || button.Name == "btnUpdate")
                {
                    button.Enabled = action;
                }
        }

        public void TextBoxControl(Control control, bool action = false)
        {
            foreach (var txt in control.Controls.OfType<TextBox>())
            {
                Debug.WriteLine($"Current ReadOnly Value: {txt.ReadOnly}");

                if (txt.ReadOnly)
                {
                    txt.ReadOnly = action;
                    Debug.WriteLine($"Setting ReadOnly to: {action}");
                }
            }
        }

        public bool ConfirmMessageBox(string message)
        {
            if (MessageBox.Show(message, "ILib", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                return true;
            else return false;
        }

        public bool WarningMessageBox(string message)
        {
            return MessageBox.Show(message, "ILib", MessageBoxButtons.OK, MessageBoxIcon.Warning) == DialogResult.OK;
        }

        public bool NotifyMessageBox(string message)
        {
            return MessageBox.Show(message, "ILib", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK;
        }
    }
}
