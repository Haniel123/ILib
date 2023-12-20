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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ILib
{
    public partial class authorManage : Form
    {
        authorBUS bus = new authorBUS();
        functionDAO func = new functionDAO();
        public authorManage()
        {
            InitializeComponent();
            dgvAuthor.AutoGenerateColumns = false;
        }

        private void authorManage_Load(object sender, EventArgs e)
        {
            func.TextBoxControl(this, true);
            var result = bus.getAuthorB();
            dgvAuthor.DataSource = result;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name;
            if (func.IsControlValid(txtName, "Tác giả"))
            {
                name = txtName.Text;
                if (bus.isNameExists(name))
                {
                    func.WarningMessageBox("Tác giả đã tồn tại. Vui lòng chọn tác giả khác.");
                    return;
                }
            }
            else
            {
                return;
            }
            DAO.Author author = new DAO.Author();
            author.Name = name;
            author.Status = 1;
          
            var result = bus.insertAuthorB(author);
            txtName.Text = result.ToString();
            var result2 = bus.getAuthorB();
            dgvAuthor.DataSource = result2;

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string authorName = txtName.Text;
            var authorId = txtId.Text;

            if (func.checkEmpty(Name))
            {
                MessageBox.Show("Không chừa trống dữ liệu !!!");
                return;
            }
            DAO.Author author = new DAO.Author();
            author.Name = authorName;
            author.Id = int.Parse(authorId);
            if (bus.updateAuthorB(authorId, author))
            {
                func.NotifyMessageBox("Sửa thành công !!!");
                var resultUser = bus.getAuthorB();
                dgvAuthor.DataSource = resultUser;
                func.TextBoxControl(this, true);
            }
            else
            {
                func.NotifyMessageBox("Sửa thất bại  !!!");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var id = txtId.Text;
            DAO.Author author = new DAO.Author();
            author.Id = int.Parse(id);
            if (func.ConfirmMessageBox("Bạn có chắc chắn muốn xóa dữ liệu này?"))
            {
                if (bus.deleteAuthorB(id, author))
                {
                    func.NotifyMessageBox("Xoá thành công !!!");
                    var result = bus.getAuthorB();
                    dgvAuthor.DataSource = result;
                    txtName.Clear();
                    txtId.Clear();
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
            if (func.IsControlValid(txtName, "Vui lòng nhập vào 'Tác giả' để tìm kiếm."))
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
                dgvAuthor.DataSource = result;
                func.NotifyMessageBox("Tìm kiếm thành công !!!");
            }
            else
            {
                dgvAuthor.DataSource = null;
                func.NotifyMessageBox("Không tìm thấy kết quả !!!");
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            func.ClearAllControls(this);
            dgvAuthor.DataSource = null;
            dgvAuthor.DataSource = bus.getAuthorB();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvAuthor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;
            int row = e.RowIndex;
            if (row >= 0)
            {
                if (dgvAuthor.CurrentRow != null)
                {
                    int numberOfCells = dgvAuthor.CurrentRow.Cells.Count;
                    for (int i = 1; i < numberOfCells; i++)
                    {
                        if (dgvAuthor.Rows[row].Cells[i].Value == null)
                        {
                            MessageBox.Show("Có dữ liệu rỗng !");
                            return;
                        }
                    }
                }
                func.ButtonControl(this, true);
                txtId.Text = dataGridView.Rows[row].Cells[0].Value.ToString();
                txtName.Text = dataGridView.Rows[row].Cells[1].Value.ToString();
                txtStatus.Text = func.LoadStatus(dataGridView.Rows[row].Cells[2].Value.ToString());
            }
        }
    }
}
