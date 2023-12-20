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
using static DAO.functionDAO;
using static DevExpress.Utils.Filtering.ExcelFilterOptions;

namespace ILib
{
    public partial class TypeofBookManagement : Form
    {
        bookTypeBUS bus = new bookTypeBUS();
        functionDAO func = new functionDAO();

        public TypeofBookManagement()
        {
            InitializeComponent();
            dgvBookType.AutoGenerateColumns = false;
        }

        private void typeOfBookManagement_Load(object sender, EventArgs e)
        {
            func.TextBoxControl(this, true);
            var result = bus.getBookTypesBUS();
            dgvBookType.DataSource = result;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name;
            if (func.IsControlValid(txtName, "Tên loại"))
            {
                name = txtName.Text;
                if (bus.isNameExists(name))
                {
                    func.WarningMessageBox("Tên loại đã tồn tại. Vui lòng chọn tên loại khác.");
                    return;
                }
            }
            else
            {
                return;
            }
            DAO.BookType booktype = new DAO.BookType();
            booktype.Name = name;
            booktype.Status = 1;
            
            var result = bus.insertBookTypeBUS(booktype);
            txtName.Text = result.ToString();
            var result2 = bus.getBookTypesBUS();
            dgvBookType.DataSource = result2;

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string name;
            if (func.IsControlValid(txtName, "Loại sách"))
            {
                name = txtName.Text;
            }
            else
            {
                return;
            }
            var id = txtID.Text;
            StatusItem selectedStatus = (StatusItem)cbbStatus.SelectedItem;
            int status = selectedStatus.Id;

            DAO.BookType booktype = new DAO.BookType();
            booktype.Name = name;
            booktype.id = int.Parse(id);
            booktype.Status = status;
            if (bus.updateBookTypeBUS(id, booktype))
            {
                func.NotifyMessageBox("Sửa thành công !!!");
                var result = bus.getBookTypesBUS();
                dgvBookType.DataSource = result;                
                func.TextBoxControl(this, true);
            }
            else
            {
                func.NotifyMessageBox("Sửa thất bại  !!!");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var id = txtID.Text;
            DAO.BookType booktype = new DAO.BookType();
            booktype.id = int.Parse(id);
            if(func.ConfirmMessageBox("Bạn có chắc chắn muốn xóa dữ liệu này?"))
            {
                if (bus.deleteBookTypeBUS(id, booktype))
                {
                    func.NotifyMessageBox("Xoá thành công !!!");
                    var result = bus.getBookTypesBUS();
                    dgvBookType.DataSource = result;
                    txtName.Clear();
                    txtID.Clear();
                    func.ButtonControl(this);
                    func.TextBoxControl(this, true);
                }
                else
                {
                    func.NotifyMessageBox("Xoá thất bại !!!");
                }
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string name;
            if (func.IsControlValid(txtName, "Vui lòng nhập vào 'Tên loại' để tìm kiếm."))
            {
                name = txtName.Text;
            }
            else
            {
                return;
            }


            var result = bus.searchBUS(name);

            if (result != null && result.Count > 0)
            {
                dgvBookType.DataSource = result;
                func.NotifyMessageBox("Tìm kiếm thành công !!!");
            }
            else
            {
                dgvBookType.DataSource = null;
                func.NotifyMessageBox("Không tìm thấy kết quả !!!");
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            func.ClearAllControls(this);
            dgvBookType.DataSource = null;
            dgvBookType.DataSource = bus.getBookTypesBUS();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cbbStatus_Click(object sender, EventArgs e)
        {
            // Load status
            functionDAO.LoadStatuses(cbbStatus, 1);
        }

        private void dgvBookType_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView.Rows.Count)
            {
                // Access the selected date and time
                string id = dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                string name = dataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                string status = dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();

                // Use the values as needed
                txtID.Text = id;
                txtName.Text = name;
                int statusInt = Convert.ToInt32(status);
                functionDAO.LoadStatuses(cbbStatus, statusInt);

                func.ButtonControl(this, true);
                func.TextBoxControl(GroupBox);
            }
        }      
    }
}
