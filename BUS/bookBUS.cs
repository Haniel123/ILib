using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class bookBUS
    {
        bookDAO BookDAO = new bookDAO();

        public int insertBookBUS(Book item)
        {
            return BookDAO.insertBook(item);
        }

        public List<Book> getBookBUS()
        {
            return BookDAO.getBook();
        }
    }
}
