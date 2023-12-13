using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class borrowBUS
    {
        borrowDAO borrowDAO = new borrowDAO();
        public int insertBorrowB(BorrowTicket item)
        {
            return borrowDAO.insertBorrow(item);
        }

        public int insertBorrowBookB(BorrowBook item)
        {
            return borrowDAO.insertBorrowBook(item);
        }



        public bool updateBorrowB(string id, BorrowTicket item)
        {
            return borrowDAO.updateBorrow(id, item);
        }

        public bool deleteBorrowB(string id, BorrowTicket item)
        {
            return borrowDAO.deleteBorrow(id, item);
        }

        public List<BorrowTicket> getBorrowB()
        {
            return borrowDAO.getBorrow();
        }

        public List<BorrowBook> getBorrowBookB(int idReader)
        {
            return borrowDAO.getBookBorrow(idReader);
        }



        public List<Book> getBookB()
        {
            return borrowDAO.getBook();
        }
        public List<Reader> getReaderB()
        {
            return borrowDAO.getReader();
        }

    }
}
