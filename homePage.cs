using BUS;
using DAO;
using DevExpress.XtraBars.Alerter;
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
    public partial class homePage : Form
    {
        functionDAO func = new functionDAO();

        public homePage()
        {
            InitializeComponent();
        }

        public void OpenForm(Form toOpen)
        {
            foreach (Form child in MdiChildren)
                child.Close();

            toOpen.MdiParent = this;
            toOpen.Show();
        }

        private void btn_bookManagement_Click(object sender, EventArgs e)
        {
            OpenForm(new BookManagement());

        }

        private void btn_bookTicket_Click(object sender, EventArgs e)
        {
            OpenForm(new BorrowTicketManagement());
        }

        private void btn_Author_Click(object sender, EventArgs e)
        {
            OpenForm(new authorManage());
        }

        private void btn_BookType_Click(object sender, EventArgs e)
        {
            OpenForm(new TypeofBookManagement());
        }

        private void btn_Reader_Click(object sender, EventArgs e)
        {
            OpenForm(new readerManage());
        }

        private void btn_Account_Click(object sender, EventArgs e)
        {
            OpenForm(new userManage());
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (func.ConfirmMessageBox("Bạn có chắc là muốn thoát?"))
            {
                Application.Exit();
            }
        }
    }

}
