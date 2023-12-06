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
using static DevExpress.Utils.Filtering.ExcelFilterOptions;
using System.Drawing.Imaging;

namespace ILib
{
    public partial class BookManagement : Form
    {
        bookBUS BookBUS = new bookBUS();
        authorBUS AuthorBus = new authorBUS();

        public BookManagement()
        {
            InitializeComponent();
            dgvBook.AutoGenerateColumns = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }


        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {

        }

        private void BookManagement_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eLibDataSet1.Author' table. You can move, or remove it, as needed.
            this.authorTableAdapter.Fill(this.eLibDataSet1.Author);
            // TODO: This line of code loads data into the 'eLibDataSet.BookType' table. You can move, or remove it, as needed.
            this.bookTypeTableAdapter.Fill(this.eLibDataSet.BookType);

        }
    }
}
