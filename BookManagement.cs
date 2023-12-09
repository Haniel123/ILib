using DAO;
using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using static DAO.functionDAO;
using DevExpress.Utils.Win.Hook;
using DTO;
using System.Web.Services.Description;

namespace ILib
{
    public partial class BookManagement : Form
    {
        ELibEntities db = new ELibEntities();
        bookBUS BookBUS = new bookBUS();
        authorBUS AuthorBus = new authorBUS();
        bookTypeBUS BookTypeBus = new bookTypeBUS();
        functionDAO func = new functionDAO();

        public BookManagement()
        {
            InitializeComponent();
            dgvBook.AutoGenerateColumns = false;
        }


        private void BookManagement_Load(object sender, EventArgs e)
        {
            func.TextBoxControl(this, true);
            var books = BookBUS.getBookBUS();
            dgvBook.DataSource = books;

            dtpkPublished.Format = DateTimePickerFormat.Custom;
            dtpkPublished.CustomFormat = "MM-yyyy";        
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name;
            int authorId;
            int typeId;
            int price;
            int quantity;
            if (func.IsControlValid(txtName, "Tên sách"))
            {
                name = txtName.Text;
            } else
            {
                return;
            }
            if (func.IsControlValid(cbbAuthor, "Tác giả"))
            {
                authorId = int.Parse(cbbAuthor.SelectedValue.ToString());
            }
            else
            {
                return;
            }
            if (func.IsControlValid(cbbType, "Loại"))
            {
                typeId = int.Parse(cbbType.SelectedValue.ToString());
            }
            else
            {
                return;
            }
            if (func.IsControlValid(numPrice, "Giá"))
            {
                price = (int)numPrice.Value;
            }
            else
            {
                return;
            }
            if (func.IsControlValid(numQuantity, "Số lượng"))
            {
                quantity = (int)numQuantity.Value;
            }
            else
            {
                return;
            }
            DateTime published = dtpkPublished.Value;

            DAO.Book book = new DAO.Book
            {
                Name = name,
                IdAuthor = authorId,
                IdType = typeId,
                Publisher = published.ToString("MM-yyyy"),
                Price = price,
                Amount = quantity,
                Status = 1
            };

            if (BookBUS.insertBookBUS(book))
            {
                func.NotifyMessageBox("Thêm thành công !!!");
                var result = BookBUS.getBookBUS();
                dgvBook.DataSource = result;
                func.TextBoxControl(this, true);
            }
            else
            {
                func.NotifyMessageBox("Thêm thất bại  !!!");
            }
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            var id = int.Parse(txtID.Text);
            DAO.Book book = new DAO.Book();
            book.id = id;
            if (func.ConfirmMessageBox("Bạn có chắc chắn muốn xóa dữ liệu này?"))
            {
                if (BookBUS.deleteBookBUS(id, book))
                {
                    func.NotifyMessageBox("Xoá thành công !!!");
                    var result = BookBUS.getBookBUS();
                    dgvBook.DataSource = result;
                    txtName.Clear();
                    txtID.Clear();
                    numPrice.Value = 0;
                    numQuantity.Value = 0;
                    func.ButtonControl(this);
                    func.TextBoxControl(this, true);
                }
                else
                {
                    func.NotifyMessageBox("Xoá thất bại !!!");
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);
            string name = txtName.Text;
            int authorId;
            int typeId;
            int price;
            int quantity;
            if (func.IsControlValid(txtName, "Tên sách"))
            {
                name = txtName.Text;
            }
            else
            {
                return;
            }
            if (func.IsControlValid(cbbAuthor, "Tác giả"))
            {
                authorId = int.Parse(cbbAuthor.SelectedValue.ToString());
            }
            else
            {
                return;
            }
            if (func.IsControlValid(cbbType, "Loại"))
            {
                typeId = int.Parse(cbbType.SelectedValue.ToString());
            }
            else
            {
                return;
            }
            if (func.IsControlValid(numPrice, "Giá"))
            {
                price = (int)numPrice.Value;
            }
            else
            {
                return;
            }
            if (func.IsControlValid(numQuantity, "Số lượng"))
            {
                quantity = (int)numQuantity.Value;
            }
            else
            {
                return;
            }
            DateTime published = dtpkPublished.Value;

            DAO.Book book = new DAO.Book
            {
                Name = name,
                IdAuthor = authorId,
                IdType = typeId,
                Publisher = published.ToString("MM-yyyy"),
                Price = price,
                Amount = quantity,
                Status = 1
            };
            if (BookBUS.updateBookBUS(id, book))
            {
                func.NotifyMessageBox("Sửa thành công !!!");
                var result = BookBUS.getBookBUS();
                dgvBook.DataSource = result;
                func.TextBoxControl(this, true);
            }
            else
            {
                func.NotifyMessageBox("Sửa thất bại  !!!");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cbbAuthor_Click(object sender, EventArgs e)
        {
            // Load author
            var author = AuthorBus.getAuthorB();
            cbbAuthor.DataSource = author;
            cbbAuthor.DisplayMember = "Name";
            cbbAuthor.ValueMember = "Id";
        }

        private void ccbType_Click(object sender, EventArgs e)
        {
            // Load type
            var type = BookTypeBus.getBookTypesBUS();
            cbbType.DataSource = type;
            cbbType.DisplayMember = "Name";
            cbbType.ValueMember = "Id";
        }

        private void cbbStatus_Click(object sender, EventArgs e)
        {
            // Load status
            functionDAO.LoadStatuses(cbbStatus, 1);
        }

        private void dgvBook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cbbStatus.Enabled = false;
            // Load authors into ComboBox
            var author = AuthorBus.getAuthorB();
            cbbAuthor.DataSource = author;
            cbbAuthor.DisplayMember = "Name";
            cbbAuthor.ValueMember = "Id";

            // Load types into ComboBox
            var type = BookTypeBus.getBookTypesBUS();
            cbbType.DataSource = type;
            cbbType.DisplayMember = "Name";
            cbbType.ValueMember = "Id";

            DataGridView dataGridView = (DataGridView)sender;
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView.Rows.Count)
            {
                // Access the selected date and time
                string id = dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                string name = dataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                string authorId = dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                string typeId = dataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                string date = dataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
                string price = dataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
                string quantity = dataGridView.Rows[e.RowIndex].Cells[6].Value.ToString();
                string status = dataGridView.Rows[e.RowIndex].Cells[7].Value.ToString();

                // Use the values as needed
                txtID.Text = id;
                txtName.Text = name;
                cbbAuthor.SelectedValue = int.Parse(authorId);
                cbbType.SelectedValue = int.Parse(typeId);
                dtpkPublished.Text = date;
                numPrice.Value = int.Parse(price);
                numQuantity.Value = int.Parse(quantity);
                int statusNum = int.Parse(status);
                functionDAO.LoadStatuses(cbbStatus, statusNum);

                func.ButtonControl(this, true);
                func.TextBoxControl(grpBox);
            }
        }
    }
}
