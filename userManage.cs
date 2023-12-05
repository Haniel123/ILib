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
using BUS;
using DAO;
namespace ILib
{
    public partial class userManage : Form
    {
        userBUS bus = new userBUS();

        functionDAO func = new functionDAO();


        public userManage()
        {
            InitializeComponent();
            dgvUser.AutoGenerateColumns = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;
            int row = e.RowIndex;
            if (dgvUser.CurrentRow != null)
            {
                int numberOfCells = dgvUser.CurrentRow.Cells.Count;
                for (int i = 1; i < numberOfCells; i++)
                {
                    if (dgvUser.Rows[row].Cells[i].Value == null)
                    {
                        MessageBox.Show("Có dữ liệu rỗng !");
                        return;
                    }
                }
            }

            txtIdUser.Text = dataGridView.Rows[row].Cells[0].Value.ToString();
            txtFullname.Text = dataGridView.Rows[row].Cells[1].Value.ToString();
            txtPhoneUser.Text = dataGridView.Rows[row].Cells[2].Value.ToString();
            txtUsername.Text = dataGridView.Rows[row].Cells[3].Value.ToString();
            txtAddressUser.Text = dataGridView.Rows[row].Cells[4].Value.ToString();
            cbbPositionUser.Text = func.LoadPositionName(dataGridView.Rows[row].Cells[5].Value.ToString());
        }

        private void userManage_Load_1(object sender, EventArgs e)
        {
            var resultUser = bus.getUserB();
            dgvUser.DataSource = resultUser;
            //Load user type
            var resultUserType = bus.getUserTypeB();
            cbbPositionUser.DataSource = resultUserType;
            cbbPositionUser.DisplayMember = "Username";
            cbbPositionUser.ValueMember = "id";
        }

        private void btnAddUser_Click(object sender, EventArgs e)
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
                return;
            }

            if (!func.CheckUserName(userName))
            {
                MessageBox.Show("Tên người dùng đã tồn tại!!!");
                return;
            }


            if (userPassword != userPasswordRepeat)
            {
                MessageBox.Show("Mật khẩu nhập lại không khớp !!!");
                return;
            }
            if (userName == "" || userPassword == "" || userFullName == "" || userAddress == "")
            {
                MessageBox.Show("Không chừa trống dữ liệu !!!");
                return;
            }
            DAO.Usert user = new DAO.Usert();
            user.Username = userName;
            user.Password = userPassword;
            user.Fullname = userFullName;
            user.Phone = int.Parse(userPhone);
            user.Address = userAddress;
            user.IdType = userType;
            user.Status = 1;
            bus.insertUserB(user);
            var resultUser = bus.getUserB();
            dgvUser.DataSource = resultUser;
            MessageBox.Show("Thêm tài khoản thành công");
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                    ((TextBox)c).Clear();
            }
        }

        private void btnEditUser_Click_1(object sender, EventArgs e)
        {
            var userName = txtUsername.Text;
            var userFullName = txtFullname.Text;
            var userId = txtIdUser.Text;
            string userPhone = txtPhoneUser.Text;
            var userAddress = txtAddressUser.Text;
            var userPassword = func.ConvertMD5(txtPasswordUser.Text);
            var userPasswordRepeat = func.ConvertMD5(txtPasswordRepeatUset.Text);
            int userType = int.Parse(cbbPositionUser.SelectedValue.ToString());
            if (!func.ValidatePhoneNumber(userPhone))
            {
                MessageBox.Show("Số điện thoại không hợp lệ !!!");
                return;
            }

            if (userPassword != userPasswordRepeat)
            {
                MessageBox.Show("Mật khẩu nhập lại không khớp !!!");
                return;
            }
            if (userName == "" || userPassword == "" || userFullName == "" || userAddress == "")
            {
                MessageBox.Show("Không chừa trống dữ liệu !!!");
                return;
            }
            DAO.Usert user = new DAO.Usert();
            user.Username = userName;
            if (userPassword != "")
            {
                user.Password = userPassword;
            }

            user.Fullname = userFullName;
            user.Address = userAddress;
            user.Phone = int.Parse(userPhone);
            user.IdType = userType;
            user.Id = int.Parse(userId);
            user.Status = 1;
            if (bus.updateUserB(userId, user))
            {
                MessageBox.Show("Sửa tài khoản thành công !!!");
                var resultUser = bus.getUserB();
                dgvUser.DataSource = resultUser;
            }
            else
            {
                MessageBox.Show("Sửa tài khoản thất bại !!!");
            }


        }

    

        private void btnDeleteUser_Click_1(object sender, EventArgs e)
        {

            var userId = txtIdUser.Text;
            DAO.Usert user = new DAO.Usert();
            user.Id = int.Parse(userId);
            if (bus.deleteUserB(userId, user))
            {
                MessageBox.Show("Xoá tài khoản thành công !!!");
                var resultUser = bus.getUserB();
                dgvUser.DataSource = resultUser;
            }
            else
            {
                MessageBox.Show("Xoá tài khoản thất bại !!!");
            }

        }

        private void GroupBox_Enter(object sender, EventArgs e)
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
