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
    public partial class authorManage : Form
    {
        authorBUS bus = new authorBUS();
        functionDAO func = new functionDAO();
        public authorManage()
        {
            InitializeComponent();
            dgvAuthor.AutoGenerateColumns = false;
        }

        private void listBoxControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void quảnLýSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void authorManage_Load(object sender, EventArgs e)
        {
            var result = bus.getAuthorB();
            dgvAuthor.DataSource = result;
        }

        private void btnAddAuthor_Click(object sender, EventArgs e)
        {
            string authorName = txtName.Text;
            DAO.Author author = new DAO.Author();
            author.Name = authorName;
            author.Status = 1;
            if (Name == "")
            {
                MessageBox.Show("Không chừa trống dữ liệu !!!");
                return;
            }
            var result = bus.insertAuthorB(author);
            txtName.Text = result.ToString();
            var result2 = bus.getAuthorB();
            dgvAuthor.DataSource = result2;

        }

        private void btnEditAuthor_Click(object sender, EventArgs e)
        {
            string authorName = txtName.Text;
            var authorId = txtId.Text;

            if (Name == "")
            {
                MessageBox.Show("Không chừa trống dữ liệu !!!");
                return;
            }
            DAO.Author author = new DAO.Author();
            author.Name = authorName;
            author.Id = int.Parse(authorId);
            if (bus.updateAuthorB(authorId, author))
            {
                MessageBox.Show("Sửa tác giả thành công !!!");
                var resultUser = bus.getAuthorB();
                dgvAuthor.DataSource = resultUser;
            }
            else
            {
                MessageBox.Show("Sửa tài khoản thất bại !!!");
            }
        }

        private void btnDeleteAuthor_Click(object sender, EventArgs e)
        {


            var userId = txtId.Text;
            DAO.Author author = new DAO.Author();
            author.Id = int.Parse(userId);
            if (bus.deleteAuthorB(userId, author))
            {
                MessageBox.Show("Xoá tài khoản thành công !!!");
                var resultUser = bus.getAuthorB();
                dgvAuthor.DataSource = resultUser;
            }
            else
            {
                MessageBox.Show("Xoá tài khoản thất bại !!!");
            }

        }

        private void dgvAuthor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;
            int row = e.RowIndex;
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
            txtId.Text = dataGridView.Rows[row].Cells[0].Value.ToString();
            txtName.Text = dataGridView.Rows[row].Cells[1].Value.ToString();
            txtStatus.Text = func.LoadStatus(dataGridView.Rows[row].Cells[2].Value.ToString());
        }
    }
}
