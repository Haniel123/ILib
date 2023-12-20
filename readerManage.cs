using BUS;
using DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ILib
{
    public partial class readerManage : Form
    {
        readerBUS bus = new readerBUS();
        functionDAO func = new functionDAO();
        public readerManage()
           
        {
            InitializeComponent();
            dgvReader.AutoGenerateColumns = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
      
            var userFullName = txtFullname.Text;
            string userPhone = txtPhoneUser.Text;
            var userAddress = txtAddressUser.Text;
   

            if (!func.ValidatePhoneNumber(userPhone))
            {
                func.WarningMessageBox("Số điện thoại không hợp lệ !!!");
                return;
            }

     
            if (userFullName == "" || userAddress == "")
            {
                func.WarningMessageBox("Không chừa trống dữ liệu !!!");
                return;
            }
            DAO.Reader reader = new DAO.Reader();

            reader.Fullname = userFullName;
            reader.Phone = int.Parse(userPhone);
            reader.Address = userAddress;
            reader.Status = 1;
            reader.IdType = 1;
            bus.insertReaderB(reader);
            var resultUser = bus.getReaderB();
            dgvReader.DataSource = resultUser;
            func.NotifyMessageBox("Thêm bạn đọc thành công !!!");
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                    ((TextBox)c).Clear();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var userFullName = txtFullname.Text;
            var userId = txtId.Text;
            string userPhone = txtPhoneUser.Text;
            var userAddress = txtAddressUser.Text;
            if (func.checkEmpty(userFullName) || func.checkEmpty(userAddress))
            {
                func.WarningMessageBox("Không chừa trống dữ liệu !!!");
                return;
            }

            if (!func.ValidatePhoneNumber(userPhone))
            {
                func.WarningMessageBox("Số điện thoại không hợp lệ !!!");
                return;
            }

            DAO.Reader user = new DAO.Reader();
            user.Fullname = userFullName;
            user.Phone = int.Parse(userPhone);
            user.Address = userAddress;
            user.Id = int.Parse(userId);
            user.Phone = int.Parse(userPhone);
            user.Status = 1;
            if (bus.updateReaderB(userId, user))
            {
                func.NotifyMessageBox("Sửa tài khoản thành công !!!");
                var resultUser = bus.getReaderB();
                dgvReader.DataSource = resultUser;
            }
            else
            {
                func.NotifyMessageBox("Sửa tài khoản thành công !!!");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var userId = txtId.Text;
            DAO.Reader user = new DAO.Reader();
            user.Id = int.Parse(userId);

            if (MessageBox.Show("Bạn có chắc là muốn xoá tài khoản này không?", "ILib", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (bus.deleteReaderB(userId, user))
                {
                    MessageBox.Show("Xoá bạn đọc thành công !!!");
                    var resultUser = bus.getReaderB();
                    dgvReader.DataSource = resultUser;
                }
                else
                {
                    MessageBox.Show("Xoá bạn đọc thất bại !!!");
                }
            }         
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string name;
            if (func.IsControlValid(txtFullname, "Vui lòng nhập vào 'Tên' để tìm kiếm,"))
            {
                name = txtFullname.Text;
            }
            else
            {
                return;
            }


            var result = bus.searchBUS(name);

            if (result != null && result.Count > 0)
            {
                dgvReader.DataSource = result;
                func.NotifyMessageBox("Tìm kiếm thành công !!!");
            }
            else
            {
                dgvReader.DataSource = null;
                func.NotifyMessageBox("Không tìm thấy kết quả !!!");
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            func.ClearAllControls(this);
            dgvReader.DataSource = null;
            dgvReader.DataSource = bus.getReaderB();
        }

        private void dgvReader_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;
            int row = e.RowIndex;
            if (row >= 0)
            {
                if (dgvReader.CurrentRow != null)
                {
                    int numberOfCells = dgvReader.CurrentRow.Cells.Count;
                    for (int i = 1; i < numberOfCells; i++)
                    {
                        if (dgvReader.Rows[row].Cells[i].Value == null)
                        {
                            MessageBox.Show("Có dữ liệu rỗng !");
                            return;
                        }
                    }
                }


            txtId.Text = dataGridView.Rows[row].Cells[0].Value.ToString();
            txtFullname.Text = dataGridView.Rows[row].Cells[1].Value.ToString();
            txtAddressUser.Text = dataGridView.Rows[row].Cells[2].Value.ToString();
            txtPhoneUser.Text = dataGridView.Rows[row].Cells[3].Value.ToString();
            txtStatus.Text = func.LoadStatus(dataGridView.Rows[row].Cells[4].Value.ToString());
            }
        }

        private void readerManage_Load(object sender, EventArgs e)
        {
            var resultUser = bus.getReaderB();
            dgvReader.DataSource = resultUser;
            //Load user type
           // var resultUserType = bus.();
            //cbbPositionUser.DataSource = resultUserType;
            //cbbPositionUser.DisplayMember = "Username";
            //cbbPositionUser.ValueMember = "id";
        }
    }
}
