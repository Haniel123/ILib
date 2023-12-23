using BUS;
using DAO;
using DevExpress.Xpo.DB;
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
    public partial class BorrowTicketManagement : Form
    {
        borrowBUS bus = new borrowBUS();
        functionDAO func = new functionDAO();

        public BorrowTicketManagement()
        {

            InitializeComponent();
            dgvBorrow.AutoGenerateColumns = false;
            dgvBook.AutoGenerateColumns = false;
            dtpStart.Format = DateTimePickerFormat.Custom;
            dtpStart.CustomFormat = "dd/MM/yyyy";

            dtpEnd.Format = DateTimePickerFormat.Custom;
            dtpEnd.CustomFormat = "dd/MM/yyyy";

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {

            var borrowCode = txtCode.Text;
            int idBook = int.Parse(cbbBook.SelectedValue.ToString());
            int idReader = int.Parse(cbbReader.SelectedValue.ToString());
            DateTime timeStart = dtpStart.Value;
            DateTime timeEnd = dtpEnd.Value;
            if (!func.CheckReader(idReader))
            {
                MessageBox.Show("Tên bạn đọc đã tồn tại!!!");
                return;
            }
            if (func.checkEmpty(borrowCode))
            {
                MessageBox.Show("Không chừa trống dữ liệu !!!");
                return;
            }

            BorrowTicket borrow = new BorrowTicket();
            //Generate Code
            string day = timeStart.Day.ToString();
            string month = timeEnd.Month.ToString();
            string year = timeEnd.Year.ToString().Substring(2);
            string finalCode = "BT"+idBook+day+month+year;  
            borrow.Code = finalCode;
            borrow.IdReader = idReader;
            borrow.IdBook = idBook;
            borrow.DateStart = timeStart;
            borrow.DateEnd = timeEnd;
            borrow.Status = 1;
            bus.insertBorrowB(borrow);
            var resultUser = bus.getBorrowB();
            dgvBorrow.DataSource = resultUser;
            MessageBox.Show("Thêm vé mượn thành công");
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                    ((TextBox)c).Clear();
            }
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            var borrowTicketId = txtId.Text;
            DAO.BorrowTicket user = new DAO.BorrowTicket();
            user.Id = int.Parse(borrowTicketId);
            if (MessageBox.Show("Bạn có chắc là muốn xoá tài khoản này không?", "ILib", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (bus.deleteBorrowB(borrowTicketId, user))
                {
                    MessageBox.Show("Xoá vé mượn thành công !!!");
                    var resultUser = bus.getBorrowB();
                    dgvBorrow.DataSource = resultUser;
                }
                else
                {
                    MessageBox.Show("Xoá tài khoản thất bại !!!");
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string borrowId = txtId.Text;

            int reader = int.Parse(cbbReader.SelectedValue.ToString());
            int book = int.Parse(cbbBook.SelectedValue.ToString());
            var dateStart = dtpStart.Value;
            var dateEnd = dtpEnd.Value;
     
            DAO.BorrowTicket borrowTicket = new DAO.BorrowTicket();
            borrowTicket.IdReader = reader;
            borrowTicket.IdBook = book;
           

            borrowTicket.DateStart = dateStart;
            borrowTicket.DateEnd = dateEnd;
            if (bus.deleteBorrowB(borrowId, borrowTicket))
            {
                MessageBox.Show("Sửa vé mượn thành công !!!");
                var resultUser = bus.getBorrowB();
                dgvBorrow.DataSource = resultUser;
            }
            else
            {
                MessageBox.Show("Sửa vé mượn thất bại !!!");
            }
        }

        private void dgvBorrow_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridView dataGridView = (DataGridView)sender;
            int row = e.RowIndex;
            if (row >= 0)
            {
                if (dgvBorrow.CurrentRow != null)
                {
                    int numberOfCells = dgvBorrow.CurrentRow.Cells.Count;
                    for (int i = 1; i < numberOfCells; i++)
                    {
                        if (dgvBorrow.Rows[row].Cells[i].Value == null)
                        {
                            MessageBox.Show("Có dữ liệu rỗng !");
                            return;
                        }
                    }
                }
                txtId.Text = dataGridView.Rows[row].Cells[0].Value.ToString();
                txtCode.Text = dataGridView.Rows[row].Cells[1].Value.ToString();
                cbbReader.Text = dataGridView.Rows[row].Cells[2].Value.ToString();
                var listBookReader = bus.getBorrowBookB(int.Parse(dataGridView.Rows[row].Cells[2].Value.ToString()));
                txtStatus.Text = func.LoadStatusBorrow(dataGridView.Rows[row].Cells[6].Value.ToString());
                dgvBook.DataSource = listBookReader;
                dgvBook.Refresh();

                string dateString = dataGridView.Rows[row].Cells[4].Value.ToString();
                DateTime parsedDate;

                if (DateTime.TryParse(dateString, out parsedDate))
                {

                    dtpStart.Value = parsedDate;
                }
                else
                {

                    MessageBox.Show("Invalid date format. Please provide a valid date.");
                }
                dtpEnd.Value = Convert.ToDateTime(dataGridView.Rows[row].Cells[5].Value);

            }
        }


        private void BorrowTicketManagement_Load(object sender, EventArgs e)
        {

            func.LoadStatusBorrow();
            var resultBorrow = bus.getBorrowB();
            dgvBorrow.DataSource = resultBorrow;

            var resultBook = bus.getBookB();
            cbbBook.DataSource = resultBook;
            cbbBook.DisplayMember = "Name";
            cbbBook.ValueMember = "id";

            var resultReader = bus.getReaderB();
            cbbReader.DataSource = resultReader;
            cbbReader.DisplayMember = "Fullname";
            cbbReader.ValueMember = "Id";
        }

        private void dgvBook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row >= 0)
            {
                if (dgvBook.CurrentRow != null)
                {
                    int numberOfCells = dgvBook.CurrentRow.Cells.Count;
                    for (int i = 1; i < numberOfCells; i++)
                    {
                        if (dgvBook.Rows[row].Cells[i].Value == null)
                        {
                            MessageBox.Show("Có dữ liệu rỗng !");
                            return;
                        }
                    }
                }
                txtIdBookBorrow.Text = dgvBook.Rows[row].Cells[0].Value.ToString();
            }
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            int idBook = int.Parse(cbbBook.SelectedValue.ToString());
            int idReader = int.Parse(cbbReader.SelectedValue.ToString());
         
            if (func.checkEmpty(idBook.ToString()) || func.checkEmpty(idReader.ToString()))
            {
                MessageBox.Show("Không chừa trống dữ liệu !!!");
                return;
            }
            BorrowBook borrowBook = new BorrowBook();
            borrowBook.Status = 1;
            borrowBook.IdBook = idBook;
            borrowBook.IdReader = idReader;
            bus.insertBorrowBookB(borrowBook);
            var resultUser = bus.getBorrowBookB(idReader);
            dgvBook.DataSource = resultUser;
            MessageBox.Show("Thêm sách mượn thành công");
        }

        private void dgvBook_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 1 && e.Value != null)
            {
                int id = Convert.ToInt32(e.Value);
                string name = func.LoadBookName(id.ToString());
                e.Value = name;
            }
        }

        private void dgvBorrow_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 2 && e.Value != null)
            {
                int id = Convert.ToInt32(e.Value);
                string name = func.LoadReader(id.ToString());
                e.Value = name;
            }
            if (e.ColumnIndex == 6 && e.Value != null)
            {
                int id = Convert.ToInt32(e.Value);
                string name = func.LoadStatusBorrow(id.ToString());
                e.Value = name;
            }
        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            var borrowBookId = txtIdBookBorrow.Text;
            int reader = int.Parse(cbbReader.SelectedValue.ToString());
            DAO.BorrowBook user = new DAO.BorrowBook();
            user.Id = int.Parse(borrowBookId);
            if (MessageBox.Show("Bạn có chắc là muốn xoá sách này không?", "ILib", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (bus.deleteBorrowBookB(borrowBookId, user))
                {
                    MessageBox.Show("Xoá sách thành công !!!");
                    var resultUser = bus.getBorrowBookB(reader);
                    dgvBook.DataSource = resultUser;
                }
                else
                { 
                    MessageBox.Show("Xoá sách thất bại !!!");
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgvBook_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvBorrow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
