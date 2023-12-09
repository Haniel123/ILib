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
            string name = txtName.Text;
            DAO.BookType booktype = new DAO.BookType();
            booktype.Name = name;
            booktype.Status = 1;
            if (func.ValidateTextBox(txtName))
                return;
            var result = bus.insertBookTypeBUS(booktype);
            txtName.Text = result.ToString();
            var result2 = bus.getBookTypesBUS();
            dgvBookType.DataSource = result2;

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            var id = txtID.Text;
            StatusItem selectedStatus = (StatusItem)cbbStatus.SelectedItem;
            int status = selectedStatus.Id;

            if (func.ValidateTextBox(txtName))
                return;
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
