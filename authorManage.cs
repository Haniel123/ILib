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
        public authorManage()
        {
            InitializeComponent();
            dgvAuthor.AutoGenerateColumns = false;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void authorManage_Load(object sender, EventArgs e)
        {
           var result = bus.getAuthorB();
            dgvAuthor.DataSource = result;
        }

        private void btnAddAuthor_Click(object sender, EventArgs e)
        {
            string authorName = txtAuhorname.Text;
            DAO.Author author = new DAO.Author();
            author.Name = authorName;
            author.Status = 1;
            var result = bus.insertAuthorB(author);
            txtAuhorname.Text = result.ToString();
            var result2 = bus.getAuthorB();
            dgvAuthor.DataSource = result2;
        }

        private void dgvAuthor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
