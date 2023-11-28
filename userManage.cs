using BUS;
using DevExpress.XtraEditors.ButtonPanel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ILib
{
    public partial class userManage : Form
    {
        userBUS bus = new userBUS();
        functionBUS func = new functionBUS();
        public userManage()
        {
            InitializeComponent();
            dgvUser.AutoGenerateColumns = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void userManage_Load(object sender, EventArgs e)
        {
            var resultUser = bus.getUserB();
            dgvUser.DataSource = resultUser;
            //Load user type
            var resultUserType = bus.getUserTypeB();
            cbbPositionUser.DataSource = resultUserType;
            cbbPositionUser.DisplayMember = "Username";
            cbbPositionUser.ValueMember = "id";
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
           
            var userName = txtUsername.Text;
            var userFullName = txtFullname.Text;
            string userPhone = txtPhoneUser.Text;
            var userAddress = txtAddressUser.Text;
            var userPassword = func.ConvertMD5(txtPasswordUser.Text);
            var userPasswordRepeat = func.ConvertMD5(txtPasswordRepeatUset.Text);
            int userType = int.Parse(cbbPositionUser.SelectedValue.ToString());

            if (!func.ValidatePhoneNumber(userPhone))
            {
                MessageBox.Show("Số điện thoại không hợp lệ !!!");
            }

            if (userPassword != userPasswordRepeat)
            {
                MessageBox.Show("Mật khẩu nhập lại không khớp !!!");
            }
            DAO.Usert user = new DAO.Usert();
            user.Username = userName;
            user.Password = userPassword;
            user.Fullname = userFullName;
            user.Address = userAddress;
            user.IdType = userType;
            user.Status = 1;
            bus.insertUserB(user);
            var resultUser = bus.getUserB();
            dgvUser.DataSource = resultUser;
        }
    }
}
