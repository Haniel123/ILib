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

        public bool IsControlValid(Control control, string controlName)
        {
            if (control is TextBox textBox)
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    WarningMessageBox($"{controlName} không được để trống !!!");
                    textBox.Focus();
                    return false;
                }
            }
            else if (control is ComboBox comboBox)
            {
                if (comboBox.SelectedItem == null)
                {
                    WarningMessageBox($"{controlName} không được để trống !!!");
                    comboBox.Focus();
                    return false;
                }
            }
            else if (control is NumericUpDown numericUpDown)
            { 
                if (numericUpDown.Value <= 0)
                {
                    WarningMessageBox($"{controlName} phải là một giá trị lớn hơn 0 !!!");
                    numericUpDown.Focus();
                    return false;
                }
            }

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


        public bool checkEmpty(string value ) {

            if (value == "" || !string.IsNullOrWhiteSpace(value))
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

        public string LoadReader(string id)
        {
            int id2 = int.Parse(id);
            var position = db.Readers.FirstOrDefault(p => p.Id.Equals(id2));
            if (position != null)
            {
                return position.Fullname.ToString();
            }
            else
            {
                return "Chưa xác định !!!";
            }
        }

        public string LoadAuthor(string id)
        {
            int id2 = int.Parse(id);
            var position = db.Authors.FirstOrDefault(p => p.Id.Equals(id2));
            if (position != null)
            {
                return position.Name.ToString();
            }
            else
            {
                return "Chưa xác định !!!";
            }
        }

        public string LoadType(string id)
        {
            int id2 = int.Parse(id);
            var position = db.BookTypes.FirstOrDefault(p => p.id.Equals(id2));
            if (position != null)
            {
                return position.Name.ToString();
            }
            else
            {
                return "Chưa xác định !!!";
            }
        }

        public string LoadBookName(string id)
        {
            int id2 = int.Parse(id);
            var position = db.Books.FirstOrDefault(p => p.id.Equals(id2));
            if (position != null)
            {
                return position.Name.ToString();
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

        public void LoadStatusBorrow()
        {
            DateTime currentDate = DateTime.Now;

            // Lấy danh sách các bản ghi có enddate lớn hơn hoặc bằng ngày hiện tại và status khác 2
            var recordsToUpdate = db.BorrowTickets.Where(e => e.DateEnd <= currentDate && e.Status != 2 && e.Status != 0).ToList();

            // Cập nhật trạng thái (status) của các bản ghi
            foreach (var record in recordsToUpdate)
            {
                record.Status = 2;
            }

            // Lưu thay đổi vào cơ sở dữ liệu
            db.SaveChanges(); ;

        }



        public string LoadStatusBorrow(string status)
        {
            int status2 = int.Parse(status);
            switch (status2)
            {
                case 1: return "Hoạt động";
                case 0: return "Đã xoá";
                case 2: return "Trễ hẹn";
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

        public bool CheckReader(int reader)
        {

            var userCheck = db.BorrowTickets.FirstOrDefault(p => p.IdReader.Equals(reader) && p.Status.Equals(1));
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

                if (txt.ReadOnly && txt.Name== "txtStatus")
                {
                    txt.ReadOnly = action;
                    Debug.WriteLine($"Setting ReadOnly to: {action}");
                }
            }
        }

        public void ClearAllControls(Control container)
        {
            foreach (Control control in container.Controls)
            {
                if (control.HasChildren)
                {
                    ClearAllControls(control); 
                }
                if (control is TextBox txt)
                {
                    txt.Clear();
                }
                else if (control is ComboBox cbb)
                {
                    cbb.SelectedIndex = -1;
                }
                else if (control is NumericUpDown num)
                {
                    num.Value = num.Minimum;
                }
                else if (control is DateTimePicker dtpk)
                {
                    if (dtpk.MinDate <= DateTime.Now && DateTime.Now <= dtpk.MaxDate)
                    {
                        dtpk.Value = DateTime.Now;
                    }
                    else
                    {
                        dtpk.Value = dtpk.MinDate;
                    }
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

        public static void LoadStatuses(ComboBox comboBox, int selectedValue)
        {
            // Clear existing items
            comboBox.Items.Clear();

            // Add default statuses
            comboBox.Items.Add(new StatusItem { Id = 0, Name = "Ẩn" });
            comboBox.Items.Add(new StatusItem { Id = 1, Name = "Hoạt động" });

            // Set display and value member properties
            comboBox.DisplayMember = "Name";
            comboBox.ValueMember = "Id";

            // Set default status
            int selectedIndex = comboBox.FindStringExact("Hoạt động"); // Assuming "Active" is the default status
            if (selectedIndex != -1)
            {
                comboBox.SelectedIndex = selectedIndex;
            }

            // Set the selected value if it exists
            if (comboBox.Items.Cast<StatusItem>().Any(item => item.Id == selectedValue))
            {
                comboBox.SelectedValue = selectedValue;
            }
        }

        public class StatusItem
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }
    }
}
