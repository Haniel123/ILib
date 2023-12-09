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
            if (func.checkEmpty(borrowCode))
            {
                MessageBox.Show("Không chừa trống dữ liệu !!!");
                return;
            }

            BorrowTicket borrow = new BorrowTicket();
            borrow.Code = borrowCode;
            borrow.IdReader = idReader;
            borrow.IdBook= idBook;
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

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

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

        private void dgvBorrow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BorrowTicketManagement_Load(object sender, EventArgs e)
        {


            var resultBorrow = bus.getBorrowB();
            dgvBorrow.DataSource = resultBorrow;

            var resultBook = bus.getBookB();
            cbbBook.DataSource = resultBook;
            cbbBook.DisplayMember = "Name";
            cbbBook.ValueMember = "id";

            var resultReader = bus.getReaderB();
            cbbReader.DataSource = resultBook;
            cbbReader.DisplayMember = "Fullname";
            cbbReader.ValueMember = "Id";
        }
    }
}
